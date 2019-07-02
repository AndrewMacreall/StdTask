/* Задача 1                                                      */
/* Программа рассчитывает средний балл студента и группы в целом */
/* Производит поиск по заданному шаблону и сортировку            */
/* Выполнил студент группы ИЭс-165-18                            */
/* Зуев Андрей Дмитриевич                                        */

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StdTask.Views;
using StdTask.Data;
using StdTask.Enums;
using StdTask.Properties;
using System.Diagnostics;

namespace StdTask
{
    public partial class MainForm : Form
    {

        private ReportManager reportManager; // отчёт

        public MainForm()
        {
            InitializeComponent();
            /* Каталог по умолчанию */
            reportOpenFileDialog.InitialDirectory = Application.StartupPath + "\\data";
            reportSaveFileDialog.InitialDirectory = Application.StartupPath + "\\data";
        }

        /* Очистка отчёта */
        private void ReportClear()
        {
            reportDataGridView.Rows.Clear();
            reportDataGridView.Columns.Clear();

            if (reportManager != null)
                reportManager.Dispose();

            reportManager = null;
        }
        /* Исключение */
        private void ReportManager_Exception(object sender, Events.ExceptionEventArgs e)
        {
            MessageBox.Show(this, e.Message, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #region FormEvents
        /* Вызывается при отображении формы */
        private void MainForm_Shown(object sender, EventArgs e)
        {
            ReportClear();
        }
        #endregion
        #region ToolStripMenu
        /* Создать проект */
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportClear();

            List<HeaderData> helperHeaders = new List<HeaderData>(); // временный список загловков
            /* Группа */
            HeaderData hGroup = new HeaderData()
            {
                ColumnType = ColumnType.TextBox,
                Name = "groupColumn",
                Text = "Группа",
                ReadOnly = false,
                Visible = true,
                View = new GroupView()

            };
            helperHeaders.Add(hGroup);
            /* Фамилия */
            HeaderData hSecondName = new HeaderData
            {
                ColumnType = ColumnType.TextBox,
                Name = "secondNameColumn",
                Text = "Фамилия",
                ReadOnly = false,
                Visible = true,
                View = new NameView()
            };
            helperHeaders.Add(hSecondName);
            /* Предметы */
            using (ReportSetupDialog dialog = new ReportSetupDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    helperHeaders.AddRange(dialog.GetSubjects);
                }
                else
                {
                    dialog.Dispose();
                    return;
                }
            }
            /* Сумма оценок */
            HeaderData hSubjectsSum = new HeaderData
            {
                ColumnType = ColumnType.TextBox,
                Name = "subtjectsSumColumn",
                Text = "Сумма оценок",
                ReadOnly = true,
                Visible = false,
                View = new SubjectsSumView()
            };
            helperHeaders.Add(hSubjectsSum);
            /* Количество оценок */
            HeaderData hSubjectsCount = new HeaderData
            {
                ColumnType = ColumnType.TextBox,
                Name = "subtjectsCountColumn",
                Text = "Количество предметов",
                ReadOnly = true,
                Visible = false,
                View = new SubjectsCountView()
            };
            helperHeaders.Add(hSubjectsCount);
            /* Приоритет */
            HeaderData hPerformance = new HeaderData()
            {
                ColumnType = ColumnType.CheckBox,
                Name = "priorityColumn",
                Text = "Вовремя",
                ReadOnly = false,
                Visible = true,
                View = new PriorityView()
            };
            helperHeaders.Add(hPerformance);
            /* Средний балл студента */
            HeaderData hStudentAvarageScore = new HeaderData
            {
                ColumnType = ColumnType.TextBox,
                Name = "studentAvarageScoreColumn",
                Text = "Средний балл студента",
                ReadOnly = true,
                Visible = true,
                View = new AverageMarkStudentView()
            };
            helperHeaders.Add(hStudentAvarageScore);
            /* Средний балл группы */
            HeaderData hGroupAvarageScore = new HeaderData
            {
                ColumnType = ColumnType.TextBox,
                Name = "groiupAvarageScoreColumn",
                Text = "Средний балл группы",
                ReadOnly = true,
                Visible = true,
                View = new AverageMarkGroupView()
            };
            helperHeaders.Add(hGroupAvarageScore);

            reportManager = new ReportManager(helperHeaders.ToArray(), ref reportDataGridView);
            reportManager.Exception += ReportManager_Exception;
        }        
        /* Открыть файл с базой */
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reportOpenFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            ReportClear();
            /* Загрузка данных */
            FileManager<ReportData> rFile = new FileManager<ReportData>(reportOpenFileDialog.FileName);
            var rData = rFile.OpenAllText();


            reportManager = new ReportManager(rData.Headers, rData.Contents, ref reportDataGridView);
            reportManager.Exception += ReportManager_Exception;

            /* Запоминаем последний открытый файл */
            Settings.Default.LastOpenFile = reportOpenFileDialog.FileName;
            Settings.Default.Save();
        }
        /* Закрыть текущий отчёт */
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportClear();
        }
        /* Сохранить базу в файл */
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reportManager == null)
                return;

            if (reportSaveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            var rData = new ReportData
            {
                Headers = reportManager.Headers,
                Contents = reportManager.Contents
            };

            FileManager<ReportData> rFile = new FileManager<ReportData>(reportSaveFileDialog.FileName);
            rFile.SaveAllText(rData);
        }
        /* Закрыть программу */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        /* Добавить данные */
        private void addDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reportManager == null)
                return;

            /* Вызов формы добавления данных */
            using (AddDataDialog dialog = new AddDataDialog(reportManager.Headers))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    reportManager.Add(dialog.Contents);
                }
            }
        }
        /* Удалить данные */
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reportManager != null)
                reportManager.RemoveSelected();
        }
        /* Поиск лучших */
        private void bestSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reportManager != null)
                reportManager.SearchStudents(SearchType.Best);
        }
        /* Поиск отличников */
        private void perfectSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reportManager != null)
                reportManager.SearchStudents(SearchType.Perfect);
        }
        /* Поиск хорошистов */
        private void goodSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reportManager != null)
                reportManager.SearchStudents(SearchType.Good);
        }
        /* Поиск троечников */
        private void passedSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reportManager != null)
                reportManager.SearchStudents(SearchType.Passed);
        }
        /* Поиск не сдавших */
        private void notPassedSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reportManager != null)
                reportManager.SearchStudents(SearchType.NotPassed);
        }
        /* Сбросить */
        private void resetSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reportManager != null) {
                
                reportManager.PrintHeaders();
                reportManager.PrintContents();
                reportDataGridView.ReadOnly = false;
                reportManager.isSorted = false;
            }

            
        }
        /* Сортировка */
        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reportManager != null)
            {
                using(SortDialog dialog = new SortDialog(reportManager.Headers))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        var sData = dialog.Sort;
                        var sWatch = new Stopwatch();

                        sWatch.Start();
                        reportManager.Sort(sData.Index, sData.Type, sData.Method);
                        sWatch.Stop();
                    
                        if (sData.Debug)
                            MessageBox.Show(this, string.Format(
                                "Времени затрачено на сортировку - {0}", sWatch.Elapsed),
                                "Информация",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    }
                }
            }
        }
        /* О программе */
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, string.Format(
                "Программа расчитывает средний балл студента и группы, выполняет поиск и сортировку студентов.\n\n\t\t\t\t\t" +
                "Версия 1.0\n\n\t\t" +
                "Зуев Андрей © 2019"),
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        #endregion
    }
}
