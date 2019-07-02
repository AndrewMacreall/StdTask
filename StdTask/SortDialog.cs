using StdTask.Data;
using StdTask.Enums;
using StdTask.Sorts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StdTask
{
    public partial class SortDialog : Form
    {
        private HeaderData[] headers; // заголовки

        private List<int> sortableIndex = new List<int>();
        private SortType sortType = SortType.Inc; // тип сортировки
        private Sort[] sortMethod = new Sort[] { new ViborSort(), new BubbleSort(), new ShakerSort() }; // методы сортировки

        public SortData Sort
        {
            get
            {
                return new SortData(sortableIndex[sortColumnComboBox.SelectedIndex], sortType, sortMethod[sortMethodComboBox.SelectedIndex], debugCheckBox.Checked);
            }
        }

        public SortDialog(HeaderData[] headers)
        {
            InitializeComponent();

            this.headers = headers;

            for (int i = 0; i < headers.Length; i++)
            {
                if (headers[i].View.IsSortable) {
                    sortColumnComboBox.Items.Add(headers[i].Text);
                    sortableIndex.Add(i);
                }
            }

            for (int i = 0; i < sortMethod.Length; i++)
            {
                sortMethodComboBox.Items.Add(sortMethod[i].Name);
            }
        }
        /* Сортировка по возрастанию */
        private void increaseSortButton_Click(object sender, EventArgs e)
        {
            sortType = SortType.Inc;
            sortTypeLabel.Text = "Сортировка по: Возрастанию";
        }
        /* Сортировка по убыванию */
        private void decreaseSortButton_Click(object sender, EventArgs e)
        {
            sortType = SortType.Dec;
            sortTypeLabel.Text = "Сортировка по: Убыванию";
        }
        /* Перехват закрытия окна */
        private void SortDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
            {
                if (sortColumnComboBox.SelectedIndex < 0)
                {
                    MessageBox.Show(this, "Необходимо выбрать сортируемый столбец!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }

                if (sortMethodComboBox.SelectedIndex < 0)
                {
                    MessageBox.Show(this, "Необходимо выбрать метод сортировки!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }
    }
}
