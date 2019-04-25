using System;

namespace Algorithm
{
    public class CocktailSort<T> : AlgorithmBase<T> where T: IComparable
    {
        public override void Sort()
        {
            int left = 0;
            int right = Items.Count - 1;

            while(left < right)
            {
                for(int i = left; i < right; i++)
                {
                    if(Items[i].CompareTo(Items[i+1]) == 1)
                    {
                        Swop(i, i + 1);
                    }
                }
                right--;

                for(int i = right; i > left; i--)
                {
                    if(Items[i].CompareTo(Items[i - 1]) == -1)
                    {
                        Swop(i, i - 1);
                    }
                }
                left++;
            }
        }
    }
}
