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
    public partial class ABC_XYZtable : Form
    {
        private MainForm MainForm;

        public ABC_XYZtable()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // открываем эту форму по центру
         }

        public ABC_XYZtable(MainForm MainForm)
        {
            this.StartPosition = FormStartPosition.CenterScreen; // открываем эту форму по центру
            this.MainForm = MainForm;
            InitializeComponent();
        }

        private void ABC_XYZtable_Load(object sender, EventArgs e)
        {
            List<Product> local = MainForm.getProductsList();// получаем список продуктов из главной формы

            local = Product.SortList(local, "number"); // сортируем по номеру

            for (int i = 0; i < local.Count; i++)// каждый из продктов, в зависимости от группы, запихиваем в определенное окошко
            {
                if (local[i].groupABC == "A")
                {
                    if (local[i].groupXYZ == "X")
                    {
                        listBoxAX.Items.Add(local[i].number.ToString() + ". " + local[i].name);
                    }
                    if (local[i].groupXYZ == "Y")
                    {
                        listBoxAY.Items.Add(local[i].number.ToString() + ". " + local[i].name);
                    }
                    if (local[i].groupXYZ == "Z")
                    {
                        listBoxAZ.Items.Add(local[i].number.ToString() + ". " + local[i].name);
                    }
                }

                if (local[i].groupABC == "B")
                {
                    if (local[i].groupXYZ == "X")
                    {
                        listBoxBX.Items.Add(local[i].number.ToString() + ". " + local[i].name);
                    }
                    if (local[i].groupXYZ == "Y")
                    {
                        listBoxBY.Items.Add(local[i].number.ToString() + ". " + local[i].name);
                    }
                    if (local[i].groupXYZ == "Z")
                    {
                        listBoxBZ.Items.Add(local[i].number.ToString() + ". " + local[i].name);
                    }
                }
                if (local[i].groupABC == "C")
                {
                    if (local[i].groupXYZ == "X")
                    {
                        listBoxCX.Items.Add(local[i].number.ToString() + ". " + local[i].name);
                    }
                    if (local[i].groupXYZ == "Y")
                    {
                        listBoxCY.Items.Add(local[i].number.ToString() + ". " + local[i].name);
                    }
                    if (local[i].groupXYZ == "Z")
                    {
                        listBoxCZ.Items.Add(local[i].number.ToString() + ". " + local[i].name);
                    }
                }
            }
        }
    }
}
