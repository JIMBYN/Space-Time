using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gravity   
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Hide();    // Hide Form1
            form2.Show();   // Show Form2
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
