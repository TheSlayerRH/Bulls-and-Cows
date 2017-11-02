using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_Games
{
    public partial class FormBullsAndCows : Form
    {
        public FormBullsAndCows()
        {
            InitializeComponent();
        }

        private void FormBullsAndCows_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        int[] code = new int[4];

        //Methods:
        private int[] getNewCode()
        {
            List<int> digits = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                digits.Add(i);
            }

            Random random = new Random();

            int zeroIndex = random.Next(digits.Count-1) + 1;
            code[0] = digits.ElementAt(zeroIndex);
            digits.RemoveAt(zeroIndex);

            for (int i = 1; i < 4; i++)
            {
                int randomDigitIndex = random.Next(digits.Count);
                code[i] = digits.ElementAt(randomDigitIndex);
                digits.RemoveAt(randomDigitIndex);
            }

            return code;
        }

        private int getNextNumber(int number)
        {
            if (number == 9)
            {
                return 0;
            }

            return number + 1;
        }

        private bool isGoodGuess(int[] guess)
        {
            for (int a = 0; a < guess.Length; a++)
            {
                for (int b = a + 1; b < guess.Length; b++)
                {
                    if (guess[a] == guess[b])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        //-------------------------------------------------------------

        private void FormBullsAndCows_Load(object sender, EventArgs e)
        {
            int[] newCode = getNewCode();
            code[0] = newCode[0];
            code[1] = newCode[1];
            code[2] = newCode[2];
            code[3] = newCode[3];
        }

        private void labelGuess1_Click(object sender, EventArgs e)
        {
            int next = getNextNumber(int.Parse(labelGuess1.Text));

            if (next == 0)
            {
                next = 1;
            }

            labelGuess1.Text = "" + next;
        }

        private void labelGuess2_Click(object sender, EventArgs e)
        {
            labelGuess2.Text = "" + getNextNumber(int.Parse(labelGuess2.Text));
        }

        private void labelGuess3_Click(object sender, EventArgs e)
        {
            labelGuess3.Text = "" + getNextNumber(int.Parse(labelGuess3.Text));
        }

        private void labelGuess4_Click(object sender, EventArgs e)
        {
            labelGuess4.Text = "" + getNextNumber(int.Parse(labelGuess4.Text));
        }

        int guessNumber = 1;

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            int bulls = 0, cows = 0;

            int[] currentGuess = {int.Parse(labelGuess1.Text), int.Parse(labelGuess2.Text), int.Parse(labelGuess3.Text), int.Parse(labelGuess4.Text)};

            if (!isGoodGuess(currentGuess))
            {
                MessageBox.Show("Guess can't have repeating numbers!");
            }
            else
            {
                for (int i = 0; i < currentGuess.Length; i++)
                {
                    if (currentGuess[i] == code[i])
                    {
                        bulls++;
                    }
                    else
                    {
                        for (int index = 0; index < code.Length; index++)
                        {
                            if (currentGuess[i] == code[index])
                            {
                                cows++;
                                break;
                            }
                        }
                    }
                }

                if (guessNumber == 1)
                {
                    labelGuess1_1.Text = labelGuess1.Text;
                    labelGuess1_2.Text = labelGuess2.Text;
                    labelGuess1_3.Text = labelGuess3.Text;
                    labelGuess1_4.Text = labelGuess4.Text;

                    labelBulls1.Text = "" + bulls;
                    labelCows1.Text = "" + cows;

                    labelGuess1_1.Visible = true;
                    labelGuess1_2.Visible = true;
                    labelGuess1_3.Visible = true;
                    labelGuess1_4.Visible = true;

                    labelBulls1.Visible = true;
                    labelCows1.Visible = true;
                }
                else if (guessNumber == 2)
                {
                    labelGuess2_1.Text = labelGuess1.Text;
                    labelGuess2_2.Text = labelGuess2.Text;
                    labelGuess2_3.Text = labelGuess3.Text;
                    labelGuess2_4.Text = labelGuess4.Text;

                    labelBulls2.Text = "" + bulls;
                    labelCows2.Text = "" + cows;

                    labelGuess2_1.Visible = true;
                    labelGuess2_2.Visible = true;
                    labelGuess2_3.Visible = true;
                    labelGuess2_4.Visible = true;

                    labelBulls2.Visible = true;
                    labelCows2.Visible = true;
                }
                else if (guessNumber == 3)
                {
                    labelGuess3_1.Text = labelGuess1.Text;
                    labelGuess3_2.Text = labelGuess2.Text;
                    labelGuess3_3.Text = labelGuess3.Text;
                    labelGuess3_4.Text = labelGuess4.Text;

                    labelBulls3.Text = "" + bulls;
                    labelCows3.Text = "" + cows;

                    labelGuess3_1.Visible = true;
                    labelGuess3_2.Visible = true;
                    labelGuess3_3.Visible = true;
                    labelGuess3_4.Visible = true;

                    labelBulls3.Visible = true;
                    labelCows3.Visible = true;
                }
                else if (guessNumber == 4)
                {
                    labelGuess4_1.Text = labelGuess1.Text;
                    labelGuess4_2.Text = labelGuess2.Text;
                    labelGuess4_3.Text = labelGuess3.Text;
                    labelGuess4_4.Text = labelGuess4.Text;

                    labelBulls4.Text = "" + bulls;
                    labelCows4.Text = "" + cows;

                    labelGuess4_1.Visible = true;
                    labelGuess4_2.Visible = true;
                    labelGuess4_3.Visible = true;
                    labelGuess4_4.Visible = true;

                    labelBulls4.Visible = true;
                    labelCows4.Visible = true;
                }
                else if (guessNumber == 5)
                {
                    labelGuess5_1.Text = labelGuess1.Text;
                    labelGuess5_2.Text = labelGuess2.Text;
                    labelGuess5_3.Text = labelGuess3.Text;
                    labelGuess5_4.Text = labelGuess4.Text;

                    labelBulls5.Text = "" + bulls;
                    labelCows5.Text = "" + cows;

                    labelGuess5_1.Visible = true;
                    labelGuess5_2.Visible = true;
                    labelGuess5_3.Visible = true;
                    labelGuess5_4.Visible = true;

                    labelBulls5.Visible = true;
                    labelCows5.Visible = true;
                }
                else if (guessNumber == 6)
                {
                    labelGuess6_1.Text = labelGuess1.Text;
                    labelGuess6_2.Text = labelGuess2.Text;
                    labelGuess6_3.Text = labelGuess3.Text;
                    labelGuess6_4.Text = labelGuess4.Text;

                    labelBulls6.Text = "" + bulls;
                    labelCows6.Text = "" + cows;

                    labelGuess6_1.Visible = true;
                    labelGuess6_2.Visible = true;
                    labelGuess6_3.Visible = true;
                    labelGuess6_4.Visible = true;

                    labelBulls6.Visible = true;
                    labelCows6.Visible = true;
                }
                else if (guessNumber == 7)
                {
                    labelGuess7_1.Text = labelGuess1.Text;
                    labelGuess7_2.Text = labelGuess2.Text;
                    labelGuess7_3.Text = labelGuess3.Text;
                    labelGuess7_4.Text = labelGuess4.Text;

                    labelBulls7.Text = "" + bulls;
                    labelCows7.Text = "" + cows;

                    labelGuess7_1.Visible = true;
                    labelGuess7_2.Visible = true;
                    labelGuess7_3.Visible = true;
                    labelGuess7_4.Visible = true;

                    labelBulls7.Visible = true;
                    labelCows7.Visible = true;
                }
                else if (guessNumber == 8)
                {
                    labelGuess8_1.Text = labelGuess1.Text;
                    labelGuess8_2.Text = labelGuess2.Text;
                    labelGuess8_3.Text = labelGuess3.Text;
                    labelGuess8_4.Text = labelGuess4.Text;

                    labelBulls8.Text = "" + bulls;
                    labelCows8.Text = "" + cows;

                    labelGuess8_1.Visible = true;
                    labelGuess8_2.Visible = true;
                    labelGuess8_3.Visible = true;
                    labelGuess8_4.Visible = true;

                    labelBulls8.Visible = true;
                    labelCows8.Visible = true;
                }
                else if (guessNumber == 9)
                {
                    labelGuess9_1.Text = labelGuess1.Text;
                    labelGuess9_2.Text = labelGuess2.Text;
                    labelGuess9_3.Text = labelGuess3.Text;
                    labelGuess9_4.Text = labelGuess4.Text;

                    labelBulls9.Text = "" + bulls;
                    labelCows9.Text = "" + cows;

                    labelGuess9_1.Visible = true;
                    labelGuess9_2.Visible = true;
                    labelGuess9_3.Visible = true;
                    labelGuess9_4.Visible = true;

                    labelBulls9.Visible = true;
                    labelCows9.Visible = true;
                }
                else if (guessNumber == 10)
                {
                    labelGuess10_1.Text = labelGuess1.Text;
                    labelGuess10_2.Text = labelGuess2.Text;
                    labelGuess10_3.Text = labelGuess3.Text;
                    labelGuess10_4.Text = labelGuess4.Text;

                    labelBulls10.Text = "" + bulls;
                    labelCows10.Text = "" + cows;

                    labelGuess10_1.Visible = true;
                    labelGuess10_2.Visible = true;
                    labelGuess10_3.Visible = true;
                    labelGuess10_4.Visible = true;

                    labelBulls10.Visible = true;
                    labelCows10.Visible = true;
                }

                guessNumber++;
                labelGuess1.Text = "1";
                labelGuess2.Text = "0";
                labelGuess3.Text = "0";
                labelGuess4.Text = "0";

                if (bulls == 4)
                {
                    buttonGuess.Enabled = false;
                    buttonPlayAgain.Text = "Play again";

                    labelGuess1.Enabled = false;
                    labelGuess2.Enabled = false;
                    labelGuess3.Enabled = false;
                    labelGuess4.Enabled = false;

                    MessageBox.Show("You won!", "Winner");
                }
                else if (guessNumber == 11)
                {
                    buttonGuess.Enabled = false;
                    buttonPlayAgain.Text = "Play again";

                    labelGuess1.Enabled = false;
                    labelGuess2.Enabled = false;
                    labelGuess3.Enabled = false;
                    labelGuess4.Enabled = false;

                    MessageBox.Show("You lost!\nThe real code is: " + code[0] + code[1] + code[2] + code[3], "Loser");
                }
            }
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            Label[] labels = { labelGuess1_1, labelGuess1_2, labelGuess1_3, labelGuess1_4,
                             labelGuess2_1, labelGuess2_2, labelGuess2_3, labelGuess2_4,
                             labelGuess3_1, labelGuess3_2, labelGuess3_3, labelGuess3_4,
                             labelGuess4_1, labelGuess4_2, labelGuess4_3, labelGuess4_4,
                             labelGuess5_1, labelGuess5_2, labelGuess5_3, labelGuess5_4,
                             labelGuess6_1, labelGuess6_2, labelGuess6_3, labelGuess6_4,
                             labelGuess7_1, labelGuess7_2, labelGuess7_3, labelGuess7_4,
                             labelGuess8_1, labelGuess8_2, labelGuess8_3, labelGuess8_4,
                             labelGuess9_1, labelGuess9_2, labelGuess9_3, labelGuess9_4,
                             labelGuess10_1, labelGuess10_2, labelGuess10_3, labelGuess10_4,

                             labelBulls1, labelBulls2, labelBulls3, labelBulls4,
                             labelBulls5, labelBulls6, labelBulls7, labelBulls8,
                             labelBulls9, labelBulls10,
                             
                             labelCows1, labelCows2, labelCows3, labelCows4,
                             labelCows5, labelCows6, labelCows7, labelCows8,
                             labelCows9, labelCows10};

            foreach (Label l in labels)
            {
                l.Visible = false;
            }

            code = getNewCode();

            guessNumber = 1;

            buttonPlayAgain.Enabled = true;
            labelGuess1.Text = "1";
            labelGuess2.Text = "0";
            labelGuess3.Text = "0";
            labelGuess4.Text = "0";

            buttonPlayAgain.Text = "Restart";
            buttonGuess.Enabled = true;

            labelGuess1.Enabled = true;
            labelGuess2.Enabled = true;
            labelGuess3.Enabled = true;
            labelGuess4.Enabled = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormGames formGames = new FormGames();
            formGames.Show();
            this.Hide();
        }
    }
}
