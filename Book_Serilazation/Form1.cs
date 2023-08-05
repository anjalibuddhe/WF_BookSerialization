using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
//SOAP
using System.Runtime.Serialization.Formatters.Soap;
//JSON
using System.Text.Json;
using System.IO;

namespace Book_Serilazation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4\Book.dat";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryFormatter formatter = new BinaryFormatter();
                Book book = new Book();
                book.Id = Convert.ToInt32(BId.Text);
                book.Name = Book_name.Text;
                book.Author = Author_name.Text;
                book.Price = Convert.ToInt32(Price_Book.Text);
                formatter.Serialize(fileStream, book);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4\Book.dat";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                Book book = new Book();
                // we done explicit type casting from Object --> Product
                book = (Book)formatter.Deserialize(fileStream);
                BId.Text = book.Id.ToString();
                Book_name.Text = book.Name;
                Author_name.Text = book.Author;
                Price_Book.Text = book.Price.ToString();

                fileStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void XMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4\Book.xml";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer=new XmlSerializer(typeof(Book));
                Book book = new Book();
                book.Id = Convert.ToInt32(BId.Text);
                book.Name = Book_name.Text;
                book.Author = Author_name.Text;
                book.Price = Convert.ToInt32(Price_Book.Text);
                xmlSerializer.Serialize(fileStream, book);
                 fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void XMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4\Book.xml";
               
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Book));
                Book book = new Book();
                // we done explicit type casting from Object --> Product
                book = (Book)xmlSerializer.Deserialize(fileStream);
                BId.Text = book.Id.ToString();
                Book_name.Text = book.Name;
                Author_name.Text = book.Author;
                Price_Book.Text = book.Price.ToString();
              
                fileStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4\Book.soap";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                SoapFormatter soapFormatter = new SoapFormatter();
                Book book = new Book();
                book.Id = Convert.ToInt32(BId.Text);
                book.Name = Book_name.Text;
                book.Author = Author_name.Text;
                book.Price = Convert.ToInt32(Price_Book.Text);
                soapFormatter.Serialize(fileStream, book);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SOAPREAD_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4\Book.soap";

                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                SoapFormatter soapFormatter = new SoapFormatter(); Book book = new Book();
                // we done explicit type casting from Object --> Product
                book = (Book)soapFormatter.Deserialize(fileStream);
                BId.Text = book.Id.ToString();
                Book_name.Text = book.Name;
                Author_name.Text = book.Author;
                Price_Book.Text = book.Price.ToString();

                fileStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void JSONWrite_Click(object sender, EventArgs e)
        {

            try
            {
                string path = @"D:\DP4\Book.soap";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                Book book = new Book();
                book.Id = Convert.ToInt32(BId.Text);
                book.Name = Book_name.Text;
                book.Author = Author_name.Text;
                book.Price = Convert.ToInt32(Price_Book.Text);
                JsonSerializer.Serialize<Book>(fileStream, book);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void JSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4\Book.soap";

                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                // we done explicit type casting from Object --> Product
                Book book = new Book();
                book = JsonSerializer.Deserialize<Book>(fileStream);
                BId.Text = book.Id.ToString();
                Book_name.Text = book.Name;
                Author_name.Text = book.Author;
                Price_Book.Text = book.Price.ToString();
                fileStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
