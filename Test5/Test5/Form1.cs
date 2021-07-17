using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //protected override void WndProc(ref Message message)
        //{
        //    const int WM_SYSCOMMAND = 0x0112;
        //    const int SC_MOVE = 0xF010;

        //    switch (message.Msg)
        //    {
        //        case WM_SYSCOMMAND:
        //            int command = message.WParam.ToInt32() & 0xfff0;
        //            if (command == SC_MOVE)
        //                return;
        //            break;
        //    }

        //    base.WndProc(ref message);
        //}
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        private int contador = 10;
        private void iniciartimer()
        {
            
            timer1.Interval = 1000;
            timer1.Enabled = true;

            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contador <= 0)
            {
                timer1.Enabled = false;
                
            }
            else
            {

                contador -= 1;
                lbltiempo.Text = "tienes " + contador.ToString();
                    
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                button1.Text = "Stop";
                button1.Enabled = false;
                iniciartimer();
                
            }
            else
            {
                button1.Text = "Start";
                timer1.Enabled = true;

            }
        }
    }
}
