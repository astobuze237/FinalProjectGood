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

namespace FinalProject
{
    public partial class ZooBear : UserControl
    {
        int x = 1000;
        int y = 650;

        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown;

        public ZooBear()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rightArrowDown == true && x < Width - 50)
            {
                x = x + 7;
            }
            else if (leftArrowDown == true && x > 0)
            {
                x = x - 7;
            }
            else if (upArrowDown == true && y > 500)
            {
                y = y - 7;
            }
            else if (downArrowDown == true && y < Height - 80)
            {
                y = y + 7;
            }
            else if (x<10)
            {
                timer1.Enabled = false;
                Thread.Sleep(1000);

                Form f = this.FindForm();
                f.Controls.Remove(this);

                ExitScreen es = new ExitScreen();
                f.Controls.Add(es);

                return;
            }

            //check for collisions
            Rectangle characterRec = new Rectangle(x, y, 80, 80);
            Rectangle ball1Rec = new Rectangle(198, 702, 52, 46);
            Rectangle ball2Rec = new Rectangle(506, 726, 50, 46);
            Rectangle ball3Rec = new Rectangle(836, 702, 50, 46);
            Rectangle ball4Rec = new Rectangle(350, 585, 52, 46);
            Rectangle ball5Rec = new Rectangle(668, 585, 52, 46);
            Rectangle ball6Rec = new Rectangle(198, 541, 52, 46);
            Rectangle ball7Rec = new Rectangle(1008, 541, 52, 46);
            Rectangle ball8Rec = new Rectangle(636, 794, 52, 46);


            if (characterRec.IntersectsWith(ball1Rec) || characterRec.IntersectsWith(ball2Rec) || characterRec.IntersectsWith(ball3Rec) || characterRec.IntersectsWith(ball4Rec) || characterRec.IntersectsWith(ball5Rec) || characterRec.IntersectsWith(ball6Rec) || characterRec.IntersectsWith(ball7Rec) || characterRec.IntersectsWith(ball8Rec))
            {
                timer1.Enabled = false;
                Thread.Sleep(1500);

                Form f = this.FindForm();
                f.Controls.Remove(this);

                ExitScreen es = new ExitScreen();
                f.Controls.Add(es);

                return;
            }

            Refresh();
        }


        private void ZooBear_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
            }
        }

        private void ZooBear_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
            }
        }

        private void ZooBear_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.CartoonBear, x, y, 80, 80);
        }
    }
}
