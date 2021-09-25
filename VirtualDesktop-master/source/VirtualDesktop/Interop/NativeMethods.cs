using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDesktop.Interop
{
	internal static class NativeMethods
	{
		[DllImport("user32.dll")]
		public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		public static extern uint RegisterWindowMessage(string lpProcName);

		[DllImport("user32.dll")]
		public static extern bool CloseWindow(IntPtr hWnd);

		[DllImport("user32.dll", ExactSpelling = true)]
		public static extern IntPtr GetShellWindow();

		[DllImport("user32.dll", ExactSpelling = true)]
		public static extern IntPtr GetAncestor(IntPtr hwnd, uint flags);

		[DllImport("user32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
		private static extern int GetClassNameW(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

		public static string GetClassName(IntPtr hWnd)
		{
			var length = 128;
			var builder = new StringBuilder(length);
			while (length < 4096)
			{
				int cchClassNameLength = GetClassNameW(hWnd, builder, length);
				if (cchClassNameLength < length - 1)
				{
					break;
				}
				else if (cchClassNameLength == 0)
				{
					throw new Win32Exception(Marshal.GetLastWin32Error());
				}
				else
				{
					length *= 2;
					builder.EnsureCapacity(length);
				}
			}
			return builder.ToString();
		}
	}
}
