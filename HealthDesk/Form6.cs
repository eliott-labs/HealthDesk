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
            InitializeComponent();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();

        }
    }
}
