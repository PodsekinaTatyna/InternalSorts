
namespace InternalSort.Sorting
{
    public class ShellSort : SortSteps
    {
        public override int[] Sort(int[] array)
        {
            int j;
            int step = array.Length / 2;
            while (step > 0)
            {
                for (int i = 0; i <= (array.Length - step); i++)
                {
                    j = i;
                    while ((j >= step) && (array[j - step] > array[j]))
                    {
                        Swap(ref array[j], ref array[j - step]);
                        j -= step;

                        Count++;
                        FixSteps(array);
                    }
                }
                step = step / 2;
            }

            return array;
        }
    }
}
