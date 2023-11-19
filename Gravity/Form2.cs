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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DO YOU WANT TO EXIT?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void btnplay_Click(object sender, EventArgs e)
        {
           
            FormGame f1 = new FormGame();
            f1.ShowDialog();
            this.Hide();
            f1.Show();   // Show Form2
            
        }
    }
}
