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

        public Modifiers SwitchDirModifiers = 
            new Modifiers {
                Ctrl = true, Win = false, Alt = true, Shift = false
            };

		public bool SwitchDirEnabled = true;

		public Modifiers MoveDirModifiers =
            new Modifiers {
                Ctrl = true, Win = false, Alt = true, Shift = true
            };

		public bool MoveDirEnabled = true;

        public Keys LeftKey = Keys.Left;
        public Keys RightKey = Keys.Right;
        public Keys UpKey = Keys.Up;
        public Keys DownKey = Keys.Down;

        public Modifiers SwitchPosModifiers =
            new Modifiers {
                Ctrl = true, Win = false, Alt = true, Shift = false
            };

        public bool SwitchPosEnabled = true;

        public Modifiers MovePosModifiers =
            new Modifiers {
                Ctrl = true, Win = false, Alt = true, Shift = true
            };

        public bool MovePosEnabled = true;

        public bool NumbersEnabled = true;
        public bool FKeysEnabled = false;

        [XmlArrayItem(ElementName = "Key")]
        public List<Keys> DesktopKeys = new List<Keys>();

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

        public int SettingsVersion = 3;

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

            if (DesktopKeys.Count == 0) {
                DesktopKeys = new List<Keys> {
                    Keys.None,
                    Keys.None,
                    Keys.None,
                    Keys.None,
                    Keys.None,
                    Keys.None,
                    Keys.None,
                    Keys.None,
                    Keys.None,
                    Keys.None,
                    Keys.None,
                    Keys.None
                };
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

            if (SettingsVersion == 2) {
                // All handled in LoadOldSettings()
                SettingsVersion = 3;
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
                settings.SwitchDirModifiers.Ctrl = (bool)switchCtrl;
            }
            var switchWin = xdoc.Element("SettingValues").Element("WinModifierSwitch");
            if (switchWin != null) {
                settings.SwitchDirModifiers.Win = (bool)switchWin;
            }
            var switchAlt = xdoc.Element("SettingValues").Element("AltModifierSwitch");
            if (switchAlt != null) {
                settings.SwitchDirModifiers.Alt = (bool)switchAlt;
            }
            var switchShift = xdoc.Element("SettingValues").Element("ShiftModifierSwitch");
            if (switchShift != null) {
                settings.SwitchDirModifiers.Shift = (bool)switchShift;
            }

            var moveCtrl = xdoc.Element("SettingValues").Element("CtrlModifierMove");
            if (moveCtrl != null) {
                settings.MoveDirModifiers.Ctrl = (bool)moveCtrl;
            }
            var moveWin = xdoc.Element("SettingValues").Element("WinModifierMove");
            if (moveWin != null) {
                settings.MoveDirModifiers.Win = (bool)moveWin;
            }
            var moveAlt = xdoc.Element("SettingValues").Element("AltModifierMove");
            if (moveAlt != null) {
                settings.MoveDirModifiers.Alt = (bool)moveAlt;
            }
            var moveShift = xdoc.Element("SettingValues").Element("ShiftModifierMove");
            if (moveShift != null) {
                settings.MoveDirModifiers.Shift = (bool)moveShift;
            }

            var fKeysForNumbers = xdoc.Element("SettingValues").Element("FKeysForNumbers");
            if (fKeysForNumbers != null) {
                settings.FKeysEnabled = (bool)fKeysForNumbers;
            }

            // Version 3

            var switchModCtrl = xdoc.Element("SettingValues").Element("SwitchModifiers").Element("Ctrl");
            if (switchModCtrl != null) {
                settings.SwitchDirModifiers.Ctrl = (bool)switchModCtrl;
                settings.SwitchPosModifiers.Ctrl = (bool)switchModCtrl;
            }
            var switchModWin = xdoc.Element("SettingValues").Element("SwitchModifiers").Element("Win");
            if (switchModWin != null) {
                settings.SwitchDirModifiers.Win = (bool)switchModWin;
                settings.SwitchPosModifiers.Win = (bool)switchModWin;
            }
            var switchModAlt = xdoc.Element("SettingValues").Element("SwitchModifiers").Element("Alt");
            if (switchModAlt != null) {
                settings.SwitchDirModifiers.Alt = (bool)switchModAlt;
                settings.SwitchPosModifiers.Alt = (bool)switchModAlt;
            }
            var switchModShift = xdoc.Element("SettingValues").Element("SwitchModifiers").Element("Shift");
            if (switchModShift != null) {
                settings.SwitchDirModifiers.Shift = (bool)switchModShift;
                settings.SwitchPosModifiers.Shift = (bool)switchModShift;
            }
            var switchEnabled = xdoc.Element("SettingValues").Element("SwitchEnabled");
            if (switchEnabled != null) {
                settings.SwitchDirEnabled = (bool)switchEnabled;
                settings.SwitchPosEnabled = (bool)switchEnabled;
            }

            var moveModCtrl = xdoc.Element("SettingValues").Element("MoveModifiers").Element("Ctrl");
            if (moveModCtrl != null) {
                settings.MoveDirModifiers.Ctrl = (bool)moveModCtrl;
                settings.MovePosModifiers.Ctrl = (bool)moveModCtrl;
            }
            var moveModWin = xdoc.Element("SettingValues").Element("MoveModifiers").Element("Win");
            if (moveModWin != null) {
                settings.MoveDirModifiers.Win = (bool)moveModWin;
                settings.MovePosModifiers.Win = (bool)moveModWin;
            }
            var moveModAlt = xdoc.Element("SettingValues").Element("MoveModifiers").Element("Alt");
            if (moveModAlt != null) {
                settings.MoveDirModifiers.Alt = (bool)moveModAlt;
                settings.MovePosModifiers.Alt = (bool)moveModAlt;
            }
            var moveModShift = xdoc.Element("SettingValues").Element("MoveModifiers").Element("Shift");
            if (moveModShift != null) {
                settings.MoveDirModifiers.Shift = (bool)moveModShift;
                settings.MovePosModifiers.Shift = (bool)moveModShift;
            }
            var moveEnabled = xdoc.Element("SettingValues").Element("MoveEnabled");
            if (moveEnabled != null) {
                settings.MoveDirEnabled = (bool)moveEnabled;
                settings.MovePosEnabled = (bool)moveEnabled;
            }

            var dirKeysEnabled = xdoc.Element("SettingValues").Element("DirectionKeysEnabled");
            if (dirKeysEnabled != null && !(bool)dirKeysEnabled) {
                settings.SwitchDirEnabled = false;
                settings.MoveDirEnabled = false;
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
