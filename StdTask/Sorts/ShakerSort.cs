using StdTask.Enums;
using System;
using System.Collections.Generic;

namespace StdTask.Sorts
{
    class ShakerSort : Sort
    {
        /* Имя сортировки */
        public override string Name
        {
            get
            {
                return "Шейкерная";
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
            var left = 0;
            var right = array.Count - 1;
            object[] temp;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (Convert.ToDecimal(array[i][index]) > Convert.ToDecimal(array[i + 1][index]))
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }

                right--;

                for (int i = right; i > left; i--)
                {
                    if (Convert.ToDecimal(array[i - 1][index]) > Convert.ToDecimal(array[i][index]))
                    {
                        temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;
                    }
                }

                left++;
            }

            return array;
        }
        /* Сортировка по уменьшению */
        private List<object[]> Decrease(List<object[]> array, int index)
        {
            var left = 0;
            var right = array.Count - 1;
            object[] temp;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (Convert.ToDecimal(array[i][index]) < Convert.ToDecimal(array[i + 1][index]))
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }

                right--;

                for (int i = right; i > left; i--)
                {
                    if (Convert.ToDecimal(array[i - 1][index]) < Convert.ToDecimal(array[i][index]))
                    {
                        temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;
                    }
                }

                left++;
            }

            return array;
        }
    }
}
