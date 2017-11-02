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
    public partial class FormGames : Form
    {
        public FormGames()
        {
            InitializeComponent();
        }

        private void FormGames_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bullsAndCowsMouseEnter(object sender, EventArgs e)
        {
            labelInformation.Text = "Bulls and Cows -\n" +
                                    "You have 10 guesses to try and guess the 4-digits number code with no repeating digits.\n" +
                                    "After each guess you will be told how many bulls and cows you got.\n\n" +

                                    "You get one bull for each digit of the digits you guessed which is in the code exactly in the right\n" +
                                    "position.\n\n" +

                                    "You get one cow for each digit of the digits you guessed which is in the code but not in the right\n" +
                                    "position.";
            labelInformation.Visible = true;
        }

        private void mastermindMouseEnter(object sender, EventArgs e)
        {
            labelInformation.Text = "Master Mind -\n" +
                                    "You have 12 guesses to try and guess the 4-colors secret code (Same color repeated is allowed).\n" +
                                    "After each guess you will be told how many bulls and cows you got.\n\n" +

                                    "You get one bull for each color of the colors you guessed which is in the code exactly in the right\n" +
                                    "position.\n\n" +

                                    "You get one cow for each color of the colors you guessed which is in the code but not in the right\n" +
                                    "position.";
            labelInformation.Visible = true;
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            labelInformation.Visible = false;
        }

        private void pictureBoxBullsAndCows_Click(object sender, EventArgs e)
        {
            FormBullsAndCows formBullsAndCows = new FormBullsAndCows();
            formBullsAndCows.Show();
            this.Hide();
        }
    }
}
