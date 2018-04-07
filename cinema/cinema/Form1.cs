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
    public partial class Form1 : Form
    {
        public int RowCount = 5;
        public int ColumCount = 7;
        public int LeftPos = 0;
        public int TopPos = 0;
        public int SeatNumber = 1;
        public TextBox Result = new TextBox();
        public Button ReservBtn = new Button();
        public static List<Button> ReservedSeats = new List<Button>();


        public Form1()
        {
            InitializeComponent();

            for (int row = 0; row < RowCount; row++)
            {

                for (int column = 0; column < ColumCount; column++)
                {
                    var seat = new Button();
                    seat.Width = 50;
                    seat.Height = 50;
                    seat.Left = LeftPos;
                    seat.Top = TopPos;
                    seat.Text = SeatNumber.ToString();
                    SeatNumber++;
                    Controls.Add(seat);
                    seat.Click += new EventHandler(SelectSeats);
                    LeftPos += 50;
                }
                LeftPos = 0;
                TopPos += 50;
            }
            this.Width = ColumCount * 50 + 17;
            this.Height = RowCount * 50 + 100;
            ReservBtn.Text = "Reserve";
            ReservBtn.AutoSize = true;
            ReservBtn.Click += new EventHandler(ReserveSeats);
            Controls.Add(ReservBtn);
            ReservBtn.Top = this.Height - ReservBtn.Height - 50;
            ReservBtn.Left = this.Width - ReservBtn.Width - 300;


        }
        public void SelectSeats(object obj, EventArgs e)
        {
            var btn = obj as Button;
            btn.BackColor = Color.Gray;
            ReservedSeats.Add(btn);


        }
        public void ReserveSeats(object obj, EventArgs e)
        {
            foreach (Button item in ReservedSeats)
            {
                item.Enabled = false;
            }
            var checkOutForm = new CheckOut();
            checkOutForm.Show();


        }
    }
}
