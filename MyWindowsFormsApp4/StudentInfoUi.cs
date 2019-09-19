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
    public partial class StudentInfoUi : Form
    {
        
        List<int> ids = new List<int>();
        List<string> names = new List<string>();
        List<string> mobiles = new List<string>();
        List<int> ages = new List<int>();
        List<string> addresses = new List<string>();
        List<double> gpaPoints = new List<double>();

        public StudentInfoUi()
        {
            InitializeComponent();
        }
        
        private void addButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string name = nameTextBox.Text;
            string mobile = mobileTextBox.Text;
            string age = ageTextBox.Text;
            string address = addressTextBox.Text;
            string gpapoint = gpaTextBox.Text;

            if (id == "" || name == "" || mobile == "" || age == "" || address == "" || gpapoint == "")
            {
                MessageBox.Show("Fill up exitong fill");
            }
            if (id.Length != 4)
            {
                MessageBox.Show("4 digit recuired");
                return;
            }
            if (name.Length > 30)
            {
                MessageBox.Show("Max 30 digit");
                return;
            }
            if (mobile.Length != 11)
            {
                MessageBox.Show("Max 11 digit");
                return;
            }
            double gpapint = Convert.ToDouble(gpaTextBox.Text);
            if (gpapint < 0 || gpapint > 4)
            {
                MessageBox.Show("Enter GPA:");
                return;
            }
            else
            {
                ids.Add(Convert.ToInt32(id));
                names.Add(name);
                mobiles.Add(mobile);
                ages.Add(Convert.ToInt32(age));
                addresses.Add(address);
                gpaPoints.Add(Convert.ToInt32(gpapoint));

                int index = ids.Count() - 1;
                ResultShowAllInfo(index, index);

                // resultRichTextBox.Text = "ID: " + ids[] + "Name: " + names + "Mobile: " + ages + "Address: " + gpaPoints;
            }
             
        }
        private void ResultShowAllInfo(int startindex, int endindex)
        {
            resultRichTextBox.Text = "";
            for (int i = startindex; i <= endindex; i++)
            {
                resultRichTextBox.Text += "ID: " + ids[i] + ", "+ "Name: " + names[i] +", "+ "Mobile: " +mobiles[i]+", "+" Age: " +ages[i]+", " + "Address: "+addresses[i]+", "+"GPA point: " + gpaPoints[i]+"\n";
            }

           



        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            ResultShowAllInfo(0,ids.Count-1);

            //double gpaPointresult = Convert.ToDouble(gpaPointresultTextBoxGb.Text);

            double gpamax = gpaPoints.Max();
            int index = gpaPoints.IndexOf(gpamax);
            string name = names[index];
            maxMarksTextBox.Text = gpamax.ToString();
            nameForMaxmarkTextBox.Text = name.ToString();

            double gpamin = gpaPoints.Min();
            index = gpaPoints.IndexOf(gpamin);
            name = names[index];
            minMarksTextBox.Text = gpamin.ToString();
            nameForMarksTextBox.Text = name.ToString();

            double total = gpaPoints.Sum();
            double avg = total / gpaPoints.Count();
            avgMarksTextBox.Text = avg.ToString();
            totalMarksForTextBox.Text = total.ToString();
        }
    }
}
