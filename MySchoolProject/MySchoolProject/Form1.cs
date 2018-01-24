using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchoolProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateSchoolList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                using (var db = new SchoolContext())
                {
                    School newSchool = new School { SchoolName = "YA Övik" };
                    School newSchool1 = new School { SchoolName = "Umeå universitet" };

                    db.Schools.Add(newSchool);
                    db.Schools.Add(newSchool1);

                    db.SaveChanges();

                }
            }
            catch (Exception a)
            {
                throw;
            }

            UpdateSchoolList();
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
