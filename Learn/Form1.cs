using System;
using System.Drawing;
using System.Windows.Forms;

namespace Learn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(10, 10);
        }
    }
}
