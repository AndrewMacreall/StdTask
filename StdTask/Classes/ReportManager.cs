using System;
using System.Windows.Forms;
using System.Collections.Generic;
using StdTask.Data;
using StdTask.Enums;
using StdTask.Events;
using StdTask.Sorts;

namespace StdTask.Views
{
    public class ReportManager
    {
        private DataGridView report; // отчёт

        public HeaderData[] Headers { get; private set; } // заголовки
        public List<object[]> Contents { get; private set; } // контент

        private Type prevView; // предыдущие значение вида заголовка
        private object prevCellValue; // предыдущие значение ячейки

        public bool isSorted = false;

        public event EventHandler<ExceptionEventArgs> Exception;

        /* Конструктор при создании отчёта */
        public ReportManager(HeaderData[] headers, ref DataGridView dataGridView)
        {
            report = dataGridView;
            Headers = headers;
            Contents = new List<object[]>();

            Init();
        }
        /* Конструктор при открытии отчёта */
        public ReportManager(HeaderData[] headers, List<object[]> contents, ref DataGridView dataGridView)
        {
            report = dataGridView;
            Headers = headers;
            Contents = contents;

            Init();
        }
        /* Инициализация */
        private void Init()
        {
            /* Отрисовка отчёта */
            PrintHeaders();
            PrintContents();
            /* Подпись на события */
            report.CellBeginEdit += Report_CellBeginEdit;
            report.CellEndEdit += Report_CellEndEdit;
            report.KeyUp += Report_KeyUp;
        }     
        /* Вызывается при запуске режима правки */
        private void Report_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (Headers[e.ColumnIndex].View != null)
                prevView = Headers[e.ColumnIndex].View.GetType();
            else
                prevView = null;

