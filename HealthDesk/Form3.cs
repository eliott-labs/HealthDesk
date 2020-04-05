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
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }




        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            string path = @"C:\Users\Eliott\source\repos\HealthDesk\HealthDesk\bin\Debug\Patients\" + metroTextBox4.Text + ".xlsx";
            Excel ex = new Excel();
            ex.CreateNewFile();
            ex.SaveAs(path);
            ex.Close();

            
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
            this.Hide();

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }
    }
}
