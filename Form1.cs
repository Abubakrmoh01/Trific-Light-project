using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trific_Light_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctrlTriaficLight1.Start();
        }

        private void ctrlTriaficLight1_GreenLightOff(object sender, ctrlTriaficLight.TraficLightEventArgs e)
        {

        }

        private void ctrlTriaficLight1_GreenLightOn(object sender, ctrlTriaficLight.TraficLightEventArgs e)
        {
            MessageBox.Show(e.CurrentLight.ToString());

        }

        private void ctrlTriaficLight1_OrangeLightOn(object sender, ctrlTriaficLight.TraficLightEventArgs e)
        {
            MessageBox.Show(e.CurrentLight.ToString());

        }

        private void ctrlTriaficLight1_RedLightOff(object sender, ctrlTriaficLight.TraficLightEventArgs e)
        {

        }

        private void ctrlTriaficLight1_RedLightOn(object sender, ctrlTriaficLight.TraficLightEventArgs e)
        {
            MessageBox.Show(e.CurrentLight.ToString());

        }
    }
}
