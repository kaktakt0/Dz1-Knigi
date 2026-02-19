using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Windows.Forms;
using Dz1_Knigi.Классы;
namespace Dz1_Knigi
{
    public partial class Bookshop : Form
    {
        private List<Book> books = new List<Book>();
        private List<Book> filteredBooks = new List<Book>();
        private List<string> authorNames = new List<string>();
        private List<string> genreNames = new List<string>();
        public Bookshop()
        {
            InitializeComponent();
            LoadData();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Biblioteka_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void BooksTable_SelectionChanged(object sender, EventArgs e)
        {
            if (BooksTable.CurrentRow != null)
            {
                var selectedBook = BooksTable.CurrentRow.DataBoundItem as Book;
                if (selectedBook != null)
                {
                    textName.Text = selectedBook.Title;
                    textAuthor.Text = selectedBook.Author;
                    textGenre.Text = selectedBook.Genre;
                    radioSaleYes.Checked = selectedBook.Discount;
                    radioSaleNo.Checked = !selectedBook.Discount;
                }
            }
        }

        private void ApplyFilter()
        {
            string selectedAuthor = FilterAuthor.SelectedItem?.ToString();
            string selectedGenre = FilterGenre.SelectedItem?.ToString();
            filteredBooks = books.Where(b =>
                (selectedAuthor == "Все" || b.Author == selectedAuthor) &&
                (selectedGenre == "Все" || b.Genre == selectedGenre)).ToList();
            BooksTable.DataSource = null;
            BooksTable.DataSource = filteredBooks;
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditForm())
            {
                form.Authors = authorNames;
                form.Genres = genreNames;
                form.BookToEdit = null;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Присваиваем новый Id
                    int newId = books.Count > 0 ? books.Max(b => b.Id) + 1 : 1;
                    form.BookToEdit.Id = newId;
                    books.Add(form.BookToEdit);
                    ApplyFilter(); // обновляем отображение с учётом фильтров
                }
            }
        }

        private void menuEdit_Click(object sender, EventArgs e)
        {
            if (BooksTable.CurrentRow == null)
            {
                MessageBox.Show("Выберите книгу для редактирования.");
                return;
            }
            var selectedBook = BooksTable.CurrentRow.DataBoundItem as Book;
            if (selectedBook == null) return;

            using (var form = new AddEditForm())
            {
                form.Authors = authorNames;
                form.Genres = genreNames;
                // Передаём выбранную книгу для редактирования
                form.BookToEdit = selectedBook;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Изменения уже внесены в объект selectedBook, просто обновляем отображение
                    BooksTable.Refresh(); // обновить текущую строку
                                        // Также нужно обновить карточку, если она отображает эту книгу
                    BooksTable_SelectionChanged(null, null);
                }
            }
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            if (BooksTable.CurrentRow == null)
            {
                MessageBox.Show("Выберите книгу для удаления.");
                return;
            }
            var selectedBook = BooksTable.CurrentRow.DataBoundItem as Book;
            if (selectedBook == null) return;

            var result = MessageBox.Show($"Удалить книгу \"{selectedBook.Title}\"?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                books.Remove(selectedBook);
                ApplyFilter(); // обновляем список
                               // Очищаем карточку
                textName.Clear();
                textAuthor.Clear();
                textGenre.Clear();
                radioSaleYes.Checked = false;
                radioSaleNo.Checked = false;
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BooksTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FilterAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void FilterGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
    }
}
