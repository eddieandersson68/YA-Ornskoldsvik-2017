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
                    foreach (var p in peopleList)
                    {
                        context.persons.Add(p);
                        context.SaveChanges();
                    }

                //var foundPeople = peopleList.Where(x => x.Age >= 20);
                var foundPeople = peopleList.Find(x => x.Firstname) Select (peopleList.Where (x => x.Age > 20  )));


                foreach (var i in foundPeople)
                    listBox1.Items.Add($"first name:{i.Firstname} Age: {i.Age}");
                //string foundPeople = peopleList.Find(x => x == persons).Firstname( Select persons).Age >= 20);



                //var ListOfPersons = from l in context.persons
                //                where l.Age >= 20
                //                select new
                //                {
                //                    personName = l.Firstname,
                //                    PersonAge = l.Age
                //                };
               


                //foreach (var i in ListOfPersons)
                //{
                //    listBox1.Items.Add(i);
                //}
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
                peopleList.Add(new Person("Berit", 35));
                peopleList.Add(new Person("Tilde", 2));
            }
        }
    }
}


