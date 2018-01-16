using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarGames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            this.back.Image = Properties.Resources.MapNight;
            //this.pnl.BackgroundImage = Properties.Resources.MapNight;
            this.front.Image = Properties.Resources.Logo;
            this.front.Size = this.front.Image.Size;
            HelperClass.BlendPictures(this.back, this.front);
            //var src = new Bitmap(Properties.Resources.Logo) ;
            //var src = new Bitmap(@"WarGames\assets.Logo.png");
            //var bmp = new Bitmap(100, 100, PixelFormat.Format32bppPArgb);
            //var gr = Graphics.FromImage(bmp);
            //{
            //    gr.Clear(Color.Blue);
            //    gr.DrawImage(src, new Rectangle(0, 0, bmp.Width, bmp.Height));
            //    bmp.Save("c:/temp/result.png", ImageFormat.Png);

            //}
        }
    }
}
