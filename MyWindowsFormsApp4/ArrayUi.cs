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
    public partial class ArrayUi : Form
    {
        public ArrayUi()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            const int size = 10;
            string[] name = new string[size];
            name[0]= "Afsar";
            name[1] = "Asraf";
            name[2] = "Ali";

            int[] age = new int[size]; /*{ 12, 25, 20 };*/

            age[0] = 20;
            age[1] = 25;
            age[2] = 28;

            string Message = "";
            for(int index=0; index<size; index++)
            {
                Message += "Name: "+" "+ name[index] +" "+ "Age: "+ " " + age[index]+"\n";
            }

            MessageBox.Show(Message);


        }
    }
}
