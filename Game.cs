using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MathGame2
{
    public partial class Game : Form
    {
        private const string pattern = @"^-?\d+(\.\d+)?$";
        private readonly Regex regex = new Regex(pattern);
        private int correctCounter;
        private int wrongCounter;
        private int timeSeconds;

        public Game()
        {
            InitializeComponent();
            LoadSettings();
            correctCounter = 0;
            wrongCounter = 0;
        }
        private void LoadSettings()
        {
            PlusCB.Checked = Properties.Settings.Default.Plus;
            MinusCB.Checked = Properties.Settings.Default.Minus;
            DivideCB.Checked = Properties.Settings.Default.Divide;
            MultiplyCB.Checked = Properties.Settings.Default.Multiply;

            OneNumCB.Checked = Properties.Settings.Default.OneNum;
            TwoNumCB.Checked = Properties.Settings.Default.TwoNum;
            ThreeNumCB.Checked = Properties.Settings.Default.ThreeNum;
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            End();
            Main main = new Main();
            Hide();
            main.ShowDialog();
            Close();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            if (Exercise.OKSettings)
            {
                if (regex.Match(AnswerTB.Text).Success)
                {
                    if (Convert.ToDouble(AnswerTB.Text) == Exercise.Answer)
                    {
                        correctCounter++;
                        CorrectCounterLabel.Text = correctCounter.ToString();
                        GenerateExercise();
                    }
                    else
                    {
                        wrongCounter++;
                        WrongCounterLabel.Text = wrongCounter.ToString();
                        AnswerTB.Clear();
                    }
                }
                else
                {
                    AnswerTB.Clear();
                }
            }
            else
            {
                MessageBox.Show("Wrong settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            GenerateExercise();
        }

        private void GenerateExercise()
        {
            AnswerTB.Clear();
            Exercise.GenerateExercise();
            ExerciseLabel.Text = Exercise.TheExercise;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                InputButton.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
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

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            timeSeconds++;
            TimeSpan t = TimeSpan.FromSeconds(timeSeconds);
            TimeLabel.Text = string.Format("{0:D2}h:{1:D2}m:{2:D2}s",
                            t.Hours,
                            t.Minutes,
                            t.Seconds);
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            End();
        }

        private void End()
        {
            MainTimer.Enabled = false;
            if (correctCounter != 0)
            {
                double secondsPerQuestion = Math.Round(timeSeconds / (double)correctCounter, 2);

                MessageBox.Show($"Time Elpased: {TimeLabel.Text}\n" +
                    $"Average time per question: {secondsPerQuestion} seconds", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SkipButton_Click(object sender, EventArgs e)
        {
            AnswerTB.Text = Exercise.Answer.ToString(); // correct++ (+1 = 1)

            // fix counters

            // correct-- (-1 = 0)
            correctCounter--;
            CorrectCounterLabel.Text = correctCounter.ToString();

            // wrong++ (+1 = 1)
            wrongCounter++;
            WrongCounterLabel.Text = wrongCounter.ToString();

        }
    }
}
