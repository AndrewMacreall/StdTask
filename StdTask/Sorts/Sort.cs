using StdTask.Enums;
using System.Collections.Generic;

namespace StdTask.Sorts
{
    public abstract class Sort
    {
        /* Название сортировки */
        public abstract string Name { get; }
        /* Сортировка */
        public abstract List<object[]> Sorted(List<object[]> array, int index, SortType sortType);
    }
}