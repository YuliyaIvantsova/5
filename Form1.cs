using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР6
{
    public partial class СМО : Form
    {
        public СМО()
        {
            InitializeComponent();
        }

        private void СМО_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSchet_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(textBox1.Text);
            double λ = Convert.ToDouble(textBox2.Text);
            double t = Convert.ToDouble(textBox3.Text);

            double μ = 1 / t;

            textBox4.Text = μ.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
