using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;
using System.IO;

namespace ABC_XYZ_analysis
{
    public partial class CalculationABCtabte : Form
    {
        private MainForm MainForm;
        public CalculationABCtabte()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // открываем эту форму по центру
        }

        public CalculationABCtabte(MainForm MainForm)
        {
            this.StartPosition = FormStartPosition.CenterScreen; // открываем эту форму по центру
            this.MainForm = MainForm; // получаем данные из вызывающей формы
            InitializeComponent();
        }



        private void EstimatesToDataGridView(List<Product> ProductsList, Dictionary<string, int> columnsList)
        {
            /***
             * метод удаляет из datagridview данные,
             * который были загружены изначально и 
             * загружает в него те данные (столбцы), которые были 
             * отобраны. к этому этапу мы должны иметь на 100% праввильные
             * данные для анализа
             ***/
            dataGridView1.Columns.Clear(); // чистим столбцы
            dataGridView1.DataSource = null; // это тут должно быть обязательно!

            dataGridView1.ColumnCount = (2 + columnsList.Count()) + 4; // количество столбцов. 2 - номер и имя, + количество столбцов данных для анализа. +  4 - сумма, процент, нарастащим итогом, группа ABC

            dataGridView1.Columns[0].Name = "Номер"; // имя колонки
            dataGridView1.Columns[0].Width = 45; // задаем ширину колонки с номером
            dataGridView1.Columns[1].Name = "Имя продукта"; // имя колонки

            for (int i = 0; i < columnsList.Count; i++)
            {
                dataGridView1.Columns[i + 2].Name = columnsList.Keys.ToList()[i]; // добавляем имена колонок остальных
            }

            // добавляем колонки
            dataGridView1.Columns[dataGridView1.ColumnCount - 4].Name = "Сумма";
            dataGridView1.Columns[dataGridView1.ColumnCount - 3].Name = "Процент";
            dataGridView1.Columns[dataGridView1.ColumnCount - 2].Name = "Нарастающим итогом";
            dataGridView1.Columns[dataGridView1.ColumnCount - 1].Name = "Группа ABC";

            for (int i = 0; i < ProductsList.Count; i++)
            {
                List<string> row = new List<string> { ProductsList[i].number.ToString(), ProductsList[i].name.ToString() }; // создаем строку для добавления в datagridview, добавляем в нее имя и номер продукта

                for (int j = 0; j < ProductsList[i].values_analysis.Count; j++)
                {
                    row.Add(ProductsList[i].values_analysis[j].ToString()); // добавляем в строку значения данных для расчета(колонки объемов продаж)
                }
                row.Add(ProductsList[i].sum_values.ToString());  // добавляем в строку сумму объемов продаж за периоды
                row.Add(ProductsList[i].percent.ToString()); // добавляем в строку процент
                row.Add(ProductsList[i].growing_percent.ToString()); // добавляем в строку нарастающий итог
                row.Add(ProductsList[i].groupABC); // добавляем группу ABC

                dataGridView1.Rows.Add(row.ToArray<string>()); // добавляем строку в datagridview



            }

            foreach (DataGridViewColumn column in dataGridView1.Columns) // запрещение сортироки (клик на имя столбца)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            

        }

        private void CalculationABCtabte_Load(object sender, EventArgs e)
        {
            List<Product> local_products= MainForm.getProductsList(); // получаем список продуктов из главной формы
            Dictionary<string, int> local_columns = MainForm.getColumnsList(); // получаем словарь колонок из главной формы
            EstimatesToDataGridView(local_products, local_columns); // рисуем в DataGridView
        }

        private void ExportToExcel()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files|*.xls";

            string DateTime1 = DateTime.Now.ToString("dd.MM.yyyy HH mm");
            sfd.FileName = "Расчетная таблица ABC-анализа (" + DateTime1 + ")";

           // sfd.FileName = "Расчетная таблица ABC-анализа";
            

            DialogResult drSaveFile = sfd.ShowDialog();
            try
            {
                if (drSaveFile == System.Windows.Forms.DialogResult.OK)
                {
                    ExcelApp.Application ExcelApp = new ExcelApp.Application();
                    ExcelApp.Application.Workbooks.Add(Type.Missing);

                    //ExcelApp.ActiveWorkbook.FileFormat = XlFileFormat.xlExcel8;   
                    // Change properties of the Workbook   
                    ExcelApp.Columns.ColumnWidth = 25;
                    //ExcelApp.Rows = Color.Red;
                    // Storing header part in Excel

                    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                    {
                        ExcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;

                    }
 
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }   

                    ExcelApp.ActiveWorkbook.SaveAs(sfd.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8, null, null, null,
                     null, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlShared, null, null, null, null, null);

                    FileInfo fileInfo = new FileInfo(sfd.FileName);
                    ExcelApp.ActiveWorkbook.Saved = true;
                    MessageBox.Show("Файл ''" +fileInfo.Name  + "'' успешно сохранен в каталог: " + fileInfo.DirectoryName);
                    ExcelApp.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохрании файла: " + ex.Message);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
    }
}
