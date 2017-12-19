using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateListBxStaff();
        }

        public void PopulateListBxStaff()
        {
            using (var DBContext = new StaffContex())
            {
                var listOfStaff = DBContext.Employee;

                foreach (var itmen in listOfStaff)
                {
                    lstBxStaff.Items.Add(itmen.FirstName.PadRight(15) + itmen.LastName);
                    cmBxFirstName.Items.Add(itmen.FirstName);
                    cmBxLastName.Items.Add(itmen.LastName);
                }
            }
        }

        public void UpdateDBStaff ()
        {
            Employee updateEmployee;
            using (var DBStaffContext = new StaffContex())
            {

                updateEmployee = DBStaffContext.Employee.Where(x => x.Person_ID == lstBxStaff.SelectedIndex +1). FirstOrDefault<Employee>();

                if (updateEmployee != null)
                {
                    updateEmployee.Person_ID = (short)lstBxStaff.SelectedIndex;
                }

               

                // Mark entity as modified
                DBStaffContext.Entry(updateEmployee).State = EntityState.Modified;


                DBStaffContext.SaveChanges();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UpdateDBStaff();
            //Employee employee;
            //using (var DBStaffContext = new StaffContex())
            {
            //    employee = DBStaffContext.Employee.Where(s => s.FirstName == cmBxFirstName.SelectedItem.ToString()).FirstOrDefault<Employee>();
            //    if (employee != null)
            //    {
            //        employee.FirstName = cmBxFirstName.SelectedItem.ToString();
            //    }

            //    using (var newContext = new StaffContex())
            //    {
            //        newContext.Entry(employee).State = System.Data.Entity.EntityState.Deleted;

            //        newContext.SaveChanges();
            //    }

                //Employee newEmployee = new Employee();
                ////newEmployee.FirstName = "Oswald";
                ////newEmployee.LastName = "Cobblepot";

                //newEmployee.FirstName = cmBxFirstName.Text;
                //newEmployee.LastName = cmBxLastName.Text;

                //DBStaffContext.Employee.Add(newEmployee);
                //DBStaffContext.SaveChanges();
            }
            


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Employee employeeToDelete;
            using (var DBStaffContex = new StaffContex())
            {
                employeeToDelete = DBStaffContex.Employee.Where(s => s.FirstName == cmBxFirstName.SelectedItem.ToString()).FirstOrDefault<Employee>();
            }

           

        }

        private class DBStaffContex
        {
        }
    }

    
}

