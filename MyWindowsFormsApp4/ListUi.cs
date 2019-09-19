using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MyWindowsFormsApp4
{
    public partial class ListUi : Form
    {
        List<string> names = new List<string> { "Afsar" };
        List<string> ages = new List<string> { "28" };
        public ListUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //name.Add(nameTextBox.Text);
            //String message = ""; Afsar
            //for (int i = 0; i < name.Count(); i++)
            //{
            //    message += "Name: " + name[i] + "\n";

            //}

            // Code to metho area for create method 
            names.Add(nameTextBox.Text);
            //ages.Add(Convert.ToInt32(ageTextBox.Text));
            ShowCustomer();

        }

        private void ShowCustomer()  //Code from add button for call Method
        {
            String message = "";
            for (int i = 0; i < names.Count(); i++)
            {
                message += "Name: " + names[i] +""+ages+ "\n";

            }

            //String message = "";
            //foreach (var name in names)
            //{
            //    message += "Name: " + name +""+ages "\n ";
            //}
            MessageBox.Show(message);
        }

        private void showButton_Click(object sender, EventArgs e) // Method call
        {
            
            ShowCustomer();
        }

        private void AddCustomer(string name, int age)
        {
           names.Add(name);
           //ages.Add(age);
        }


    }
}
