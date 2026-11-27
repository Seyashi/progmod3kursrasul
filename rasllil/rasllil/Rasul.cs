using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rasllil
{
    public partial class Rasul : Form
    {
        public Rasul()
        {
            InitializeComponent();
        }

        private void формыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void кошкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 petya = new Form1();
            petya.Show();

        }

        private void собакиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 gayka  = new Form2();
            gayka.Show();
        }

        private void птицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 bolt = new Form3();
            bolt.Show();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
