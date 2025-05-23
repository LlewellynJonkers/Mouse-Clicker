namespace Mouse_Clicker
{
    partial class MainMouseClicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpControl = new System.Windows.Forms.GroupBox();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.lblMiniseconds = new System.Windows.Forms.Label();
            this.txtMilliseconds = new System.Windows.Forms.TextBox();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.radFrequency = new System.Windows.Forms.RadioButton();
            this.radbtnPeriod = new System.Windows.Forms.RadioButton();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.lblMouseBtn = new System.Windows.Forms.Label();
            this.lblClick = new System.Windows.Forms.Label();
            this.cmbButton = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radRepeat = new System.Windows.Forms.RadioButton();
            this.numRepeat = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.radStopped = new System.Windows.Forms.RadioButton();
            this.grpCursor = new System.Windows.Forms.GroupBox();
            this.radCurrPos = new System.Windows.Forms.RadioButton();
            this.radPickLoc = new System.Windows.Forms.RadioButton();
            this.btnPickPos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.grpControl.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRepeat)).BeginInit();
            this.grpCursor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpControl
            // 
            this.grpControl.Controls.Add(this.lblFrequency);
            this.grpControl.Controls.Add(this.txtFrequency);
            this.grpControl.Controls.Add(this.lblMiniseconds);
            this.grpControl.Controls.Add(this.txtMilliseconds);
            this.grpControl.Controls.Add(this.lblSeconds);
            this.grpControl.Controls.Add(this.txtSeconds);
            this.grpControl.Controls.Add(this.lblMinutes);
            this.grpControl.Controls.Add(this.txtMinutes);
            this.grpControl.Controls.Add(this.lblHours);
            this.grpControl.Controls.Add(this.txtHours);
            this.grpControl.Controls.Add(this.radFrequency);
            this.grpControl.Controls.Add(this.radbtnPeriod);
            this.grpControl.Location = new System.Drawing.Point(12, 12);
            this.grpControl.Name = "grpControl";
            this.grpControl.Size = new System.Drawing.Size(571, 125);
            this.grpControl.TabIndex = 0;
            this.grpControl.TabStop = false;
            this.grpControl.Text = "Click Control";
            this.grpControl.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Enabled = false;
            this.lblFrequency.Location = new System.Drawing.Point(125, 89);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(76, 16);
            this.lblFrequency.TabIndex = 11;
            this.lblFrequency.Text = "Per second";
            // 
            // txtFrequency
            // 
            this.txtFrequency.Enabled = false;
            this.txtFrequency.Location = new System.Drawing.Point(21, 86);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.Size = new System.Drawing.Size(98, 22);
            this.txtFrequency.TabIndex = 10;
            this.txtFrequency.Text = "10";
            // 
            // lblMiniseconds
            // 
            this.lblMiniseconds.AutoSize = true;
            this.lblMiniseconds.Location = new System.Drawing.Point(473, 50);
            this.lblMiniseconds.Name = "lblMiniseconds";
            this.lblMiniseconds.Size = new System.Drawing.Size(82, 16);
            this.lblMiniseconds.TabIndex = 9;
            this.lblMiniseconds.Text = "Milliseconds";
            // 
            // txtMilliseconds
            // 
            this.txtMilliseconds.Location = new System.Drawing.Point(418, 47);
            this.txtMilliseconds.Name = "txtMilliseconds";
            this.txtMilliseconds.Size = new System.Drawing.Size(49, 22);
            this.txtMilliseconds.TabIndex = 8;
            this.txtMilliseconds.Text = "100";
            this.txtMilliseconds.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(337, 50);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(61, 16);
            this.lblSeconds.TabIndex = 7;
            this.lblSeconds.Text = "Seconds";
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(282, 47);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(49, 22);
            this.txtSeconds.TabIndex = 6;
            this.txtSeconds.Text = "0";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(201, 50);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(53, 16);
            this.lblMinutes.TabIndex = 5;
            this.lblMinutes.Text = "Minutes";
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(146, 47);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(49, 22);
            this.txtMinutes.TabIndex = 4;
            this.txtMinutes.Text = "0";
            this.txtMinutes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(76, 50);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(43, 16);
            this.lblHours.TabIndex = 3;
            this.lblHours.Text = "Hours";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(21, 47);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(49, 22);
            this.txtHours.TabIndex = 2;
            this.txtHours.Text = "0";
            // 
            // radFrequency
            // 
            this.radFrequency.AutoSize = true;
            this.radFrequency.Location = new System.Drawing.Point(95, 21);
            this.radFrequency.Name = "radFrequency";
            this.radFrequency.Size = new System.Drawing.Size(92, 20);
            this.radFrequency.TabIndex = 1;
            this.radFrequency.Text = "Frequency";
            this.radFrequency.UseVisualStyleBackColor = true;
            this.radFrequency.CheckedChanged += new System.EventHandler(this.RadCheck_CheckedChanged);
            // 
            // radbtnPeriod
            // 
            this.radbtnPeriod.AutoSize = true;
            this.radbtnPeriod.Checked = true;
            this.radbtnPeriod.Location = new System.Drawing.Point(21, 21);
            this.radbtnPeriod.Name = "radbtnPeriod";
            this.radbtnPeriod.Size = new System.Drawing.Size(68, 20);
            this.radbtnPeriod.TabIndex = 0;
            this.radbtnPeriod.TabStop = true;
            this.radbtnPeriod.Text = "Period";
            this.radbtnPeriod.UseVisualStyleBackColor = true;
            this.radbtnPeriod.CheckedChanged += new System.EventHandler(this.RadCheck_CheckedChanged);
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.comboBox1);
            this.grpOptions.Controls.Add(this.cmbButton);
            this.grpOptions.Controls.Add(this.lblClick);
            this.grpOptions.Controls.Add(this.lblMouseBtn);
            this.grpOptions.Location = new System.Drawing.Point(12, 143);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(259, 100);
            this.grpOptions.TabIndex = 1;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Click Options";
            // 
            // lblMouseBtn
            // 
            this.lblMouseBtn.AutoSize = true;
            this.lblMouseBtn.Location = new System.Drawing.Point(18, 27);
            this.lblMouseBtn.Name = "lblMouseBtn";
            this.lblMouseBtn.Size = new System.Drawing.Size(88, 16);
            this.lblMouseBtn.TabIndex = 0;
            this.lblMouseBtn.Text = "Mouse Button";
            // 
            // lblClick
            // 
            this.lblClick.AutoSize = true;
            this.lblClick.Location = new System.Drawing.Point(18, 56);
            this.lblClick.Name = "lblClick";
            this.lblClick.Size = new System.Drawing.Size(71, 16);
            this.lblClick.TabIndex = 1;
            this.lblClick.Text = "Click Type";
            this.lblClick.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // cmbButton
            // 
            this.cmbButton.AllowDrop = true;
            this.cmbButton.FormattingEnabled = true;
            this.cmbButton.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Middle"});
            this.cmbButton.Location = new System.Drawing.Point(127, 24);
            this.cmbButton.Name = "cmbButton";
            this.cmbButton.Size = new System.Drawing.Size(121, 24);
            this.cmbButton.TabIndex = 2;
            this.cmbButton.Text = "Left";
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Single",
            "Double"});
            this.comboBox1.Location = new System.Drawing.Point(127, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Single";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radStopped);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numRepeat);
            this.groupBox1.Controls.Add(this.radRepeat);
            this.groupBox1.Location = new System.Drawing.Point(279, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Click Repeat";
            // 
            // radRepeat
            // 
            this.radRepeat.AutoSize = true;
            this.radRepeat.Location = new System.Drawing.Point(15, 25);
            this.radRepeat.Name = "radRepeat";
            this.radRepeat.Size = new System.Drawing.Size(73, 20);
            this.radRepeat.TabIndex = 0;
            this.radRepeat.TabStop = true;
            this.radRepeat.Text = "Repeat";
            this.radRepeat.UseVisualStyleBackColor = true;
            // 
            // numRepeat
            // 
            this.numRepeat.Location = new System.Drawing.Point(89, 25);
            this.numRepeat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRepeat.Name = "numRepeat";
            this.numRepeat.Size = new System.Drawing.Size(78, 22);
            this.numRepeat.TabIndex = 1;
            this.numRepeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "times.";
            // 
            // radStopped
            // 
            this.radStopped.AutoSize = true;
            this.radStopped.Location = new System.Drawing.Point(15, 54);
            this.radStopped.Name = "radStopped";
            this.radStopped.Size = new System.Drawing.Size(152, 20);
            this.radStopped.TabIndex = 3;
            this.radStopped.TabStop = true;
            this.radStopped.Text = "Repeat until stopped";
            this.radStopped.UseVisualStyleBackColor = true;
            // 
            // grpCursor
            // 
            this.grpCursor.Controls.Add(this.label2);
            this.grpCursor.Controls.Add(this.txtY);
            this.grpCursor.Controls.Add(this.label3);
            this.grpCursor.Controls.Add(this.txtX);
            this.grpCursor.Controls.Add(this.btnPickPos);
            this.grpCursor.Controls.Add(this.radPickLoc);
            this.grpCursor.Controls.Add(this.radCurrPos);
            this.grpCursor.Location = new System.Drawing.Point(13, 249);
            this.grpCursor.Name = "grpCursor";
            this.grpCursor.Size = new System.Drawing.Size(572, 100);
            this.grpCursor.TabIndex = 3;
            this.grpCursor.TabStop = false;
            this.grpCursor.Text = "Cursor position";
            // 
            // radCurrPos
            // 
            this.radCurrPos.AutoSize = true;
            this.radCurrPos.Location = new System.Drawing.Point(20, 37);
            this.radCurrPos.Name = "radCurrPos";
            this.radCurrPos.Size = new System.Drawing.Size(121, 20);
            this.radCurrPos.TabIndex = 0;
            this.radCurrPos.TabStop = true;
            this.radCurrPos.Text = "Current Position";
            this.radCurrPos.UseVisualStyleBackColor = true;
            // 
            // radPickLoc
            // 
            this.radPickLoc.AutoSize = true;
            this.radPickLoc.Location = new System.Drawing.Point(155, 39);
            this.radPickLoc.Name = "radPickLoc";
            this.radPickLoc.Size = new System.Drawing.Size(17, 16);
            this.radPickLoc.TabIndex = 1;
            this.radPickLoc.TabStop = true;
            this.radPickLoc.UseVisualStyleBackColor = true;
            // 
            // btnPickPos
            // 
            this.btnPickPos.Location = new System.Drawing.Point(178, 22);
            this.btnPickPos.Name = "btnPickPos";
            this.btnPickPos.Size = new System.Drawing.Size(152, 51);
            this.btnPickPos.TabIndex = 2;
            this.btnPickPos.Text = "Pick Position";
            this.btnPickPos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(417, 35);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(49, 22);
            this.txtY.TabIndex = 8;
            this.txtY.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "X";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(339, 36);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(49, 22);
            this.txtX.TabIndex = 6;
            this.txtX.Text = "0";
            // 
            // MainMouseClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 485);
            this.Controls.Add(this.grpCursor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpControl);
            this.MaximizeBox = false;
            this.Name = "MainMouseClicker";
            this.Text = "Mouse Clicker";
            this.grpControl.ResumeLayout(false);
            this.grpControl.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRepeat)).EndInit();
            this.grpCursor.ResumeLayout(false);
            this.grpCursor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpControl;
        private System.Windows.Forms.RadioButton radbtnPeriod;
        private System.Windows.Forms.RadioButton radFrequency;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.Label lblMiniseconds;
        private System.Windows.Forms.TextBox txtMilliseconds;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Label lblClick;
        private System.Windows.Forms.Label lblMouseBtn;
        private System.Windows.Forms.ComboBox cmbButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radStopped;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numRepeat;
        private System.Windows.Forms.RadioButton radRepeat;
        private System.Windows.Forms.GroupBox grpCursor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button btnPickPos;
        private System.Windows.Forms.RadioButton radPickLoc;
        private System.Windows.Forms.RadioButton radCurrPos;
    }
}

