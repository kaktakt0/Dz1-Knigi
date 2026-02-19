using System;
using System.Collections.Generic;
using Dz1_Knigi.Классы;
using System.Windows.Forms;

namespace Dz1_Knigi
{
    public partial class AddEditForm : Form
    {
        public Book BookToEdit { get; set; } 
        public List<string> Authors { get; set; }
        public List<string> Genres { get; set; }
        public AddEditForm()
        {
            InitializeComponent();
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            cmbAuthor.Items.Clear();
            cmbAuthor.Items.AddRange(Authors.ToArray());
            cmbGenre.Items.Clear();
            cmbGenre.Items.AddRange(Genres.ToArray());

            if (BookToEdit != null)
            {
                textName.Text = BookToEdit.Title;
                cmbAuthor.SelectedItem = BookToEdit.Author;
                cmbGenre.SelectedItem = BookToEdit.Genre;
                radioSaleYes.Checked = BookToEdit.Discount;
                radioSaleNo.Checked = !BookToEdit.Discount;
            }
            else
            {
                // По умолчанию ставим первую позицию в комбобоксах и "Нет скидки"
                if (cmbAuthor.Items.Count > 0) cmbAuthor.SelectedIndex = 0;
                if (cmbGenre.Items.Count > 0) cmbGenre.SelectedIndex = 0;
                radioSaleNo.Checked = true;
            }
        }

        private void buttonSafe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                MessageBox.Show("Введите название книги.");
                return;
            }
            if (cmbAuthor.SelectedItem == null || cmbGenre.SelectedItem == null)
            {
                MessageBox.Show("Выберите автора и жанр.");
                return;
            }

            if (BookToEdit == null)
            {
                // Создаем новую книгу (Id будет присвоен в главной форме)
                BookToEdit = new Book();
            }
            // Заполняем поля
            BookToEdit.Title = textName.Text.Trim();
            BookToEdit.Author = cmbAuthor.SelectedItem.ToString();
            BookToEdit.Genre = cmbGenre.SelectedItem.ToString();
            BookToEdit.Discount = radioSaleYes.Checked;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

        }
    }
}
