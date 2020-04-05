using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthDesk;
using System.IO;

namespace HealthDesk
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            if (!Directory.Exists(@"C:\Windows\Temp\Equipment"))
            {
                Directory.CreateDirectory(@"C:\Windows\Temp\Equipment");
                File.Create(@"C:\Windows\Temp\Equipment\UsedBeds.txt");
                File.Create(@"C:\Windows\Temp\Equipment\Bed#.txt");
                File.Create(@"C:\Windows\Temp\Equipment\Vent#.txt");
                File.Create(@"C:\Windows\Temp\Equipment\UsedVents.txt");

            }
            if (!Directory.Exists(@"C:\Windows\Temp\Patient"))
            {
                Directory.CreateDirectory(@"C:\Windows\Temp\Patient");
                File.Create(@"C:\Windows\Temp\Patient\Start.xlsx");

            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();
            Form2 f2 = new Form2();
            f2.Show();
            

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }
    }
}
