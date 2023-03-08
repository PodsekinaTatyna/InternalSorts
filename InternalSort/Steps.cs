using InternalSort.Sorting;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace InternalSort
{
    public partial class Steps : Form
    {
        bool[] chekedSorts;
        SortSteps[] sortSteps;

        public Steps(bool[] chekedSorts, SortSteps[] sortSteps)
        {
            InitializeComponent();
            this.chekedSorts = chekedSorts;
            this.sortSteps = sortSteps;
        }

        private void PrintSteps(string nameSort,int i)
        {
            TextBox SortsStepsBox = new TextBox();
            SortsStepsBox.Text = "Всего шагов: " + sortSteps[i].Count + Environment.NewLine + sortSteps[i].Text;
            SortsStepsBox.Multiline = true;
            SortsStepsBox.ScrollBars = ScrollBars.Both;
            SortsStepsBox.Size = new Size(405, 445);
            TabPage SortsPages = new TabPage(nameSort);
            SortsPages.Controls.Add(SortsStepsBox);
            tabControl1.TabPages.Add(SortsPages);
        }

        private void Steps_Load(object sender, EventArgs e)
        {
            try
            {
                if (chekedSorts[0] == true)
                {
                    PrintSteps("Пирамидальная сортировка", 0);
                }

                if (chekedSorts[1] == true)
                {
                    PrintSteps("Сортировка Шелла", 1);
                }

                if (chekedSorts[2] == true)
                {
                    PrintSteps("Шейкер сортировка", 2);
                }
                if (chekedSorts[3] == true)
                {
                    PrintSteps("Сортировка вставками", 3);
                }

                if (chekedSorts[4] == true)
                {
                    PrintSteps("Сортировка обменом", 4);
                }

                if (chekedSorts[5] == true)
                {
                    PrintSteps("Быстрая сортировка с рекурсией", 5);
                }

                if (chekedSorts[6] == true)
                {
                    PrintSteps("Быстрая сортировка без рекурсиии", 6);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
