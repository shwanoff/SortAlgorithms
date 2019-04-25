using System;

namespace Algorithm
{
    public class BubbleSort<T> : AlgorithmBase<T> where T: IComparable
    {
        protected override void MakeSort()
        {
            var count = Items.Count;

            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < count - j - 1; i++)
                {
                    var a = Items[i];
                    var b = Items[i + 1];

                    if (a.CompareTo(b) == 1)
                    {
                        Swop(i, i + 1);

                        ComparisonCount++;
                    }
                }
            }
        }
    }
}
