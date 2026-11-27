using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtRasul.Text;
            lblRasul.Text = name;
            string name1 = txtRasul1.Text;
            string name2 = txtRasul2.Text;
            lblRasul.Text = $"{name} {name1} {name2}";
        }
        private void txtRasul1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
