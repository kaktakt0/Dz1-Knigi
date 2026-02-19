using System.Collections.Generic;
using System.IO;
using Dz1_Knigi.Классы;
using System.Linq;


namespace Dz1_Knigi
{
    partial class Bookshop
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BooksTable = new System.Windows.Forms.DataGridView();
            this.labelFilter = new System.Windows.Forms.Label();
            this.FilterGenre = new System.Windows.Forms.ComboBox();
            this.FilterAuthor = new System.Windows.Forms.ComboBox();
            this.groupSale = new System.Windows.Forms.GroupBox();
            this.radioSaleNo = new System.Windows.Forms.RadioButton();
            this.radioSaleYes = new System.Windows.Forms.RadioButton();
            this.textAuthor = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textGenre = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelCard = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksTable)).BeginInit();
            this.groupSale.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdd,
            this.menuEdit,
            this.menuDelete,
            this.menuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAdd
            // 
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.Size = new System.Drawing.Size(124, 34);
            this.menuAdd.Text = "Добавить";
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(126, 34);
            this.menuEdit.Text = "Изменить";
            this.menuEdit.Click += new System.EventHandler(this.menuEdit_Click);
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(108, 34);
            this.menuDelete.Text = "Удалить";
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(91, 34);
            this.menuExit.Text = "Выйти";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Panel1.Controls.Add(this.BooksTable);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.labelFilter);
            this.splitContainer1.Panel1.Controls.Add(this.FilterGenre);
            this.splitContainer1.Panel1.Controls.Add(this.FilterAuthor);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.groupSale);
            this.splitContainer1.Panel2.Controls.Add(this.textAuthor);
            this.splitContainer1.Panel2.Controls.Add(this.textName);
            this.splitContainer1.Panel2.Controls.Add(this.textGenre);
            this.splitContainer1.Panel2.Controls.Add(this.labelGenre);
            this.splitContainer1.Panel2.Controls.Add(this.labelName);
            this.splitContainer1.Panel2.Controls.Add(this.labelAuthor);
            this.splitContainer1.Panel2.Controls.Add(this.labelCard);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1061, 702);
            this.splitContainer1.SplitterDistance = 523;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // BooksTable
            // 
            this.BooksTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.BooksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksTable.Location = new System.Drawing.Point(0, 99);
            this.BooksTable.Name = "BooksTable";
            this.BooksTable.RowHeadersWidth = 72;
            this.BooksTable.RowTemplate.Height = 31;
            this.BooksTable.Size = new System.Drawing.Size(517, 591);
            this.BooksTable.TabIndex = 0;
            this.BooksTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksTable_CellContentClick);
            this.BooksTable.SelectionChanged += new System.EventHandler(this.BooksTable_SelectionChanged);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Noto Serif Armenian", 9.857142F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(3, 52);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(179, 32);
            this.labelFilter.TabIndex = 2;
            this.labelFilter.Text = "Фильтровать";
            // 
            // FilterGenre
            // 
            this.FilterGenre.FormattingEnabled = true;
            this.FilterGenre.Location = new System.Drawing.Point(363, 61);
            this.FilterGenre.Name = "FilterGenre";
            this.FilterGenre.Size = new System.Drawing.Size(157, 32);
            this.FilterGenre.TabIndex = 1;
            this.FilterGenre.SelectedIndexChanged += new System.EventHandler(this.FilterGenre_SelectedIndexChanged);
            // 
            // FilterAuthor
            // 
            this.FilterAuthor.FormattingEnabled = true;
            this.FilterAuthor.Location = new System.Drawing.Point(204, 61);
            this.FilterAuthor.Name = "FilterAuthor";
            this.FilterAuthor.Size = new System.Drawing.Size(153, 32);
            this.FilterAuthor.TabIndex = 0;
            this.FilterAuthor.SelectedIndexChanged += new System.EventHandler(this.FilterAuthor_SelectedIndexChanged);
            // 
            // groupSale
            // 
            this.groupSale.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupSale.Controls.Add(this.radioSaleNo);
            this.groupSale.Controls.Add(this.radioSaleYes);
            this.groupSale.Location = new System.Drawing.Point(38, 315);
            this.groupSale.Name = "groupSale";
            this.groupSale.Size = new System.Drawing.Size(406, 337);
            this.groupSale.TabIndex = 7;
            this.groupSale.TabStop = false;
            this.groupSale.Text = "Скидка:";
            // 
            // radioSaleNo
            // 
            this.radioSaleNo.AutoSize = true;
            this.radioSaleNo.Location = new System.Drawing.Point(6, 118);
            this.radioSaleNo.Name = "radioSaleNo";
            this.radioSaleNo.Size = new System.Drawing.Size(142, 29);
            this.radioSaleNo.TabIndex = 8;
            this.radioSaleNo.TabStop = true;
            this.radioSaleNo.Text = "Нет скидки";
            this.radioSaleNo.UseVisualStyleBackColor = true;
            // 
            // radioSaleYes
            // 
            this.radioSaleYes.AutoSize = true;
            this.radioSaleYes.Location = new System.Drawing.Point(6, 43);
            this.radioSaleYes.Name = "radioSaleYes";
            this.radioSaleYes.Size = new System.Drawing.Size(235, 29);
            this.radioSaleYes.TabIndex = 9;
            this.radioSaleYes.TabStop = true;
            this.radioSaleYes.Text = "Скидка для студента";
            this.radioSaleYes.UseVisualStyleBackColor = true;
            // 
            // textAuthor
            // 
            this.textAuthor.Location = new System.Drawing.Point(144, 95);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Size = new System.Drawing.Size(300, 29);
            this.textAuthor.TabIndex = 6;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(144, 175);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(300, 29);
            this.textName.TabIndex = 5;
            // 
            // textGenre
            // 
            this.textGenre.Location = new System.Drawing.Point(144, 245);
            this.textGenre.Name = "textGenre";
            this.textGenre.Size = new System.Drawing.Size(300, 29);
            this.textGenre.TabIndex = 4;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(33, 245);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(69, 25);
            this.labelGenre.TabIndex = 3;
            this.labelGenre.Text = "Жанр:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(33, 175);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(105, 25);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Название:";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(33, 95);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(75, 25);
            this.labelAuthor.TabIndex = 1;
            this.labelAuthor.Text = "Автор:";
            // 
            // labelCard
            // 
            this.labelCard.AutoSize = true;
            this.labelCard.Font = new System.Drawing.Font("Noto Sans Armenian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCard.Location = new System.Drawing.Point(180, 9);
            this.labelCard.Name = "labelCard";
            this.labelCard.Size = new System.Drawing.Size(163, 38);
            this.labelCard.TabIndex = 0;
            this.labelCard.Text = "Карточка";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Bookshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1061, 702);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Bookshop";
            this.Text = "Книжный магазин";
            this.Load += new System.EventHandler(this.Biblioteka_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BooksTable)).EndInit();
            this.groupSale.ResumeLayout(false);
            this.groupSale.PerformLayout();
            this.ResumeLayout(false);

        }
        private void LoadData()
        {
            // Загрузка авторов
            var authorsDict = new Dictionary<int, string>();
            var authorLines = File.ReadAllLines("Authors.txt");
            foreach (var line in authorLines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var parts = line.Split(new[] { '.' }, 2);
                int id = int.Parse(parts[0].Trim());
                string name = parts[1].Trim();
                authorsDict[id] = name;
                authorNames.Add(name);
            }

            // Загрузка жанров
            var genresDict = new Dictionary<int, string>();
            var genreLines = File.ReadAllLines("Genres.txt");
            foreach (var line in genreLines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var parts = line.Split(new[] { '.' }, 2);
                int id = int.Parse(parts[0].Trim());
                string name = parts[1].Trim();
                genresDict[id] = name;
                genreNames.Add(name);
            }

            // Загрузка книг
            var bookLines = File.ReadAllLines("Books.txt");
            foreach (var line in bookLines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var dotSplit = line.Split(new[] { '.' }, 2);
                int id = int.Parse(dotSplit[0].Trim());
                string rest = dotSplit[1].Trim();
                var commaParts = rest.Split(',').Select(p => p.Trim()).ToList();
                string title = commaParts[0];
                int authorId = int.Parse(commaParts[1]);
                int genreId = int.Parse(commaParts[2]);
                bool discount = bool.Parse(commaParts[3]);

                books.Add(new Book
                {
                    Id = id,
                    Title = title,
                    Author = authorsDict[authorId],
                    Genre = genresDict[genreId],
                    Discount = discount
                });
            }

            // Заполнение ComboBox фильтров
            FilterAuthor.Items.Clear();
            FilterAuthor.Items.Add("Все");
            FilterAuthor.Items.AddRange(authorNames.ToArray());
            FilterAuthor.SelectedIndex = 0;

            FilterGenre.Items.Clear();
            FilterGenre.Items.Add("Все");
            FilterGenre.Items.AddRange(genreNames.ToArray());
            FilterGenre.SelectedIndex = 0;

            // Отображение книг
            filteredBooks = new List<Book>(books);
            BooksTable.DataSource = filteredBooks;
        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox FilterGenre;
        private System.Windows.Forms.ComboBox FilterAuthor;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.DataGridView BooksTable;
        private System.Windows.Forms.TextBox textAuthor;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textGenre;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelCard;
        private System.Windows.Forms.GroupBox groupSale;
        private System.Windows.Forms.RadioButton radioSaleNo;
        private System.Windows.Forms.RadioButton radioSaleYes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

