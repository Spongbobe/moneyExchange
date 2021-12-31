using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moneyExchange.Plugins.Classes
{
    public class SlideShow
    {
        public async Task ChangeImages(string[] imgs, Control picturebox, int delayInSecond)
        {
            await Task.Run(() =>
            {
                var time = new System.Timers.Timer(delayInSecond*1000) { AutoReset = true };
                time.Start();

                if (picturebox is PictureBox)
                {
                    var pcb = (PictureBox)picturebox;
                    time.Elapsed += (ae, e) =>
                    {
                        var rand = new Random();
                        var val1 = rand.Next(0, imgs.Length);
                        pcb.Image = Image.FromFile(imgs[val1]);
                    };
                }
            });


        }
        public async Task ChangeTime(Control lbl)
        {
            await Task.Run(() =>
            {
                var time = new System.Timers.Timer(1000) { AutoReset = true };
                time.Start();
                time.Elapsed += (obj, ae) =>
                {
                    lbl.Text = DateTime.Now.ToString();
                };
            });
            
        }

        public async Task ChangeQuotes(Control lbl,string[] msg)
        {
            await Task.Run(() =>
            {
               
                var time = new System.Timers.Timer(5000) { AutoReset = true };
                time.Start();
                time.Elapsed += (obj, ae) =>
                {
                    Random rn = new Random();
                   


                    int val = rn.Next(0, msg.Length);
                    lbl.Text = msg[val];
                };
            });
        }
    }
}
