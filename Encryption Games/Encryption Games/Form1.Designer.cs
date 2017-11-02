namespace Encryption_Games
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
            this.buttonGames = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCredits = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGames
            // 
            this.buttonGames.BackColor = System.Drawing.Color.Transparent;
            this.buttonGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonGames.Image = global::Encryption_Games.Properties.Resources.button;
            this.buttonGames.Location = new System.Drawing.Point(348, 405);
            this.buttonGames.Name = "buttonGames";
            this.buttonGames.Size = new System.Drawing.Size(185, 78);
            this.buttonGames.TabIndex = 0;
            this.buttonGames.Text = "Games";
            this.buttonGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonGames.Click += new System.EventHandler(this.buttonGames_Click);
            this.buttonGames.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonGames_MouseDown);
            this.buttonGames.MouseEnter += new System.EventHandler(this.buttonGames_MouseEnter);
            this.buttonGames.MouseLeave += new System.EventHandler(this.buttonGames_MouseLeave);
            this.buttonGames.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonGames_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Games List:\r\n\r\nBulls and Cows\r\nMastermind";
            // 
            // buttonCredits
            // 
            this.buttonCredits.BackColor = System.Drawing.Color.Transparent;
            this.buttonCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonCredits.Image = global::Encryption_Games.Properties.Resources.button;
            this.buttonCredits.Location = new System.Drawing.Point(371, 493);
            this.buttonCredits.Name = "buttonCredits";
            this.buttonCredits.Size = new System.Drawing.Size(140, 60);
            this.buttonCredits.TabIndex = 3;
            this.buttonCredits.Text = "Credits";
            this.buttonCredits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonCredits.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonCredits_MouseDown);
            this.buttonCredits.MouseEnter += new System.EventHandler(this.buttonCredits_MouseEnter);
            this.buttonCredits.MouseLeave += new System.EventHandler(this.buttonCredits_MouseLeave);
            this.buttonCredits.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonCredits_MouseUp);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Monotype Corsiva", 78F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.LightGray;
            this.labelTitle.Location = new System.Drawing.Point(88, 55);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(731, 127);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Encryption Games";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(878, 606);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonCredits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGames);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(894, 644);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(894, 644);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption Games - Menu";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label buttonGames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label buttonCredits;
        private System.Windows.Forms.Label labelTitle;

    }
}

