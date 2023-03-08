
namespace InternalSort.Sorting
{
    public class HeapSort : SortSteps
    {

        public override int[] Sort(int[] array)
        {
            int n = array.Length;

            // Построение кучи (перегруппируем массив)
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(array, n, i);

            // Один за другим извлекаем элементы из кучи
            for (int i = n - 1; i >= 0; i--)
            {
                // Перемещаем текущий корень в конец
                Swap(ref array[0], ref array[i]);
                Count++;
                FixSteps(array);
                // вызываем процедуру heapify на уменьшенной куче
                Heapify(array, i, 0);

                
            }

            return array;
        }

        // Процедура для преобразования в двоичную кучу поддерева с корневым узлом i, что является
        // индексом в arr[]. n - размер кучи
        private void Heapify(int[] array, int n, int i)
        {
            int largest = i;// Инициализируем наибольший элемент как корень

            int left = 2 * i + 1; // left = 2*i + 1
            int right = 2 * i + 2; // right = 2*i + 2

            // Если левый дочерний элемент больше корня
            if (left < n && array[left] > array[largest])
                largest = left;

            // Если правый дочерний элемент больше, чем самый большой элемент на данный момент
            if (right < n && array[right] > array[largest])
                largest = right;

            // Если самый большой элемент не корень
            if (largest != i)
            {
                int temp = array[i];
                array[i] = array[largest];
                array[largest] = temp;

                Count++;
                FixSteps(array);

                // Рекурсивно преобразуем в двоичную кучу затронутое поддерево
                Heapify(array, n, largest);
            }
        }

    }
}
