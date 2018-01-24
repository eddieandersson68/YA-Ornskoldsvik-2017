using System.Windows.Forms;
using System.Data.Entity;

namespace Övning11
{
    public partial class Form1 : Form
    {
        //PersonsDb p = new PersonsDb();
        public Form1()
        {
            InitializeComponent();
        }

        public void Update()
        {
            using (var context = new PersonsDb())
            {
                foreach (var s in context.persons)
                {
                    context.persons.Add(s);
                    context.SaveChanges();
                    listBox1.Items.Add(s);
                }
            }

        }

        public void Getpersons()
        {
            using (var context = new PersonsDb())
            {
                
                var personList = from e in context.persons
                                 where e.Age >= 20
                                 select new
                                 {
                                     PersonName = e.FirstName,
                                     PersonAge = e.Age
                                 };
                foreach(var n in personList)
                {
                    listBox1.Items.Add(n.Age);
                }
            }
        }
    }
}
