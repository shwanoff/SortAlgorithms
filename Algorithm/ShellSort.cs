using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class ShellSort<T> : AlgorithmBase<T> where T: IComparable
    {
        protected override void MakeSort()
        {
            var step = Items.Count / 2;

            while(step > 0)
            {
                for(int i = step; i < Items.Count; i++)
                {
                    int j = i;
                    while((j >= step) && Compare(Items[j - step], Items[j]) == 1)
                    {
                        Swop(j - step, j);
                        j -= step;
                    }
                }

                step /= 2;
            }
        }
    }
}