            prevCellValue = report[e.ColumnIndex, e.RowIndex].Value; // запоминаем значение перед редактированием
        }
        /* Вызывается при завершении режима правки */
        private void Report_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Headers[e.ColumnIndex].View != null)
                {
                    var value = report[e.ColumnIndex, e.RowIndex].Value;
                    report[e.ColumnIndex, e.RowIndex].Value = Headers[e.ColumnIndex].View.IsValid(value); // проверка на валидность и возвращение отредактированного значения
                }
                Contents[e.RowIndex][e.ColumnIndex] = report[e.ColumnIndex, e.RowIndex].Value;

                CalculateSubjectsSum(e.RowIndex, typeof(SubjectsSumView)); // пересчёт суммы предметов студента
                CalculateAvarageMarkStudent(e.RowIndex, typeof(AverageMarkStudentView)); // пересчёт среднего балла студента

                var group = Convert.ToString(GetValue(e.RowIndex, typeof(GroupView))); // получение группы студента, которому изменили данные
                CalculateAvarageMarkGroup(group, typeof(AverageMarkGroupView)); // пересчёт среднего значения группы

                if (prevView != null && Equals(prevView, typeof(GroupView)))
                    CalculateAvarageMarkGroup(Convert.ToString(prevCellValue), typeof(AverageMarkGroupView));
            }
            catch (Exception ex)
            {
                report[e.ColumnIndex, e.RowIndex].Value = prevCellValue;
                Exception?.Invoke(this, new ExceptionEventArgs(ex.Message));
            }
        }
        /* Вызывается в момент отпускания клавиши */
        private void Report_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                RemoveSelected();
        }
        /* Отрисовка заголовков */
        public void PrintHeaders()
        {
            report.Columns.Clear();
            foreach (HeaderData data in Headers)
            {
                var column = new DataGridViewColumn();

                switch (data.ColumnType)
                {
                    case ColumnType.TextBox:
                        column = new DataGridViewTextBoxColumn();
                        break;

                    case ColumnType.CheckBox:
                        column = new DataGridViewCheckBoxColumn();
                        break;
                }

                column.Name = data.Name;
                column.HeaderText = data.Text;
                column.ReadOnly = data.ReadOnly;
                column.Visible = data.Visible;

                report.Columns.Add(column);
            }
        }
        /* Отрисовка контента */
        public void PrintContents()
        {
            report.Rows.Clear();
            for (int i = 0; i < Contents.Count; i++) // строка
            {
                var row = report.Rows.Count; // последняя строка
                report.Rows.Add(); // новая строка в datagridview

                for (int j = 0; j < Contents[i].Length; j++)
                {
                    report[j, row].Value = Contents[i][j];
                }
            }
        }
        public void PrintContents(List<object[]> contents)
        {
            report.Rows.Clear();
            for (int i = 0; i < contents.Count; i++) // строка
            {
                var row = report.Rows.Count; // последняя строка
                report.Rows.Add(); // новая строка в datagridview

                for (int j = 0; j < contents[i].Length; j++)
                {
                    report[j, row].Value = contents[i][j];
                }
            }
        }
        /* Изменение данных */
        private void ChangeValue(int rowIndex, int columnIndex, object value)
        {
            report[columnIndex, rowIndex].Value = value;
            Contents[rowIndex][columnIndex] = value;
        }
        /* Изменение нескольких данных */
        private void ChangeValues(string group, Type destinationType, object value)
        {
            for (int rowIndex = 0; rowIndex < Contents.Count; rowIndex++)
            {
                var destinationIndex = 0;
                var isExists = false;

                for (int columnIndex = 0; columnIndex < Headers.Length; columnIndex++)
                {
                    if (Headers[columnIndex].View == null)
                        continue;

                    var currentType = Headers[columnIndex].View.GetType();

                    if (Equals(currentType, typeof(GroupView))) {
                        if (string.Equals(group, Convert.ToString(Contents[rowIndex][columnIndex])))
                            isExists = true;
                    }

                    if (Equals(currentType, destinationType))
                        destinationIndex = columnIndex;
                }

                if (isExists) {
                    report[destinationIndex, rowIndex].Value = value;
                    Contents[rowIndex][destinationIndex] = value;
                }
            }
        }
        /* Получить значение */
        private object GetValue(int rowIndex, Type destinationType)
        {
            object value = null;

            for (int columnIndex = 0; columnIndex < Headers.Length; columnIndex++)
            {
                if (Headers[columnIndex].View == null)
                    continue;

                if (Equals(Headers[columnIndex].View.GetType(), destinationType))
                    value = Contents[rowIndex][columnIndex];
            }

            return value;
        }
        /* Перевод из DataGridView в List */
        private List<object[]> ToList()
        {
            List<object[]> result = new List<object[]>();

            for (int i = 0; i < report.Rows.Count; i++)
            {
                object[] temp = new object[report.Columns.Count];
                for (int j = 0; j < report.Columns.Count; j++)
                    temp[j] = report[j, i].Value;
                result.Add(temp);
            }

            return result;
        }
        /* Расчёт суммы предметов студента */
        private void CalculateSubjectsSum(int rowIndex, Type avarageType)
        {
            decimal sum = 0.0m;
            var avarageIndex = -1;

            for (int columnIndex = 0; columnIndex < Headers.Length; columnIndex++)
            {
                if (Headers[columnIndex].View == null)
                    continue;

                if (Equals(Headers[columnIndex].View.GetType(), avarageType))
                    avarageIndex = columnIndex;

                var temp = Headers[columnIndex].View.AvarageMarkStudent(Contents[rowIndex][columnIndex]);

                sum += temp;
            }

            if (avarageIndex < 0)
                return;

            ChangeValue(rowIndex, avarageIndex, sum);
        }
        /* Расчёт количества предметов студента */
        private void CalculateSubjectsCount(int rowIndex, Type avarageType)
        {
            var count = 0;
            var avarageIndex = -1;

            for (int columnIndex = 0; columnIndex < Headers.Length; columnIndex++)
            {
                if (Headers[columnIndex].View == null)
                    continue;

                if (Equals(Headers[columnIndex].View.GetType(), avarageType))
                    avarageIndex = columnIndex;

                var temp = Headers[columnIndex].View.AvarageMarkStudent(Contents[rowIndex][columnIndex]);

                if (temp > 0)
                    count++;
            }

            if (avarageIndex < 0)
                return;

            ChangeValue(rowIndex, avarageIndex, count);
        }
        /* Средний балл студента */
        private void CalculateAvarageMarkStudent(int rowIndex, Type avarageType)
        {
            decimal sum = 0.0m;
            var count = 0;
            var avarageIndex = -1;

            for (int columnIndex = 0; columnIndex < Headers.Length; columnIndex++)
            {
                if (Headers[columnIndex].View == null)
                    continue;

                if (Equals(Headers[columnIndex].View.GetType(), avarageType))
                    avarageIndex = columnIndex;

                if (Equals(Headers[columnIndex].View.GetType(), typeof(SubjectsSumView)))
                    sum = Convert.ToDecimal(Contents[rowIndex][columnIndex]);

                if (Equals(Headers[columnIndex].View.GetType(), typeof(SubjectsCountView)))
                    count = Convert.ToInt32(Contents[rowIndex][columnIndex]);
            }

            if (avarageIndex < 0)
                return;

            var avarage = sum / count;


            ChangeValue(rowIndex, avarageIndex, avarage.ToString("F" + 2));
        }
        /* Средний балл группы */
        private void CalculateAvarageMarkGroup(string group, Type avarageType)
        {
            var sum = 0.0m;
            var count = 0;

            for (int rowIndex = 0; rowIndex < Contents.Count; rowIndex++)
            {
                var bufSum = 0.0m;
                var isExists = false;

                for (int columnIndex = 0; columnIndex < Headers.Length; columnIndex++)
                {
                    if (Headers[columnIndex].View == null)
                        continue;

                    var currentType = Headers[columnIndex].View.GetType();

                    if (Equals(currentType, typeof(GroupView)))
                    {
                        if (string.Equals(group, Convert.ToString(Contents[rowIndex][columnIndex]))) {
                            count++;
                            isExists = true;
                        }
                    }

                    if (Equals(currentType, typeof(AverageMarkStudentView)))
                        bufSum = Convert.ToDecimal(Contents[rowIndex][columnIndex]);
                }

                if (isExists)
                    sum += bufSum;
            }

            if (sum <= 0.0m || count <= 0)
                return;

            var avarage = sum / count;

            ChangeValues(group, avarageType, avarage.ToString("F" + 2));
        }
        /* Добавление данных */
        public void Add(object[,] contents)
        {
            
            for (int i = 0; i < contents.GetLength(0); i++) // строки
            {

                object[] content = new object[Headers.Length]; // значения контента по столбцам
                var rowIndex = report.Rows.Count; // последняя строка
                report.Rows.Add(); // новая строка в datagridview

                for (int j = 0; j < contents.GetLength(1); j++) // столбцы
                {
                    report[j, rowIndex].Value = contents[i, j];
                    content[j] = contents[i, j];
                }
                
                Contents.Add(content); // новая строка в контент
                CalculateSubjectsSum(rowIndex, typeof(SubjectsSumView)); // расчёт суммы оценок студента
                CalculateSubjectsCount(rowIndex, typeof(SubjectsCountView)); // расчёт количества оценок
                CalculateAvarageMarkStudent(rowIndex, typeof(AverageMarkStudentView)); // расчёт среднего балла студента
                CalculateAvarageMarkGroup(Convert.ToString(GetValue(rowIndex, typeof(GroupView))), typeof(AverageMarkGroupView)); // расчёт среднего балла группы
            }

        }
        /* Удаление данных */
        public void RemoveSelected()
        {
            if (isSorted)
                return;

            foreach (DataGridViewRow row in report.SelectedRows)
            {
                var group = Convert.ToString(GetValue(row.Index, typeof(GroupView)));
                Contents.RemoveAt(row.Index);
                report.Rows.RemoveAt(row.Index);
                CalculateAvarageMarkGroup(group, typeof(AverageMarkGroupView));
            }
        }
        /* Поиск студентов по результатам сессии */
        public void SearchStudents(SearchType list)
        {
            List<object[]> notPassedList = new List<object[]>();
            List<object[]> passedList = new List<object[]>();
            List<object[]> goodList = new List<object[]>();
            List<object[]> perfectList = new List<object[]>();
            List<object[]> bestList = new List<object[]>();

            report.ReadOnly = true;
            isSorted = true;

            for (int i = 0; i < Contents.Count; i++)
            {
                var isPerfect = 1;
                var isBest = false;

                for (int j = 0; j < Headers.Length; j++)
                {
                    if (Headers[j].View == null)
                        continue;

                    var value = Headers[j].View.AvarageMarkStudent(Contents[i][j]);

                    if (Equals(Headers[j].View.GetType(), typeof(PriorityView)))
                        isBest = Convert.ToBoolean(Contents[i][j]);

                    if (value == 2) {
                        notPassedList.Add(Contents[i]);
                        isPerfect = -1;
                        break;
                    }

                    if (value == 3) {
                        passedList.Add(Contents[i]);
                        isPerfect = -1;
                        break;
                    }

                    if (value == 4)
                        isPerfect = 0; 
                }

                if (isPerfect < 0)
                    continue;

                if (isPerfect > 0)
                {
                    if (isBest)
                        bestList.Add(Contents[i]);

                    perfectList.Add(Contents[i]);
                }
                else
                    goodList.Add(Contents[i]);
            }

            switch (list)
            {
                case SearchType.NotPassed:
                    PrintContents(notPassedList);
                    break;

                case SearchType.Passed:
                    PrintContents(passedList);
                    break;

                case SearchType.Good:
                    PrintContents(goodList);
                    break;

                case SearchType.Perfect:
                    PrintContents(perfectList);
                    break;

                case SearchType.Best:
                    PrintContents(bestList);
                    break;
            }
            
        }
        /* Сортировка */
        public void Sort(int columnIndex, SortType sortType, Sort sortMethod)
        {
            Sort sort = sortMethod;

            List<object[]> helperList = sort.Sorted(ToList(), columnIndex, sortType);

            PrintContents(helperList);
        }
        /* Очистка */
        public void Dispose()
        {
            Headers = null;
            Contents = null;
            /* Отписывание от событий */
            report.CellBeginEdit -= Report_CellBeginEdit;
            report.CellEndEdit -= Report_CellEndEdit;
            report.KeyUp -= Report_KeyUp;
        }
    }
}
