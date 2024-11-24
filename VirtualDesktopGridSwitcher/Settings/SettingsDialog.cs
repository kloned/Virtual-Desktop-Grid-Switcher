using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace VirtualDesktopGridSwitcher.Settings {
    public partial class SettingsDialog : Form {

        private SettingValues settings;
        private ComboBox[] desktopCombos; 

        public SettingsDialog(SettingValues settings) {

            InitializeComponent();

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

            checkBoxCtrlModifierSwitchDir.Checked = settings.SwitchDirModifiers.Ctrl;
            checkBoxWinModifierSwitchDir.Checked = settings.SwitchDirModifiers.Win;
            checkBoxAltModifierSwitchDir.Checked = settings.SwitchDirModifiers.Alt;
            checkBoxShiftModifierSwitchDir.Checked = settings.SwitchDirModifiers.Shift;
            checkBoxEnabledSwitchDir.Checked = settings.SwitchDirEnabled;

            checkBoxCtrlModifierMoveDir.Checked = settings.MoveDirModifiers.Ctrl;
            checkBoxWinModifierMoveDir.Checked = settings.MoveDirModifiers.Win;
            checkBoxAltModifierMoveDir.Checked = settings.MoveDirModifiers.Alt;
            checkBoxShiftModifierMoveDir.Checked = settings.MoveDirModifiers.Shift;
            checkBoxEnabledMoveDir.Checked = settings.MoveDirEnabled;

            checkBoxArrowKeys.Checked = settings.ArrowKeysEnabled;

            SetComboBoxForKey(comboBoxLeft, settings.LeftKey);
            SetComboBoxForKey(comboBoxRight, settings.RightKey);
            SetComboBoxForKey(comboBoxUp, settings.UpKey);
            SetComboBoxForKey(comboBoxDown, settings.DownKey);

            checkBoxCtrlModifierSwitchPos.Checked = settings.SwitchPosModifiers.Ctrl;
            checkBoxWinModifierSwitchPos.Checked = settings.SwitchPosModifiers.Win;
            checkBoxAltModifierSwitchPos.Checked = settings.SwitchPosModifiers.Alt;
            checkBoxShiftModifierSwitchPos.Checked = settings.SwitchPosModifiers.Shift;
            checkBoxEnabledSwitchPos.Checked = settings.SwitchPosEnabled;

            checkBoxCtrlModifierMovePos.Checked = settings.MovePosModifiers.Ctrl;
            checkBoxWinModifierMovePos.Checked = settings.MovePosModifiers.Win;
            checkBoxAltModifierMovePos.Checked = settings.MovePosModifiers.Alt;
            checkBoxShiftModifierMovePos.Checked = settings.MovePosModifiers.Shift;
            checkBoxEnabledMovePos.Checked = settings.MovePosEnabled;

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
                    MessageBox.Show(this, "Unrequired desktops WILL be removed");
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

            settings.SwitchDirModifiers.Ctrl = checkBoxCtrlModifierSwitchDir.Checked;
            settings.SwitchDirModifiers.Win = checkBoxWinModifierSwitchDir.Checked;
            settings.SwitchDirModifiers.Alt = checkBoxAltModifierSwitchDir.Checked;
            settings.SwitchDirModifiers.Shift = checkBoxShiftModifierSwitchDir.Checked;
            settings.SwitchDirEnabled = checkBoxEnabledSwitchDir.Checked;

            settings.MoveDirModifiers.Ctrl = checkBoxCtrlModifierMoveDir.Checked;
            settings.MoveDirModifiers.Win = checkBoxWinModifierMoveDir.Checked;
            settings.MoveDirModifiers.Alt = checkBoxAltModifierMoveDir.Checked;
            settings.MoveDirModifiers.Shift = checkBoxShiftModifierMoveDir.Checked;
            settings.MoveDirEnabled = checkBoxEnabledMoveDir.Checked;

            settings.ArrowKeysEnabled = checkBoxArrowKeys.Checked;

            settings.LeftKey = GetKeyFromComboBox(comboBoxLeft);
            settings.RightKey = GetKeyFromComboBox(comboBoxRight);
            settings.UpKey = GetKeyFromComboBox(comboBoxUp);
            settings.DownKey = GetKeyFromComboBox(comboBoxDown);

            settings.SwitchPosModifiers.Ctrl = checkBoxCtrlModifierSwitchPos.Checked;
            settings.SwitchPosModifiers.Win = checkBoxWinModifierSwitchPos.Checked;
            settings.SwitchPosModifiers.Alt = checkBoxAltModifierSwitchPos.Checked;
            settings.SwitchPosModifiers.Shift = checkBoxShiftModifierSwitchPos.Checked;
            settings.SwitchPosEnabled = checkBoxEnabledSwitchPos.Checked;

            settings.MovePosModifiers.Ctrl = checkBoxCtrlModifierMovePos.Checked;
            settings.MovePosModifiers.Win = checkBoxWinModifierMovePos.Checked;
            settings.MovePosModifiers.Alt = checkBoxAltModifierMovePos.Checked;
            settings.MovePosModifiers.Shift = checkBoxShiftModifierMovePos.Checked;
            settings.MovePosEnabled = checkBoxEnabledMovePos.Checked;

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

        private void pictureBoxDonate_Click(object sender, EventArgs e) {
            Process.Start("http://paypal.me/SimonLiddington");
        }

    }
}
