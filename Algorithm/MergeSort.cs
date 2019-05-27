using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class MergeSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public MergeSort(IEnumerable<T> items) : base(items) { }

        public MergeSort() { }

        protected override void MakeSort()
        {
            var sorted = Sort(Items);
            for (int i = 0; i < sorted.Count; i++)
            {
                Set(i, sorted[i]);
            }
        }

        private List<T> Sort(List<T> items)
        {
            if(items.Count == 1)
            {
                return items;
            }

            var mid = items.Count / 2;

            var left = items.Take(mid).ToList();
            var right = items.Skip(mid).ToList();

            return Merge(Sort(left), Sort(right));
        }

        private List<T> Merge(List<T> left, List<T> right)
        {
            var length = left.Count + right.Count;
            var leftPointer = 0;
            var rightPointer = 0;

            var result = new List<T>(length);

            for(int i = 0; i < length; i++)
            {
                if(leftPointer < left.Count && rightPointer < right.Count)
                {
                    if(Compare(left[leftPointer], right[rightPointer]) == -1)
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }
                    else
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                }
                else
                {
                    if(rightPointer < right.Count)
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                    else
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }
                }
            }

            return result;
        }
    }
}
