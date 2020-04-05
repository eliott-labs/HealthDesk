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
            string path = @"C:\Users\Eliott\source\repos\HealthDesk\HealthDesk\bin\Debug\Patients\" + metroLabel4.Text + ".xlsx";
            Excel excel = new Excel(path, 1);
            excel.WriteTocell(0, 8, metroTextBox1.Text);
            excel.WriteTocell(0, 9, metroTextBox2.Text);
            excel.WriteTocell(0, 10, metroTextBox3.Text);
            excel.Save();
            excel.Close();

            var listd = new List<string>();
            using (var file2 = new StreamReader(@"C:\Users\Eliott\source\repos\HealthDesk\HealthDesk\bin\Debug\Equipment\UsedBeds.txt"))

            {
                var line2 = string.Empty;

                while ((line2 = file2.ReadLine()) != null)
                {
                    listd.Add(line2);
                }
            }

            //File.Delete(@"C:\Users\Eliott\source\repos\HealthDesk\HealthDesk\bin\Debug\Equipment\UsedBeds.txt");

            //foreach (string value in listd)
            //{
            //    System.IO.File.AppendAllText(@"C:\Users\Eliott\source\repos\HealthDesk\HealthDesk\bin\Debug\Equipment\AvailableBeds.txt", value + Environment.NewLine);

            //}

            System.IO.File.AppendAllText(@"C:\Users\Eliott\source\repos\HealthDesk\HealthDesk\bin\Debug\Equipment\UsedBeds.txt", Environment.NewLine + metroTextBox1.Text + Environment.NewLine);

            //Updateequip();

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
    }
}
