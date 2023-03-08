
namespace InternalSort.Sorting
{
    public class SelectionSort : SortSteps
    {
        public override int[] Sort(int[] array)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                //поиск минимального числа
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                //обмен элементов
                Swap(ref array[min], ref array[i]);

                Count++;
                FixSteps(array);
            }

            return array;
        }

    }
}
