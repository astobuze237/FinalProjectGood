using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace FinalProject
{
    public partial class Calmness : UserControl
    {
        int circleSize = 0;
        int pixelGrowth = 1;

        Boolean startAnimation = false;

        public Calmness()
        {
            InitializeComponent();

            instructionsLabel.Visible = false;
            textLabel.Visible = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int x = Width / 2 - 25;
            int y = Height / 2 - 25;

            startButton.Visible = false;
            instructionsButton.Visible = false;
            instructionsLabel.Visible = false;

            SoundPlayer player = new SoundPlayer(Properties.Resources.Ocean);
            player.Play();

            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.Blue);

            textLabel.Visible = true;
            textLabel.Text = "Breathe in";
            textLabel.Refresh();

            for (int i = 0; i < 4; i++)
            {


                while (pixelGrowth < 155)
                {

                    g.FillEllipse(drawBrush, x - pixelGrowth / 2, y - pixelGrowth / 2, circleSize + pixelGrowth, circleSize + pixelGrowth);
                    Thread.Sleep(15);
                    pixelGrowth++;

                }

                textLabel.Text = "Hold";
                textLabel.Refresh();
                Thread.Sleep(2000);

                textLabel.Text = "Breathe out";
                textLabel.Refresh();


                while (pixelGrowth > 0)
                {

                    g.Clear(Color.LemonChiffon);
                    g.FillEllipse(drawBrush, x - pixelGrowth / 2, y - pixelGrowth / 2, circleSize + pixelGrowth, circleSize + pixelGrowth);
                    Thread.Sleep(20);
                    pixelGrowth--;

                }
            }
            player.Stop();
        }

        private void instructionsButton_Click(object sender, EventArgs e)
        {
            instructionsLabel.Visible = true;
        }


    }
}
