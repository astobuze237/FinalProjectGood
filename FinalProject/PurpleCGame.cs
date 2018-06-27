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
    public partial class PurpleCGame : UserControl
    {
        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown;

        //initial starting points for black rectangle

        int drawX = 0;
        int drawY = 0;

        //monster
        int monsterX = 200;
        int monsterY = 400;

        int monster2X = 300;
        int monster2Y = 200;

        int monsterSize = 20;

        List<int> monstersX = new List<int>();
        List<int> monstersY = new List<int>();

        SolidBrush characterBrush = new SolidBrush(Color.Purple);

        SolidBrush monsterBrush = new SolidBrush(Color.Black);

        public PurpleCGame()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rightArrowDown == true && drawX < Width)
            {
                drawX = drawX + 3;
            }
            else if (leftArrowDown == true && drawX > 0)
            {
                drawX = drawX - 3;
            }
            else if (upArrowDown == true && drawY > 0)
            {
                drawY = drawY - 3;
            }
            else if (downArrowDown == true && drawY < Height)
            {
                drawY = drawY + 5;
            }
            else if (drawX > Width - 21)
            {
                timer1.Enabled = false;
                Thread.Sleep(2000);

                Form f = this.FindForm();
                f.Controls.Remove(this);

                ExitScreen es = new ExitScreen();
                f.Controls.Add(es);

                return;
            }

            //monster mouvement

            if (drawX > monsterX)
            {
                monsterX++;
            }
            if (drawX < monsterX)
            {
                monsterX--;
            }
            if (drawY > monsterY)
            {
                monsterY++;
            }
            if (drawY < monsterY)
            {
                monsterY--;
            }

            //collisions checks and other processing

            Rectangle monsterRec = new Rectangle(monsterX, monsterY, 40, 40);

            Rectangle characterRec = new Rectangle(drawX, drawY, 40, 40);

            for (int i = 0; i < monstersX.Count; i++)
            {
                //   Rectangle monRec = new Rectangle(monstersX[i], monstersY[i], );
            }

            if (monsterRec.IntersectsWith(characterRec))
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.Beep);
                player.Play();

                timer1.Enabled = false;
                Thread.Sleep(2000);

                Form f = this.FindForm();
                f.Controls.Remove(this);

                ExitScreen es = new ExitScreen();
                f.Controls.Add(es);

                return;
            }

            Refresh();
        }

        private void PurpleCGame_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void PurpleCGame_KeyUp(object sender, KeyEventArgs e)
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

        private void PurpleCGame_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(characterBrush, drawX, drawY, 40, 40);

            e.Graphics.FillRectangle(monsterBrush, monsterX, monsterY, 40, 40);
        }
    }

}
