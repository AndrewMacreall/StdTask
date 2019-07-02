using StdTask.Enums;
using StdTask.Sorts;

namespace StdTask.Data
{
    public struct SortData
    {
        public SortData(int index, SortType type, Sort method, bool debug)
        {
            Index = index;
            Type = type;
            Method = method;
            Debug = debug;
        }

        public int Index { get; private set; }
        public SortType Type { get; private set; }
        public Sort Method { get; private set; }
        public bool Debug { get; private set; }
    }
}
