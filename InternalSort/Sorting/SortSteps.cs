using System;
using System.Windows.Forms;

namespace InternalSort.Sorting
{
    public abstract class SortSteps
    {
        public abstract int[] Sort(int[] array);

        public string Text { get; set; }

        public int Count { get; set; }

        protected void FixSteps(int[] array)
        {
            Text += "Шаг " + Count + Environment.NewLine;

            for (int i = 0; i < array.Length; i++)
            {
                Text += array[i] + "  ";
            }

            Text += Environment.NewLine;
        }

        protected void Swap(ref int firstElement, ref int secondElement)
        {
            var temp = firstElement;
            firstElement = secondElement;
            secondElement = temp;
        }

    }
}
