
namespace Dz1_Knigi
{
    partial class AddEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelGenre = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.groupSale = new System.Windows.Forms.GroupBox();
            this.radioSaleNo = new System.Windows.Forms.RadioButton();
            this.radioSaleYes = new System.Windows.Forms.RadioButton();
            this.buttonSafe = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.groupSale.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(96, 235);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(69, 25);
            this.labelGenre.TabIndex = 0;
            this.labelGenre.Text = "Жанр:";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(96, 142);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(75, 25);
            this.labelAuthor.TabIndex = 1;
            this.labelAuthor.Text = "Автор:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(96, 52);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(105, 25);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Название:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(216, 48);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(300, 29);
            this.textName.TabIndex = 5;
            // 
            // groupSale
            // 
            this.groupSale.Controls.Add(this.radioSaleNo);
            this.groupSale.Controls.Add(this.radioSaleYes);
            this.groupSale.Font = new System.Drawing.Font("Noto Sans Armenian", 9.857142F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSale.Location = new System.Drawing.Point(101, 296);
            this.groupSale.Name = "groupSale";
            this.groupSale.Size = new System.Drawing.Size(415, 159);
            this.groupSale.TabIndex = 6;
            this.groupSale.TabStop = false;
            this.groupSale.Text = "Скидка:";
            // 
            // radioSaleNo
            // 
            this.radioSaleNo.AutoSize = true;
            this.radioSaleNo.Font = new System.Drawing.Font("Agency FB", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSaleNo.Location = new System.Drawing.Point(6, 99);
            this.radioSaleNo.Name = "radioSaleNo";
            this.radioSaleNo.Size = new System.Drawing.Size(75, 32);
            this.radioSaleNo.TabIndex = 7;
            this.radioSaleNo.TabStop = true;
            this.radioSaleNo.Text = "Нет";
            this.radioSaleNo.UseVisualStyleBackColor = true;
            // 
            // radioSaleYes
            // 
            this.radioSaleYes.AutoSize = true;
            this.radioSaleYes.Font = new System.Drawing.Font("Agency FB", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSaleYes.Location = new System.Drawing.Point(6, 38);
            this.radioSaleYes.Name = "radioSaleYes";
            this.radioSaleYes.Size = new System.Drawing.Size(66, 32);
            this.radioSaleYes.TabIndex = 8;
            this.radioSaleYes.TabStop = true;
            this.radioSaleYes.Text = "Да";
            this.radioSaleYes.UseVisualStyleBackColor = true;
            // 
            // buttonSafe
            // 
            this.buttonSafe.Location = new System.Drawing.Point(101, 475);
            this.buttonSafe.Name = "buttonSafe";
            this.buttonSafe.Size = new System.Drawing.Size(152, 44);
            this.buttonSafe.TabIndex = 7;
            this.buttonSafe.Text = "Сохранить";
            this.buttonSafe.UseVisualStyleBackColor = true;
            this.buttonSafe.Click += new System.EventHandler(this.buttonSafe_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(384, 475);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(132, 44);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Отмена";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(216, 232);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(300, 32);
            this.cmbGenre.TabIndex = 9;
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(216, 142);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(300, 32);
            this.cmbAuthor.TabIndex = 10;
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(855, 619);
            this.Controls.Add(this.cmbAuthor);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSafe);
            this.Controls.Add(this.groupSale);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelGenre);
            this.Name = "AddEditForm";
            this.Text = "Редактор Книг";
            this.Load += new System.EventHandler(this.AddEditForm_Load);
            this.groupSale.ResumeLayout(false);
            this.groupSale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGenre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.GroupBox groupSale;
        private System.Windows.Forms.RadioButton radioSaleNo;
        private System.Windows.Forms.RadioButton radioSaleYes;
        private System.Windows.Forms.Button buttonSafe;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.ComboBox cmbAuthor;
    }
}