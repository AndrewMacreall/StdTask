namespace StdTask.Views
{
    class PriorityView : View
    {
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
            return value;
        }
    }
}
