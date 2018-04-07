using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema
{
    public partial class Afisha : Form
    {
        public Afisha()
        {
            InitializeComponent();
        }


        private void Seats()
        {
            var AfishaForm = new Form1();
            AfishaForm.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Seats();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            Seats();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seats();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Seats();

        }
    }
}
