using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class SelectionSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public SelectionSort(IEnumerable<T> items) : base(items) { }

        public SelectionSort() { }

        protected override void MakeSort()
        {
            var minIndex = 0;

            for(int i = 0; i < Items.Count - 1; i++)
            {
                minIndex = i;

                for(int j = i + 1; j < Items.Count; j++)
                {
                    if(Compare(Items[j], Items[minIndex]) == -1)
                    {
                        minIndex = j;
                    }
                }

                if (i != minIndex)
                {
                    Swop(i, minIndex);
                }
            }
        }
    }
}
