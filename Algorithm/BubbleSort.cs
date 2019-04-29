using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class BubbleSort<T> : AlgorithmBase<T> where T: IComparable
    {
        public BubbleSort(IEnumerable<T> items) : base(items) { }

        public BubbleSort() { }

        protected override void MakeSort()
        {
            var count = Items.Count;

            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < count - j - 1; i++)
                {
                    var a = Items[i];
                    var b = Items[i + 1];

                    if (Compare(a, b) == 1)
                    {
                        Swop(i, i + 1);
                    }
                }
            }
        }
    }
}
