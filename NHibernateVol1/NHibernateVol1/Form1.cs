using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHibernateVol1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerateSchema();
            UpdateListBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            Person p = new Person();
            p.FirstName = tbxFirstName.Text;
            p.LastName = tbxLastName.Text;

            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(p);
                transaction.Commit();
            }
            UpdateListBox();
        }


        public void GenerateSchema()
        {
            var schemaUpdate = new SchemaUpdate(NHibernateHelper.Configuration);
            schemaUpdate.Execute(Console.WriteLine, true);
        }
        
        private void UpdateListBox()
        {
            lstBxNames.Items.Clear();

            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())

            {
                //Criteria Queries
                //Query Over Queries
                //HQL
                //Linq2NHibernate
                //Native SQL

                var allPersonsFromDb = session.QueryOver<Person>().List();
                //var client = session.Get<Clients>(5);

                foreach (var p in allPersonsFromDb)
                {
                   lstBxNames.Items.Add(p.FirstName + " " + p.LastName);
                }
            }
        }
    }
}
