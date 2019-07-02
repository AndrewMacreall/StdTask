using StdTask.Enums;
using System;
using System.Collections.Generic;

namespace StdTask.Sorts
{
    class ViborSort : Sort
    {
        /* Имя сортировки */
        public override string Name
        {
            get
            {
                return "Выбором";
            }
        }
        /* Сортировка */
        public override List<object[]> Sorted(List<object[]> array, int index, SortType sortType)
        {
            if (sortType == SortType.Inc)
                array = Increase(array, index);
            else
                array = Decrease(array, index);

            return array;
        }
        /* Сортировка по возрастанию */
        private List<object[]> Increase(List<object[]> array, int index)
        {
            for (int i = 0; i < array.Count - 1; i++)
            {
                var value = Convert.ToDecimal(array[i][index]);
                var row = i;

                for (int j = i + 1; j < array.Count; j++)
                {
                    if (Convert.ToDecimal(array[j][index]) < value)
                    {
                        value = Convert.ToDecimal(array[j][index]);
                        row = j;
                    }
                }

                var temp = array[row];
                array[row] = array[i];
                array[i] = temp;
            }

            return array;
        }
        /* Сортировка по уменьшению */
        private List<object[]> Decrease(List<object[]> array, int index)
        {
            for (int i = 0; i < array.Count - 1; i++)
            {
                var value = Convert.ToDecimal(array[i][index]);
                var row = i;

                for (int j = i + 1; j < array.Count; j++)
                {
                    if (Convert.ToDecimal(array[j][index]) > value)
                    {
                        value = Convert.ToDecimal(array[j][index]);
                        row = j;
                    }
                }

                var temp = array[row];
                array[row] = array[i];
                array[i] = temp;
            }

            return array;
        }
    }
}
