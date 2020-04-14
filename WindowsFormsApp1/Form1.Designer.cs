namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rareliterature = new System.Windows.Forms.RadioButton();
            this.Subscription = new System.Windows.Forms.RadioButton();
            this.Readingroom = new System.Windows.Forms.RadioButton();
            this.Periodica = new System.Windows.Forms.RadioButton();
            this.AddBook_cl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBook = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.All = new System.Windows.Forms.RadioButton();
            this.Rareliterature1 = new System.Windows.Forms.RadioButton();
            this.Subscription1 = new System.Windows.Forms.RadioButton();
            this.Readingroom1 = new System.Windows.Forms.RadioButton();
            this.Periodica1 = new System.Windows.Forms.RadioButton();
            this.SearchBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Show = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.All1 = new System.Windows.Forms.RadioButton();
            this.Rareliterature2 = new System.Windows.Forms.RadioButton();
            this.Subscription2 = new System.Windows.Forms.RadioButton();
            this.Readingroom2 = new System.Windows.Forms.RadioButton();
            this.Periodica2 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Add = new System.Windows.Forms.RadioButton();
            this.Delete = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Rareliterature3 = new System.Windows.Forms.RadioButton();
            this.Subscription3 = new System.Windows.Forms.RadioButton();
            this.Readingroom3 = new System.Windows.Forms.RadioButton();
            this.Periodica3 = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.AddInfo = new System.Windows.Forms.RadioButton();
            this.SearchInfo = new System.Windows.Forms.RadioButton();
            this.DeleteInfo = new System.Windows.Forms.RadioButton();
            this.Do = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.Rareliterature);
            this.groupBox1.Controls.Add(this.Subscription);
            this.groupBox1.Controls.Add(this.Readingroom);
            this.groupBox1.Controls.Add(this.Periodica);
            this.groupBox1.Controls.Add(this.AddBook_cl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddBook);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление/Удалиение книг ";
            // 
            // Rareliterature
            // 
            this.Rareliterature.AutoSize = true;
            this.Rareliterature.Location = new System.Drawing.Point(429, 54);
            this.Rareliterature.Name = "Rareliterature";
            this.Rareliterature.Size = new System.Drawing.Size(183, 24);
            this.Rareliterature.TabIndex = 8;
            this.Rareliterature.TabStop = true;
            this.Rareliterature.Text = "Редкая литература";
            this.Rareliterature.UseVisualStyleBackColor = true;
            this.Rareliterature.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // Subscription
            // 
            this.Subscription.AutoSize = true;
            this.Subscription.Location = new System.Drawing.Point(304, 54);
            this.Subscription.Name = "Subscription";
            this.Subscription.Size = new System.Drawing.Size(119, 24);
            this.Subscription.TabIndex = 7;
            this.Subscription.TabStop = true;
            this.Subscription.Text = "Абонемент";
            this.Subscription.UseVisualStyleBackColor = true;
            // 
            // Readingroom
            // 
            this.Readingroom.AutoSize = true;
            this.Readingroom.Location = new System.Drawing.Point(146, 54);
            this.Readingroom.Name = "Readingroom";
            this.Readingroom.Size = new System.Drawing.Size(152, 24);
            this.Readingroom.TabIndex = 6;
            this.Readingroom.TabStop = true;
            this.Readingroom.Text = "Читальный зал";
            this.Readingroom.UseVisualStyleBackColor = true;
            this.Readingroom.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Periodica
            // 
            this.Periodica.AutoSize = true;
            this.Periodica.Location = new System.Drawing.Point(21, 54);
            this.Periodica.Name = "Periodica";
            this.Periodica.Size = new System.Drawing.Size(119, 24);
            this.Periodica.TabIndex = 5;
            this.Periodica.TabStop = true;
            this.Periodica.Text = "Периодика";
            this.Periodica.UseVisualStyleBackColor = true;
            // 
            // AddBook_cl
            // 
            this.AddBook_cl.Location = new System.Drawing.Point(451, 146);
            this.AddBook_cl.Name = "AddBook_cl";
            this.AddBook_cl.Size = new System.Drawing.Size(205, 55);
            this.AddBook_cl.TabIndex = 4;
            this.AddBook_cl.Text = "Выполнить";
            this.AddBook_cl.UseVisualStyleBackColor = true;
            this.AddBook_cl.Click += new System.EventHandler(this.AddBook_cl_Click_1);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите название книги и автора                (через запятую)";
            this.label2.Click += new System.EventHandler(this.SearchBook_Click);
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(291, 94);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(339, 26);
            this.AddBook.TabIndex = 2;
            this.AddBook.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.All);
            this.groupBox2.Controls.Add(this.Rareliterature1);
            this.groupBox2.Controls.Add(this.Subscription1);
            this.groupBox2.Controls.Add(this.Readingroom1);
            this.groupBox2.Controls.Add(this.Periodica1);
            this.groupBox2.Controls.Add(this.SearchBook);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Search);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(680, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 455);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск книг по автору";
            // 
            // All
            // 
            this.All.AutoSize = true;
            this.All.Location = new System.Drawing.Point(195, 84);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(136, 24);
            this.All.TabIndex = 10;
            this.All.TabStop = true;
            this.All.Text = "Весь каталог";
            this.All.UseVisualStyleBackColor = true;
            // 
            // Rareliterature1
            // 
            this.Rareliterature1.AutoSize = true;
            this.Rareliterature1.Location = new System.Drawing.Point(6, 84);
            this.Rareliterature1.Name = "Rareliterature1";
            this.Rareliterature1.Size = new System.Drawing.Size(183, 24);
            this.Rareliterature1.TabIndex = 9;
            this.Rareliterature1.TabStop = true;
            this.Rareliterature1.Text = "Редкая литература";
            this.Rareliterature1.UseVisualStyleBackColor = true;
            // 
            // Subscription1
            // 
            this.Subscription1.AutoSize = true;
            this.Subscription1.Location = new System.Drawing.Point(195, 54);
            this.Subscription1.Name = "Subscription1";
            this.Subscription1.Size = new System.Drawing.Size(119, 24);
            this.Subscription1.TabIndex = 8;
            this.Subscription1.TabStop = true;
            this.Subscription1.Text = "Абонемент";
            this.Subscription1.UseVisualStyleBackColor = true;
            // 
            // Readingroom1
            // 
            this.Readingroom1.AutoSize = true;
            this.Readingroom1.Location = new System.Drawing.Point(320, 54);
            this.Readingroom1.Name = "Readingroom1";
            this.Readingroom1.Size = new System.Drawing.Size(152, 24);
            this.Readingroom1.TabIndex = 7;
            this.Readingroom1.TabStop = true;
            this.Readingroom1.Text = "Читальный зал";
            this.Readingroom1.UseVisualStyleBackColor = true;
            // 
            // Periodica1
            // 
            this.Periodica1.AutoSize = true;
            this.Periodica1.Location = new System.Drawing.Point(6, 54);
            this.Periodica1.Name = "Periodica1";
            this.Periodica1.Size = new System.Drawing.Size(119, 24);
            this.Periodica1.TabIndex = 6;
            this.Periodica1.TabStop = true;
            this.Periodica1.Text = "Периодика";
            this.Periodica1.UseVisualStyleBackColor = true;
            // 
            // SearchBook
            // 
            this.SearchBook.Location = new System.Drawing.Point(339, 170);
            this.SearchBook.Name = "SearchBook";
            this.SearchBook.Size = new System.Drawing.Size(156, 45);
            this.SearchBook.TabIndex = 3;
            this.SearchBook.Text = "Поиск";
            this.SearchBook.UseVisualStyleBackColor = true;
            this.SearchBook.Click += new System.EventHandler(this.SearchBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите имя автора:";
            // 
            // Search
            // 
            this.Search.AccessibleDescription = "";
            this.Search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Search.Location = new System.Drawing.Point(330, 126);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(174, 26);
            this.Search.TabIndex = 1;
            this.Search.Tag = "";
            this.Search.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.Location = new System.Drawing.Point(18, 233);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(486, 214);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Show);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.All1);
            this.groupBox3.Controls.Add(this.Rareliterature2);
            this.groupBox3.Controls.Add(this.Subscription2);
            this.groupBox3.Controls.Add(this.Readingroom2);
            this.groupBox3.Controls.Add(this.Periodica2);
            this.groupBox3.Location = new System.Drawing.Point(12, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(662, 238);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Каталог книг";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(15, 184);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(138, 46);
            this.Show.TabIndex = 13;
            this.Show.Text = "Показать";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // textBox2
            // 
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox2.Location = new System.Drawing.Point(190, 16);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(466, 214);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // All1
            // 
            this.All1.AutoSize = true;
            this.All1.Location = new System.Drawing.Point(15, 154);
            this.All1.Name = "All1";
            this.All1.Size = new System.Drawing.Size(136, 24);
            this.All1.TabIndex = 11;
            this.All1.TabStop = true;
            this.All1.Text = "Весь каталог";
            this.All1.UseVisualStyleBackColor = true;
            // 
            // Rareliterature2
            // 
            this.Rareliterature2.AutoSize = true;
            this.Rareliterature2.Location = new System.Drawing.Point(15, 124);
            this.Rareliterature2.Name = "Rareliterature2";
            this.Rareliterature2.Size = new System.Drawing.Size(183, 24);
            this.Rareliterature2.TabIndex = 9;
            this.Rareliterature2.TabStop = true;
            this.Rareliterature2.Text = "Редкая литература";
            this.Rareliterature2.UseVisualStyleBackColor = true;
            // 
            // Subscription2
            // 
            this.Subscription2.AutoSize = true;
            this.Subscription2.Location = new System.Drawing.Point(15, 94);
            this.Subscription2.Name = "Subscription2";
            this.Subscription2.Size = new System.Drawing.Size(119, 24);
            this.Subscription2.TabIndex = 8;
            this.Subscription2.TabStop = true;
            this.Subscription2.Text = "Абонемент";
            this.Subscription2.UseVisualStyleBackColor = true;
            // 
            // Readingroom2
            // 
            this.Readingroom2.AutoSize = true;
            this.Readingroom2.Location = new System.Drawing.Point(15, 64);
            this.Readingroom2.Name = "Readingroom2";
            this.Readingroom2.Size = new System.Drawing.Size(152, 24);
            this.Readingroom2.TabIndex = 7;
            this.Readingroom2.TabStop = true;
            this.Readingroom2.Text = "Читальный зал";
            this.Readingroom2.UseVisualStyleBackColor = true;
            // 
            // Periodica2
            // 
            this.Periodica2.AutoSize = true;
            this.Periodica2.Location = new System.Drawing.Point(15, 34);
            this.Periodica2.Name = "Periodica2";
            this.Periodica2.Size = new System.Drawing.Size(119, 24);
            this.Periodica2.TabIndex = 6;
            this.Periodica2.TabStop = true;
            this.Periodica2.Text = "Периодика";
            this.Periodica2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Delete);
            this.groupBox4.Controls.Add(this.Add);
            this.groupBox4.Location = new System.Drawing.Point(291, 130);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(154, 75);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.Location = new System.Drawing.Point(6, 14);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(109, 24);
            this.Add.TabIndex = 0;
            this.Add.TabStop = true;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.AutoSize = true;
            this.Delete.Location = new System.Drawing.Point(6, 44);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(101, 24);
            this.Delete.TabIndex = 1;
            this.Delete.TabStop = true;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Do);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.Rareliterature3);
            this.groupBox5.Controls.Add(this.Subscription3);
            this.groupBox5.Controls.Add(this.Readingroom3);
            this.groupBox5.Controls.Add(this.Periodica3);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Location = new System.Drawing.Point(12, 474);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1187, 219);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Добавление/Удаление/Поиск информиции в фондах";
            // 
            // textBox3
            // 
            this.textBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox3.Location = new System.Drawing.Point(686, 25);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(486, 188);
            this.textBox3.TabIndex = 1;
            // 
            // Rareliterature3
            // 
            this.Rareliterature3.AutoSize = true;
            this.Rareliterature3.Location = new System.Drawing.Point(15, 126);
            this.Rareliterature3.Name = "Rareliterature3";
            this.Rareliterature3.Size = new System.Drawing.Size(183, 24);
            this.Rareliterature3.TabIndex = 15;
            this.Rareliterature3.TabStop = true;
            this.Rareliterature3.Text = "Редкая литература";
            this.Rareliterature3.UseVisualStyleBackColor = true;
            // 
            // Subscription3
            // 
            this.Subscription3.AutoSize = true;
            this.Subscription3.Location = new System.Drawing.Point(15, 96);
            this.Subscription3.Name = "Subscription3";
            this.Subscription3.Size = new System.Drawing.Size(119, 24);
            this.Subscription3.TabIndex = 14;
            this.Subscription3.TabStop = true;
            this.Subscription3.Text = "Абонемент";
            this.Subscription3.UseVisualStyleBackColor = true;
            // 
            // Readingroom3
            // 
            this.Readingroom3.AutoSize = true;
            this.Readingroom3.Location = new System.Drawing.Point(15, 66);
            this.Readingroom3.Name = "Readingroom3";
            this.Readingroom3.Size = new System.Drawing.Size(152, 24);
            this.Readingroom3.TabIndex = 13;
            this.Readingroom3.TabStop = true;
            this.Readingroom3.Text = "Читальный зал";
            this.Readingroom3.UseVisualStyleBackColor = true;
            // 
            // Periodica3
            // 
            this.Periodica3.AutoSize = true;
            this.Periodica3.Location = new System.Drawing.Point(15, 36);
            this.Periodica3.Name = "Periodica3";
            this.Periodica3.Size = new System.Drawing.Size(119, 24);
            this.Periodica3.TabIndex = 12;
            this.Periodica3.TabStop = true;
            this.Periodica3.Text = "Периодика";
            this.Periodica3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.DeleteInfo);
            this.groupBox6.Controls.Add(this.SearchInfo);
            this.groupBox6.Controls.Add(this.AddInfo);
            this.groupBox6.Location = new System.Drawing.Point(278, 25);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(167, 125);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            // 
            // AddInfo
            // 
            this.AddInfo.AutoSize = true;
            this.AddInfo.Location = new System.Drawing.Point(6, 11);
            this.AddInfo.Name = "AddInfo";
            this.AddInfo.Size = new System.Drawing.Size(164, 36);
            this.AddInfo.TabIndex = 0;
            this.AddInfo.TabStop = true;
            this.AddInfo.Text = "Добавить";
            this.AddInfo.UseVisualStyleBackColor = true;
            // 
            // SearchInfo
            // 
            this.SearchInfo.AutoSize = true;
            this.SearchInfo.Location = new System.Drawing.Point(6, 71);
            this.SearchInfo.Name = "SearchInfo";
            this.SearchInfo.Size = new System.Drawing.Size(120, 36);
            this.SearchInfo.TabIndex = 1;
            this.SearchInfo.TabStop = true;
            this.SearchInfo.Text = "Поиск";
            this.SearchInfo.UseVisualStyleBackColor = true;
            // 
            // DeleteInfo
            // 
            this.DeleteInfo.AutoSize = true;
            this.DeleteInfo.Location = new System.Drawing.Point(6, 41);
            this.DeleteInfo.Name = "DeleteInfo";
            this.DeleteInfo.Size = new System.Drawing.Size(152, 36);
            this.DeleteInfo.TabIndex = 2;
            this.DeleteInfo.TabStop = true;
            this.DeleteInfo.Text = "Удалить";
            this.DeleteInfo.UseVisualStyleBackColor = true;
            // 
            // Do
            // 
            this.Do.Location = new System.Drawing.Point(457, 81);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(205, 55);
            this.Do.TabIndex = 17;
            this.Do.Text = "Выполнить";
            this.Do.UseVisualStyleBackColor = true;
            this.Do.Click += new System.EventHandler(this.Info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1217, 700);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBook_cl;
        private System.Windows.Forms.Button SearchBook;
        private System.Windows.Forms.RadioButton Subscription;
        private System.Windows.Forms.RadioButton Readingroom;
        private System.Windows.Forms.RadioButton Periodica;
        private System.Windows.Forms.RadioButton Rareliterature;
        private System.Windows.Forms.RadioButton All;
        private System.Windows.Forms.RadioButton Rareliterature1;
        private System.Windows.Forms.RadioButton Subscription1;
        private System.Windows.Forms.RadioButton Readingroom1;
        private System.Windows.Forms.RadioButton Periodica1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton All1;
        private System.Windows.Forms.RadioButton Rareliterature2;
        private System.Windows.Forms.RadioButton Subscription2;
        private System.Windows.Forms.RadioButton Readingroom2;
        private System.Windows.Forms.RadioButton Periodica2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton Delete;
        private System.Windows.Forms.RadioButton Add;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Do;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton DeleteInfo;
        private System.Windows.Forms.RadioButton SearchInfo;
        private System.Windows.Forms.RadioButton AddInfo;
        private System.Windows.Forms.RadioButton Rareliterature3;
        private System.Windows.Forms.RadioButton Subscription3;
        private System.Windows.Forms.RadioButton Readingroom3;
        private System.Windows.Forms.RadioButton Periodica3;
        private System.Windows.Forms.TextBox textBox3;
    }
}

