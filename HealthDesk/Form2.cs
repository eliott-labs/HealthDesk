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
using Microsoft.Office.Interop.Excel;
using x = Microsoft.Office.Interop.Excel;
using OfficeOpenXml.Core.ExcelPackage;

using _Excel = Microsoft.Office.Interop.Excel;


namespace HealthDesk
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            Form1 f1 = new Form1();
            f1.Close();

            InitializeComponent();
            this.MaximizeBox = false;
            //For Later
            //string filetext = File.ReadAllText(@"C:\Users\Eliott\source\repos\HealthDesk\HealthDesk\PatientList.txt");
            //metroTextBox2.Text = filetext;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
        
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string patientid2 = metroTextBox1.Text;


            Form4 f4 = new Form4(patientid2);
            f4.Show();
            this.Hide();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
