using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthDesk
{
    public partial class Form4 : MetroFramework.Forms.MetroForm
    {
        public Form4(string patientid2p)
        {
            string patientl = patientid2p;
            string path = @"C:\Users\Eliott\source\repos\HealthDesk\HealthDesk\bin\Debug\Patients\" + patientl + ".xlsx";
            Excel excel = new Excel(path, 1);

            string First = excel.ReadCell(0, 1);
            string Last = excel.ReadCell(0, 2);
            string DOB = excel.ReadCell(0, 3);
            string symp = excel.ReadCell(0, 5);
            string status = excel.ReadCell(0, 6);
            string doctor = excel.ReadCell(0, 7);

            excel.Close();
            InitializeComponent();
            
            metroTextBox1.Text = First;
            metroTextBox2.Text = Last;
            metroTextBox3.Text = DOB;
            metroTextBox4.Text = patientid2p;
            metroComboBox1.Text = symp;
            metroComboBox2.Text = status;
            metroTextBox5.Text = doctor;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(metroTextBox4.Text);
            f5.Show();

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
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
            if (metroTextBox4.Text.Length < 1)
            {
                MessageBox.Show("Make sure everything is filled in");
            }
            if (metroTextBox5.Text.Length < 1)
            {
                MessageBox.Show("Make sure everything is filled in");
            }
            if (metroComboBox1.Text.Length < 1)
            {
                MessageBox.Show("Make sure everything is filled in");
            }
            if (metroComboBox2.Text.Length < 1)
            {
                MessageBox.Show("Make sure everything is filled in");
            }
            else
            {
                string path = @"C:\Users\Eliott\source\repos\HealthDesk\HealthDesk\bin\Debug\Patients\" + metroTextBox4.Text + ".xlsx";
                Excel excel = new Excel(path, 1);
                excel.WriteTocell(0, 1, metroTextBox1.Text);
                excel.WriteTocell(0, 2, metroTextBox2.Text);
                excel.WriteTocell(0, 3, metroTextBox3.Text);
                excel.WriteTocell(0, 4, metroTextBox4.Text);
                excel.WriteTocell(0, 5, metroComboBox1.Text);
                excel.WriteTocell(0, 6, metroComboBox2.Text);
                excel.WriteTocell(0, 7, metroTextBox5.Text);
                excel.Save();
                excel.Close();
            }
        }
    }
}
