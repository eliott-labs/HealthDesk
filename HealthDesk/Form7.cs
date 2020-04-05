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
    public partial class Form7 : MetroFramework.Forms.MetroForm
    {
        public Form7()
        {
            InitializeComponent();

            Updateit();

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        public void Updateit()
        {
            var listc = new List<string>();


            using (var file = new StreamReader(@"C:\Users\Eliott\source\repos\HealthDesk\HealthDesk\bin\Debug\Equipment\Bed#.txt")) //All bed#
            {
                var line = string.Empty;

                while ((line = file.ReadLine()) != null)
                {
                    listc.Add(line);

                }
            }

            var listd = new List<string>();
            using (var file2 = new StreamReader(@"C:\Users\Eliott\source\repos\HealthDesk\HealthDesk\bin\Debug\Equipment\UsedBeds.txt"))

            {
                var line2 = string.Empty;

                while ((line2 = file2.ReadLine()) != null)
                {
                    listd.Add(line2);
                }
            }



            IEnumerable<string> list3;
            list3 = listc.Except(listd);
            //MessageBox.Show((list3.));
            int num1 = listd.Count;
            int num2 = listc.Count;
            int num3 = list3.Count();

            foreach (string value in list3)
            {
                System.IO.File.AppendAllText(@"C:\Users\Eliott\source\repos\HealthDesk\HealthDesk\bin\Debug\Equipment\AvailableBeds.txt", value + Environment.NewLine);
                
            }
            string filetext = File.ReadAllText(@"C:\Users\Eliott\source\repos\HealthDesk\HealthDesk\bin\Debug\Equipment\AvailableBeds.txt");
            metroTextBox1.Text = filetext;
            metroLabel4.Text = Convert.ToString(num1);
            metroLabel6.Text = Convert.ToString(num3);
        }
    }
}
