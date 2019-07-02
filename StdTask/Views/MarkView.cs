using System;

namespace StdTask.Views
{
    class MarkView : View
    {
        private readonly byte markMin = 2;
        private readonly byte markMax = 5;

        /* Проверка сортируемая ли колонка */
        /* true - сортируемая */
        /* false - не сортируемая */
        public override bool IsSortable
        {
            get
            {
                return true;
            }
        }

        /* Учитывать ли значение для расчёта среднего балла студента */
        /* value - учитывать */
        /* 0 - не учитывать */
        public override decimal AvarageMarkStudent(object value)
        {
            return Convert.ToDecimal(value);
        }

        protected override object ValidView(string value)
        {
            byte byteBuf = Convert.ToByte(value);

            if (byteBuf < markMin || byteBuf > markMax)
                throw new Exception($"Значение меньше {markMin} или больше {markMax}!");

            return byteBuf;
        }
    }
}
