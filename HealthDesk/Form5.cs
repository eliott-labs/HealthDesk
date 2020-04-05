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
    public partial class Form5 : MetroFramework.Forms.MetroForm
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }
    }
}
