using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Windows.Forms;

namespace VirtualDesktopGridSwitcher.Settings {
    public partial class SettingsDialog : Form {

        private SettingValues settings;
        private ComboBox[] desktopCombos; 

        public SettingsDialog(SettingValues settings) {

            this.settings = settings;
            this.desktopCombos = 
                new ComboBox[] {
                    comboBox1,
                    comboBox2,
                    comboBox3,
                    comboBox4,
                    comboBox5,
                    comboBox6,
                    comboBox7,
                    comboBox8,
                    comboBox9,
                    comboBox10,
                    comboBox11,
                    comboBox12
                };

            InitializeComponent();

            PopulateComboBoxKeyValues(comboBoxLeft);
            PopulateComboBoxKeyValues(comboBoxRight);
            PopulateComboBoxKeyValues(comboBoxUp);
            PopulateComboBoxKeyValues(comboBoxDown);

            foreach (ComboBox desktopCombo in desktopCombos) {
                PopulateComboBoxKeyValues(desktopCombo);
            }

            PopulateComboBoxKeyValues(comboBoxKeySticky);
            PopulateComboBoxKeyValues(comboBoxAlwaysOnTopKey);

            LoadValues();
        }

        private static void PopulateComboBoxKeyValues(ComboBox comboBox) {
            List<Keys> keyValues = Enum.GetValues(typeof(Keys)).Cast<Keys>().Where(v => v > 0).ToList();
            comboBox.DataSource = keyValues;
        }

        protected override void OnVisibleChanged(EventArgs e) {
            base.OnVisibleChanged(e);

            if (this.Visible) {
                LoadValues();
            }
        }

        private void LoadValues() {
            textBoxRows.Text = settings.Rows.ToString();
            textBoxColumns.Text = settings.Columns.ToString();

            checkBoxWrapAround.Checked = settings.WrapAround;

            checkBoxCtrlModifierSwitch.Checked = settings.SwitchModifiers.Ctrl;
            checkBoxWinModifierSwitch.Checked = settings.SwitchModifiers.Win;
            checkBoxAltModifierSwitch.Checked = settings.SwitchModifiers.Alt;
            checkBoxShiftModifierSwitch.Checked = settings.SwitchModifiers.Shift;
            checkBoxEnabledSwitch.Checked = settings.SwitchEnabled;

            checkBoxCtrlModifierMove.Checked = settings.MoveModifiers.Ctrl;
            checkBoxWinModifierMove.Checked = settings.MoveModifiers.Win;
            checkBoxAltModifierMove.Checked = settings.MoveModifiers.Alt;
            checkBoxShiftModifierMove.Checked = settings.MoveModifiers.Shift;
            checkBoxEnabledMove.Checked = settings.MoveEnabled;

            checkBoxDirectionKeys.Checked = settings.DirectionKeysEnabled;
            SetComboBoxForKey(comboBoxLeft, settings.LeftKey);
            SetComboBoxForKey(comboBoxRight, settings.RightKey);
            SetComboBoxForKey(comboBoxUp, settings.UpKey);
            SetComboBoxForKey(comboBoxDown, settings.DownKey);

            checkBoxFKeys.Checked = settings.FKeysEnabled;
            checkBoxNumbers.Checked = settings.NumbersEnabled;

            for (int i = 0; i < desktopCombos.Length; ++i) {
                SetComboBoxForKey(desktopCombos[i], settings.DesktopKeys[i]);
            }

            checkBoxCtrlModifierSticky.Checked = settings.StickyWindowHotKey.Modifiers.Ctrl;
            checkBoxWinModifierSticky.Checked = settings.StickyWindowHotKey.Modifiers.Win;
            checkBoxAltModifierSticky.Checked = settings.StickyWindowHotKey.Modifiers.Alt;
            checkBoxShiftModifierSticky.Checked = settings.StickyWindowHotKey.Modifiers.Shift;
            SetComboBoxForKey(comboBoxKeySticky, settings.StickyWindowHotKey.Key);
            checkBoxEnabledSticky.Checked = settings.StickyWindowEnabled;

            checkBoxCtrlModifierAlwaysOnTop.Checked = settings.AlwaysOnTopHotkey.Modifiers.Ctrl;
            checkBoxWinModifierAlwaysOnTop.Checked = settings.AlwaysOnTopHotkey.Modifiers.Win;
            checkBoxAltModifierAlwaysOnTop.Checked = settings.AlwaysOnTopHotkey.Modifiers.Alt;
            checkBoxShiftModifierAlwaysOnTop.Checked = settings.AlwaysOnTopHotkey.Modifiers.Shift;
            SetComboBoxForKey(comboBoxAlwaysOnTopKey, settings.AlwaysOnTopHotkey.Key);
            checkBoxEnabledAlwaysOnTop.Checked = settings.AlwaysOnTopEnabled;
        }

