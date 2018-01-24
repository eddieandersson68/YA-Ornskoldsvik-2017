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
            using (var DBContext = new StaffContext())
            {
                var listOfStaff = DBContext.Employee;

                foreach (var itmen in listOfStaff)
                {
                    lstBxStaff.Items.Add(itmen.FirstName + itmen.LastName);
                    //cmBxFirstName.Items.Add(itmen.FirstName);
                    //cmBxLastName.Items.Add(itmen.LastName);
                }
            }
        }

        public void UpdateDBStaff()
        {
            Employee updateEmployee;
            using (var DBStaffContext = new StaffContext())
            {
                updateEmployee = DBStaffContext.Employee.Where(x => x.Person_ID == lstBxStaff.SelectedIndex).First();

                if (updateEmployee != null)
                {
                    updateEmployee.FirstName = txBxFirstName.Text;
                    updateEmployee.LastName = txBxLastName.Text;
                }

                // Save modifuíed entity as new context 
                using (var newContext = new StaffContext())
                {
                    // Mark entity as modified
                    newContext.Entry(updateEmployee).State = EntityState.Modified;
                    //newContext.Entry(updateEmployee).State = System.Data.Entity.EntityState.Deleted;

                    // Call savechanges
                    newContext.SaveChanges();
                }

                //using (var dbContext = new WorkContext())
                //{

                //    var updateStudent = dbContext.Students.Where(x => x.Id == 3).First();


                //    updateStudent.FirstName = "NewJohn";

                //    // Mark entity as modified
                //    dbContext.Entry(updateStudent).State = EntityState.Modified;


                //    dbContext.SaveChanges();
                //}






                // DBStaffContext.SaveChanges();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (var dbContext = new StaffContext())
            {
                Employee newEmployee = new Employee();
                newEmployee.FirstName = txBxFirstName.Text;
                newEmployee.LastName = txBxLastName.Text;

                dbContext.Employee.Add(newEmployee);
                dbContext.SaveChanges();
            }

            lstBxStaff.Items.Clear();
            PopulateListBxStaff();

            //UpdateDBStaff();
            //Employee employee;
            //using (var DBStaffContext = new StaffContex())
            //{
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
            //}

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstBxStaff.SelectedItem == null)
                return;

            var employeeIdToDelete = ((Employee)lstBxStaff.SelectedItem).Person_ID;

            
            using (var DBStaffRemoveContex = new StaffContext())
            {
                var employeeToDelete = DBStaffRemoveContex.Employee.Where(s => s.Person_ID == employeeIdToDelete).First();
                DBStaffRemoveContex.Employee.Remove(employeeToDelete);
                DBStaffRemoveContex.SaveChanges();
            }
        }


        private void lsBxStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBxStaff.SelectedItem == null)
                return;

            var currenEmployee = (Employee)lstBxStaff.SelectedItem;
            txBxFirstName.Text = currenEmployee.FirstName;
            txBxLastName.Text = currenEmployee.LastName;
            labelId.Text = currenEmployee.Person_ID.ToString();
        }

        private class DBStaffContex
        {
        }

        private void btnUpdateDBStaff_Click(object sender, EventArgs e)
        {
            UpdateDBStaff();
        }
    }


}

