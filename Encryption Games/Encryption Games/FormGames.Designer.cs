namespace Encryption_Games
{
    partial class FormGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGames));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelBullsAndCows = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelInformation = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBullsAndCows = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBullsAndCows)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Monotype Corsiva", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.LightGray;
            this.labelTitle.Location = new System.Drawing.Point(592, 490);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(274, 117);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Games";
            // 
            // labelBullsAndCows
            // 
            this.labelBullsAndCows.AutoSize = true;
            this.labelBullsAndCows.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBullsAndCows.ForeColor = System.Drawing.Color.White;
            this.labelBullsAndCows.Location = new System.Drawing.Point(6, 199);
            this.labelBullsAndCows.Name = "labelBullsAndCows";
            this.labelBullsAndCows.Size = new System.Drawing.Size(206, 31);
            this.labelBullsAndCows.TabIndex = 8;
            this.labelBullsAndCows.Text = "Bulls and Cows";
            this.labelBullsAndCows.Click += new System.EventHandler(this.pictureBoxBullsAndCows_Click);
            this.labelBullsAndCows.MouseEnter += new System.EventHandler(this.bullsAndCowsMouseEnter);
            this.labelBullsAndCows.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(288, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Master Mind";
            this.label2.MouseEnter += new System.EventHandler(this.mastermindMouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation.ForeColor = System.Drawing.Color.White;
            this.labelInformation.Location = new System.Drawing.Point(12, 267);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(796, 252);
            this.labelInformation.TabIndex = 10;
            this.labelInformation.Text = resources.GetString("labelInformation.Text");
            this.labelInformation.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(283, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 184);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseEnter += new System.EventHandler(this.mastermindMouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // pictureBoxBullsAndCows
            // 
            this.pictureBoxBullsAndCows.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBullsAndCows.Image = global::Encryption_Games.Properties.Resources.Bulls_and_Cows;
            this.pictureBoxBullsAndCows.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBullsAndCows.Name = "pictureBoxBullsAndCows";
            this.pictureBoxBullsAndCows.Size = new System.Drawing.Size(200, 184);
            this.pictureBoxBullsAndCows.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBullsAndCows.TabIndex = 6;
            this.pictureBoxBullsAndCows.TabStop = false;
            this.pictureBoxBullsAndCows.Click += new System.EventHandler(this.pictureBoxBullsAndCows_Click);
            this.pictureBoxBullsAndCows.MouseEnter += new System.EventHandler(this.bullsAndCowsMouseEnter);
            this.pictureBoxBullsAndCows.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // FormGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(878, 606);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBullsAndCows);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxBullsAndCows);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(894, 644);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(894, 644);
            this.Name = "FormGames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption Games - Games Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGames_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBullsAndCows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxBullsAndCows;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelBullsAndCows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelInformation;
    }
}