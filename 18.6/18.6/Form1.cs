using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image s = papi1.Image;
            papi1.Image = papi2.Image;
            papi2.Image = papi3.Image;
            papi3.Image = papi4.Image;
            papi4.Image = papi5.Image;
            papi5.Image = papi6.Image;
            papi6.Image = papi7.Image;
            papi7.Image = papi8.Image;
            papi8.Image = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image s = papi8.Image;
            papi8.Image = papi7.Image;
            papi7.Image = papi6.Image;
            papi6.Image = papi5.Image;
            papi5.Image = papi4.Image;
            papi4.Image = papi3.Image;
            papi3.Image = papi2.Image;
            papi2.Image = papi1.Image;
            papi1.Image = s;
        }
    }
}
