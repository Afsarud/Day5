namespace MyWindowsFormsApp4
{
    partial class TestData
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.practice1Button = new System.Windows.Forms.Button();
            this.showbutton2 = new System.Windows.Forms.Button();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.elementLabel = new System.Windows.Forms.Label();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.elementTextBox = new System.Windows.Forms.TextBox();
            this.sizebutton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // practice1Button
            // 
            this.practice1Button.Location = new System.Drawing.Point(670, 49);
            this.practice1Button.Name = "practice1Button";
            this.practice1Button.Size = new System.Drawing.Size(75, 23);
            this.practice1Button.TabIndex = 0;
            this.practice1Button.Text = "Practice1";
            this.practice1Button.UseVisualStyleBackColor = true;
            this.practice1Button.Click += new System.EventHandler(this.showButton_Click);
            // 
            // showbutton2
            // 
            this.showbutton2.Location = new System.Drawing.Point(670, 115);
            this.showbutton2.Name = "showbutton2";
            this.showbutton2.Size = new System.Drawing.Size(75, 23);
            this.showbutton2.TabIndex = 1;
            this.showbutton2.Text = "Practice2";
            this.showbutton2.UseVisualStyleBackColor = true;
            this.showbutton2.Click += new System.EventHandler(this.showbutton2_Click);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(149, 56);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(27, 13);
            this.sizeLabel.TabIndex = 2;
            this.sizeLabel.Text = "Size";
            // 
            // elementLabel
            // 
            this.elementLabel.AutoSize = true;
            this.elementLabel.Location = new System.Drawing.Point(131, 120);
            this.elementLabel.Name = "elementLabel";
            this.elementLabel.Size = new System.Drawing.Size(45, 13);
            this.elementLabel.TabIndex = 3;
            this.elementLabel.Text = "Element";
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(232, 56);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(122, 20);
            this.sizeTextBox.TabIndex = 4;
            // 
            // elementTextBox
            // 
            this.elementTextBox.Location = new System.Drawing.Point(232, 115);
            this.elementTextBox.Name = "elementTextBox";
            this.elementTextBox.Size = new System.Drawing.Size(122, 20);
            this.elementTextBox.TabIndex = 5;
            // 
            // sizebutton
            // 
            this.sizebutton.Location = new System.Drawing.Point(428, 54);
            this.sizebutton.Name = "sizebutton";
            this.sizebutton.Size = new System.Drawing.Size(75, 23);
            this.sizebutton.TabIndex = 6;
            this.sizebutton.Text = "Size";
            this.sizebutton.UseVisualStyleBackColor = true;
            this.sizebutton.Click += new System.EventHandler(this.sizebutton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(428, 115);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(670, 183);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 8;
            this.showButton.Text = "Practice3";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Practice4";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TestData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.sizebutton);
            this.Controls.Add(this.elementTextBox);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.elementLabel);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.showbutton2);
            this.Controls.Add(this.practice1Button);
            this.Name = "TestData";
            this.Text = "TestData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button practice1Button;
        private System.Windows.Forms.Button showbutton2;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label elementLabel;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox elementTextBox;
        private System.Windows.Forms.Button sizebutton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button button1;
    }
}