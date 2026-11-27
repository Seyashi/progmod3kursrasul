using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RasulLibrary;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<IBook> books = new List<IBook>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var book = new Book
            {
                Title = txtBookTitle.Text,
                Author = txtAuthor.Text,
                ISBN = txtISBN.Text,
            };
            books.Add(book);
            UpdateBookList();
        }
        private void UpdateBookList()
        {
            lstBooks.Items.Clear();
            foreach (var book in books)
            {
                istBooks.Items.Add(book.Title);


            }
        }
        private void btnRemoveBook_click(object sender,EventArgs e)
        {
            if(lstBook.SelectedItem != null)
            {
                books.RemoveAt(lstBooks.SelectedIndex);
                UpdateBookList();
            }
        }
    }
}
