using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryBooks;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            List<Book> myBooks = new List<Book>();
            myBooks.Add(new Book("THGTTG", "Adams.Douglas", "B.Wahlstöms", "9789176890035"));
            myBooks.Add(new Book("Främlingar", "Koontz.Dean.R", " Höganäs", " 9177521404"));
            myBooks.Add(new Book("DET", "King.Steven", "Albert Bonniers Förlag", "9789100174682"));

            foreach (var x in myBooks)
            {
                comboBox1.Items.Add(x.GetBookInfo());
                richTextBox1.AppendText(x.GetBookInfo());
            }
        }

        public void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var newBook = new Book(tbxAuthor.Text, tbxTitle.Text);
            
            comboBox1.Items.Add(newBook.GetBookInfo());
            richTextBox1.AppendText(newBook.GetBookInfo());
        }
    }
}
