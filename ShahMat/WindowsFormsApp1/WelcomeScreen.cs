using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WelcomeScreen : Form
    {
        public int Leftpost = 0;
        public int Toppost = 0;
        public int BtnCount = 9;
        public int BtnNumber = 1;

        public WelcomeScreen()
        {
            InitializeComponent();
            for (int setir = 1; setir < BtnCount; setir++)
            {
                for (int Sutun = 1; Sutun < BtnCount; Sutun++)
                {
                    this.Width = 500;
                    this.Height = 500;
                    var clr1 = Color.DarkGray;
                    var clr2 = Color.White;
                    var btn = new Button();
                    btn.Width = 50;
                    btn.Height = 50;
                    btn.Top = Toppost;
                    btn.Left = Leftpost;
                    Leftpost += 50;
                    Controls.Add(btn);
                    BtnNumber++;

                    if (setir % 2 == 0)
                    {

                        if (Sutun % 2 == 0)
                        {
                            btn.BackColor = clr1;
                        }
                        else
                        {
                            btn.BackColor = clr2;
                        }
                    }
                    else
                    {
                        if (Sutun % 2 == 0)
                        {
                            btn.BackColor = clr2;
                        }
                        else
                        {
                            btn.BackColor = clr1;
                        }
                    }

                }
                Leftpost = 0;
                Toppost += 50;

            }
            
        }
    }
}
