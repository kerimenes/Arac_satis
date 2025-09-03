using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_araç_satış
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 anasyf = new Form2();
            anasyf.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
    
        }
    }
}
