using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsFormsApp4
{
    public partial class TestData : Form
    {
        const int size = 10;
        int[] element = new int[size];
        int userSize=0;
        int index = 0;

        public TestData()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            
            
            int[] number = new int[10]; /*{ 12, 25, 20 };*/

            number[0] = 1;
            number[1] = 1;
            number[2] = 2;
            number[3] = 3;
            number[4] = 4; 
            number[5] = 5;
            number[6] = 6;
            number[7] = 7;
            number[8] = 8;
            number[9] = 9;

            string Message = "";
            for (int index = 0; index < 10; index++)
            {
                Message += "Name: " + " " + number[index] + "\n";
            }

            MessageBox.Show(Message);
        }

        private void showbutton2_Click(object sender, EventArgs e)
        {
            string messege = "";

            for(int i=0; i < userSize; i++)
            {
                messege += " " + element[i];
            }
                MessageBox.Show("Value: " + messege);
           
                 messege = "";
            for (int i = userSize-1; i >= 0; i--)
            {
                messege += " " + element[i];
            }
            MessageBox.Show("Value: " + messege);
        }

        private void sizebutton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(sizeTextBox.Text) <= size)
            {
                userSize = Convert.ToInt32(sizeTextBox.Text);
            }
            else
            {
                MessageBox.Show("Size is long:" + size);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (index < userSize)
            {
                element[index] = Convert.ToInt32(elementTextBox.Text);
                index++;
            }
            else
            {
                MessageBox.Show("element is full !");
            }
        }

        private void showButton_Click_1(object sender, EventArgs e)
        {

            string messege = "";

            for (int i = 0; i < userSize; i++)
            {
                messege += " " + element[i];
            }
            MessageBox.Show("Value: " + messege);
            
            int sum = 0;
            for (int i = 0; i < userSize; i++)
            {
                sum += element[i];
            }

            //messege = " ";

            //for (int i=0; i<userSize; i++)
            //{
            //    messege = Convert.ToString(element[i]+ element[i]);
            //}
            MessageBox.Show("Sum: "+ sum);
            
        }
    }
}
