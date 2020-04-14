using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Library library = new Library();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBook_cl_Click_1(object sender, EventArgs e)
        {

            char[] delimiterChars = { ',', '\n' };
            try
            {
                string[] info = AddBook.Text.Split(delimiterChars);
                if (Add.Checked)
                {
                    if (info.Length != 2)
                        throw new Exception("Неверный ввод данных");
                    else if (Subscription.Checked)
                    {
                        library.AddBookInSubscription(new Book(info[0], info[1]));
                    }
                    else if (Periodica.Checked)
                    {
                        library.AddBookInPeriodica(new Book(info[0], info[1]));
                    }
                    else if (Readingroom.Checked)
                    {
                        library.AddBookInReadingRoom(new Book(info[0], info[1]));
                    }
                    else if (Rareliterature.Checked)
                    {
                        library.AddBookInRareLiterature(new Book(info[0], info[1]));
                    }
                    else
                    {
                        throw new Exception("Вы не указали фонд");
                    }
                }
                else if (Delete.Checked)
                {
                    if (info.Length != 2)
                        throw new Exception("Неверный ввод данных");
                    else if (Subscription.Checked)
                    {
                        if(library.DeleteBookInSubscription(new Book(info[0], info[1]))==false)
                            throw new Exception("Данной книги нету в книгах по абонементу");
                    }
                    else if (Periodica.Checked)
                    {
                        if(library.DeleteBookInPeriodica(new Book(info[0], info[1])))
                            throw new Exception("Данной книги нету в периодике");
                    }
                    else if (Readingroom.Checked)
                    {
                        if(library.DeleteBookInReadingRoom(new Book(info[0], info[1])))
                            throw new Exception("Данной книги нету в читальном зале");
                    }
                    else if (Rareliterature.Checked)
                    {
                        if(library.DeleteBookInRareLiterature(new Book(info[0], info[1])))
                            throw new Exception("Данной книги нету в редкой литературе");
                    }
                    else
                    {
                        throw new Exception("Вы не указали фонд");
                    }
                }
                else
                {
                    throw new Exception("Вы не указали операцию");
                }
            }
            catch (Exception exc)
            {
                DialogResult res;
                res = MessageBox.Show(exc.Message);
            }
            AddBook.Text = "";
        }

        private void SearchBook_Click(object sender, EventArgs e)
        {
            List<Book> list;
            textBox1.Text = "";
            char[] delimiterChars = { ' ', '\n' };
            try
            {
                if(Subscription1.Checked)
                {
                    list = library.ShowSubscriptionAuthorBooks(Search.Text);
                    if (list.Count == 0)
                    {
                        throw new Exception("Книг от данного автора в библиотеке нету");
                    }
                    foreach(Book elem in list)
                    {
                        textBox1.Text += "\n" + elem.ToString();
                    }
                }
                else if(Periodica1.Checked)
                {
                    list = library.ShowPeriodicaAuthorBooks(Search.Text);
                    if (list.Count == 0)
                    {
                        throw new Exception("Книг от данного автора в периодике нету");
                    }
                    foreach (Book elem in list)
                    {
                        textBox1.Text += "\n" + elem.ToString();
                    }
                }
                else if(Readingroom1.Checked)
                {
                    list = library.ShowReadingRoomAuthorBooks(Search.Text);
                    if (list.Count == 0)
                    {
                        throw new Exception("Книг от данного автора в читальном зале нету");
                    }
                    foreach (Book elem in list)
                    {
                        textBox1.Text += "\n" + elem.ToString();
                    }
                }
                else if(Rareliterature1.Checked)
                {
                    list = library.ShowRareLiteratureAuthorBooks(Search.Text);
                    if (list.Count == 0)
                    {
                        throw new Exception("Книг от данного автора в редкой литературе нету");
                    }
                    foreach (Book elem in list)
                    {
                        textBox1.Text += "\n" + elem.ToString();
                    }
                }
                else if(All.Checked)
                {
                    list = library.ShowAllAuthorBooks(Search.Text);
                    if (list.Count == 0)
                    {
                        throw new Exception("Книг от данного автора в библиотеке нету");
                    }
                    foreach (Book elem in list)
                    {
                        textBox1.Text += "\n" + elem.ToString();
                    }
                }
                else
                {
                    throw new Exception("Вы не указали фонд");
                }
            }
            catch (Exception exc)
            {
                DialogResult res;
                res = MessageBox.Show(exc.Message);
            }
            Search.Text = "";
        }

        private void Show_Click(object sender, EventArgs e)
        {
            List<Book> list;
            textBox2.Clear();
            try
            { 
                if (Subscription2.Checked)
                {
                    list = library.ShowSubscriptionCatalog();
                    if (list.Count == 0)
                    {
                        throw new Exception("Книг по абонементу нету");
                    }
                    foreach (Book elem in list)
                    {
                        textBox2.Text += "\n" + elem.ToString();
                    }
                }
                else if (Periodica2.Checked)
                {
                    list = library.ShowPeriodicaCatalog();
                    if (list.Count == 0)
                    {
                        throw new Exception("Книг в периодике нету");
                    }
                    foreach (Book elem in list)
                    {
                        textBox2.Text += "\n" + elem.ToString();
                    }
                }
                else if (Readingroom2.Checked)
                {
                    list = library.ShowReadingRoomCatalog();
                    if (list.Count == 0)
                    {
                        throw new Exception("Книг в читальном зале нету");
                    }
                    foreach (Book elem in list)
                    {
                        textBox2.Text += "\n" + elem.ToString();
                    }
                }
                else if (Rareliterature2.Checked)
                {
                    list = library.ShowRareLiteratureCatalog();
                    if (list.Count == 0)
                    {
                        throw new Exception("Книг в редкой литературе нету");
                    }
                    foreach (Book elem in list)
                    {
                        textBox2.Text += "\n" + elem.ToString();
                    }
                }
                else if (All1.Checked)
                {
                    list = library.ShowAllBooks();
                    if (list.Count == 0)
                    {
                        throw new Exception("Книг в библиотеке нету");
                    }
                    foreach (Book elem in list)
                    {
                        textBox2.Text += "\n" + elem.ToString();
                    }
                }
                else
                {
                    throw new Exception("Вы не указали фонд");
                }
            }
            catch (Exception exc)
            {
                DialogResult res;
                res = MessageBox.Show(exc.Message);
            }
        }

        private void Info_Click(object sender, EventArgs e)
        {
            try
            {
                if (AddInfo.Checked)
                {
                    if (Subscription3.Checked)
                    {
                        library.AddInfoInSubscription(textBox3.Text);
                    }
                    else if (Periodica3.Checked)
                    {
                        library.AddInfoInPeriodica(textBox3.Text);
                    }
                    else if (Readingroom3.Checked)
                    {
                        library.AddInfoInReadingRoom(textBox3.Text);
                    }
                    else if (Rareliterature3.Checked)
                    {
                        library.AddInfoInRareLiterature(textBox3.Text);
                    }
                    else
                    {
                        throw new Exception("Вы не указали фонд");
                    }
                    textBox3.Text = "";
                }
                else if (DeleteInfo.Checked)
                {
                    if (Subscription3.Checked)
                    {
                        library.DeleteInfoInSubscription();
                    }
                    else if (Periodica3.Checked)
                    {
                        library.DeleteInfoInPeriodica();
                    }
                    else if (Readingroom3.Checked)
                    {
                        library.DeleteInfoInReadingRoom();
                    }
                    else if (Rareliterature3.Checked)
                    {
                        library.DeleteInfoInRareLiterature();
                    }
                    else
                    {
                        throw new Exception("Вы не указали фонд");
                    }
                }
                else if (DeleteInfo.Checked)
                {
                    if (Subscription3.Checked)
                    {
                        library.DeleteInfoInSubscription();
                    }
                    else if (Periodica3.Checked)
                    {
                        library.DeleteInfoInPeriodica();
                    }
                    else if (Readingroom3.Checked)
                    {
                        library.DeleteInfoInReadingRoom();
                    }
                    else if (Rareliterature3.Checked)
                    {
                        library.DeleteInfoInRareLiterature();
                    }
                    else
                    {
                        throw new Exception("Вы не указали фонд");
                    }
                }
                else if (SearchInfo.Checked)
                {
                    if (Subscription3.Checked)
                    {
                        textBox3.Text =  library.GetInfoInSubscription();
                    }
                    else if (Periodica3.Checked)
                    {
                        textBox3.Text = library.GetInfoInPeriodica();
                    }
                    else if (Readingroom3.Checked)
                    {
                        textBox3.Text = library.GetInfoInReadingRoom();
                    }
                    else if (Rareliterature3.Checked)
                    {
                        textBox3.Text = library.GetInfoInRareLiterature();
                    }
                    else
                    {
                        throw new Exception("Вы не указали фонд");
                    }
                    if(textBox3.Text.Equals(""))
                        throw new Exception("Информация в данном фонде отсутствует");
                }
                else
                {
                    throw new Exception("Вы не указали операцию");
                }
            }
            catch (Exception exc)
            {
                DialogResult res;
                res = MessageBox.Show(exc.Message);
            }
        }

            private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
