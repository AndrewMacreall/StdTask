using StdTask.Views;
using StdTask.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StdTask
{
    public partial class ReportSetupDialog : Form
    {
        public ReportSetupDialog()
        {
            InitializeComponent();
        }
        /* Возвращает выбранные предметы */
        public List<HeaderData> GetSubjects
        {
            get
            {
                List<HeaderData> result = new List<HeaderData>();

                for (int i = 0; i < selectedSubjectsListBox.Items.Count; i++)
                {
                    HeaderData header = new HeaderData()
                    {
                        ColumnType = Enums.ColumnType.TextBox,
                        Name = "subjectColumn" + i,
                        Text = (string)selectedSubjectsListBox.Items[i],
                        ReadOnly = false,
                        Visible = true,
                        View = new MarkView()
                    };
                    result.Add(header);
                }

                return result;
            }
        }
        /* Загрузка предметов */
        private void ReportSetupDialog_Load(object sender, EventArgs e)
        {
            FileManager<ContentData> subFile = new FileManager<ContentData>(Properties.Settings.Default.SubjectsPath);
            var subject = subFile.OpenAllText();

            foreach (string value in subject.Values) {
                subjectsListBox.Items.Add(value);
            }
        }
        /* Перехват закрытия окна */
        private void ReportSetupDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((e.CloseReason != CloseReason.UserClosing) && (selectedSubjectsListBox.Items.Count == 0))
            {
                MessageBox.Show(this, "Необходимо выбрать, как минимум один предмет!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
        /* Добавление предметов */
        private void addButton_Click(object sender, EventArgs e)
        {
            var subject = subjectsListBox.SelectedItem;

            if (subject != null) {
                subjectsListBox.Items.Remove(subject);
                selectedSubjectsListBox.Items.Add(subject);
            }
        }
        /* Удаление предмета */
        private void removeButton_Click(object sender, EventArgs e)
        {
            var subject = selectedSubjectsListBox.SelectedItem;

            if (subject != null)
            {
                selectedSubjectsListBox.Items.Remove(subject);
                subjectsListBox.Items.Add(subject);
            }
        }
    }
}
