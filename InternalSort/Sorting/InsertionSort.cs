
namespace InternalSort.Sorting
{
    public class InsertionSort : SortSteps
    {

        public override int[] Sort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 0) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                    Count++;
                    FixSteps(array);
                }
                array[j] = key;

            }

            return array;
        }

    }
}
