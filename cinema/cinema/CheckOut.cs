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
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
            foreach (Button item in Form1.ReservedSeats)
            {
                SelectedSeats.Text += item.Text + " ,";
            }
        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {

            var result = "Salam, " + NameBox.Text + " " + SurnameBox.Text + ". Siz " + SelectedSeats.Text + " yerleri reserv etmisiniz ve odeyeceyiniz mebleg " + Form1.ReservedSeats.Count * 5 + " AZN-dir.Enjoy your life (bacarirsansa)";
            Netice.Text += result;
        }
    }
}
