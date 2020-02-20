namespace PongWinForms
{
    partial class Pong
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
            this.components = new System.ComponentModel.Container();
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.ResponsiveInterface = new System.Windows.Forms.Timer(this.components);
            this.Scoreboard = new System.Windows.Forms.Label();
            this.UpdateScore = new System.Windows.Forms.Timer(this.components);
            this.BallMovement = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.BackgroundImage = global::PongWinForms.Properties.Resources.PlayerGraphics;
            this.Player1.Location = new System.Drawing.Point(12, 374);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(16, 72);
            this.Player1.TabIndex = 0;
            this.Player1.TabStop = false;
            // 
            // Player2
            // 
            this.Player2.BackgroundImage = global::PongWinForms.Properties.Resources.PlayerGraphics;
            this.Player2.Location = new System.Drawing.Point(772, 177);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(16, 72);
            this.Player2.TabIndex = 1;
            this.Player2.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ball.BackgroundImage = global::PongWinForms.Properties.Resources.Ball;
            this.Ball.Location = new System.Drawing.Point(408, 242);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(13, 14);
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            // 
            // ResponsiveInterface
            // 
            this.ResponsiveInterface.Enabled = true;
            this.ResponsiveInterface.Interval = 1;
            this.ResponsiveInterface.Tick += new System.EventHandler(this.ResponsiveInterface_Tick);
            // 
            // Scoreboard
            // 
            this.Scoreboard.AutoSize = true;
            this.Scoreboard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Scoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoreboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Scoreboard.Location = new System.Drawing.Point(381, 9);
            this.Scoreboard.Name = "Scoreboard";
            this.Scoreboard.Size = new System.Drawing.Size(40, 20);
            this.Scoreboard.TabIndex = 3;
            this.Scoreboard.Text = "0 | 0";
            this.Scoreboard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UpdateScore
            // 
            this.UpdateScore.Enabled = true;
            this.UpdateScore.Tick += new System.EventHandler(this.UpdateScore_Tick);
            // 
            // BallMovement
            // 
            this.BallMovement.Enabled = true;
            this.BallMovement.Interval = 1;
            this.BallMovement.Tick += new System.EventHandler(this.BallMovement_Tick);
            // 
            // Pong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.Scoreboard);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Name = "Pong";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressed);
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.PictureBox Player2;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer ResponsiveInterface;
        private System.Windows.Forms.Label Scoreboard;
        private System.Windows.Forms.Timer UpdateScore;
        private System.Windows.Forms.Timer BallMovement;
    }
}

