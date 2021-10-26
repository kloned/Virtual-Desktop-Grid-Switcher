using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text.RegularExpressions;
using WindowsDesktop.Properties;
using Microsoft.Win32;

namespace WindowsDesktop.Interop
{
	public static class IID
	{
		private static readonly Regex _osBuildRegex = new Regex(@"v_(?<build>\d{5}?)");

		// ReSharper disable once InconsistentNaming
		public static Dictionary<string, Guid> GetIIDs(string[] targets)
		{
			var known = new Dictionary<string, Guid>();

			foreach (var prop in Settings.Default.Properties.OfType<SettingsProperty>())
			{
				if (int.TryParse(_osBuildRegex.Match(prop.Name).Groups["build"]?.ToString(), out var build)
					&& build == ProductInfo.OSBuild)
				{
					foreach (var str in (StringCollection)Settings.Default[prop.Name])
					{
						var pair = str.Split(',');
						if (pair.Length != 2) continue;

						var @interface = pair[0];
						if (targets.All(x => @interface != x) || known.ContainsKey(@interface)) continue;

						if (!Guid.TryParse(pair[1], out var guid)) continue;
						
						known.Add(@interface, guid);
					}

					break;
				}
			}

			var except = targets.Except(known.Keys).ToArray();
			if (except.Length > 0)
			{
				var fromRegistry = GetIIDsFromRegistry(except);
				foreach (var kvp in fromRegistry) known.Add(kvp.Key, kvp.Value);
			}

			// In Windows 11 they started hiding the interface name in the registry
			if (known.Count == 0) {
				if (ProductInfo.OSBuild >= 22000) {
					known =
						new Dictionary<string, Guid> {
							{ "IVirtualDesktopNotificationService", new Guid("0cd45e71-d927-4f15-8b0a-8fef525337bf") },
							{ "IApplicationViewCollection", new Guid("1841c6d7-4f9d-42c0-af41-8747538f10e5") },
							{ "IApplicationView", new Guid("372e1d3b-38d3-42e4-a15b-8ab2b178f513") },
							{ "IVirtualDesktopPinnedApps", new Guid("4ce81583-1e4c-4632-a621-07a53543148f") },
							{ "IVirtualDesktop", new Guid("536d3495-b208-4cc9-ae26-de8111275bf8") },
							{ "IVirtualDesktopManagerInternal", new Guid("b2f925b9-5a0f-4d2e-9f4d-2b1507593c10") },
							{ "IVirtualDesktopNotification", new Guid("cd403e52-deed-4c13-b437-b98380f2b1e8") }
						};
				}
			}

			return known;
		}

		// ReSharper disable once InconsistentNaming
		private static Dictionary<string, Guid> GetIIDsFromRegistry(string[] targets)
		{
			using (var interfaceKey = Registry.ClassesRoot.OpenSubKey("Interface"))
			{
				if (interfaceKey == null)
				{
					throw new Exception(@"Registry key '\HKEY_CLASSES_ROOT\Interface' is missing.");
				}

				var result = new Dictionary<string, Guid>();
				var names = interfaceKey.GetSubKeyNames();

				foreach (var name in names)
				{
					using (var key = interfaceKey.OpenSubKey(name))
					{
						if (key?.GetValue("") is string value)
						{
							var match = targets.FirstOrDefault(x => x == value);
							//var match2 = targets.FirstOrDefault(x => value.IndexOf(x) != -1);
							if (match != null && Guid.TryParse(key.Name.Split('\\').Last(), out var guid))
							{
								result[match] = guid;
							}
						}
					}
				}

				return result;
			}
		}
	}
}
