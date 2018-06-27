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
    public partial class StartScreen : UserControl
    {

        public StartScreen()
        {
            InitializeComponent();

            //startButton.Visible = true;
            //instructionsButton.Visible = true;

            //option1Button.Visible = false;
            //option2Button.Visible = false;
            //option3Button.Visible = false;
            //option4Button.Visible = false;


            enterButton.Visible = false;
            inputBox.Visible = false;

            this.BackColor = Color.Azure;

            option1Button.Visible = true;
            option2Button.Visible = true;
            option3Button.Visible = true;
            option4Button.Visible = true;
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            option1Button.Visible = false;
            option2Button.Visible = false;
            option3Button.Visible = false;
            option4Button.Visible = false;

            questionLabel.Text = "Are you in an adventurous mood or a puzzle mood?";
            optionsLabel.Text = "Enter adventurous or puzzle above.";

            inputBox.Visible = true;
            enterButton.Visible = true;

            if (inputBox.Text == "adventurous")
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                InteractiveZoo iz = new InteractiveZoo();
                f.Controls.Add(iz);
            }
            else if (inputBox.Text == "puzzle")
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                MemoryGame mg = new MemoryGame();
                f.Controls.Add(mg);
            }
           
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            boost();          

        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            boost();

        }

        private void option4Button_Click(object sender, EventArgs e)
        {
            boost();
        }

        public void boost()
        {

            option1Button.Visible = false;
            option2Button.Visible = false;
            option3Button.Visible = false;
            option4Button.Visible = false;

            questionLabel.Visible = true;
            optionsLabel.Visible = true;

            questionLabel.Text = "What do you need a boost in?";
            optionsLabel.Text = "Please enter focus, calmness, happiness, or motivations above.";

            inputBox.Visible = true;
            enterButton.Visible = true;


        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string input = inputBox.Text;


            if (input == "happiness")
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                InteractiveZoo iz = new InteractiveZoo();
                f.Controls.Add(iz);
            }
            else if (input == "focus")
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                MemoryGame mg = new MemoryGame();
                f.Controls.Add(mg);
            }
            else if (input == "calmness")
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                Calmness c = new Calmness();
                f.Controls.Add(c);
            }
            else if (input == "motivation")
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                Motivation m = new Motivation();
                f.Controls.Add(m);
            }
            else if (input == "puzzle")
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                MemoryGame mg = new MemoryGame();
                f.Controls.Remove(this);
            }
            else if (input == "adventurous")
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                Motivation m = new Motivation();
                f.Controls.Add(m);
            }
            else
            {
                questionLabel.Text = "Please enter one of the words that were suggested";
            }
        }
    }
}
