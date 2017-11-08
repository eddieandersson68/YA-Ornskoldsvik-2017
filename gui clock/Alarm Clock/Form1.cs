using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Form1
{
    public partial class Form1 : Form
    {
        private Clock c1;

        public Form1()
        {
            InitializeComponent();
            c1 = new Clock();
            c1.Timechanged += C1_Timechanged;
        }

        private void C1_Timechanged(object sender, TimeEventArgs e)
        {
            this.BeginInvoke(new Action(()=> label1.Text = string.Format("{0:D2}:{1:D2}", e.Hour, e.Minute)));
        }

        public void Form1_Load(object sender, EventArgs e)
        { 
           
            
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) )
            {
                int tempHour = int.Parse(textBox1.Text);
                int tempMinute = int.Parse(textBox2.Text);
                c1.SetTime(tempHour, tempMinute);
            }
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            c1.StartClock();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                int tempHour = int.Parse(textBox1.Text);
                int tempMinute = int.Parse(textBox2.Text);
                c1.SetTime(tempHour, tempMinute);
            }
        }

       
    }
}
