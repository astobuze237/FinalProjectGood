namespace FinalProject
{
    partial class StartScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.questionLabel = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.option4Button = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Verdana", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(104, 50);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(940, 165);
            this.questionLabel.TabIndex = 3;
            this.questionLabel.Text = "What is your reason for playing?";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option1Button
            // 
            this.option1Button.Font = new System.Drawing.Font("Verdana", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Button.Location = new System.Drawing.Point(402, 176);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(309, 101);
            this.option1Button.TabIndex = 4;
            this.option1Button.Text = "For fun";
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.Font = new System.Drawing.Font("Verdana", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Button.Location = new System.Drawing.Point(402, 283);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(309, 101);
            this.option2Button.TabIndex = 5;
            this.option2Button.Text = "Taking a break";
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.Font = new System.Drawing.Font("Verdana", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Button.Location = new System.Drawing.Point(402, 389);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(309, 101);
            this.option3Button.TabIndex = 6;
            this.option3Button.Text = "Stressed";
            this.option3Button.UseVisualStyleBackColor = true;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // option4Button
            // 
            this.option4Button.Font = new System.Drawing.Font("Verdana", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option4Button.Location = new System.Drawing.Point(402, 496);
            this.option4Button.Name = "option4Button";
            this.option4Button.Size = new System.Drawing.Size(309, 101);
            this.option4Button.TabIndex = 7;
            this.option4Button.Text = "Other";
            this.option4Button.UseVisualStyleBackColor = true;
            this.option4Button.Click += new System.EventHandler(this.option4Button_Click);
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(458, 432);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(224, 37);
            this.inputBox.TabIndex = 8;
            // 
            // enterButton
            // 
            this.enterButton.Font = new System.Drawing.Font("Verdana", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.Location = new System.Drawing.Point(478, 496);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(193, 65);
            this.enterButton.TabIndex = 10;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // optionsLabel
            // 
            this.optionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.optionsLabel.Font = new System.Drawing.Font("Verdana", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsLabel.Location = new System.Drawing.Point(248, 618);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(630, 172);
            this.optionsLabel.TabIndex = 11;
            this.optionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.option4Button);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.questionLabel);
            this.Name = "StartScreen";
            this.Size = new System.Drawing.Size(1148, 790);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Button option4Button;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label optionsLabel;
    }
}
