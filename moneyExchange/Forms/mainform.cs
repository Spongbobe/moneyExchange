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
        #region Declaring Variables
        string[] imgs = new string[] { "./images/wallpaperflare.com_wallpaper (1).jpg", "./images/wallpaperflare.com_wallpaper (2).jpg", "./images/wallpaperflare.com_wallpaper.jpg" };

        string[] _quotes = new string[] { "“It cost so much, caring. I didn't have any currency to spend on it.”", "“Banks do not create money for the public good. They are businesses owned by private shareholders. Their purpose is to make a profit.”", "“Higher prices are the symptom, not the cause, of currency collapse.”", "“Time is the currency you should care about. Money is less of a factor in how you spend your time than you currently have set your life up to believe.”" };
        
        #endregion

        #region Declaring Class
        SlideShow slideShow = new SlideShow();
        LoadingPercent loadingPercent = new LoadingPercent();
        Todolist toDoList = new Todolist();


        #endregion


        public mainform()
        {
            InitializeComponent();
            Social_links(guna2Panel1);

        }

        private void Social_links(Control containerOfLink)
        {
            void links()
            {
                var urls = new string[] { "https://www.facebook.com/", "https://twitter.com/", "https://www.instagram.com/", "https://www.youtube.com/" };


                facebook_link.Click += (obj, ae) => { System.Diagnostics.Process.Start(urls[0]); };
                twitter_link.Click += (obj, ae) => { System.Diagnostics.Process.Start(urls[1]); };
                instagram_link.Click += (obj, ae) => { System.Diagnostics.Process.Start(urls[2]); };
                youtube_link.Click += (obj, ae) => { System.Diagnostics.Process.Start(urls[3]); };
            }
            links();
        }

        private async void mainform_Load(object sender, EventArgs e)
        {
            await slideShow.ChangeImages(imgs,slideShowPcb,1);
            await slideShow.ChangeTime(currentDateTime);
            await slideShow.ChangeQuotes(quotes, _quotes);

            for (int i = 0; i < imgs.Length; i++)
            {
                Guna2GradientCircleButton btn = new Guna2GradientCircleButton();
                btn.Size = new Size(15, 15);
                btn.Cursor = Cursors.Hand;
                btn.Name =i.ToString();
               
                flowLayoutPanel1.Controls.Add(btn);

            }


            foreach (Control item in flowLayoutPanel1.Controls)
            {
                item.Click += (obj, ae) =>
                {
                    for (int i = 0; i < imgs.Length; i++)
                    {
                        if (item.Name == i.ToString())
                        {
                            slideShowPcb.Image = Image.FromFile(imgs[i]);
                        }
                    }
                };
            }

            itemTextbox.KeyPress += (obj, ae) =>
            {
                if(ae.KeyChar == (char)Keys.Enter)
                {
                    ae.Handled = true;
                    
                    if (itemTextbox.Text.Length > 0)
                    {
                        toDoList._Todolist(flowLayoutPanel2,itemTextbox.Text);
                    }
                    itemTextbox.Clear();

                }

            };

        }
        

    }
}
