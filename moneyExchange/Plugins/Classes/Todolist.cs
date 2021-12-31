using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace moneyExchange.Plugins.Classes
{
    public class Todolist
    {
        public void _Todolist(Control container,string msg)
        {
            
            Guna2Chip chip = new Guna2Chip();
            chip.Size = new System.Drawing.Size(400, 40);
            chip.BorderRadius = 2;
            chip.Text = msg;
            chip.ForeColor = Color.White;
            chip.FillColor = Color.Black;
            chip.BorderColor = Color.Black;
            chip.Font =new System.Drawing.Font("Segoe UI Semibold", 10F);
            
            container.Controls.Add(chip);
        }
    }
}
