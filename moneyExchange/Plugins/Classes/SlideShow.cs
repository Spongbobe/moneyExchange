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
                        Random rn = new Random();
                        var val1 = rn.Next(0, imgs.Length);
                        pcb.Image = Image.FromFile(imgs[val1]);
                    };
                }
            });


        }
    }
}
