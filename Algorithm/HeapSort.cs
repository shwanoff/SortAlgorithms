using Algorithm.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class HeapSort<T> : AlgorithmBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            var heap = new Heap<T>(Items);
            var sorted = heap.Order();
            Items = sorted;
        }

    }
}
