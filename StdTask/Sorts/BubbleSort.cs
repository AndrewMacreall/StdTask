using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StdTask.Enums;

namespace StdTask.Sorts
{
    class BubbleSort : Sort
    {
        /* Имя сортировки */
        public override string Name
        {
            get
            {
                return "Обменом";
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
        /* Сортировка по увеличению */
        private List<object[]> Increase(List<object[]> array, int index)
        {
            object[] temp;
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = i + 1; j < array.Count; j++)
                {
                    if (Convert.ToDecimal(array[i][index]) > Convert.ToDecimal(array[j][index]))
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }
        /* Сортировка по уменьшению */
        private List<object[]> Decrease(List<object[]> array, int index)
        {
            object[] temp;
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = i + 1; j < array.Count; j++)
                {
                    if (Convert.ToDecimal(array[i][index]) < Convert.ToDecimal(array[j][index]))
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }
    }
}
