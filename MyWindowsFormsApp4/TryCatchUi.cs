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
    public partial class TryCatchUi : Form
    {
        List<string> names = new List<string> { "Afsar" };
        List<string> ages = new List<string> { "28" };
        public TryCatchUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            String message = "";
            try
            {
                for (int i = 0; i < names.Count(); i++)
                {
                    message += "Name: " + names[i] + "" + ages + "\n";

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


            //String message = "";
            //foreach (var name in names)
            //{
            //    message += "Name: " + name +""+ages "\n ";
            //}
            //MessageBox.Show(message);
        }

        private void namelabel_Click(object sender, EventArgs e)
        {

        }
        
    }
}
