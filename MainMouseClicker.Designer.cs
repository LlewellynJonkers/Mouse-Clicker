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
            this.grpPeriod = new System.Windows.Forms.GroupBox();
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
            this.grpPeriod.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPeriod
            // 
            this.grpPeriod.Controls.Add(this.lblFrequency);
            this.grpPeriod.Controls.Add(this.txtFrequency);
            this.grpPeriod.Controls.Add(this.lblMiniseconds);
            this.grpPeriod.Controls.Add(this.txtMilliseconds);
            this.grpPeriod.Controls.Add(this.lblSeconds);
            this.grpPeriod.Controls.Add(this.txtSeconds);
            this.grpPeriod.Controls.Add(this.lblMinutes);
            this.grpPeriod.Controls.Add(this.txtMinutes);
            this.grpPeriod.Controls.Add(this.lblHours);
            this.grpPeriod.Controls.Add(this.txtHours);
            this.grpPeriod.Controls.Add(this.radFrequency);
            this.grpPeriod.Controls.Add(this.radbtnPeriod);
            this.grpPeriod.Location = new System.Drawing.Point(12, 12);
            this.grpPeriod.Name = "grpPeriod";
            this.grpPeriod.Size = new System.Drawing.Size(571, 125);
            this.grpPeriod.TabIndex = 0;
            this.grpPeriod.TabStop = false;
            this.grpPeriod.Text = "Click Control";
            this.grpPeriod.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // MainMouseClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.grpPeriod);
            this.MaximizeBox = false;
            this.Name = "MainMouseClicker";
            this.Text = "Mouse Clicker";
            this.grpPeriod.ResumeLayout(false);
            this.grpPeriod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPeriod;
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
    }
}

