using System;

namespace StdTask.Views
{
    class NameView : View
    {

        private readonly int lengthMin = 3;
        private readonly int lengthMax = 16;

        /* Проверка сортируемая ли колонка */
        /* true - сортируемая */
        /* false - не сортируемая */
        public override bool IsSortable
        {
            get
            {
                return false;
            }
        }

        /* Учитывать ли значение для расчёта среднего балла студента */
        /* value - учитывать */
        /* 0 - не учитывать */
        public override decimal AvarageMarkStudent(object value)
        {
            return 0;
        }

        protected override object ValidView(string value)
        {
            if (value.Length < lengthMin || value.Length > lengthMax)
                throw new Exception($"Значение меньше {lengthMin} или больше {lengthMax} символов!");

            return value;
        }
    }
}
