using System;
using System.Windows.Forms;

namespace MathGame2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (Exercise.OKSettings)
            {
                Game game = new Game();
                Hide();
                game.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Wrong settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