        private bool SaveValues() {
            try {
                var rows = int.Parse(textBoxRows.Text);
                var cols = int.Parse(textBoxColumns.Text);

                if (rows * cols > 20) {
                    var result =
                        MessageBox.Show(this,
                                        (rows * cols) + " desktops is not recommended for windows performance. Continue?",
                                        "Warning",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning);
                    if (result != DialogResult.Yes) {
                        return false;
                    }
                }

                if (rows * cols < settings.Rows * settings.Columns) {
                    MessageBox.Show(this, "Unrequired desktops will not be removed");
                } else if (rows * cols > settings.Rows * settings.Columns) {
                    MessageBox.Show(this, "More desktops will be created to fill the grid if necessary");
                }

                settings.Rows = rows;
                settings.Columns = cols;
            } catch {
                MessageBox.Show(this, "Values for Rows and Columns must be numbers only");
                return false;
            }

            settings.WrapAround = checkBoxWrapAround.Checked;

            settings.SwitchModifiers.Ctrl = checkBoxCtrlModifierSwitch.Checked;
            settings.SwitchModifiers.Win = checkBoxWinModifierSwitch.Checked;
            settings.SwitchModifiers.Alt = checkBoxAltModifierSwitch.Checked;
            settings.SwitchModifiers.Shift = checkBoxShiftModifierSwitch.Checked;
            settings.SwitchEnabled = checkBoxEnabledSwitch.Checked;

            settings.MoveModifiers.Ctrl = checkBoxCtrlModifierMove.Checked;
            settings.MoveModifiers.Win = checkBoxWinModifierMove.Checked;
            settings.MoveModifiers.Alt = checkBoxAltModifierMove.Checked;
            settings.MoveModifiers.Shift = checkBoxShiftModifierMove.Checked;
            settings.MoveEnabled = checkBoxEnabledMove.Checked;

            settings.DirectionKeysEnabled = checkBoxDirectionKeys.Checked;
            settings.LeftKey = GetKeyFromComboBox(comboBoxLeft);
            settings.RightKey = GetKeyFromComboBox(comboBoxRight);
            settings.UpKey = GetKeyFromComboBox(comboBoxUp);
            settings.DownKey = GetKeyFromComboBox(comboBoxDown);

            settings.FKeysEnabled = checkBoxFKeys.Checked;
            settings.NumbersEnabled = checkBoxNumbers.Checked;

            for (int i = 0; i < desktopCombos.Length; ++i) {
                settings.DesktopKeys[i] = GetKeyFromComboBox(desktopCombos[i]);
            }

            settings.StickyWindowHotKey.Modifiers.Ctrl = checkBoxCtrlModifierSticky.Checked;
            settings.StickyWindowHotKey.Modifiers.Win = checkBoxWinModifierSticky.Checked;
            settings.StickyWindowHotKey.Modifiers.Alt = checkBoxAltModifierSticky.Checked;
            settings.StickyWindowHotKey.Modifiers.Shift = checkBoxShiftModifierSticky.Checked;
            settings.StickyWindowHotKey.Key = GetKeyFromComboBox(comboBoxKeySticky);
            settings.StickyWindowEnabled = checkBoxEnabledSticky.Checked;

            settings.AlwaysOnTopHotkey.Modifiers.Ctrl = checkBoxCtrlModifierAlwaysOnTop.Checked;
            settings.AlwaysOnTopHotkey.Modifiers.Win = checkBoxWinModifierAlwaysOnTop.Checked;
            settings.AlwaysOnTopHotkey.Modifiers.Alt = checkBoxAltModifierAlwaysOnTop.Checked;
            settings.AlwaysOnTopHotkey.Modifiers.Shift = checkBoxShiftModifierAlwaysOnTop.Checked;
            settings.AlwaysOnTopHotkey.Key = GetKeyFromComboBox(comboBoxAlwaysOnTopKey);
            settings.AlwaysOnTopEnabled = checkBoxEnabledAlwaysOnTop.Checked;

            if (!settings.ApplySettings()) {
                MessageBox.Show(this, "Failed to apply settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!settings.Save()) {
                MessageBox.Show(this, "Failed to save settings to file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private static void SetComboBoxForKey(ComboBox comboBox, Keys key) {
            comboBox.SelectedItem = key == Keys.None ? (object)null : key;
        }

        private static Keys GetKeyFromComboBox(ComboBox comboBox) {
            return (Keys?)comboBox.SelectedItem ?? Keys.None;
        }

        private void buttonOK_Click(object sender, EventArgs e) {
            SaveValues();
        }

        private void comboBoxKey_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Delete && ((ComboBox)sender).SelectedItem != null) {
                ((ComboBox)sender).SelectedItem = null;
            } else if (e.KeyCode != Keys.ControlKey &&
                e.KeyCode != Keys.Menu &&
                e.KeyCode != Keys.ShiftKey &&
                e.KeyCode != Keys.LWin &&
                e.KeyCode != Keys.RWin) {
                ((ComboBox)sender).SelectedItem = e.KeyCode;
            }
            e.Handled = true;
        }

        private void comboBoxKey_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }
    }
}
