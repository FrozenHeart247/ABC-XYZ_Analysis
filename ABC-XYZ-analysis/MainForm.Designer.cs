namespace ABC_XYZ_analysis
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StartABCanalysis = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.comboBox__delete_column = new System.Windows.Forms.ComboBox();
            this.checkBox_new_column_as_first = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label_file_parth = new System.Windows.Forms.Label();
            this.New_column_name = new System.Windows.Forms.TextBox();
            this.logs = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox_logs = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox_rename_column = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox_rename_column = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.сохранитьВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьCsvtxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_logs.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(735, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.закрытьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьВExcelToolStripMenuItem,
            this.сохранитьCsvtxtToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(708, 294);
            this.dataGridView1.TabIndex = 1;
            // 
            // StartABCanalysis
            // 
            this.StartABCanalysis.Location = new System.Drawing.Point(4, 19);
            this.StartABCanalysis.Name = "StartABCanalysis";
            this.StartABCanalysis.Size = new System.Drawing.Size(221, 23);
            this.StartABCanalysis.TabIndex = 3;
            this.StartABCanalysis.Text = "Анализ ABC";
            this.StartABCanalysis.UseVisualStyleBackColor = true;
            this.StartABCanalysis.Click += new System.EventHandler(this.StartABCanalysis_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(240, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Анализ XYZ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(477, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Анализ ABC+XYZ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(88, 84);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 25);
            this.button7.TabIndex = 13;
            this.button7.Text = "Удалить столбец";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // comboBox__delete_column
            // 
            this.comboBox__delete_column.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox__delete_column.FormattingEnabled = true;
            this.comboBox__delete_column.Location = new System.Drawing.Point(186, 32);
            this.comboBox__delete_column.Name = "comboBox__delete_column";
            this.comboBox__delete_column.Size = new System.Drawing.Size(146, 21);
            this.comboBox__delete_column.TabIndex = 12;
            // 
            // checkBox_new_column_as_first
            // 
            this.checkBox_new_column_as_first.AutoSize = true;
            this.checkBox_new_column_as_first.Location = new System.Drawing.Point(67, 52);
            this.checkBox_new_column_as_first.Name = "checkBox_new_column_as_first";
            this.checkBox_new_column_as_first.Size = new System.Drawing.Size(213, 17);
            this.checkBox_new_column_as_first.TabIndex = 8;
            this.checkBox_new_column_as_first.Text = "Добавить столбец в начало таблицы";
            this.checkBox_new_column_as_first.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(88, 84);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 25);
            this.button6.TabIndex = 9;
            this.button6.Text = "Добавить столбец";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label_file_parth
            // 
            this.label_file_parth.AutoSize = true;
            this.label_file_parth.Location = new System.Drawing.Point(12, 24);
            this.label_file_parth.Name = "label_file_parth";
            this.label_file_parth.Size = new System.Drawing.Size(77, 13);
            this.label_file_parth.TabIndex = 10;
            this.label_file_parth.Text = "Путь к файлу:";
            // 
            // New_column_name
            // 
            this.New_column_name.Location = new System.Drawing.Point(167, 13);
            this.New_column_name.Name = "New_column_name";
            this.New_column_name.Size = new System.Drawing.Size(148, 20);
            this.New_column_name.TabIndex = 11;
            // 
            // logs
            // 
            this.logs.Location = new System.Drawing.Point(6, 16);
            this.logs.Name = "logs";
            this.logs.ReadOnly = true;
            this.logs.Size = new System.Drawing.Size(343, 120);
            this.logs.TabIndex = 8;
            this.logs.Text = "";
            this.logs.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ведите имя нового столбца:";
            // 
            // groupBox_logs
            // 
            this.groupBox_logs.Controls.Add(this.logs);
            this.groupBox_logs.Location = new System.Drawing.Point(364, 406);
            this.groupBox_logs.Name = "groupBox_logs";
            this.groupBox_logs.Size = new System.Drawing.Size(356, 141);
            this.groupBox_logs.TabIndex = 11;
            this.groupBox_logs.TabStop = false;
            this.groupBox_logs.Text = "Журнал";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.StartABCanalysis);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(12, 344);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(708, 54);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Провести анализ";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // comboBox_rename_column
            // 
            this.comboBox_rename_column.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rename_column.FormattingEnabled = true;
            this.comboBox_rename_column.Location = new System.Drawing.Point(178, 13);
            this.comboBox_rename_column.Name = "comboBox_rename_column";
            this.comboBox_rename_column.Size = new System.Drawing.Size(151, 21);
            this.comboBox_rename_column.TabIndex = 14;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(88, 84);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 25);
            this.button5.TabIndex = 15;
            this.button5.Text = "Переименовать столбец";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // textBox_rename_column
            // 
            this.textBox_rename_column.Location = new System.Drawing.Point(165, 49);
            this.textBox_rename_column.Name = "textBox_rename_column";
            this.textBox_rename_column.Size = new System.Drawing.Size(164, 20);
            this.textBox_rename_column.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Введите новое имя столца:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 408);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(346, 141);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.checkBox_new_column_as_first);
            this.tabPage1.Controls.Add(this.New_column_name);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(338, 115);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить столбец";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.comboBox__delete_column);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(338, 115);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Удалить столбец";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Выберите столбец для удаления:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.comboBox_rename_column);
            this.tabPage3.Controls.Add(this.textBox_rename_column);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(338, 115);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Переименовать столбец";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Столбец для переименования:";
            // 
            // сохранитьВExcelToolStripMenuItem
            // 
            this.сохранитьВExcelToolStripMenuItem.Name = "сохранитьВExcelToolStripMenuItem";
            this.сохранитьВExcelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьВExcelToolStripMenuItem.Text = "Сохранить в Excel";
            this.сохранитьВExcelToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВExcelToolStripMenuItem_Click);
            // 
            // сохранитьCsvtxtToolStripMenuItem
            // 
            this.сохранитьCsvtxtToolStripMenuItem.Name = "сохранитьCsvtxtToolStripMenuItem";
            this.сохранитьCsvtxtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьCsvtxtToolStripMenuItem.Text = "Сохранить csv/txt";
            this.сохранитьCsvtxtToolStripMenuItem.Click += new System.EventHandler(this.сохранитьCsvtxtToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 565);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox_logs);
            this.Controls.Add(this.label_file_parth);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Проведение ABC-XYZ-анализа";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_logs.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button StartABCanalysis;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox New_column_name;
        private System.Windows.Forms.Label label_file_parth;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox checkBox_new_column_as_first;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboBox__delete_column;
        private System.Windows.Forms.RichTextBox logs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox_logs;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_rename_column;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox_rename_column;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьCsvtxtToolStripMenuItem;
    }
}