using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HealthDesk
{
    public partial class Form5 : MetroFramework.Forms.MetroForm
    {
        public Form5(string patientID)
        {
            this.MaximizeBox = false;
            InitializeComponent();
            metroLabel4.Text = patientID;
            Updateequip();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e, string patientid)
        {
   


        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text.Length < 1)
            {
                MessageBox.Show("Make sure everything is filled in");
            }
            if (metroTextBox2.Text.Length < 1)
            {
                MessageBox.Show("Make sure everything is filled in");
            }
            if (metroTextBox3.Text.Length < 1)
            {
                MessageBox.Show("Make sure everything is filled in");
            }
            else
            {
                string path = @"C:\Users\Eliott\source\repos\HealthDesk\HealthDesk\bin\Debug\Patients\" + metroLabel4.Text + ".xlsx";
                Excel excel = new Excel(path, 1);
                excel.WriteTocell(0, 8, metroTextBox1.Text);
                excel.WriteTocell(0, 9, metroTextBox2.Text);
                excel.WriteTocell(0, 10, metroTextBox3.Text);
                excel.Save();
                excel.Close();

                //BEDS
                var listd = new List<string>();
                using (var file2 = new StreamReader(@"C:\Users\Eliott\source\repos\HealthDesk\HealthDesk\bin\Debug\Equipment\UsedBeds.txt"))

                {
                    var line2 = string.Empty;

                    while ((line2 = file2.ReadLine()) != null)
                    {
                        listd.Add(line2);
                    }
                }
                System.IO.File.AppendAllText(@"C:\Users\Eliott\source\repos\HealthDesk\HealthDesk\bin\Debug\Equipment\UsedBeds.txt", Environment.NewLine + metroTextBox1.Text + Environment.NewLine);

                //VENTS
                var liste = new List<string>();
                using (var file3 = new StreamReader(@"C:\Users\Eliott\source\repos\HealthDesk\HealthDesk\bin\Debug\Equipment\UsedVents.txt"))

                {
                    var line3 = string.Empty;

                    while ((line3 = file3.ReadLine()) != null)
                    {
                        liste.Add(line3);
                    }
                }

                Updateequip();
            }

        }

        public void Updateequip()
        {
            string path = @"C:\Users\Eliott\source\repos\HealthDesk\HealthDesk\bin\Debug\Patients\" + metroLabel4.Text + ".xlsx";
            Excel excel = new Excel(path, 1);
            metroTextBox1.Text = excel.ReadCell(0, 8);
            metroTextBox2.Text = excel.ReadCell(0, 9);
            metroTextBox3.Text = excel.ReadCell(0, 10);
            excel.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();

        }
    }
}
