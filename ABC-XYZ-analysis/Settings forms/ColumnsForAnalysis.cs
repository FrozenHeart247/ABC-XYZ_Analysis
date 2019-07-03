using System;
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
     * форма выбора колонок для анализа
    ***/ 
    public partial class ColumnsForAnalysis : Form
    {
        private MainForm MainForm;

        public ColumnsForAnalysis()
        {
            InitializeComponent();
        }
      
        public ColumnsForAnalysis(MainForm MainForm)
        {
        this.MainForm = MainForm; // получаем  данные из вызывающей формы
           InitializeComponent();
           this.FormClosing += new FormClosingEventHandler(ColumnsForAnalysis_FormClosing);
           label1.Text = "Столбцы с объемами продаж. В данном поле отметьте только \n те столбцы, которые Вы хотите использовать для расчета.\nУбедитесь, что данные в этих столбцах верны и имеют \nтолько численные значения."; //\nТакже не отмечаются столбцы с номером товара и т.д.
           
           ToolTip t = new ToolTip();
           t.SetToolTip(button2, "При нажатии на данную кнопку будут отмечены/убраны отметки со всех столбцов.\nНе отмечается столбец, который выбран в качестве столбца имен товаров (поставщиков).");
           t.SetToolTip(comboBox1,"В данном поле нужно выбрать столбец, в котором находятся наименования\nтоваров или поставщиков.");
        }
        public Boolean state = false;
        public Dictionary<string, int> local = new Dictionary<string, int>(); // локальный словарь колонок
        public int NameIndex; // Индекс столбца с именами

        private void ColumnsForAnalysis_Load(object sender, EventArgs e)
        {
            local = MainForm.getColumnsList(); // получаем колонки
            try
            {
                for (int i = 0; i < local.Count; i++)
                {
                    checkedListBox1.Items.Add(local.Keys.ToList()[i]); //добавляем имена колонок в листчекбокс
                    comboBox1.Items.Add(local.Keys.ToList()[i]); // имена колонок в комбобокс (выбрать имя)
                }
                comboBox1.SelectedIndex = 0; // по умолчанию  выбираем нулевой элемент
                NameIndex = 0; // индекс столбца с именами
                local.Add("name", comboBox1.SelectedIndex); // записывеам в словарь индекс столбца с именами
            }
            catch {
                MessageBox.Show("Ошибка!");
                Close(); // закрываем форму
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                local.Clear(); // чистим локальный список имен столбцов
                for (int i = 0; i < checkedListBox1.Items.Count; i++) // перезаписываем текщий список, оставляем в нем только отмеченные столбцы
                {
                    if (checkedListBox1.GetItemChecked(i)) // если элемент отмечен
                    {
                        local.Add(checkedListBox1.Items[i].ToString(), i); // записываем его в локальный словарь колонок его имя и номер
                    }
                }
                NameIndex = comboBox1.SelectedIndex; // получаем индекс столбца с именами
                local.Add("name", NameIndex); // записывеам в словарь индекс столбца с именами

                if(local.Count == 1) // если выбрано только только имя (т.е. столбцы с данными вообще не выбраны)
                {
                    throw new Exception("Отметьте нужные столбцы!");
                }
                if (checkedListBox1.GetItemChecked(NameIndex)) // если столбец имен входит в выбранные столбцы в листчекбокс
                {
                    throw new Exception("Столбец имен присутствует а столбцах с данными!");
                }
                
                MainForm.setColumnsList(local); // отдаем словарь в главную форму
                Dispose(); // закрываем форму. используется этот метод, а не Close(), так как на Close() навешан обработчик
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /***
             * отмечаем/снимаем значения чекбоксов всех,
             * кроме того, который выбран как столбец имен
            ***/

            NameIndex = comboBox1.SelectedIndex; // получаем индекс столбца с именами

            checkedListBox1.SetItemChecked(NameIndex, false); // убираем все галочки

            for (int i = 0; i < checkedListBox1.Items.Count; i++) // идем по всем элементам checkedListBoxа
                if (i != NameIndex) // если это не столбец с именами
                {
                    checkedListBox1.SetItemCheckState(i, (state ? CheckState.Checked : CheckState.Unchecked)); // отмечаем или снимаем
                }
            state = !state;
        }

        private void ColumnsForAnalysis_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;
            e.Cancel = DialogResult.Yes != MessageBox.Show("Прервать операцию?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (e.Cancel == false)
            {
                // если операция прервана, отдаем пустой словарь
                MainForm.setColumnsList(new Dictionary<string,int>());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }  
        
    }
}
