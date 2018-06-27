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
    public partial class MemoryGame : UserControl
    {
        bool pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8, pb9, pb10, pb11, pb12, pb13, pb14, pb15, pb16, pb17, pb18;
        int click = 1, firstCard;

//        if(pb1==true, pb2==true,pb3==true,pb4==true,pb5==true,pb6==true,pb7==true,pb8==true,pb9==true,pb10==true,pb11==true,pb12==true,pb13==true,pb14==true,pb15==true,pb16==true,pb17==true,pb18==true)
//            {
//             Form f = this.FindForm();
//        f.Controls.Remove(this);

//        ExitScreen es = new ExitScreen();
//        f.Controls.Add(es);
//}

        public MemoryGame()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            instructionsButton.Visible = false;
            titleLabel.Visible = false;
            label1.Visible = false;

            pictureBox1.BackgroundImage = Properties.Resources.PlayingCard;
            pictureBox2.BackgroundImage = Properties.Resources.PlayingCard;
            pictureBox3.BackgroundImage = Properties.Resources.PlayingCard;
            pictureBox4.BackgroundImage = Properties.Resources.PlayingCard;
            pictureBox5.BackgroundImage = Properties.Resources.PlayingCard;
            pictureBox6.BackgroundImage = Properties.Resources.PlayingCard;
            pictureBox7.BackgroundImage = Properties.Resources.PlayingCard;
            pictureBox8.BackgroundImage = Properties.Resources.PlayingCard;
            pictureBox9.BackgroundImage = Properties.Resources.PlayingCard;
            pictureBox10.BackgroundImage = Properties.Resources.PlayingCard;
            pictureBox11.BackgroundImage = Properties.Resources.PlayingCard;
            pictureBox12.BackgroundImage = Properties.Resources.PlayingCard;
            pictureBox13.BackgroundImage = Properties.Resources.PlayingCard;
            pictureBox14.BackgroundImage = Properties.Resources.PlayingCard;
            pictureBox15.BackgroundImage = Properties.Resources.PlayingCard;
            pictureBox16.BackgroundImage = Properties.Resources.PlayingCard;
            pictureBox17.BackgroundImage = Properties.Resources.PlayingCard;
            pictureBox18.BackgroundImage = Properties.Resources.PlayingCard;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BackgroundImage = Properties.Resources.BlueCircleCard;
            pb1 = true;
            pictureBox1.Refresh();
        

            if (click == 1)
            {
                firstCard = 1;
                click = 2;
              
            }
            else
            {
                if (pb3 == false)
                {
                    Thread.Sleep(2000);
                    pictureBox1.BackgroundImage = Properties.Resources.PlayingCard;
                    pictureBox1.Refresh();
                    pb1 = false;

                    deleteFirstCard(firstCard);
                }
                click = 1;
             
            }
    
        }

        private void instructionsButton_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BackgroundImage = Properties.Resources.PinkCard;
            pb2 = true;
            pictureBox2.Refresh();
            

            if (click == 1)
            {
                firstCard = 2;
                click = 2;
             
            }
            else
            {
               if (pb15 == false)
                {
                    Thread.Sleep(2000);
                    pictureBox2.BackgroundImage = Properties.Resources.PlayingCard;
                    pictureBox2.Refresh();
                    pb2 = false;

                    deleteFirstCard(firstCard);
                }
                click = 1;
            
            }

            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BackgroundImage = Properties.Resources.BlueCircleCard;
            pb3 = true;
            pictureBox3.Refresh();
     

            if (click == 1)
            {
                firstCard = 3;
                click = 2;
              
            }
            else
            {
                if (pb1 == false)
                {
                    Thread.Sleep(2000);
                    pictureBox3.BackgroundImage = Properties.Resources.PlayingCard;
                    pictureBox3.Refresh();
                    pb3 = false;

                    deleteFirstCard(firstCard);
                }
                click = 1;
              
            }

            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BackgroundImage = Properties.Resources.SymbolSquareCard;
            pb4 = true;
            pictureBox4.Refresh();
         

            if (click == 1)
            {
                firstCard = 4;
                click = 2;
                
            }
            else
            {
                if (pb12 == false)
                {
                    Thread.Sleep(2000);
                    pictureBox4.BackgroundImage = Properties.Resources.PlayingCard;
                    pictureBox4.Refresh();
                    pb4 = false;

                    deleteFirstCard(firstCard);
                }
                click = 1;
                
            }

           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.BackgroundImage = Properties.Resources.WaveCircleCard;
            pb5 = true;
            pictureBox5.Refresh();
          

            if (click == 1)
            {
                firstCard = 5;
                click = 2;
               
            }
            else
            {
                if (pb7 == false)
                {
                    Thread.Sleep(2000);
                    pictureBox5.BackgroundImage = Properties.Resources.PlayingCard;
                    pictureBox5.Refresh();
                    pb5 = false;

                    deleteFirstCard(firstCard);
                }
                click = 1;
             
            }

          
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.BackgroundImage = Properties.Resources.LineCircleCard;
            pb6 = true;
            pictureBox6.Refresh();
          

            if (click == 1)
            {
                firstCard = 6;
                click = 2;
                
            }
            else
            {
                if (pb14 == false)
                {
                    Thread.Sleep(2000);
                    pictureBox6.BackgroundImage = Properties.Resources.PlayingCard;
                    pictureBox6.Refresh();
                    pb6 = false;

                    deleteFirstCard(firstCard);
                }
                click = 1;
                
            }

            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.BackgroundImage = Properties.Resources.WaveCircleCard;
            pb7 = true;
            pictureBox7.Refresh();
         

            if (click == 1)
            {
                firstCard = 7;
                click = 2;
                
            }
            else
            {
                if (pb5 == false)
                {
                    Thread.Sleep(2000);
                    pictureBox7.BackgroundImage = Properties.Resources.PlayingCard;
                    pictureBox7.Refresh();
                    pb7 = false;

                    deleteFirstCard(firstCard);
                }
                click = 1;
              
            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.BackgroundImage = Properties.Resources.CatCard;
            pb8 = true;
            pictureBox8.Refresh();
            

            if (click == 1)
            {
                firstCard = 8;
                click = 2;
               
            }
            else
            {
                if (pb11 == false)
                {
                    Thread.Sleep(2000);
                    pictureBox8.BackgroundImage = Properties.Resources.PlayingCard;
                    pictureBox8.Refresh();
                    pb8 = false;

                    deleteFirstCard(firstCard);
                }
                click = 1;
                
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
           
            pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox9.BackgroundImage = Properties.Resources.BlackStarCard;
            pb9 = true;
            pictureBox9.Refresh();
         

            if (click == 1)
            {
                firstCard = 9;
                click = 2;
             
            }
            else
            {
                if (pb16 == false)
                {
                    Thread.Sleep(2000);
                    pictureBox9.BackgroundImage = Properties.Resources.PlayingCard;
                    pictureBox9.Refresh();
                    pb9 = false;

                    deleteFirstCard(firstCard);
                }
                click = 1;
                
            }

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            
            pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox10.BackgroundImage = Properties.Resources.DiamondCard;
            pb10 = true;
            pictureBox10.Refresh();


            if (click == 1)
            {
                firstCard = 10;
                click = 2;
           
            }
            else
            {
                if (pb18 == false)
                {
                    Thread.Sleep(2000);
                    pictureBox10.BackgroundImage = Properties.Resources.PlayingCard;
                    pictureBox10.Refresh();
                    
                    pb10 = false;

                    deleteFirstCard(firstCard);
                }
                click = 1;
          
            }

         
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            
            pictureBox11.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox11.BackgroundImage = Properties.Resources.CatCard;
            pb11 = true;
            pictureBox11.Refresh();
    

            if (click == 1)
            {
                firstCard = 11;
                click = 2;
          
            }
            else
            {
                if (pb8 == false)
                {
                    Thread.Sleep(2000);
                    pictureBox11.BackgroundImage = Properties.Resources.PlayingCard;
                    pictureBox11.Refresh();
                    pb11 = false;

                    deleteFirstCard(firstCard);
                }
                click = 1;
             
            }

           
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            
            pictureBox12.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox12.BackgroundImage = Properties.Resources.SymbolSquareCard;
            pb12 = true;
            pictureBox12.Refresh();
          

            if (click == 1)
            {
                firstCard = 12;
                click = 2;
               
            }
            else
            {
                if (pb4 == false)
                {
                    Thread.Sleep(2000);
                    pictureBox12.BackgroundImage = Properties.Resources.PlayingCard;
                    pictureBox12.Refresh();
                    pb12 = false;

                    deleteFirstCard(firstCard);
                }
                click = 1;
        
            }

          
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox13.BackgroundImage = Properties.Resources.StarCard;
            pb13 = true;
            pictureBox13.Refresh();

            if (click == 1)
            {
                firstCard = 13;
                click = 2;           
            }
            else
            {
                if (pb17 == false)
                {
                    Thread.Sleep(2000);
                    pictureBox13.BackgroundImage = Properties.Resources.PlayingCard;
                    pictureBox13.Refresh();
                    pb13 = false;

                    deleteFirstCard(firstCard);
                }
                click = 1;
             
            }

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            
            pictureBox14.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox14.BackgroundImage = Properties.Resources.LineCircleCard;
            pb14 = true;
            pictureBox14.Refresh();
       

            if (click == 1)
            {
                firstCard = 14;
                click = 2;
        
            }
            else
            {
                if (pb6 == false)
                {
                    Thread.Sleep(2000);
                    pictureBox14.BackgroundImage = Properties.Resources.PlayingCard;
                    pictureBox14.Refresh();
                    pb14 = false;

                    deleteFirstCard(firstCard);
                }
                click = 1;
                
            }

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            
            pictureBox15.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox15.BackgroundImage = Properties.Resources.PinkCard;
            pb15 = true;
            pictureBox15.Refresh();
            

            if (click == 1)
            {
                firstCard = 15;
                click = 2;
           
            }
            else
            {
               if (pb2 == false)
                {
                    Thread.Sleep(2000);
                    pictureBox15.BackgroundImage = Properties.Resources.PlayingCard;
                    pictureBox15.Refresh();
                    pb15 = false;

                    deleteFirstCard(firstCard);
                }
                click = 1;
                
            }

           
        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {
           
            pictureBox16.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox16.BackgroundImage = Properties.Resources.BlackStarCard;
            pb16 = true;
            pictureBox16.Refresh();
      

            if (click == 1)
            {
                firstCard = 16;
                click = 2;
           
            }
            else
            {
                if (pb16 == false)
                {
                    Thread.Sleep(2000);
                    pictureBox9.BackgroundImage = Properties.Resources.PlayingCard;
                    pictureBox9.Refresh();
                    pb16 = false;

                    deleteFirstCard(firstCard);
                }
                click = 1;
                
            }

         
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox17.BackgroundImage = Properties.Resources.StarCard;
            pb17 = true;
            pictureBox17.Refresh();
   

            if (click == 1)
            {              
                click = 2;
                firstCard = 17;

     
            }
            else
            {
             
               if (pb13 == false)
                {
                    Thread.Sleep(2000);
                    pictureBox17.BackgroundImage = Properties.Resources.PlayingCard;
                    pictureBox17.Refresh();

                    pb17 = false;

                    deleteFirstCard(firstCard);
                }
                click = 1;
              
            }

           
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox18.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox18.BackgroundImage = Properties.Resources.DiamondCard;
            pb18 = true;
            pictureBox18.Refresh();
            

            if (click == 1)
            {
                firstCard = 18;

                click = 2;
          
            }
            else
            {
            if (pb10 == false)
                {
                    Thread.Sleep(2000);
                    pictureBox18.BackgroundImage = Properties.Resources.PlayingCard;
                    pictureBox18.Refresh();

                    pb18 = false;

                    deleteFirstCard(firstCard);
                }
                click = 1;
              
            }

           
        }

        public void deleteFirstCard(int firstCard)
        {
           

            if (firstCard == 1)
            {
                pictureBox1.BackgroundImage = Properties.Resources.PlayingCard;
                pictureBox1.Refresh();
            }
            else if (firstCard == 2)
            {
                pictureBox2.BackgroundImage = Properties.Resources.PlayingCard;
                pictureBox2.Refresh();
            }
            else if (firstCard == 3)
            {
                pictureBox3.BackgroundImage = Properties.Resources.PlayingCard;
                pictureBox3.Refresh();
            }
            else if (firstCard == 4)
            {
                pictureBox4.BackgroundImage = Properties.Resources.PlayingCard;
                pictureBox4.Refresh();
            }
            else if (firstCard == 5)
            {
                pictureBox5.BackgroundImage = Properties.Resources.PlayingCard;
                pictureBox5.Refresh();
            }
            else if (firstCard == 6)
            {
                pictureBox6.BackgroundImage = Properties.Resources.PlayingCard;
                pictureBox6.Refresh();
            }
            else if (firstCard == 7)
            {
                pictureBox7.BackgroundImage = Properties.Resources.PlayingCard;
                pictureBox7.Refresh();
            }
            else if (firstCard == 8)
            {
                pictureBox8.BackgroundImage = Properties.Resources.PlayingCard;
                pictureBox8.Refresh();
            }
            else if (firstCard == 9)
            {
                pictureBox9.BackgroundImage = Properties.Resources.PlayingCard;
                pictureBox9.Refresh();
            }
            else if (firstCard == 10)
            {
                pictureBox10.BackgroundImage = Properties.Resources.PlayingCard;
                pictureBox10.Refresh();
            }
            else if (firstCard == 11)
            {
                pictureBox11.BackgroundImage = Properties.Resources.PlayingCard;
                pictureBox11.Refresh();
            }
            else if (firstCard == 12)
            {
                pictureBox12.BackgroundImage = Properties.Resources.PlayingCard;
                pictureBox12.Refresh();
            }
            else if (firstCard == 13)
            {
                pictureBox13.BackgroundImage = Properties.Resources.PlayingCard;
                pictureBox13.Refresh();
            }
            else if (firstCard == 14)
            {
                pictureBox14.BackgroundImage = Properties.Resources.PlayingCard;
                pictureBox14.Refresh();
            }
            else if (firstCard == 15)
            {
                pictureBox15.BackgroundImage = Properties.Resources.PlayingCard;
                pictureBox15.Refresh();
            }
            else if(firstCard == 16)
            {
                pictureBox16.BackgroundImage = Properties.Resources.PlayingCard;
                pictureBox16.Refresh();
            }
            else if(firstCard == 17)
            {
                pictureBox17.BackgroundImage = Properties.Resources.PlayingCard;
                pictureBox17.Refresh();
            }
            else if(firstCard == 18)
            {
                pictureBox18.BackgroundImage = Properties.Resources.PlayingCard;
                pictureBox18.Refresh();
            }
           
        }
    }
}
