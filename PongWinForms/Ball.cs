using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PongWinForms
{
    class Ball
    {
        private int Speed { get; set; }
        private bool GoingLeft { get; set; }
        private bool GoingUp { get; set; }
        private int DefaultX { get; set; }
        private int DefaultY { get; set; }
        private PictureBox BallGraphic { get; set; }

        public Ball(PictureBox ballGraphic, int x, int y)
        {
            this.BallGraphic = ballGraphic;
            this.DefaultX = x;
            this.DefaultY = y;
            Reset();
        }

        public void Reset()
        {
            // False means right, true means left
            GoingLeft = new Random().Next(0, 1) == 0 ? false : true;

            // False means down, true means up
            GoingUp = new Random().Next(0, 1) == 0 ? false : true;

            // Restore default location
            BallGraphic.Left = DefaultX;
            BallGraphic.Top = DefaultY;

            // Reset speed
            Speed = 1;
        }

        /// <summary>
        /// Doubles the speed of the instance of the Ball whenever called.
        /// </summary>
        public void UpdateSpeed()
        {
            Speed++;
        }

        /// <summary>
        /// Verifies if the instance is touching the outer bounds and changes the direction
        /// </summary>
        public void IsOutOfBounds(Player player1, Player player2)
        {
            // Change vertical direction when touching top or bottom bounds
            if (BallGraphic.Top <= 0 && GoingUp == true)
                GoingUp = false;
            if (BallGraphic.Top >= 432 && GoingUp == false)
                GoingUp = true;

            // Verify if a player 1 has scored
            if (BallGraphic.Left >= 768)
            {
                Reset();
                player1.HasScored();
            }

            // Verify if a player 2 has scored
            if (BallGraphic.Left <= 0)
            {
                Reset();
                player2.HasScored();
            }
        }

        /// <summary>
        /// Checks if the ball has collided with one of the players and changes
        /// the direction accordingly
        /// </summary>
        /// <param name="player1">Player 1 instance</param>
        /// <param name="player2">Player 2 instance</param>
        public void OnCollision(Player player1, Player player2)
        {
            if (BallGraphic.Bounds.IntersectsWith(player1.PlayerGraphics.Bounds))
            {
                GoingLeft = false;
                UpdateSpeed();
            }

            else if(BallGraphic.Bounds.IntersectsWith(player2.PlayerGraphics.Bounds))
            {
                GoingLeft = true;
                UpdateSpeed();
            }
        }

        public void Move()
        {
            if (GoingLeft == true && GoingUp == true)
            {
                BallGraphic.Left -= Speed;
                BallGraphic.Top -= Speed;
            }

            else if(GoingLeft == false && GoingUp == true)
            {
                BallGraphic.Left += Speed;
                BallGraphic.Top -= Speed;
            }

            else if (GoingLeft == false && GoingUp == false)
            {
                BallGraphic.Left += Speed;
                BallGraphic.Top += Speed;
            }

            else if (GoingLeft == true && GoingUp == false)
            {
                BallGraphic.Left -= Speed;
                BallGraphic.Top += Speed;
            }
        }
    }
}
