using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongWinForms
{
    public partial class Configuration : Form
    {

        KeysConverter kc = new KeysConverter();

        public Configuration()
        {
            InitializeComponent();
        }

        private void UpKey1_KeyDown(object sender, KeyEventArgs e)
        {
            UpKey1.Text = kc.ConvertToString(e.KeyValue);
        }

        private void UpKey2_KeyDown(object sender, KeyEventArgs e)
        {
            UpKey2.Text = kc.ConvertToString(e.KeyValue);
        }

        private void DownKey1_KeyDown(object sender, KeyEventArgs e)
        {
            DownKey1.Text = kc.ConvertToString(e.KeyValue);
        }

        private void DownKey2_KeyDown(object sender, KeyEventArgs e)
        {
            DownKey2.Text = kc.ConvertToString(e.KeyValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*foreach (TextBox. textbox in this.Controls)
            {
                if (string.IsNullOrEmpty(textbox.Text))
                {
                    MessageBox.Show("Controls can not be empty!", "Controls are empty!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }*/

            // Converting string to Forms.Keys
            KeysConverter kc = new KeysConverter();
            Enum.TryParse(UpKey1.Text, out Keys oneUp);
            Enum.TryParse(DownKey1.Text, out Keys oneDown);
            Enum.TryParse(UpKey2.Text, out Keys twoUp);
            Enum.TryParse(DownKey2.Text, out Keys twoDown);

            // Save settings
            Settings settings = new Settings((int)ScoreToWin.Value, oneUp, oneDown, twoUp, twoDown);

            // Start the game
            Pong game = new Pong(settings);
            game.Show();

            // Hide configuration form
            this.Hide();


        }
    }
}
