using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDbTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //UpdateSchoolList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new SchoolContext())
                {
                    School newSchool = new School { SchoolName = "YA Övik:", Adress = "Hamngatan 2"};
                    School newSchool1 = new School { SchoolName = "Umeå universitet:", Adress = "Storgatan 4" };

                    db.Schools.Add(newSchool);
                    db.Schools.Add(newSchool1);

                    db.SaveChanges();

                    //const string format = "{0,-5}";
                    //string list = { school.Name }.PadRight(5);
                    foreach (var school in db.Schools)
                    {
                        //string line1 = string.Format(format,$" { school.SchoolName} { school.Adress}");
                        //lstBxSchools.Items.Add(line1);

                       lstBxSchools.Items.Add($"{school.SchoolName}  {school.Adress}");
                        //lstBxSchools.Items.Add($" {school.Adress}");


                    }
                }

                
            }
            catch (Exception a)
            {
                throw;
            }
            //UpdateSchoolList();
        }

        public void UpdateSchoolList()
        {

            try
            {
                using (var db = new SchoolContext())
                {
                    foreach (var school in db.Schools)
                    {
                        lstBxSchools.Items.Add(school.SchoolName);
                    }
                }
            }

            catch (Exception a)
            {
                throw;
            }
        }
        
    }
    
}

