using System;
using ABC_XYZ_analysis.Properties;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_XYZ_analysis
{
    /***
     * настроить загружаемый файл
     * выбрать лист, первая строка как заголовки
    ***/
    public partial class LoadExcelFileSettings : Form
    {
        private MainForm MainForm;

        public LoadExcelFileSettings()
        {
            InitializeComponent();
            //this.FormClosing += new FormClosingEventHandler(LoadExcelFileSettings_FormClosing);
        }

        public LoadExcelFileSettings(MainForm MainForm)
        {
           this.MainForm = MainForm;
           InitializeComponent();
           this.FormClosing += new FormClosingEventHandler(LoadExcelFileSettings_FormClosing);
          }

        string checked_table = "0"; // номер выбранного листа


        string checked_heads = "0"; //первая строка как заголовки. Если 0 - то не заголовки, если 1 то заголовки

        public Dictionary<string, string> local = new Dictionary<string, string>(); // локальный словарь с настройками

        public Exception Exc()
        {
            return new Exception();
        }

        public void LoadExcelFileSettings_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true; // по умолчанию первая строка как заголовки
            Dictionary<string, string> settings = MainForm.getExcelFileSettings(); // получаем словарь с настройками
            local = MainForm.getExcelFileSettings(); // получаем словарь с настройками из главной формы
            local.Add("checked_table", checked_table);
            local.Add("checked_heads", checked_heads);
            string s = settings["tables_names"]; // имена таблиц 
            String[] tables_names = s.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries); // парсим имена в массив
            string file_name = settings["file_name"];// имя самого файла
            label3.Text = "Вы собираетесь загрузить файл: "+file_name;
            label1.Text = "Листов в Вашем документе: " + settings["tables_count"] + ". Пожалуйста, выберите нужный для работы лист.";
            for (int i = 0; i < tables_names.Length; i++)
            {
                comboBox1.Items.Add(tables_names[i]); // добавляем имена в комбобокс
            }
            comboBox1.SelectedIndex = 0; // по дефолту выбран первый лист
            MainForm.setExcelFileSettings(local); // отдаем словарь с настройками в главную форму
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checked_table = comboBox1.SelectedIndex.ToString(); // номер выбранной таблицы
            //string checked_heads = "";
            if (checkBox1.Checked) // есть ли заголовки (стоит ли галочка)
            {
                checked_heads = "1";  // стоит
            }
            else
            {
                checked_heads = "0"; // не стоит
            }
            local["checked_table"] = checked_table;
            local["checked_heads"] = checked_heads;
            MainForm.setExcelFileSettings(local);
            Dispose();// закрываем форму. используется этот метод, а не Close(), так как на Close() навешан обработчик
     
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void LoadExcelFileSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;
           e.Cancel = DialogResult.Yes != MessageBox.Show("Прервать загрузку документа?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if (e.Cancel == false)
           {
               local["checked_table"] = "-1"; // записываем номер выбранной таблицы -1, чтобы произошло исключение в главной форме и загрузка прервалась. Это костыль ужасный 
           }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }      
    }
}
