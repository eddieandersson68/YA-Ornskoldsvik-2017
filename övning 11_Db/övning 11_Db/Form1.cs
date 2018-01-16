using System;
using System.Windows.Forms;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace övning_11_Db
{
    public partial class Form1 : Form
    {
        List<Person> peopleList = new List<Person>();
        Person p;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPeople();

            using (var context = new peopleDb())
            {
                    //var p = new Person();
                    //p.Firstname = "Kalle"; p.Age = 5;
                    //p.Firstname = "Saga"; p.Age = 53;
                    //p.Firstname = "Sven"; p.Age = 45;
                    //p.Firstname = "Karin"; p.Age = 23;
                    //p.Firstname = "Molly"; p.Age = 12;

                    foreach (var p in peopleList)
                    {
                        context.persons.Add(p);
                        context.SaveChanges();

                    }
                    var ListOfPersons = from l in context.persons
                                    where l.Age <= 20
                                    select new
                                    {
                                        personName = l.Firstname,
                                        PersonAge = l.Age
                                    };


                foreach (var i in ListOfPersons)
                {
                    listBox1.Items.Add(i.ToString());
                }
            }
        }
        public void AddPeople()
        {
            {
                peopleList.Add (new Person("Kalle", 5));
                peopleList.Add(new Person("Saga", 53));
                peopleList.Add(new Person("Sven", 45));
                peopleList.Add(new Person("Karin", 23));
                peopleList.Add(new Person("Molly", 12));
            }
        }
    }
}


