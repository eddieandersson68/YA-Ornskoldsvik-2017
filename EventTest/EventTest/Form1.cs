using System;
using System.Threading;
using System.Windows.Forms;

namespace EventTest
{
    public partial class Form1 : Form
    {
        //DelegateDemo d1;
        MyCheckTimeClass checker1;
        //MyCheckTimeClass checker2;
        private Label testLabel = new Label();
        string test = "hej";

        public Form1()
        {
            

            //System.Timers.Timer t1 = new System.Timers.Timer();
            //t1.Interval = 1000;
            //t1.Elapsed += T1_Elapsed;
            //t1.Start();

            //System.Timers.Timer t2 = new System.Timers.Timer();
            //t2.Interval = 1000;
            //t2.Elapsed += T2_Elapsed;
            //t2.Start();
            InitializeComponent();

            





            //Demo 2 Event & Thread
            checker1 = new MyCheckTimeClass();
            checker1.Every10SecEvent += Every10SecOccured;

            //dateTime test
            //checker2 = new MyCheckTimeClass();
            //checker1.Every10SecEvent += EverySecOccured;

            Thread t1 = new Thread(new ThreadStart(checker1.Start));
            t1.Start();


           // New thread start
           //Thread t2 = new Thread(new ThreadStart(checker1.TimeStart));
           // t2.Start();



        }

        //private void T1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        //{
        //    if (InvokeRequired)
        //    {
        //        Invoke(new MethodInvoker(ChangeLabel));
        //    }

        //}


        //private void T2_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        //{
        //    if (InvokeRequired)
        //    {
        //        Invoke(new MethodInvoker(ChangeLabe2));
        //    }


        //}


        private void Every10SecOccured(object sender, EventArgs e)
        {
            ChangeLabel();

            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(ChangeLabel));
            }
            else
                ChangeLabel();
        }

        //private void EverySecOccured(object sender, EventArgs e)
        //{
        //    //ChangeLabe2();

        //    if (InvokeRequired)
        //    {
        //        Invoke(new MethodInvoker(ChangeLabe2));
        //    }
        //    else
        //        ChangeLabe2();
        //}

        

        private void ChangeLabel()
        {


            label1.Text = DateTime.Now.ToString();

            string textToShow = "10 sec has passed -->" + DateTime.Now.Second;
            testLabel.Text = (textToShow + checker1.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            testLabel.Text = test;
            testLabel.Location = new System.Drawing.Point(25, 25);
            testLabel.BorderStyle = BorderStyle.FixedSingle;
            testLabel.Visible = true;
            testLabel.AutoSize = true;
            Controls.Add(testLabel);

        }

        //private void ChangeLabe2()
        //{
        //    label2.Text = DateTime.Now.ToString();
        //}


    }

   
    
}



