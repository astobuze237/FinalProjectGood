using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FinalProject
{
    public partial class InteractiveZoo : UserControl
    {
        public InteractiveZoo()
        {
            InitializeComponent();

            captionLabel.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            captionLabel.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;

            pictureBox1.BackgroundImage = Properties.Resources.CartoonBear;
            pictureBox2.BackgroundImage = Properties.Resources.cat;
            pictureBox3.BackgroundImage = Properties.Resources.CartoonLion;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.BearGrowl);
            player.Play();

            Form f = this.FindForm();
            f.Controls.Remove(this);

            ZooBear zb = new ZooBear();
            f.Controls.Add(zb);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.CatMeow);
            player.Play();

            Form f = this.FindForm();
            f.Controls.Remove(this);

            ZooCat zc = new ZooCat();
            f.Controls.Add(zc);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.LionRoar);
            player.Play();

            Form f = this.FindForm();
            f.Controls.Remove(this);

            ZooLion zl = new ZooLion();
            f.Controls.Add(zl);
        }

    }
}
