using System;

namespace StdTask.Views
{
    public abstract class View
    {
        /* Сортируемая ли колонка */
        public abstract bool IsSortable { get; }
        /* Ввалдность введёных данных */
        public object IsValid(object value)
        {
            var strBuf = Convert.ToString(value);

            if (string.IsNullOrEmpty(strBuf))
                throw new Exception($"Необходимо ввести значение!");

            if (string.IsNullOrWhiteSpace(strBuf))
                throw new Exception($"Значение не может состоять из символов-разделителей!");

            strBuf = strBuf.Trim(); // удаление символов-разделителей из начала и конца строки

            return ValidView(strBuf);
        }
        /* Абстрактная функция средней оценки студента */
        public abstract decimal AvarageMarkStudent(object value);
        /* Абстрактная функция проверки на валидность */
        protected abstract object ValidView(string value);
    }
}
