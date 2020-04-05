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

namespace HealthDesk
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
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
