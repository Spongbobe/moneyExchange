using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna;
using Guna.UI2.WinForms;

namespace moneyExchange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loading();

            Guna2TabControl tctrl =new Guna2TabControl();
        }
        private void loading()
        {
            System.Timers.Timer timer = new System.Timers.Timer(1000) { AutoReset =true};
            timer.Start();
            timer.Elapsed += (obj, ae) =>
            {
                guna2HScrollBar1.Value += 5;
            };

            guna2ComboBox1.Items.Add("Item1");
            guna2ComboBox1.Items.Add("Item2");
            guna2ComboBox1.Items.Add("Item3");

        }

        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox1.Checked)
            {
                guna2HtmlLabel1.Visible = false;
                guna2HtmlToolTip1.Active = true;
                guna2HtmlToolTip1.Show("hello", guna2CustomCheckBox1);

            }
            else
                guna2HtmlLabel1.Visible =true;

        }
    }
}
