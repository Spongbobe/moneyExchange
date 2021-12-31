using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using moneyExchange.Plugins.Classes;

namespace moneyExchange.Forms
{
    public partial class mainform : Form
    {
        #region Declaring Class
        SlideShow slideShow = new SlideShow();
        LoadingPercent loadingPercent = new LoadingPercent();
        #endregion
        public mainform()
        {
            InitializeComponent();
            //Social_links(guna2Panel1);

        }

        private void Social_links(Control containerOfLink)
        {
            int c = 0;
            var urls = new string[] { "https://www.facebook.com/", "https://twitter.com/", "https://www.instagram.com/", "https://www.youtube.com/" };


            foreach (var item in containerOfLink.Controls)
            {
                var i = item as Control;
                i.Click += (ae, e) =>
                {

                };
            }


        }

        private async void mainform_Load(object sender, EventArgs e)
        {
            var imgs = new string[] { "./images/wallpaperflare.com_wallpaper (1).jpg", "./images/wallpaperflare.com_wallpaper (2).jpg", "./images/wallpaperflare.com_wallpaper.jpg" };


            await slideShow.ChangeImages(imgs,slideShowPcb,1);
           
        }

       
    }
}
