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
            Excel excel = new Excel(@"C:\Users\Eliott\source\repos\HealthDesk\HealthDesk\bin\Debug\Patients\123456789.xlsx", 1);

            string First = excel.ReadCell(0, 1);
            string Last = excel.ReadCell(0, 2);
            string DOB = excel.ReadCell(0, 3);
            string symp = excel.ReadCell(0, 5);
            string status = excel.ReadCell(0, 6);
            InitializeComponent();
            
            metroTextBox1.Text = First;
            metroTextBox2.Text = Last;
            metroTextBox3.Text = DOB;
            metroTextBox4.Text = patientid2p;
            metroComboBox1.Text = symp;
            metroComboBox2.Text = status;
        }


    }
}
