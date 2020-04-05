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
    public partial class Form6 : MetroFramework.Forms.MetroForm
    {
        public Form6()
        {
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }
    }
}
