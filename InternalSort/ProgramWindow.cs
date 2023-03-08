using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Export;
using InternalSort.Sorting;

namespace InternalSort
{
    
    public partial class ProgramWindow : Form
    {
        ExportData data = new ExportData();

        public bool[] CheckedSorts { get; set; }
        public SortSteps[] Steps { get; set; }

        public ProgramWindow()
        {
            InitializeComponent();
        }

        private void input_Click(object sender, EventArgs e)
        {
            if (sortingArrayBox.Text != "")
            {
                sortingArrayBox.Text = "";
                arrayBox.Text = "";
                steps.Enabled = false;
            }

            arrayBox.Text += " " + elementBox.Text;
            elementBox.Text = "";
        }

        private void element_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && (elementBox.Text != "" || e.KeyChar != 45))
            {
                e.Handled = true;
            }
        }

        private void steps_Click(object sender, EventArgs e)
        {
            if (sortingArrayBox.Text != "")
            {
                Steps steps = new Steps(CheckedSorts, Steps);
                steps.ShowDialog();
            }
        }

        private void sorting_Click(object sender, EventArgs e)
        {
            HeapSort heapSort = new HeapSort();
            ShellSort shellSort = new ShellSort();
            ShakerSort shakerSort = new ShakerSort();
            InsertionSort insertionSort = new InsertionSort();
            SelectionSort selectionSort = new SelectionSort();
            QuickSortWithRecursion quickSortWithRecursion = new QuickSortWithRecursion();
            QuickSortWithoutRecursion quickSortWithoutRecursion = new QuickSortWithoutRecursion();

            sortingArrayBox.Text = "";
            steps.Enabled = true;

            var checkedSorts = new bool[7];
            var soretsSteps = new SortSteps[7];

            try
            {
                if (arrayBox.Text == "")
                    throw new Exception("Введите последовательность или загрузите текстовый файл с ней");

                if (heapSortCheck.Checked == true)
                {
                    int[] array = arrayBox.Text.Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    Print("Пирамидальная сортировка", heapSort.Sort(array));
                    checkedSorts[0] = true;
                    soretsSteps[0] = heapSort;
                }

                if (shellSortCheck.Checked == true)
                {
                    int[] array = arrayBox.Text.Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    Print("Сортировка Шелла", shellSort.Sort(array));
                    checkedSorts[1] = true;
                    soretsSteps[1] = shellSort;
                }

                if (shakerSortCheck.Checked == true)
                {
                    int[] array = arrayBox.Text.Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    Print("Шейкер сортировка", shakerSort.Sort(array));
                    checkedSorts[2] = true;
                    soretsSteps[2] = shakerSort;
                }

                if (insertionSortCheck.Checked == true)
                {
                    int[] array = arrayBox.Text.Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    Print("Сортировка вставками", insertionSort.Sort(array));
                    checkedSorts[3] = true;
                    soretsSteps[3] = insertionSort;
                }

                if (selectionSortCheck.Checked == true)
                {
                    int[] array = arrayBox.Text.Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    Print("Сортировка обменом", selectionSort.Sort(array));
                    checkedSorts[4] = true;
                    soretsSteps[4] = selectionSort;
                }

                if (quickSortWithRecursionCheck.Checked == true)
                {
                    int[] array = arrayBox.Text.Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    Print("Быстрая сортировка с рекурсией", quickSortWithRecursion.Sort(array));
                    checkedSorts[5] = true;
                    soretsSteps[5] = quickSortWithRecursion;
                }

                if (quickSortWithoutRecursionCheck.Checked == true)
                {
                    int[] array = arrayBox.Text.Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    Print("Быстрая сортировка без рекурсиии", quickSortWithoutRecursion.Sort(array));
                    checkedSorts[6] = true;
                    soretsSteps[6] = quickSortWithoutRecursion;
                }

                CheckedSorts = checkedSorts;
                Steps = soretsSteps;

                if (sortingArrayBox.Text == "")
                    throw new Exception("Сначала выберите одну или более сортировок");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void Print(string name, int[] array)
        {
            sortingArrayBox.Text += name + " : ";

            for (int i = 0; i < array.Length; i++)
            {
                sortingArrayBox.Text += array[i] + " ";
            }

            sortingArrayBox.Text += Environment.NewLine;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            arrayBox.Text = data.OpenFaile();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.SaveFaile(sortingArrayBox);
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            arrayBox.Text = data.OpenFaile();
        }

        private void saveFaile_Click(object sender, EventArgs e)
        {
            data.SaveFaile(sortingArrayBox);
        }
    }
}
