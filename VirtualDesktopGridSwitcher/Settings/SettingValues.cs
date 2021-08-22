using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace VirtualDesktopGridSwitcher.Settings {

    public class SettingValues {

        public class Modifiers {
            public bool Ctrl;
            public bool Win;
            public bool Alt;
            public bool Shift;
        }

        public class Hotkey {
            public Keys Key;
            public Modifiers Modifiers;
        }

        public class BrowserInfo {
            public string ProgID;
            public string ExeName;
            public string ClassName;
        }

        public int Columns = 3;
        public int Rows = 3;

        public bool WrapAround = false;

        public Modifiers SwitchModifiers = 
            new Modifiers {
                Ctrl = true, Win = false, Alt = true, Shift = false
            };

		public bool SwitchEnabled = true;

		public Modifiers MoveModifiers =
            new Modifiers {
                Ctrl = true, Win = false, Alt = true, Shift = true
            };

		public bool MoveEnabled = true;

        public bool NumbersEnabled = true;
        public bool FKeysEnabled = false;

        public bool Set1Enabled = true;
        public Keys LeftKey1 = Keys.Left;
        public Keys RightKey1 = Keys.Right;
        public Keys UpKey1 = Keys.Up;
        public Keys DownKey1 = Keys.Down;

        public bool Set2Enabled = false;
        public Keys LeftKey2 = Keys.H;
        public Keys RightKey2 = Keys.L;
        public Keys UpKey2 = Keys.J;
        public Keys DownKey2 = Keys.K;

        public Hotkey AlwaysOnTopHotkey =
            new Hotkey {
                Key = Keys.Space,
                Modifiers = new Modifiers {
                    Ctrl = true, Win = false, Alt = true, Shift = false
                }
            };

		public bool AlwaysOnTopEnabled = true;

		public Hotkey StickyWindowHotKey =
            new Hotkey {
                Key = Keys.Space,
                Modifiers = new Modifiers {
                    Ctrl = true, Win = false, Alt = true, Shift = true
                }
            };

	    public bool StickyWindowEnabled = true;

        public bool ActivateWebBrowserOnSwitch = true;

        public List<BrowserInfo> BrowserInfoList = new List<BrowserInfo>();

        public int MoveOnNewWindowDetectTimeoutMs = 3000;

        [XmlArrayItem(ElementName = "ExeName")]
        public List<string> MoveOnNewWindowExeNames = new List<string>();

        public int SettingsVersion;

        private static string SettingsFileName { 
            get {
                var baseDir = AppDomain.CurrentDomain.BaseDirectory;
                return Path.Combine(baseDir, "VirtualDesktopGridSwitcher.Settings");
            }
        }

        private void SetListDefaults() {
            if (BrowserInfoList.Count == 0) {
                BrowserInfoList =
                    new List<BrowserInfo> {
                        // Edge works without us interfering
                        //new BrowserInfo { ProgID = "AppXq0fevzme2pys62n3e0fbqa7peapykr8v", ExeName = "ApplicationFrameHost.exe", ClassName = "ApplicationFrameWindow" },

                        // IE doesn't work whatever you do - always uses oldest window!
                        //new BrowserInfo { ProgID = "IE.HTTP", ExeName = "iexplore.exe", ClassName = "IEFrame" },

                        new BrowserInfo { ProgID = "ChromeHTML", ExeName = "chrome.exe", ClassName = "Chrome_WidgetWin_1" },

                        new BrowserInfo { ProgID = "FirefoxURL", ExeName = "firefox.exe", ClassName = "MozillaWindowClass" }

                        // Opera works without us interfering
                        //new BrowserInfo { ProgID = "OperaStable" , ExeName = "opera.exe", ClassName = "Chrome_WidgetWin_1" }
                    };
            }

            if (MoveOnNewWindowExeNames.Count == 0) {
                MoveOnNewWindowExeNames = new List<string>() { "WINWORD.EXE", "EXCEL.EXE", "AcroRd32.exe" };
            }
        }

        public static SettingValues Load() {
            SettingValues settings;
            if (!File.Exists(SettingsFileName)) {
                settings = new SettingValues();
            } else {
                XmlSerializer serializer = new XmlSerializer(typeof(SettingValues));
                FileStream fs = new FileStream(SettingsFileName, FileMode.Open);
                settings = (SettingValues)serializer.Deserialize(fs);
                fs.Close();

                LoadOldSettings(settings);
            }

            settings.SetListDefaults();

            settings.ApplyVersionUpdates();

            return settings;
        }

        private void ApplyVersionUpdates() {
            bool save = false;

            if (SettingsVersion == 0) {
                if (!MoveOnNewWindowExeNames.Contains("AcroRd32.exe")) {
                    MoveOnNewWindowExeNames.Add("AcroRd32.exe");
                }
                if (MoveOnNewWindowDetectTimeoutMs == 500) {
                    MoveOnNewWindowDetectTimeoutMs = 1200;
                }
                SettingsVersion = 1;
                save = true;
            }

            if (SettingsVersion == 1) {
                if (MoveOnNewWindowDetectTimeoutMs == 1200) {
                    MoveOnNewWindowDetectTimeoutMs = 3000;
                }
                NumbersEnabled = !FKeysEnabled;
                SettingsVersion = 2;
                save = true;
            }

            if (save) {
                Save();
            }
        }

        private static void LoadOldSettings(SettingValues settings) {
            // Backward compatibility
            XDocument xdoc = XDocument.Load(SettingsFileName);

            var switchCtrl = xdoc.Element("SettingValues").Element("CtrlModifierSwitch");
            if (switchCtrl != null) {
                settings.SwitchModifiers.Ctrl = (bool)switchCtrl;
            }
            var switchWin = xdoc.Element("SettingValues").Element("WinModifierSwitch");
            if (switchWin != null) {
                settings.SwitchModifiers.Win = (bool)switchWin;
            }
            var switchAlt = xdoc.Element("SettingValues").Element("AltModifierSwitch");
            if (switchAlt != null) {
                settings.SwitchModifiers.Alt = (bool)switchAlt;
            }
            var switchShift = xdoc.Element("SettingValues").Element("ShiftModifierSwitch");
            if (switchShift != null) {
                settings.SwitchModifiers.Shift = (bool)switchShift;
            }

            var moveCtrl = xdoc.Element("SettingValues").Element("CtrlModifierMove");
            if (moveCtrl != null) {
                settings.MoveModifiers.Ctrl = (bool)moveCtrl;
            }
            var moveWin = xdoc.Element("SettingValues").Element("WinModifierMove");
            if (moveWin != null) {
                settings.MoveModifiers.Win = (bool)moveWin;
            }
            var moveAlt = xdoc.Element("SettingValues").Element("AltModifierMove");
            if (moveAlt != null) {
                settings.MoveModifiers.Alt = (bool)moveAlt;
            }
            var moveShift = xdoc.Element("SettingValues").Element("ShiftModifierMove");
            if (moveShift != null) {
                settings.MoveModifiers.Shift = (bool)moveShift;
            }

            var fKeysForNumbers = xdoc.Element("SettingValues").Element("FKeysForNumbers");
            if (fKeysForNumbers != null) {
                settings.FKeysEnabled = (bool)fKeysForNumbers;
            }

        }

        public bool Save() {
            try {
                XmlSerializer serializer =
                    new XmlSerializer(typeof(SettingValues));
                TextWriter writer = new StreamWriter(SettingsFileName);
                serializer.Serialize(writer, this);
                writer.Close();
            } catch {
                return false;
            }
            return true;
        }

        public event ApplyHandler Apply;
        public delegate bool ApplyHandler();

        public bool ApplySettings() {
            if (this.Apply != null) {
                return this.Apply();
            }
            return true;
        }

        public BrowserInfo GetBrowserToActivateInfo() {
            if (ActivateWebBrowserOnSwitch) {
                const string userChoice = @"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice";
                using (RegistryKey userChoiceKey = Registry.CurrentUser.OpenSubKey(userChoice)) {
                    if (userChoiceKey != null) {
                        object progIdValue = userChoiceKey.GetValue("Progid");
                        if (progIdValue != null) {
                            return BrowserInfoList.Where(v => v.ProgID == progIdValue.ToString()).FirstOrDefault();
                        }
                    }
                }
            }
            return null;
        }
    }
}
