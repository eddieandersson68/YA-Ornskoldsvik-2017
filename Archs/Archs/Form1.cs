using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Archs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
                 
                
        }
      
        Thread th;
        Random rnd;

        private void Form1_Load(object sender, EventArgs e)
        {
           rnd = new Random();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.DrawArc(Pens.Red, 50, 50, 100, 100, 0, -180);
        }

        public void thread ()
        {
            for (int i = 0; i < 100; i++)
            {

                this.CreateGraphics().DrawArc(new Pen(Color.Red), 50, 50, 100, 100, 0, -180); rnd.Next(0, this.Width);  rnd.Next(0, this.Height 20,20;
                Thread.Sleep(50);
            }
            MessageBox.Show("done");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            th = new Thread(thread);
            th.Start();
        }
    }
}
