using System;
using System.Windows.Forms;

namespace MathGame2
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void PlusCB_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Plus = PlusCB.Checked;
            Properties.Settings.Default.Save();
        }

        private void MinusCB_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Minus = MinusCB.Checked;
            Properties.Settings.Default.Save();
        }

        private void DivideCB_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Divide = DivideCB.Checked;
            Properties.Settings.Default.Save();
        }

        private void MultiplyCB_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Multiply = MultiplyCB.Checked;
            Properties.Settings.Default.Save();
        }

        private void OneNumCB_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.OneNum = OneNumCB.Checked;
            Properties.Settings.Default.Save();
        }

        private void TwoNumCB_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TwoNum = TwoNumCB.Checked;
            Properties.Settings.Default.Save();
        }

        private void ThreeNumCB_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ThreeNum = ThreeNumCB.Checked;
            Properties.Settings.Default.Save();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            PlusCB.Checked = Properties.Settings.Default.Plus;
            MinusCB.Checked = Properties.Settings.Default.Minus;
            DivideCB.Checked = Properties.Settings.Default.Divide;
            MultiplyCB.Checked = Properties.Settings.Default.Multiply;

            OneNumCB.Checked = Properties.Settings.Default.OneNum;
            TwoNumCB.Checked = Properties.Settings.Default.TwoNum;
            ThreeNumCB.Checked = Properties.Settings.Default.ThreeNum;
        }
    }
}
