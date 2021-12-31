using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moneyExchange.Plugins.Classes
{
    public class LoadingPercent
    {
        public void LoadBar(Control ctrl)
        {

            if(ctrl is Guna.UI2.WinForms.Guna2HScrollBar)
            {
                var item = ctrl as Guna.UI2.WinForms.Guna2HScrollBar;

                System.Timers.Timer timer = new System.Timers.Timer(200) { AutoReset = true };
                timer.Start();
                timer.Elapsed += (obj, ae) =>
                {
                    
                        item.LargeChange += 10;
                        if (item.LargeChange >= 100)
                        {
                            item.Value = 0;
                            item.LargeChange = 0;

                        }
                        // Show the current time in the form's title bar.
                    
                };
            }
            
        }
    }
}
