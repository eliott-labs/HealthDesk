﻿using System;
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
    public partial class Form9 : MetroFramework.Forms.MetroForm
    {
        public Form9()
        {
            InitializeComponent();

            Updateit();

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Updateit();
        }

        public void Updateit()
        {
            var listc = new List<string>();


            using (var file = new StreamReader(@"C:\Windows\Temp\Equipment\Vent#.txt")) //All vent#
            {
                var line = string.Empty;

                while ((line = file.ReadLine()) != null)
                {
                    listc.Add(line);

                }
            }

            var listd = new List<string>();
            using (var file2 = new StreamReader(@"C:\Windows\Temp\Equipment\UsedVents.txt"))

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

            File.Delete(@"C:\Windows\Temp\Equipment\AvailableVents.txt");

            foreach (string value in list3)
            {
                System.IO.File.AppendAllText(@"C:\Windows\Temp\Equipment\AvailableVents.txt", value + Environment.NewLine);
                
            }
            string filetext = File.ReadAllText(@"C:\Windows\Temp\Equipment\AvailableVents.txt");
            metroTextBox1.Text = filetext;
            metroLabel4.Text = Convert.ToString(num1);
            metroLabel6.Text = Convert.ToString(num3);
        }
    }
}
