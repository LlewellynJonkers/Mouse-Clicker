using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse_Clicker
{
    public partial class MainMouseClicker : Form
    {
        public MainMouseClicker()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RadCheck_CheckedChanged(object sender, EventArgs e)
        {
            txtFrequency.Enabled = radFrequency.Checked;
            txtHours.Enabled = txtMinutes.Enabled = txtSeconds.Enabled = txtMilliseconds.Enabled = radbtnPeriod.Checked;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
