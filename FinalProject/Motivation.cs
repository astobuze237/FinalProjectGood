using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Motivation : UserControl
    {

        //initial starting points for black rectangle

        int drawX = 0;
        int drawY;

        

        public Motivation()
        {
            InitializeComponent();
            drawY = Width / 2 - 10;

            label1.Visible = false;

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            instructionsButton.Visible = false;

            pictureBox1.BackgroundImage = Properties.Resources.GreenCircle;
            pictureBox2.BackgroundImage = Properties.Resources.PurpleCircle;
            pictureBox3.BackgroundImage = Properties.Resources.BlueSquare;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Form f = this.FindForm();
            f.Controls.Remove(this);

            GreenGame gg = new GreenGame();
            f.Controls.Add(gg);

            gg.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Form f = this.FindForm();
            f.Controls.Remove(this);

            PurpleCGame pc = new PurpleCGame();
            f.Controls.Add(pc);

            pc.Focus();

        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            BlueGame bg = new BlueGame();
            f.Controls.Add(bg);

            bg.Focus();

        }

        private void instructionsButton_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }
    }
}
