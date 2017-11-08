using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace PersonRegistry
{
    public partial class Form1 : Form
    {
        TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
        HelperMethods h = new HelperMethods();

        private static List<Person> ListOfPersons = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  Events to check if what's typed into textboxes is characters and not number, but still allow to use backspace
        /// </summary>

        private void tbxFirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar)
            || e.KeyChar == (char)Keys.Space 
            || e.KeyChar == (char)Keys.Back);
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            lsBxPersons.Items.Clear();
            PersonToSearchFor(tbxSearch.Text.ToLower());
            
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (!rdbMale.Checked && !rdbFemale.Checked)
                return;

            Person p;

            if (rdbMale.Checked)
            {
                p = new Male("Mr", tbxFirstname.Text.ToLower(), tbxLastname.Text.ToLower());
            }

            else
            {
                p = new Female("Miss", tbxFirstname.Text.ToLower(), tbxLastname.Text.ToLower());
            }
            //if (ListOfPersons != null)
            ListOfPersons.Add(p);

            if (tbxFirstname.Text != "" || tbxLastname.Text != "")
                lsBxPersons.Items.Add(p);

            tbxFirstname.Clear();
            tbxLastname.Clear();
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            //ListOfPersons = ListOfPersons.OrderBy(x => x.GetLastName()).ThenBy(x => x.GetFirstName().ToString()).ToList();
            lsBxPersons.Items.Clear();
            ListOfPersons.Sort();
            PrintListOfPersons();
        }
        /// <summary>
        /// Code to merge two parents to make children
        /// </summary>
        private void btnMerge_Click(object sender, EventArgs e)
        {
            if (lsBxPersons.SelectedIndices == null)
                return;
            if (lsBxPersons.SelectedIndices.Count == 2)
            {
                var indexNr = lsBxPersons.SelectedIndices;
                if (ListOfPersons[indexNr[0]] is Male && ListOfPersons[indexNr[1]] is Female)
                {
                    var child = (ListOfPersons[indexNr[1]] + ListOfPersons[indexNr[0]]);
                    ListOfPersons.Add(child);
                }
                else if (ListOfPersons[indexNr[0]] is Female && ListOfPersons[indexNr[1]] is Male)
                {
                    var child = (ListOfPersons[indexNr[0]] + ListOfPersons[indexNr[1]]);
                    ListOfPersons.Add(child);
                }
            }

            if (lsBxPersons.SelectedIndices.Count > 2)
            {
                MessageBox.Show("Hey!!\nYou have selected more than two people from the list." +
                                "\nPlease select only two");
            }

            #region Checking for same sex etc
            /// Checking for same sex selections and showing message about it.

            var indexOfWrongKind = lsBxPersons.SelectedIndices;

            if (lsBxPersons.SelectedIndices.Count == 2 &&
                ListOfPersons[indexOfWrongKind[0]] is Male && ListOfPersons[indexOfWrongKind[1]] is Male)
            {
                h.SameSex();
            }
            if (lsBxPersons.SelectedIndices.Count == 2 &&
                ListOfPersons[indexOfWrongKind[0]] is Female && ListOfPersons[indexOfWrongKind[1]] is Female)
            {
                h.SameSex();
            }
            if (lsBxPersons.SelectedIndices.Count == 2 &&
                ListOfPersons[indexOfWrongKind[0]] is Male && ListOfPersons[indexOfWrongKind[1]] is Child)
            {
                h.Immoral();
            }
            if (lsBxPersons.SelectedIndices.Count == 2 &&
                ListOfPersons[indexOfWrongKind[0]] is Female && ListOfPersons[indexOfWrongKind[1]] is Child)
            {
                h.Immoral();
            }

            if (lsBxPersons.SelectedIndices.Count == 2 &&
               ListOfPersons[indexOfWrongKind[0]] is Child && ListOfPersons[indexOfWrongKind[1]] is Male)
            {
                h.Immoral();
            }

            if (lsBxPersons.SelectedIndices.Count == 2 &&
               ListOfPersons[indexOfWrongKind[0]] is Child && ListOfPersons[indexOfWrongKind[1]] is Female)
            {
                h.Immoral();
            }
            #endregion

            lsBxPersons.Items.Clear();
            PrintListOfPersons();
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int indexNr;

            if (lsBxPersons.SelectedIndex == -1)
            {
                indexNr = lsBxPersons.SelectedIndex - 1;
            }
            else
            {
                indexNr = lsBxPersons.SelectedIndex;
                lsBxPersons.Items.Clear();
                ListOfPersons.RemoveAt(indexNr);
                PrintListOfPersons();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lsBxPersons.Items.Clear();
            ListOfPersons.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void PrintListOfPersons()
        {
            //TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

            foreach (var i in ListOfPersons)
            {
                lsBxPersons.Items.Add(i.GetPerson());
            }
        }

        public void PersonToSearchFor(string searchstring)
        {
            var quaryperson = from o in ListOfPersons
                              where o.GetLastName().StartsWith(searchstring)
                              || o.GetFirstName().StartsWith(searchstring)
                              //|| o.GetPrefix().StartsWith(searchstring)
                              orderby o.ToString()
                              select o;

            foreach (var item in quaryperson)
            {
                lsBxPersons.Items.Add(item.ToString());
            }
        }
    }
}