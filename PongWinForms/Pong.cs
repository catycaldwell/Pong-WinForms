using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PongWinForms
{
    public partial class Pong : Form
    {

        // Player instances
        Player player1;
        Player player2;
        Ball ball;

        // Match variables
        int ScoreToWin;

        public Pong(Settings settings)
        {
            InitializeComponent();

            // Initialize players with their respective controls.
            player1 = new Player(settings.PlayerOneUp, settings.PlayerOneDown, Player1);
            player2 = new Player(settings.PlayerTwoUp, settings.PlayerTwoDown, Player2);

            // Initialize the ball and match
            ball = new Ball(Ball, Ball.Left, Ball.Top);
            ScoreToWin = settings.ScoreToWin;

            // Centralize the ball to the center of the screen
            Ball.Left = (this.Width / 2) - (Ball.Width / 2);

        }

        private void ResponsiveInterface_Tick(object sender, EventArgs e)
        {
            // Adjust interface according to the window size
            Player2.Left = this.Size.Width - 44;
        }

        private void KeyPressed(object sender, KeyEventArgs keyPressed)
        {
            player1.Move(keyPressed);
            player2.Move(keyPressed);
        }

        private void UpdateScore_Tick(object sender, EventArgs e)
        {
            // Update scoreboard text
            Scoreboard.Text = $"{player1.Score} | {player2.Score}";

            // Check for player one victory
            if(player1.Score >= ScoreToWin)
            {
                BallMovement.Stop();
                labelVictory.Visible = true;
                labelVictory.Text = "Player 1 has won!";
            }

            if (player2.Score >= ScoreToWin)
            {
                BallMovement.Stop();
                labelVictory.Visible = true;
                labelVictory.Text = "Player 2 has won!";
            }

        }

        private void BallMovement_Tick(object sender, EventArgs e)
        {
            ball.Move();
            ball.IsOutOfBounds(player1, player2);
            ball.OnCollision(player1, player2);
        }

        private void Pong_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
