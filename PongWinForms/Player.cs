using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongWinForms
{
    class Player
    {
        // Player variables
        public int Score { get; private set; }

        // Controls
        Keys Up;
        Keys Down;

        // Player Sprite
        public PictureBox PlayerGraphics;

        public Player(Keys up, Keys down, PictureBox playerGraphics)
        {
            this.Up = up;
            this.Down = down;
            this.Score = 0;
            this.PlayerGraphics = playerGraphics;
        }

        public void Move(KeyEventArgs e)
        {
            if (e.KeyCode == Up)
            {
                // Move the player in an upwards direciton
                PlayerGraphics.Top += -13;

                //If the player were to move out of bounds, move the player to the edge of the screen.
                if (PlayerGraphics.Location.Y < 5)
                    PlayerGraphics.Top = 5;
            }

            else if (e.KeyCode == Down)
            {
                // Move the player in an upwards direciton
                PlayerGraphics.Top += 13;


                //If the player were to move out of bounds, move the player to the edge of the screen.
                if (PlayerGraphics.Location.Y > (Pong.ActiveForm.Size.Height - PlayerGraphics.Height))
                    PlayerGraphics.Top = (Pong.ActiveForm.Size.Height - PlayerGraphics.Height);
            }

        }

        public void HasScored()
        {
            Score++;
        }
    }
}
