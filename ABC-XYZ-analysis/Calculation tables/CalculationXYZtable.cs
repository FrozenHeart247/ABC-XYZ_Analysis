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
    public partial class CalculationXYZtable : Form
    {

        private MainForm MainForm;

        public CalculationXYZtable()
        {
            this.StartPosition = FormStartPosition.CenterScreen; // открываем эту форму по центру
            InitializeComponent();
        }

        public CalculationXYZtable(MainForm MainForm)
        {
            this.StartPosition = FormStartPosition.CenterScreen; // открываем эту форму по центру
            this.MainForm = MainForm;
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
            dataGridView1.Columns.Clear(); // очищаем колонки
            dataGridView1.DataSource = null; // это тут должно быть обязательно!

            dataGridView1.ColumnCount = (2 + columnsList.Count()) + 5; //задаем колочество столбцоа. 2 - имя и номер товара. columnsList.Count - количество столбцов длля расчета. 5 - сумма, среднее значение, отклонение, коэфф вариации, группа XYZ 

            dataGridView1.Columns[0].Name = "Номер"; // имя колонки
            dataGridView1.Columns[1].Name = "Имя продукта"; // имя колонки

            for (int i = 0; i < columnsList.Count; i++)
            {
                dataGridView1.Columns[i + 2].Name = columnsList.Keys.ToList()[i]; // добавляем имена колонок остальных
            }

            // добавляем колонки
            dataGridView1.Columns[dataGridView1.ColumnCount - 5].Name = "Сумма";
            dataGridView1.Columns[dataGridView1.ColumnCount - 4].Name = "Среднее значение";
            dataGridView1.Columns[dataGridView1.ColumnCount - 3].Name = "Стандартное отклонение";
            dataGridView1.Columns[dataGridView1.ColumnCount - 2].Name = "Коэффициент вариации";
            dataGridView1.Columns[dataGridView1.ColumnCount - 1].Name = "Группа XYZ";


            for (int i = 0; i < ProductsList.Count; i++)
            {
                List<string> row = new List<string> { ProductsList[i].number.ToString(), ProductsList[i].name.ToString() }; // создаем строку для добавления в datagridview, добавляем в нее имя и номер продукта

                for (int j = 0; j < ProductsList[i].values_analysis.Count; j++)
                {
                    row.Add(ProductsList[i].values_analysis[j].ToString()); // добавляем в строку значения данных для расчета(колонки объемов продаж)
                }

                row.Add(ProductsList[i].sum_values.ToString());  // добавляем в строку сумму объемов продаж за периоды
                row.Add(ProductsList[i].average_value.ToString()); // добавляем в строку среднее значение объемов продаж за периоды
                row.Add(ProductsList[i].standard_deviation.ToString());// добавляем в строку стендартное отклонение
                row.Add(ProductsList[i].coefficient_of_variation.ToString());// добавляем в строку коэфф вариации
                row.Add(ProductsList[i].groupXYZ);// добавляем в строку группу XYZ


                dataGridView1.Rows.Add(row.ToArray<string>()); // добавляем строку в datagridview



            }

            dataGridView1.Columns[0].Width = 45; // задаем ширину столбца "номер товара"


            foreach (DataGridViewColumn column in dataGridView1.Columns) // запрещение сортироки (клик на имя столбца)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }


        }
        private void CalculationXYZtable_Load(object sender, EventArgs e)
        {
            List<Product> local_products = MainForm.getProductsList();// получаем список продуктов из главной формы

            Dictionary<string, int> local_columns = MainForm.getColumnsList();// получаем словарь колонок из главной формы
            
            EstimatesToDataGridView(local_products, local_columns); // рисуем в DataGridView
        }

        private void ExportToExcel()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files|*.xls";

            //sfd.FileName = "Расчетная таблица XYZ-анализа";
            string DateTime1 = DateTime.Now.ToString("dd.MM.yyyy HH mm");
            sfd.FileName = "Расчетная таблица XYZ-анализа (" + DateTime1 + ")";

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

                    // Storing Each row and column value to excel sheet   
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                            // ExcelApp.Cells.BorderAround
                        }
                    }

                    //Save Copy by giving file Path   
                    // ExcelApp.ActiveWorkbook.SaveCopyAs("C:\\" + FileName);   

                    //OR using SaveFileDialog   
                    //ExcelApp.ActiveWorkbook.SaveCopyAs(sfd.FileName);

                    //OR even you can use SaveAs function   
                    ExcelApp.ActiveWorkbook.SaveAs(sfd.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8, null, null, null,
                     null, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlShared, null, null, null, null, null);

                    FileInfo fileInfo = new FileInfo(sfd.FileName);
                    ExcelApp.ActiveWorkbook.Saved = true;
                    MessageBox.Show("Файл ''" + fileInfo.Name + "'' успешно сохранен в каталог: " + fileInfo.DirectoryName);
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
