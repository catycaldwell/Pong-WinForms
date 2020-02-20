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

        public Pong()
        {
            InitializeComponent();

            // Initialize players with their respective controls.
            player1 = new Player(Keys.W, Keys.S, Player1);
            player2 = new Player(Keys.Up, Keys.Down, Player2);

            // Initialize the ball
            
            ball = new Ball(Ball, Ball.Left, Ball.Top);

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
            var height = this.Height;
            player1.Move(keyPressed);
            player2.Move(keyPressed);
        }

        private void UpdateScore_Tick(object sender, EventArgs e)
        {
            Scoreboard.Text = $"{player1.Score} | {player2.Score}";
        }

        private void BallMovement_Tick(object sender, EventArgs e)
        {
            ball.Move();
            ball.IsOutOfBounds(player1, player2);
            ball.OnCollision(player1, player2);
        }
    }
}
