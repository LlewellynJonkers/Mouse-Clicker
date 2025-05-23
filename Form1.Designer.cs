namespace Mouse_Clicker
{
    partial class Form1
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
            this.radbtnPeriod = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.lblMiniseconds = new System.Windows.Forms.Label();
            this.txtMilliseconds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpPeriod.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPeriod
            // 
            this.grpPeriod.Controls.Add(this.label1);
            this.grpPeriod.Controls.Add(this.textBox1);
            this.grpPeriod.Controls.Add(this.lblMiniseconds);
            this.grpPeriod.Controls.Add(this.txtMilliseconds);
            this.grpPeriod.Controls.Add(this.lblSeconds);
            this.grpPeriod.Controls.Add(this.txtSeconds);
            this.grpPeriod.Controls.Add(this.lblMinutes);
            this.grpPeriod.Controls.Add(this.txtMinutes);
            this.grpPeriod.Controls.Add(this.lblHours);
            this.grpPeriod.Controls.Add(this.txtHours);
            this.grpPeriod.Controls.Add(this.radioButton2);
            this.grpPeriod.Controls.Add(this.radbtnPeriod);
            this.grpPeriod.Location = new System.Drawing.Point(12, 12);
            this.grpPeriod.Name = "grpPeriod";
            this.grpPeriod.Size = new System.Drawing.Size(571, 125);
            this.grpPeriod.TabIndex = 0;
            this.grpPeriod.TabStop = false;
            this.grpPeriod.Text = "Click Control";
            this.grpPeriod.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(95, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Frequency";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadCheck_CheckedChanged);
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(21, 47);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(49, 22);
            this.txtHours.TabIndex = 2;
            this.txtHours.Text = "0";
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
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(201, 50);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(53, 16);
            this.lblMinutes.TabIndex = 5;
            this.lblMinutes.Text = "Minutes";
            this.lblMinutes.Click += new System.EventHandler(this.label1_Click);
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
            // lblMiniseconds
            // 
            this.lblMiniseconds.AutoSize = true;
            this.lblMiniseconds.Location = new System.Drawing.Point(473, 50);
            this.lblMiniseconds.Name = "lblMiniseconds";
            this.lblMiniseconds.Size = new System.Drawing.Size(82, 16);
            this.lblMiniseconds.TabIndex = 9;
            this.lblMiniseconds.Text = "Milliseconds";
            this.lblMiniseconds.Click += new System.EventHandler(this.label1_Click_1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(125, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Per second";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(21, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.grpPeriod);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpPeriod.ResumeLayout(false);
            this.grpPeriod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPeriod;
        private System.Windows.Forms.RadioButton radbtnPeriod;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.Label lblMiniseconds;
        private System.Windows.Forms.TextBox txtMilliseconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

