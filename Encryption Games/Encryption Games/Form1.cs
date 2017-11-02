using Encryption_Games.Properties;
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
    public partial class Form1 : Form
    {
        Image button = Resources.button;
        Image clickedButton = Resources.clickedButton;
        Image buttonHover = Resources.buttonHover;

        public Form1()
        {
            InitializeComponent();
        }

        //resizeImage: Returns the image entered with the wanted size;
        private Image resizeImage(Image image, Size newSize)
        {
            Image newImage = new Bitmap(newSize.Width, newSize.Height);

            using (Graphics g = Graphics.FromImage((Bitmap)newImage))
            {
                g.DrawImage(image, new Rectangle(Point.Empty, newSize));
            }

            return newImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int titleX = this.Width / 2 - (labelTitle.Width / 2);
            int gamesX = this.Width / 2 - (buttonGames.Width / 2);
            int creditsX = this.Width / 2 - (buttonCredits.Width / 2);

            buttonGames.Location = new Point(gamesX, buttonGames.Location.Y);
            buttonCredits.Location = new Point(creditsX, buttonCredits.Location.Y);
            labelTitle.Location = new Point(titleX, labelTitle.Location.Y);

            buttonGames.Image = resizeImage(button, buttonGames.Size);
            buttonCredits.Image = resizeImage(button, buttonCredits.Size);
        }

        //buttonGames:
        private void buttonGames_MouseDown(object sender, MouseEventArgs e)
        {
            buttonGames.Image = resizeImage(clickedButton, buttonGames.Size);
        }

        private void buttonGames_MouseUp(object sender, MouseEventArgs e)
        {
            buttonGames.Image = resizeImage(buttonHover, buttonGames.Size);
        }

        private void buttonGames_MouseEnter(object sender, EventArgs e)
        {
            buttonGames.Image = resizeImage(buttonHover, buttonGames.Size);
        }

        private void buttonGames_MouseLeave(object sender, EventArgs e)
        {
            buttonGames.Image = resizeImage(button, buttonGames.Size);
        }

        private void buttonGames_Click(object sender, EventArgs e)
        {
            FormGames formGames = new FormGames();
            formGames.Show();
            this.Hide();
        }

        //buttonCredits:
        private void buttonCredits_MouseDown(object sender, MouseEventArgs e)
        {
            buttonCredits.Image = resizeImage(clickedButton, buttonCredits.Size);
        }

        private void buttonCredits_MouseUp(object sender, MouseEventArgs e)
        {
            buttonCredits.Image = resizeImage(buttonHover, buttonCredits.Size);
        }

        private void buttonCredits_MouseEnter(object sender, EventArgs e)
        {
            buttonCredits.Image = resizeImage(buttonHover, buttonCredits.Size);
        }

        private void buttonCredits_MouseLeave(object sender, EventArgs e)
        {
            buttonCredits.Image = resizeImage(button, buttonCredits.Size);
        }
    }
}
