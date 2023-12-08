using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GitMergeBranches0._8._12._23
{
    public partial class MainPage : ContentPage
    {
        private static int likes = 0;
        public MainPage()
        {
            InitializeComponent();
            label_likes.Text = likes.ToString();
        }

        public void LikeImage(object sender, EventArgs e)
        {
            likes++;
            label_likes.Text = likes.ToString();
        }

        public void DislikeImage(object sender, EventArgs e)
        {
            if (likes > 0)
            {
                likes--;
                label_likes.Text = likes.ToString();
            }
        }
    }
}
