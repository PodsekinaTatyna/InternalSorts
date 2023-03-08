
namespace InternalSort.Sorting
{
    public class QuickSortWithRecursion : SortSteps
    {

        public override int[]  Sort(int[] array)
        {
            return Sort(array, 0, array.Length - 1);
        }
        public int[] Sort(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    Swap(ref array[i],ref array[j]);
                    i++;
                    j--;

                    Count++;
                    FixSteps(array);
                }
            }

            if (leftIndex < j)
                Sort(array, leftIndex, j);

            if (i < rightIndex)
                Sort(array, i, rightIndex);

            return array;
        }
    }
}
