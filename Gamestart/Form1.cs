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
using System.Media;
namespace Gamestart
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();


        }

        private void startButton_Click(object sender, EventArgs e)
        {

            //sound 
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.beep);
            SoundPlayer startsound = new SoundPlayer(Properties.Resources.start);
            SoundPlayer clicksound = new SoundPlayer(Properties.Resources.click);

            //button vanish 
            startButton.Visible = false;
            clicksound.Play();

            //Game countown
            countDown.Text = "Games Starting in 3";
            Thread.Sleep(1000);
            alertPlayer.Play();
            Refresh();

            countDown.Text = "Games Starting in 2";
            Thread.Sleep(1000);
            alertPlayer.Play();
            Refresh();

            countDown.Text = "Games Starting in 1";
            Thread.Sleep(1000);
            alertPlayer.Play();
            Refresh();

            countDown.Text = "";
            Thread.Sleep(1000);

            //go screen
            startsound.Play();
            this.BackColor = Color.Green;
            go.Visible = true;
            go.Text = "GO";

        }

    }
}
