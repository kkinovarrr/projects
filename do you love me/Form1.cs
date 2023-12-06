using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11111
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
       /* private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            button2.Left = r.Next(0, this.ClientSize.Width - button2.Width);
            button2.Top = r.Next(0, this.ClientSize.Height - button2.Height);
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Right choice.";
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(45, 50);
            button1.Visible = false; button2.Visible = false;
         }

        private void button2_MouseMove_1(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            button2.Left = r.Next(0, this.ClientSize.Width - button2.Width);
            button2.Top = r.Next(0, this.ClientSize.Height - button2.Height);
        }
    }
}
