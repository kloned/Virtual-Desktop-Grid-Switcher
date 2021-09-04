namespace VirtualDesktopGridSwitcher.Settings {
    partial class SettingsDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            this.labelRows = new System.Windows.Forms.Label();
            this.labelColumns = new System.Windows.Forms.Label();
            this.checkBoxWrapAround = new System.Windows.Forms.CheckBox();
            this.labelKeyModifiers = new System.Windows.Forms.Label();
            this.textBoxRows = new System.Windows.Forms.TextBox();
            this.textBoxColumns = new System.Windows.Forms.TextBox();
            this.checkBoxCtrlModifierSwitch = new System.Windows.Forms.CheckBox();
            this.checkBoxShiftModifierSwitch = new System.Windows.Forms.CheckBox();
            this.checkBoxAltModifierSwitch = new System.Windows.Forms.CheckBox();
            this.checkBoxWinModifierSwitch = new System.Windows.Forms.CheckBox();
            this.checkBoxFKeys = new System.Windows.Forms.CheckBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxWinModifierMove = new System.Windows.Forms.CheckBox();
            this.checkBoxAltModifierMove = new System.Windows.Forms.CheckBox();
            this.checkBoxShiftModifierMove = new System.Windows.Forms.CheckBox();
            this.checkBoxCtrlModifierMove = new System.Windows.Forms.CheckBox();
            this.labelMoveToDesktopModifiers = new System.Windows.Forms.Label();
            this.toolTipSettingsDialog = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxWinModifierSticky = new System.Windows.Forms.CheckBox();
            this.checkBoxAltModifierSticky = new System.Windows.Forms.CheckBox();
            this.checkBoxShiftModifierSticky = new System.Windows.Forms.CheckBox();
            this.checkBoxCtrlModifierSticky = new System.Windows.Forms.CheckBox();
            this.labelToggleSticky = new System.Windows.Forms.Label();
            this.checkBoxWinModifierAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.checkBoxAltModifierAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.checkBoxShiftModifierAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.checkBoxCtrlModifierAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.labelToggleAkwaysOnTop = new System.Windows.Forms.Label();
            this.checkBoxEnabledAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.checkBoxEnabledSticky = new System.Windows.Forms.CheckBox();
            this.labelModifiers = new System.Windows.Forms.Label();
            this.labelActionKeys = new System.Windows.Forms.Label();
            this.checkBoxNumbers = new System.Windows.Forms.CheckBox();
            this.comboBoxKeySticky = new System.Windows.Forms.ComboBox();
            this.comboBoxAlwaysOnTopKey = new System.Windows.Forms.ComboBox();
            this.checkBoxEnabledSwitch = new System.Windows.Forms.CheckBox();
            this.checkBoxEnabledMove = new System.Windows.Forms.CheckBox();
            this.comboBoxLeft = new System.Windows.Forms.ComboBox();
            this.comboBoxRight = new System.Windows.Forms.ComboBox();
            this.comboBoxUp = new System.Windows.Forms.ComboBox();
            this.comboBoxDown = new System.Windows.Forms.ComboBox();
            this.checkBoxDirectionKeys = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.labelDonate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxDonate = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDonate)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRows.Location = new System.Drawing.Point(147, 12);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(48, 16);
            this.labelRows.TabIndex = 2;
            this.labelRows.Text = "Rows:";
            this.toolTipSettingsDialog.SetToolTip(this.labelRows, "Number of rows in desktop grid");
            // 
            // labelColumns
            // 
            this.labelColumns.AutoSize = true;
            this.labelColumns.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.labelColumns.Location = new System.Drawing.Point(12, 12);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(68, 16);
            this.labelColumns.TabIndex = 0;
            this.labelColumns.Text = "Columns:";
            this.toolTipSettingsDialog.SetToolTip(this.labelColumns, "Number of columns in desktop grid");
            // 
            // checkBoxWrapAround
            // 
            this.checkBoxWrapAround.AutoSize = true;
            this.checkBoxWrapAround.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxWrapAround.Location = new System.Drawing.Point(264, 10);
            this.checkBoxWrapAround.Name = "checkBoxWrapAround";
            this.checkBoxWrapAround.Size = new System.Drawing.Size(112, 20);
            this.checkBoxWrapAround.TabIndex = 4;
            this.checkBoxWrapAround.Text = "Wrap Around";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxWrapAround, "Switch/Move to opposite side of grid when move beyond edge");
            this.checkBoxWrapAround.UseVisualStyleBackColor = true;
            // 
            // labelKeyModifiers
            // 
            this.labelKeyModifiers.AutoSize = true;
            this.labelKeyModifiers.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.labelKeyModifiers.Location = new System.Drawing.Point(12, 97);
            this.labelKeyModifiers.Name = "labelKeyModifiers";
            this.labelKeyModifiers.Size = new System.Drawing.Size(117, 16);
            this.labelKeyModifiers.TabIndex = 7;
            this.labelKeyModifiers.Text = "Switch Desktop:";
            this.toolTipSettingsDialog.SetToolTip(this.labelKeyModifiers, "Key modifier combination to use with arrow keys to switch to another desktop");
            // 
            // textBoxRows
            // 
            this.textBoxRows.Location = new System.Drawing.Point(196, 10);
            this.textBoxRows.Name = "textBoxRows";
            this.textBoxRows.Size = new System.Drawing.Size(49, 20);
            this.textBoxRows.TabIndex = 3;
            this.toolTipSettingsDialog.SetToolTip(this.textBoxRows, "Number of rows in desktop grid");
            // 
            // textBoxColumns
            // 
            this.textBoxColumns.Location = new System.Drawing.Point(81, 10);
            this.textBoxColumns.Name = "textBoxColumns";
            this.textBoxColumns.Size = new System.Drawing.Size(49, 20);
            this.textBoxColumns.TabIndex = 1;
            this.toolTipSettingsDialog.SetToolTip(this.textBoxColumns, "Number of columns in desktop grid");
            // 
            // checkBoxCtrlModifierSwitch
            // 
            this.checkBoxCtrlModifierSwitch.AutoSize = true;
            this.checkBoxCtrlModifierSwitch.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxCtrlModifierSwitch.Location = new System.Drawing.Point(172, 96);
            this.checkBoxCtrlModifierSwitch.Name = "checkBoxCtrlModifierSwitch";
            this.checkBoxCtrlModifierSwitch.Size = new System.Drawing.Size(50, 20);
            this.checkBoxCtrlModifierSwitch.TabIndex = 9;
            this.checkBoxCtrlModifierSwitch.Text = "Ctrl";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxCtrlModifierSwitch, "Key modifier combination to use with arrow keys to switch to another desktop");
            this.checkBoxCtrlModifierSwitch.UseVisualStyleBackColor = true;
            // 
            // checkBoxShiftModifierSwitch
            // 
            this.checkBoxShiftModifierSwitch.AutoSize = true;
            this.checkBoxShiftModifierSwitch.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxShiftModifierSwitch.Location = new System.Drawing.Point(318, 96);
            this.checkBoxShiftModifierSwitch.Name = "checkBoxShiftModifierSwitch";
            this.checkBoxShiftModifierSwitch.Size = new System.Drawing.Size(58, 20);
            this.checkBoxShiftModifierSwitch.TabIndex = 12;
            this.checkBoxShiftModifierSwitch.Text = "Shift";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxShiftModifierSwitch, "Key modifier combination to use with arrow keys to switch to another desktop");
            this.checkBoxShiftModifierSwitch.UseVisualStyleBackColor = true;
            // 
            // checkBoxAltModifierSwitch
            // 
            this.checkBoxAltModifierSwitch.AutoSize = true;
            this.checkBoxAltModifierSwitch.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxAltModifierSwitch.Location = new System.Drawing.Point(272, 96);
            this.checkBoxAltModifierSwitch.Name = "checkBoxAltModifierSwitch";
            this.checkBoxAltModifierSwitch.Size = new System.Drawing.Size(45, 20);
            this.checkBoxAltModifierSwitch.TabIndex = 11;
            this.checkBoxAltModifierSwitch.Text = "Alt";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxAltModifierSwitch, "Key modifier combination to use with arrow keys to switch to another desktop");
            this.checkBoxAltModifierSwitch.UseVisualStyleBackColor = true;
            // 
            // checkBoxWinModifierSwitch
            // 
            this.checkBoxWinModifierSwitch.AutoSize = true;
            this.checkBoxWinModifierSwitch.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxWinModifierSwitch.Location = new System.Drawing.Point(222, 96);
            this.checkBoxWinModifierSwitch.Name = "checkBoxWinModifierSwitch";
            this.checkBoxWinModifierSwitch.Size = new System.Drawing.Size(51, 20);
            this.checkBoxWinModifierSwitch.TabIndex = 10;
            this.checkBoxWinModifierSwitch.Text = "Win";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxWinModifierSwitch, "Key modifier combination to use with arrow keys to switch to another desktop");
            this.checkBoxWinModifierSwitch.UseVisualStyleBackColor = true;
            // 
            // checkBoxFKeys
            // 
            this.checkBoxFKeys.AutoSize = true;
            this.checkBoxFKeys.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxFKeys.Location = new System.Drawing.Point(531, 130);
            this.checkBoxFKeys.Name = "checkBoxFKeys";
            this.checkBoxFKeys.Size = new System.Drawing.Size(74, 20);
            this.checkBoxFKeys.TabIndex = 14;
            this.checkBoxFKeys.Text = "F1-F12";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxFKeys, "Enable Modifiers + F Number Keys");
            this.checkBoxFKeys.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonApply.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.buttonApply.Location = new System.Drawing.Point(420, 402);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(90, 30);
            this.buttonApply.TabIndex = 45;
            this.buttonApply.Text = "&Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.buttonCancel.Location = new System.Drawing.Point(518, 402);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 30);
            this.buttonCancel.TabIndex = 46;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // checkBoxWinModifierMove
            // 
            this.checkBoxWinModifierMove.AutoSize = true;
            this.checkBoxWinModifierMove.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxWinModifierMove.Location = new System.Drawing.Point(222, 204);
            this.checkBoxWinModifierMove.Name = "checkBoxWinModifierMove";
            this.checkBoxWinModifierMove.Size = new System.Drawing.Size(51, 20);
            this.checkBoxWinModifierMove.TabIndex = 23;
            this.checkBoxWinModifierMove.Text = "Win";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxWinModifierMove, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxWinModifierMove.UseVisualStyleBackColor = true;
            // 
            // checkBoxAltModifierMove
            // 
            this.checkBoxAltModifierMove.AutoSize = true;
            this.checkBoxAltModifierMove.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxAltModifierMove.Location = new System.Drawing.Point(272, 204);
            this.checkBoxAltModifierMove.Name = "checkBoxAltModifierMove";
            this.checkBoxAltModifierMove.Size = new System.Drawing.Size(45, 20);
            this.checkBoxAltModifierMove.TabIndex = 24;
            this.checkBoxAltModifierMove.Text = "Alt";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxAltModifierMove, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxAltModifierMove.UseVisualStyleBackColor = true;
            // 
            // checkBoxShiftModifierMove
            // 
            this.checkBoxShiftModifierMove.AutoSize = true;
            this.checkBoxShiftModifierMove.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxShiftModifierMove.Location = new System.Drawing.Point(318, 204);
            this.checkBoxShiftModifierMove.Name = "checkBoxShiftModifierMove";
            this.checkBoxShiftModifierMove.Size = new System.Drawing.Size(58, 20);
            this.checkBoxShiftModifierMove.TabIndex = 25;
            this.checkBoxShiftModifierMove.Text = "Shift";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxShiftModifierMove, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxShiftModifierMove.UseVisualStyleBackColor = true;
            // 
            // checkBoxCtrlModifierMove
            // 
            this.checkBoxCtrlModifierMove.AutoSize = true;
            this.checkBoxCtrlModifierMove.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxCtrlModifierMove.Location = new System.Drawing.Point(172, 204);
            this.checkBoxCtrlModifierMove.Name = "checkBoxCtrlModifierMove";
            this.checkBoxCtrlModifierMove.Size = new System.Drawing.Size(50, 20);
            this.checkBoxCtrlModifierMove.TabIndex = 22;
            this.checkBoxCtrlModifierMove.Text = "Ctrl";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxCtrlModifierMove, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxCtrlModifierMove.UseVisualStyleBackColor = true;
            // 
            // labelMoveToDesktopModifiers
            // 
            this.labelMoveToDesktopModifiers.AutoSize = true;
            this.labelMoveToDesktopModifiers.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.labelMoveToDesktopModifiers.Location = new System.Drawing.Point(12, 205);
            this.labelMoveToDesktopModifiers.Name = "labelMoveToDesktopModifiers";
            this.labelMoveToDesktopModifiers.Size = new System.Drawing.Size(128, 16);
            this.labelMoveToDesktopModifiers.TabIndex = 20;
            this.labelMoveToDesktopModifiers.Text = "Move To Desktop:";
            this.toolTipSettingsDialog.SetToolTip(this.labelMoveToDesktopModifiers, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            // 
            // checkBoxWinModifierSticky
            // 
            this.checkBoxWinModifierSticky.AutoSize = true;
            this.checkBoxWinModifierSticky.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxWinModifierSticky.Location = new System.Drawing.Point(222, 360);
            this.checkBoxWinModifierSticky.Name = "checkBoxWinModifierSticky";
            this.checkBoxWinModifierSticky.Size = new System.Drawing.Size(51, 20);
            this.checkBoxWinModifierSticky.TabIndex = 41;
            this.checkBoxWinModifierSticky.Text = "Win";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxWinModifierSticky, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxWinModifierSticky.UseVisualStyleBackColor = true;
            // 
            // checkBoxAltModifierSticky
            // 
            this.checkBoxAltModifierSticky.AutoSize = true;
            this.checkBoxAltModifierSticky.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxAltModifierSticky.Location = new System.Drawing.Point(271, 360);
            this.checkBoxAltModifierSticky.Name = "checkBoxAltModifierSticky";
            this.checkBoxAltModifierSticky.Size = new System.Drawing.Size(45, 20);
            this.checkBoxAltModifierSticky.TabIndex = 42;
            this.checkBoxAltModifierSticky.Text = "Alt";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxAltModifierSticky, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxAltModifierSticky.UseVisualStyleBackColor = true;
            // 
            // checkBoxShiftModifierSticky
            // 
            this.checkBoxShiftModifierSticky.AutoSize = true;
            this.checkBoxShiftModifierSticky.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxShiftModifierSticky.Location = new System.Drawing.Point(318, 360);
            this.checkBoxShiftModifierSticky.Name = "checkBoxShiftModifierSticky";
            this.checkBoxShiftModifierSticky.Size = new System.Drawing.Size(58, 20);
            this.checkBoxShiftModifierSticky.TabIndex = 43;
            this.checkBoxShiftModifierSticky.Text = "Shift";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxShiftModifierSticky, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxShiftModifierSticky.UseVisualStyleBackColor = true;
            // 
            // checkBoxCtrlModifierSticky
            // 
            this.checkBoxCtrlModifierSticky.AutoSize = true;
            this.checkBoxCtrlModifierSticky.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxCtrlModifierSticky.Location = new System.Drawing.Point(172, 360);
            this.checkBoxCtrlModifierSticky.Name = "checkBoxCtrlModifierSticky";
            this.checkBoxCtrlModifierSticky.Size = new System.Drawing.Size(50, 20);
            this.checkBoxCtrlModifierSticky.TabIndex = 40;
            this.checkBoxCtrlModifierSticky.Text = "Ctrl";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxCtrlModifierSticky, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxCtrlModifierSticky.UseVisualStyleBackColor = true;
            // 
            // labelToggleSticky
            // 
            this.labelToggleSticky.AutoSize = true;
            this.labelToggleSticky.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.labelToggleSticky.Location = new System.Drawing.Point(12, 360);
            this.labelToggleSticky.Name = "labelToggleSticky";
            this.labelToggleSticky.Size = new System.Drawing.Size(159, 16);
            this.labelToggleSticky.TabIndex = 38;
            this.labelToggleSticky.Text = "Toggle Sticky Window:";
            this.toolTipSettingsDialog.SetToolTip(this.labelToggleSticky, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            // 
            // checkBoxWinModifierAlwaysOnTop
            // 
            this.checkBoxWinModifierAlwaysOnTop.AutoSize = true;
            this.checkBoxWinModifierAlwaysOnTop.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxWinModifierAlwaysOnTop.Location = new System.Drawing.Point(222, 309);
            this.checkBoxWinModifierAlwaysOnTop.Name = "checkBoxWinModifierAlwaysOnTop";
            this.checkBoxWinModifierAlwaysOnTop.Size = new System.Drawing.Size(51, 20);
            this.checkBoxWinModifierAlwaysOnTop.TabIndex = 34;
            this.checkBoxWinModifierAlwaysOnTop.Text = "Win";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxWinModifierAlwaysOnTop, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxWinModifierAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // checkBoxAltModifierAlwaysOnTop
            // 
            this.checkBoxAltModifierAlwaysOnTop.AutoSize = true;
            this.checkBoxAltModifierAlwaysOnTop.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxAltModifierAlwaysOnTop.Location = new System.Drawing.Point(271, 309);
            this.checkBoxAltModifierAlwaysOnTop.Name = "checkBoxAltModifierAlwaysOnTop";
            this.checkBoxAltModifierAlwaysOnTop.Size = new System.Drawing.Size(45, 20);
            this.checkBoxAltModifierAlwaysOnTop.TabIndex = 35;
            this.checkBoxAltModifierAlwaysOnTop.Text = "Alt";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxAltModifierAlwaysOnTop, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxAltModifierAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // checkBoxShiftModifierAlwaysOnTop
            // 
            this.checkBoxShiftModifierAlwaysOnTop.AutoSize = true;
            this.checkBoxShiftModifierAlwaysOnTop.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxShiftModifierAlwaysOnTop.Location = new System.Drawing.Point(318, 309);
            this.checkBoxShiftModifierAlwaysOnTop.Name = "checkBoxShiftModifierAlwaysOnTop";
            this.checkBoxShiftModifierAlwaysOnTop.Size = new System.Drawing.Size(58, 20);
            this.checkBoxShiftModifierAlwaysOnTop.TabIndex = 36;
            this.checkBoxShiftModifierAlwaysOnTop.Text = "Shift";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxShiftModifierAlwaysOnTop, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxShiftModifierAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // checkBoxCtrlModifierAlwaysOnTop
            // 
            this.checkBoxCtrlModifierAlwaysOnTop.AutoSize = true;
            this.checkBoxCtrlModifierAlwaysOnTop.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxCtrlModifierAlwaysOnTop.Location = new System.Drawing.Point(172, 309);
            this.checkBoxCtrlModifierAlwaysOnTop.Name = "checkBoxCtrlModifierAlwaysOnTop";
            this.checkBoxCtrlModifierAlwaysOnTop.Size = new System.Drawing.Size(50, 20);
            this.checkBoxCtrlModifierAlwaysOnTop.TabIndex = 33;
            this.checkBoxCtrlModifierAlwaysOnTop.Text = "Ctrl";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxCtrlModifierAlwaysOnTop, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            this.checkBoxCtrlModifierAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // labelToggleAkwaysOnTop
            // 
            this.labelToggleAkwaysOnTop.AutoSize = true;
            this.labelToggleAkwaysOnTop.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.labelToggleAkwaysOnTop.Location = new System.Drawing.Point(12, 310);
            this.labelToggleAkwaysOnTop.Name = "labelToggleAkwaysOnTop";
            this.labelToggleAkwaysOnTop.Size = new System.Drawing.Size(160, 16);
            this.labelToggleAkwaysOnTop.TabIndex = 31;
            this.labelToggleAkwaysOnTop.Text = "Toggle Always On Top:";
            this.toolTipSettingsDialog.SetToolTip(this.labelToggleAkwaysOnTop, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            // 
            // checkBoxEnabledAlwaysOnTop
            // 
            this.checkBoxEnabledAlwaysOnTop.AutoSize = true;
            this.checkBoxEnabledAlwaysOnTop.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxEnabledAlwaysOnTop.Location = new System.Drawing.Point(16, 329);
            this.checkBoxEnabledAlwaysOnTop.Name = "checkBoxEnabledAlwaysOnTop";
            this.checkBoxEnabledAlwaysOnTop.Size = new System.Drawing.Size(70, 20);
            this.checkBoxEnabledAlwaysOnTop.TabIndex = 32;
            this.checkBoxEnabledAlwaysOnTop.Text = "Enable";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxEnabledAlwaysOnTop, "Enable / Disable Toggle Always On Top Key Combination");
            this.checkBoxEnabledAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnabledSticky
            // 
            this.checkBoxEnabledSticky.AutoSize = true;
            this.checkBoxEnabledSticky.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxEnabledSticky.Location = new System.Drawing.Point(16, 379);
            this.checkBoxEnabledSticky.Name = "checkBoxEnabledSticky";
            this.checkBoxEnabledSticky.Size = new System.Drawing.Size(70, 20);
            this.checkBoxEnabledSticky.TabIndex = 39;
            this.checkBoxEnabledSticky.Text = "Enable";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxEnabledSticky, "Enable / Disable Sticky Window Key Combination");
            this.checkBoxEnabledSticky.UseVisualStyleBackColor = true;
            // 
            // labelModifiers
            // 
            this.labelModifiers.AutoSize = true;
            this.labelModifiers.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelModifiers.Location = new System.Drawing.Point(212, 73);
            this.labelModifiers.Name = "labelModifiers";
            this.labelModifiers.Size = new System.Drawing.Size(105, 16);
            this.labelModifiers.TabIndex = 5;
            this.labelModifiers.Text = "Modifier Keys";
            this.toolTipSettingsDialog.SetToolTip(this.labelModifiers, "Key modifier combination to use with arrow keys to switch to another desktop");
            // 
            // labelActionKeys
            // 
            this.labelActionKeys.AutoSize = true;
            this.labelActionKeys.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelActionKeys.Location = new System.Drawing.Point(452, 9);
            this.labelActionKeys.Name = "labelActionKeys";
            this.labelActionKeys.Size = new System.Drawing.Size(93, 16);
            this.labelActionKeys.TabIndex = 6;
            this.labelActionKeys.Text = "Action Keys";
            this.toolTipSettingsDialog.SetToolTip(this.labelActionKeys, "Key modifier combination to use with arrow keys to switch to another desktop");
            // 
            // checkBoxNumbers
            // 
            this.checkBoxNumbers.AutoSize = true;
            this.checkBoxNumbers.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxNumbers.Location = new System.Drawing.Point(392, 130);
            this.checkBoxNumbers.Name = "checkBoxNumbers";
            this.checkBoxNumbers.Size = new System.Drawing.Size(111, 20);
            this.checkBoxNumbers.TabIndex = 13;
            this.checkBoxNumbers.Text = "Numbers 1-9";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxNumbers, "Enable Moifiers + Number Keys");
            this.checkBoxNumbers.UseVisualStyleBackColor = true;
            // 
            // comboBoxKeySticky
            // 
            this.comboBoxKeySticky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxKeySticky.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.comboBoxKeySticky.FormattingEnabled = true;
            this.comboBoxKeySticky.Location = new System.Drawing.Point(385, 357);
            this.comboBoxKeySticky.Name = "comboBoxKeySticky";
            this.comboBoxKeySticky.Size = new System.Drawing.Size(70, 24);
            this.comboBoxKeySticky.TabIndex = 44;
            this.toolTipSettingsDialog.SetToolTip(this.comboBoxKeySticky, "Just press the key you want. Delete will clear a value.");
            this.comboBoxKeySticky.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxKey_KeyDown);
            this.comboBoxKeySticky.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKey_KeyPress);
            // 
            // comboBoxAlwaysOnTopKey
            // 
            this.comboBoxAlwaysOnTopKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxAlwaysOnTopKey.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.comboBoxAlwaysOnTopKey.FormattingEnabled = true;
            this.comboBoxAlwaysOnTopKey.Location = new System.Drawing.Point(385, 307);
            this.comboBoxAlwaysOnTopKey.Name = "comboBoxAlwaysOnTopKey";
            this.comboBoxAlwaysOnTopKey.Size = new System.Drawing.Size(70, 24);
            this.comboBoxAlwaysOnTopKey.TabIndex = 37;
            this.toolTipSettingsDialog.SetToolTip(this.comboBoxAlwaysOnTopKey, "Just press the key you want. Delete will clear a value.");
            this.comboBoxAlwaysOnTopKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxKey_KeyDown);
            this.comboBoxAlwaysOnTopKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKey_KeyPress);
            // 
            // checkBoxEnabledSwitch
            // 
            this.checkBoxEnabledSwitch.AutoSize = true;
            this.checkBoxEnabledSwitch.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxEnabledSwitch.Location = new System.Drawing.Point(16, 116);
            this.checkBoxEnabledSwitch.Margin = new System.Windows.Forms.Padding(1);
            this.checkBoxEnabledSwitch.Name = "checkBoxEnabledSwitch";
            this.checkBoxEnabledSwitch.Size = new System.Drawing.Size(70, 20);
            this.checkBoxEnabledSwitch.TabIndex = 8;
            this.checkBoxEnabledSwitch.Text = "Enable";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxEnabledSwitch, "Enable / Disable All Switch Desktop Combinations");
            this.checkBoxEnabledSwitch.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnabledMove
            // 
            this.checkBoxEnabledMove.AutoSize = true;
            this.checkBoxEnabledMove.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxEnabledMove.Location = new System.Drawing.Point(16, 224);
            this.checkBoxEnabledMove.Margin = new System.Windows.Forms.Padding(1);
            this.checkBoxEnabledMove.Name = "checkBoxEnabledMove";
            this.checkBoxEnabledMove.Size = new System.Drawing.Size(70, 20);
            this.checkBoxEnabledMove.TabIndex = 21;
            this.checkBoxEnabledMove.Text = "Enable";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxEnabledMove, "Enable / Disable All Move To Desktop Combinations");
            this.checkBoxEnabledMove.UseVisualStyleBackColor = true;
            // 
            // comboBoxLeft
            // 
            this.comboBoxLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxLeft.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.comboBoxLeft.FormattingEnabled = true;
            this.comboBoxLeft.Location = new System.Drawing.Point(392, 67);
            this.comboBoxLeft.Name = "comboBoxLeft";
            this.comboBoxLeft.Size = new System.Drawing.Size(70, 24);
            this.comboBoxLeft.TabIndex = 16;
            this.toolTipSettingsDialog.SetToolTip(this.comboBoxLeft, "Just press the key you want. Delete will clear a value.");
            this.comboBoxLeft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxKey_KeyDown);
            this.comboBoxLeft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKey_KeyPress);
            // 
            // comboBoxRight
            // 
            this.comboBoxRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxRight.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.comboBoxRight.FormattingEnabled = true;
            this.comboBoxRight.Location = new System.Drawing.Point(531, 67);
            this.comboBoxRight.Name = "comboBoxRight";
            this.comboBoxRight.Size = new System.Drawing.Size(70, 24);
            this.comboBoxRight.TabIndex = 18;
            this.toolTipSettingsDialog.SetToolTip(this.comboBoxRight, "Just press the key you want. Delete will clear a value.");
            this.comboBoxRight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxKey_KeyDown);
            this.comboBoxRight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKey_KeyPress);
            // 
            // comboBoxUp
            // 
            this.comboBoxUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxUp.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.comboBoxUp.FormattingEnabled = true;
            this.comboBoxUp.Location = new System.Drawing.Point(461, 37);
            this.comboBoxUp.Name = "comboBoxUp";
            this.comboBoxUp.Size = new System.Drawing.Size(70, 24);
            this.comboBoxUp.TabIndex = 15;
            this.toolTipSettingsDialog.SetToolTip(this.comboBoxUp, "Just press the key you want. Delete will clear a value.");
            this.comboBoxUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxKey_KeyDown);
            this.comboBoxUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKey_KeyPress);
            // 
            // comboBoxDown
            // 
            this.comboBoxDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxDown.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.comboBoxDown.FormattingEnabled = true;
            this.comboBoxDown.Location = new System.Drawing.Point(461, 97);
            this.comboBoxDown.Name = "comboBoxDown";
            this.comboBoxDown.Size = new System.Drawing.Size(70, 24);
            this.comboBoxDown.TabIndex = 19;
            this.toolTipSettingsDialog.SetToolTip(this.comboBoxDown, "Just press the key you want. Delete will clear a value.");
            this.comboBoxDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxKey_KeyDown);
            this.comboBoxDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKey_KeyPress);
            // 
            // checkBoxDirectionKeys
            // 
            this.checkBoxDirectionKeys.AutoSize = true;
            this.checkBoxDirectionKeys.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.checkBoxDirectionKeys.Location = new System.Drawing.Point(466, 69);
            this.checkBoxDirectionKeys.Margin = new System.Windows.Forms.Padding(1);
            this.checkBoxDirectionKeys.Name = "checkBoxDirectionKeys";
            this.checkBoxDirectionKeys.Size = new System.Drawing.Size(70, 20);
            this.checkBoxDirectionKeys.TabIndex = 17;
            this.checkBoxDirectionKeys.Text = "Enable";
            this.toolTipSettingsDialog.SetToolTip(this.checkBoxDirectionKeys, "Enable Key Set 1");
            this.checkBoxDirectionKeys.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(70, 24);
            this.comboBox1.TabIndex = 48;
            this.toolTipSettingsDialog.SetToolTip(this.comboBox1, "Just press the key you want. Delete will clear a value.");
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxKey_KeyDown);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKey_KeyPress);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(85, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(70, 24);
            this.comboBox2.TabIndex = 49;
            this.toolTipSettingsDialog.SetToolTip(this.comboBox2, "Just press the key you want. Delete will clear a value.");
            this.comboBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxKey_KeyDown);
            this.comboBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKey_KeyPress);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(161, 21);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(70, 24);
            this.comboBox3.TabIndex = 50;
            this.toolTipSettingsDialog.SetToolTip(this.comboBox3, "Just press the key you want. Delete will clear a value.");
            this.comboBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxKey_KeyDown);
            this.comboBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKey_KeyPress);
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox6.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(161, 51);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(70, 24);
            this.comboBox6.TabIndex = 53;
            this.toolTipSettingsDialog.SetToolTip(this.comboBox6, "Just press the key you want. Delete will clear a value.");
            this.comboBox6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxKey_KeyDown);
            this.comboBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKey_KeyPress);
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox5.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(85, 51);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(70, 24);
            this.comboBox5.TabIndex = 52;
            this.toolTipSettingsDialog.SetToolTip(this.comboBox5, "Just press the key you want. Delete will clear a value.");
            this.comboBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxKey_KeyDown);
            this.comboBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKey_KeyPress);
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(9, 51);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(70, 24);
            this.comboBox4.TabIndex = 51;
            this.toolTipSettingsDialog.SetToolTip(this.comboBox4, "Just press the key you want. Delete will clear a value.");
            this.comboBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxKey_KeyDown);
            this.comboBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKey_KeyPress);
            // 
            // comboBox9
            // 
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox9.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(161, 81);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(70, 24);
            this.comboBox9.TabIndex = 56;
            this.toolTipSettingsDialog.SetToolTip(this.comboBox9, "Just press the key you want. Delete will clear a value.");
            this.comboBox9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxKey_KeyDown);
            this.comboBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKey_KeyPress);
            // 
            // comboBox8
            // 
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox8.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(85, 81);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(70, 24);
            this.comboBox8.TabIndex = 55;
            this.toolTipSettingsDialog.SetToolTip(this.comboBox8, "Just press the key you want. Delete will clear a value.");
            this.comboBox8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxKey_KeyDown);
            this.comboBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKey_KeyPress);
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox7.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(9, 81);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(70, 24);
            this.comboBox7.TabIndex = 54;
            this.toolTipSettingsDialog.SetToolTip(this.comboBox7, "Just press the key you want. Delete will clear a value.");
            this.comboBox7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxKey_KeyDown);
            this.comboBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKey_KeyPress);
            // 
            // comboBox12
            // 
            this.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox12.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Location = new System.Drawing.Point(161, 111);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(70, 24);
            this.comboBox12.TabIndex = 59;
            this.toolTipSettingsDialog.SetToolTip(this.comboBox12, "Just press the key you want. Delete will clear a value.");
            this.comboBox12.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxKey_KeyDown);
            this.comboBox12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKey_KeyPress);
            // 
            // comboBox11
            // 
            this.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox11.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(85, 111);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(70, 24);
            this.comboBox11.TabIndex = 58;
            this.toolTipSettingsDialog.SetToolTip(this.comboBox11, "Just press the key you want. Delete will clear a value.");
            this.comboBox11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxKey_KeyDown);
            this.comboBox11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKey_KeyPress);
            // 
            // comboBox10
            // 
            this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox10.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(9, 111);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(70, 24);
            this.comboBox10.TabIndex = 57;
            this.toolTipSettingsDialog.SetToolTip(this.comboBox10, "Just press the key you want. Delete will clear a value.");
            this.comboBox10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxKey_KeyDown);
            this.comboBox10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKey_KeyPress);
            // 
            // labelDonate
            // 
            this.labelDonate.AutoSize = true;
            this.labelDonate.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.labelDonate.Location = new System.Drawing.Point(13, 409);
            this.labelDonate.Name = "labelDonate";
            this.labelDonate.Size = new System.Drawing.Size(299, 16);
            this.labelDonate.TabIndex = 62;
            this.labelDonate.Text = "If you would like to show appreciation, click";
            this.toolTipSettingsDialog.SetToolTip(this.labelDonate, "Key modifier combination to use with arrow keys to move a window to another deskt" +
        "op");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox12);
            this.groupBox1.Controls.Add(this.comboBox11);
            this.groupBox1.Controls.Add(this.comboBox10);
            this.groupBox1.Controls.Add(this.comboBox9);
            this.groupBox1.Controls.Add(this.comboBox8);
            this.groupBox1.Controls.Add(this.comboBox7);
            this.groupBox1.Controls.Add(this.comboBox6);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(376, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 144);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desktops 1 to 12";
            // 
            // pictureBoxDonate
            // 
            this.pictureBoxDonate.Image = global::VirtualDesktopGridSwitcher.Properties.Resources.Donate;
            this.pictureBoxDonate.Location = new System.Drawing.Point(313, 408);
            this.pictureBoxDonate.Name = "pictureBoxDonate";
            this.pictureBoxDonate.Size = new System.Drawing.Size(74, 21);
            this.pictureBoxDonate.TabIndex = 61;
            this.pictureBoxDonate.TabStop = false;
            this.pictureBoxDonate.Click += new System.EventHandler(this.pictureBoxDonate_Click);
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.pictureBoxDonate);
            this.Controls.Add(this.textBoxColumns);
            this.Controls.Add(this.textBoxRows);
            this.Controls.Add(this.comboBoxDown);
            this.Controls.Add(this.checkBoxAltModifierAlwaysOnTop);
            this.Controls.Add(this.checkBoxShiftModifierAlwaysOnTop);
            this.Controls.Add(this.comboBoxAlwaysOnTopKey);
            this.Controls.Add(this.checkBoxAltModifierSticky);
            this.Controls.Add(this.checkBoxShiftModifierSticky);
            this.Controls.Add(this.comboBoxKeySticky);
            this.Controls.Add(this.checkBoxAltModifierMove);
            this.Controls.Add(this.checkBoxAltModifierSwitch);
            this.Controls.Add(this.checkBoxShiftModifierSwitch);
            this.Controls.Add(this.checkBoxNumbers);
            this.Controls.Add(this.comboBoxUp);
            this.Controls.Add(this.comboBoxRight);
            this.Controls.Add(this.comboBoxLeft);
            this.Controls.Add(this.labelActionKeys);
            this.Controls.Add(this.labelModifiers);
            this.Controls.Add(this.checkBoxEnabledSticky);
            this.Controls.Add(this.checkBoxEnabledAlwaysOnTop);
            this.Controls.Add(this.checkBoxEnabledMove);
            this.Controls.Add(this.checkBoxEnabledSwitch);
            this.Controls.Add(this.checkBoxWinModifierAlwaysOnTop);
            this.Controls.Add(this.checkBoxCtrlModifierAlwaysOnTop);
            this.Controls.Add(this.labelToggleAkwaysOnTop);
            this.Controls.Add(this.checkBoxWinModifierSticky);
            this.Controls.Add(this.checkBoxCtrlModifierSticky);
            this.Controls.Add(this.labelToggleSticky);
            this.Controls.Add(this.checkBoxWinModifierMove);
            this.Controls.Add(this.checkBoxCtrlModifierMove);
            this.Controls.Add(this.labelMoveToDesktopModifiers);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.checkBoxFKeys);
            this.Controls.Add(this.checkBoxWinModifierSwitch);
            this.Controls.Add(this.checkBoxCtrlModifierSwitch);
            this.Controls.Add(this.labelKeyModifiers);
            this.Controls.Add(this.checkBoxWrapAround);
            this.Controls.Add(this.labelColumns);
            this.Controls.Add(this.labelRows);
            this.Controls.Add(this.checkBoxDirectionKeys);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxShiftModifierMove);
            this.Controls.Add(this.labelDonate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsDialog";
            this.Text = "Virtual Desktop Grid Switcher Settings";
            this.toolTipSettingsDialog.SetToolTip(this, "Click to support development via PayPal");
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDonate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.CheckBox checkBoxWrapAround;
        private System.Windows.Forms.Label labelKeyModifiers;
        private System.Windows.Forms.TextBox textBoxRows;
        private System.Windows.Forms.TextBox textBoxColumns;
        private System.Windows.Forms.CheckBox checkBoxCtrlModifierSwitch;
        private System.Windows.Forms.CheckBox checkBoxShiftModifierSwitch;
        private System.Windows.Forms.CheckBox checkBoxAltModifierSwitch;
        private System.Windows.Forms.CheckBox checkBoxWinModifierSwitch;
        private System.Windows.Forms.CheckBox checkBoxFKeys;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxWinModifierMove;
        private System.Windows.Forms.CheckBox checkBoxAltModifierMove;
        private System.Windows.Forms.CheckBox checkBoxShiftModifierMove;
        private System.Windows.Forms.CheckBox checkBoxCtrlModifierMove;
        private System.Windows.Forms.Label labelMoveToDesktopModifiers;
        private System.Windows.Forms.ToolTip toolTipSettingsDialog;
        private System.Windows.Forms.ComboBox comboBoxKeySticky;
        private System.Windows.Forms.CheckBox checkBoxWinModifierSticky;
        private System.Windows.Forms.CheckBox checkBoxAltModifierSticky;
        private System.Windows.Forms.CheckBox checkBoxShiftModifierSticky;
        private System.Windows.Forms.CheckBox checkBoxCtrlModifierSticky;
        private System.Windows.Forms.Label labelToggleSticky;
        private System.Windows.Forms.CheckBox checkBoxWinModifierAlwaysOnTop;
        private System.Windows.Forms.CheckBox checkBoxAltModifierAlwaysOnTop;
        private System.Windows.Forms.CheckBox checkBoxShiftModifierAlwaysOnTop;
        private System.Windows.Forms.CheckBox checkBoxCtrlModifierAlwaysOnTop;
        private System.Windows.Forms.Label labelToggleAkwaysOnTop;
        private System.Windows.Forms.ComboBox comboBoxAlwaysOnTopKey;
		private System.Windows.Forms.CheckBox checkBoxEnabledSwitch;
		private System.Windows.Forms.CheckBox checkBoxEnabledMove;
		private System.Windows.Forms.CheckBox checkBoxEnabledAlwaysOnTop;
		private System.Windows.Forms.CheckBox checkBoxEnabledSticky;
        private System.Windows.Forms.Label labelModifiers;
        private System.Windows.Forms.Label labelActionKeys;
        private System.Windows.Forms.ComboBox comboBoxLeft;
        private System.Windows.Forms.ComboBox comboBoxRight;
        private System.Windows.Forms.ComboBox comboBoxUp;
        private System.Windows.Forms.ComboBox comboBoxDown;
        private System.Windows.Forms.CheckBox checkBoxNumbers;
        private System.Windows.Forms.CheckBox checkBoxDirectionKeys;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxDonate;
        private System.Windows.Forms.Label labelDonate;
    }
}