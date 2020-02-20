namespace PongWinForms
{
    partial class Configuration
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
            this.groupControls = new System.Windows.Forms.GroupBox();
            this.DownKey2 = new System.Windows.Forms.TextBox();
            this.UpKey2 = new System.Windows.Forms.TextBox();
            this.DownKey1 = new System.Windows.Forms.TextBox();
            this.UpKey1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControlUp = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ScoreToWin = new System.Windows.Forms.NumericUpDown();
            this.labelMaxScore = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupControls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreToWin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControls
            // 
            this.groupControls.Controls.Add(this.DownKey2);
            this.groupControls.Controls.Add(this.UpKey2);
            this.groupControls.Controls.Add(this.DownKey1);
            this.groupControls.Controls.Add(this.UpKey1);
            this.groupControls.Controls.Add(this.label1);
            this.groupControls.Controls.Add(this.labelControlUp);
            this.groupControls.Controls.Add(this.labelPlayer2);
            this.groupControls.Controls.Add(this.labelPlayer1);
            this.groupControls.Location = new System.Drawing.Point(12, 12);
            this.groupControls.Name = "groupControls";
            this.groupControls.Size = new System.Drawing.Size(378, 111);
            this.groupControls.TabIndex = 0;
            this.groupControls.TabStop = false;
            this.groupControls.Text = "Player Controls";
            // 
            // DownKey2
            // 
            this.DownKey2.Location = new System.Drawing.Point(258, 65);
            this.DownKey2.MaxLength = 100;
            this.DownKey2.Name = "DownKey2";
            this.DownKey2.Size = new System.Drawing.Size(85, 20);
            this.DownKey2.TabIndex = 7;
            this.DownKey2.Text = "Down";
            this.DownKey2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DownKey2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DownKey2_KeyDown);
            // 
            // UpKey2
            // 
            this.UpKey2.Location = new System.Drawing.Point(145, 65);
            this.UpKey2.MaxLength = 1;
            this.UpKey2.Name = "UpKey2";
            this.UpKey2.Size = new System.Drawing.Size(85, 20);
            this.UpKey2.TabIndex = 6;
            this.UpKey2.Text = "Up";
            this.UpKey2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpKey2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpKey2_KeyDown);
            // 
            // DownKey1
            // 
            this.DownKey1.Location = new System.Drawing.Point(258, 37);
            this.DownKey1.MaxLength = 1;
            this.DownKey1.Name = "DownKey1";
            this.DownKey1.Size = new System.Drawing.Size(85, 20);
            this.DownKey1.TabIndex = 5;
            this.DownKey1.Text = "S";
            this.DownKey1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DownKey1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DownKey1_KeyDown);
            // 
            // UpKey1
            // 
            this.UpKey1.Location = new System.Drawing.Point(145, 37);
            this.UpKey1.MaxLength = 1;
            this.UpKey1.Name = "UpKey1";
            this.UpKey1.Size = new System.Drawing.Size(85, 20);
            this.UpKey1.TabIndex = 4;
            this.UpKey1.Text = "W";
            this.UpKey1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpKey1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpKey1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Down";
            // 
            // labelControlUp
            // 
            this.labelControlUp.AutoSize = true;
            this.labelControlUp.Location = new System.Drawing.Point(173, 20);
            this.labelControlUp.Name = "labelControlUp";
            this.labelControlUp.Size = new System.Drawing.Size(21, 13);
            this.labelControlUp.TabIndex = 2;
            this.labelControlUp.Text = "Up";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Location = new System.Drawing.Point(88, 68);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(51, 13);
            this.labelPlayer2.TabIndex = 1;
            this.labelPlayer2.Text = "Player 2: ";
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Location = new System.Drawing.Point(88, 37);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(51, 13);
            this.labelPlayer1.TabIndex = 0;
            this.labelPlayer1.Text = "Player 1: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ScoreToWin);
            this.groupBox1.Controls.Add(this.labelMaxScore);
            this.groupBox1.Location = new System.Drawing.Point(12, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 62);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Controls";
            // 
            // ScoreToWin
            // 
            this.ScoreToWin.Location = new System.Drawing.Point(145, 28);
            this.ScoreToWin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ScoreToWin.Name = "ScoreToWin";
            this.ScoreToWin.Size = new System.Drawing.Size(198, 20);
            this.ScoreToWin.TabIndex = 1;
            this.ScoreToWin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelMaxScore
            // 
            this.labelMaxScore.AutoSize = true;
            this.labelMaxScore.Location = new System.Drawing.Point(70, 30);
            this.labelMaxScore.Name = "labelMaxScore";
            this.labelMaxScore.Size = new System.Drawing.Size(69, 13);
            this.labelMaxScore.TabIndex = 0;
            this.labelMaxScore.Text = "Score to win:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(315, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(225, 226);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 261);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupControls);
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.groupControls.ResumeLayout(false);
            this.groupControls.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreToWin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupControls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelControlUp;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.TextBox DownKey2;
        private System.Windows.Forms.TextBox UpKey2;
        private System.Windows.Forms.TextBox DownKey1;
        private System.Windows.Forms.TextBox UpKey1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown ScoreToWin;
        private System.Windows.Forms.Label labelMaxScore;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}