using System.Collections.Generic;

namespace InternalSort.Sorting
{
    public class QuickSortWithoutRecursion : SortSteps
    {
        Stack<int>  stack = new Stack<int>();
        int pivot;
        int pivotIndex = 0;
        int leftIndex;
        int rightIndex;

        public override int[] Sort(int[] array)
        {
            leftIndex = pivotIndex + 1;
            rightIndex = array.Length - 1;

            stack.Push(pivotIndex);//Вносим вссе елементы и правые и левые
            stack.Push(rightIndex);

            int leftIndexOfSubSet, rightIndexOfSubset;

            while (stack.Count > 0)
            {
                rightIndexOfSubset = stack.Pop();//удаляем и возвращяем правый и левый
                leftIndexOfSubSet = stack.Pop();

                leftIndex = leftIndexOfSubSet + 1;
                pivotIndex = leftIndexOfSubSet;
                rightIndex = rightIndexOfSubset;

                pivot = array[pivotIndex];

                if (leftIndex > rightIndex)
                    continue;

                while (leftIndex < rightIndex)
                {
                    while ((leftIndex <= rightIndex) && (array[leftIndex] <= pivot))
                        leftIndex++;    //увеличить вправо, чтобы найти больший элемент, чем pivot

                    while ((leftIndex <= rightIndex) && (array[rightIndex] >= pivot))
                        rightIndex--;//уменьшить вправо, чтобы найти меньший элемент, чем pivot

                    if (rightIndex >= leftIndex)   //если правый индекс больше, то только поменять местами
                    {
                        Swap(ref array[leftIndex], ref array[rightIndex]);

                        Count++;
                        FixSteps(array);
                    }
                }

                if (pivotIndex <= rightIndex)
                    if (array[pivotIndex] > array[rightIndex])
                    {
                        Swap(ref array[pivotIndex], ref array[rightIndex]);

                        Count++;
                        FixSteps(array);
                    }


                if (leftIndexOfSubSet < rightIndex)
                {
                    stack.Push(leftIndexOfSubSet);
                    stack.Push(rightIndex - 1);
                }

                if (rightIndexOfSubset > rightIndex)
                {
                    stack.Push(rightIndex + 1);
                    stack.Push(rightIndexOfSubset);
                }
            }
            return array;
        }
    }
}
