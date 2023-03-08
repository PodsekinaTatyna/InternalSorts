namespace InternalSort
{
    partial class ProgramWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.input = new System.Windows.Forms.Button();
            this.saveFaile = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.sorting = new System.Windows.Forms.Button();
            this.elementBox = new System.Windows.Forms.TextBox();
            this.arrayBox = new System.Windows.Forms.TextBox();
            this.steps = new System.Windows.Forms.Button();
            this.heapSortCheck = new System.Windows.Forms.CheckBox();
            this.shellSortCheck = new System.Windows.Forms.CheckBox();
            this.shakerSortCheck = new System.Windows.Forms.CheckBox();
            this.insertionSortCheck = new System.Windows.Forms.CheckBox();
            this.selectionSortCheck = new System.Windows.Forms.CheckBox();
            this.quickSortWithRecursionCheck = new System.Windows.Forms.CheckBox();
            this.quickSortWithoutRecursionCheck = new System.Windows.Forms.CheckBox();
            this.sortingArrayBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "сохранить как..";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input.Location = new System.Drawing.Point(357, 336);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(111, 35);
            this.input.TabIndex = 1;
            this.input.Text = "Ввод";
            this.input.UseVisualStyleBackColor = false;
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // saveFaile
            // 
            this.saveFaile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveFaile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveFaile.Location = new System.Drawing.Point(357, 119);
            this.saveFaile.Name = "saveFaile";
            this.saveFaile.Size = new System.Drawing.Size(91, 36);
            this.saveFaile.TabIndex = 2;
            this.saveFaile.Text = "Сохранить";
            this.saveFaile.UseVisualStyleBackColor = false;
            this.saveFaile.Click += new System.EventHandler(this.saveFaile_Click);
            // 
            // openFile
            // 
            this.openFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.openFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openFile.Location = new System.Drawing.Point(357, 53);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(91, 33);
            this.openFile.TabIndex = 3;
            this.openFile.Text = "Открыть";
            this.openFile.UseVisualStyleBackColor = false;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // sorting
            // 
            this.sorting.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sorting.Location = new System.Drawing.Point(93, 398);
            this.sorting.Name = "sorting";
            this.sorting.Size = new System.Drawing.Size(102, 40);
            this.sorting.TabIndex = 4;
            this.sorting.Text = "Сортировать";
            this.sorting.UseVisualStyleBackColor = false;
            this.sorting.Click += new System.EventHandler(this.sorting_Click);
            // 
            // elementBox
            // 
            this.elementBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.elementBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elementBox.Location = new System.Drawing.Point(340, 283);
            this.elementBox.Multiline = true;
            this.elementBox.Name = "elementBox";
            this.elementBox.Size = new System.Drawing.Size(143, 36);
            this.elementBox.TabIndex = 7;
            this.elementBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.elementBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.element_KeyPress);
            // 
            // arrayBox
            // 
            this.arrayBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.arrayBox.Location = new System.Drawing.Point(12, 233);
            this.arrayBox.Multiline = true;
            this.arrayBox.Name = "arrayBox";
            this.arrayBox.ReadOnly = true;
            this.arrayBox.Size = new System.Drawing.Size(309, 26);
            this.arrayBox.TabIndex = 8;
            // 
            // steps
            // 
            this.steps.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.steps.Enabled = false;
            this.steps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.steps.Location = new System.Drawing.Point(291, 398);
            this.steps.Name = "steps";
            this.steps.Size = new System.Drawing.Size(124, 40);
            this.steps.TabIndex = 9;
            this.steps.Text = "Посмотреть шаги";
            this.steps.UseVisualStyleBackColor = false;
            this.steps.Click += new System.EventHandler(this.steps_Click);
            // 
            // heapSortCheck
            // 
            this.heapSortCheck.AutoSize = true;
            this.heapSortCheck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.heapSortCheck.Location = new System.Drawing.Point(12, 46);
            this.heapSortCheck.Name = "heapSortCheck";
            this.heapSortCheck.Size = new System.Drawing.Size(170, 17);
            this.heapSortCheck.TabIndex = 10;
            this.heapSortCheck.Text = "Пирамидальная сортировка";
            this.heapSortCheck.UseVisualStyleBackColor = false;
            // 
            // shellSortCheck
            // 
            this.shellSortCheck.AutoSize = true;
            this.shellSortCheck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.shellSortCheck.Location = new System.Drawing.Point(12, 69);
            this.shellSortCheck.Name = "shellSortCheck";
            this.shellSortCheck.Size = new System.Drawing.Size(122, 17);
            this.shellSortCheck.TabIndex = 11;
            this.shellSortCheck.Text = "Сортировка Шелла";
            this.shellSortCheck.UseVisualStyleBackColor = false;
            // 
            // shakerSortCheck
            // 
            this.shakerSortCheck.AutoSize = true;
            this.shakerSortCheck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.shakerSortCheck.Location = new System.Drawing.Point(12, 92);
            this.shakerSortCheck.Name = "shakerSortCheck";
            this.shakerSortCheck.Size = new System.Drawing.Size(127, 17);
            this.shakerSortCheck.TabIndex = 12;
            this.shakerSortCheck.Text = "Шейкер сортировка";
            this.shakerSortCheck.UseVisualStyleBackColor = false;
            // 
            // insertionSortCheck
            // 
            this.insertionSortCheck.AutoSize = true;
            this.insertionSortCheck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.insertionSortCheck.Location = new System.Drawing.Point(12, 115);
            this.insertionSortCheck.Name = "insertionSortCheck";
            this.insertionSortCheck.Size = new System.Drawing.Size(144, 17);
            this.insertionSortCheck.TabIndex = 13;
            this.insertionSortCheck.Text = "Сортировка вставками";
            this.insertionSortCheck.UseVisualStyleBackColor = false;
            // 
            // selectionSortCheck
            // 
            this.selectionSortCheck.AutoSize = true;
            this.selectionSortCheck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.selectionSortCheck.Location = new System.Drawing.Point(12, 138);
            this.selectionSortCheck.Name = "selectionSortCheck";
            this.selectionSortCheck.Size = new System.Drawing.Size(135, 17);
            this.selectionSortCheck.TabIndex = 14;
            this.selectionSortCheck.Text = "Сортировка обменом";
            this.selectionSortCheck.UseVisualStyleBackColor = false;
            // 
            // quickSortWithRecursionCheck
            // 
            this.quickSortWithRecursionCheck.AutoSize = true;
            this.quickSortWithRecursionCheck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.quickSortWithRecursionCheck.Location = new System.Drawing.Point(12, 161);
            this.quickSortWithRecursionCheck.Name = "quickSortWithRecursionCheck";
            this.quickSortWithRecursionCheck.Size = new System.Drawing.Size(197, 17);
            this.quickSortWithRecursionCheck.TabIndex = 15;
            this.quickSortWithRecursionCheck.Text = "Быстрая сортировка с рекурсией";
            this.quickSortWithRecursionCheck.UseVisualStyleBackColor = false;
            // 
            // quickSortWithoutRecursionCheck
            // 
            this.quickSortWithoutRecursionCheck.AutoSize = true;
            this.quickSortWithoutRecursionCheck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.quickSortWithoutRecursionCheck.Location = new System.Drawing.Point(12, 184);
            this.quickSortWithoutRecursionCheck.Name = "quickSortWithoutRecursionCheck";
            this.quickSortWithoutRecursionCheck.Size = new System.Drawing.Size(203, 17);
            this.quickSortWithoutRecursionCheck.TabIndex = 16;
            this.quickSortWithoutRecursionCheck.Text = "Быстрая сортировка без рекурсии";
            this.quickSortWithoutRecursionCheck.UseVisualStyleBackColor = false;
            // 
            // sortingArrayBox
            // 
            this.sortingArrayBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sortingArrayBox.Location = new System.Drawing.Point(12, 283);
            this.sortingArrayBox.Multiline = true;
            this.sortingArrayBox.Name = "sortingArrayBox";
            this.sortingArrayBox.ReadOnly = true;
            this.sortingArrayBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sortingArrayBox.Size = new System.Drawing.Size(309, 99);
            this.sortingArrayBox.TabIndex = 17;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Выберите файл";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 39);
            this.label1.TabIndex = 18;
            this.label1.Text = "Введите число последова-\r\nтельности и нажмите \"Ввод\" \r\nили \"ENTER\" :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Начальная последовательность:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Отсортированная последовательность:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Выберите одну или более сортировок:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(9, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 171);
            this.panel1.TabIndex = 22;
            // 
            // ProgramWindow
            // 
            this.AcceptButton = this.input;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortingArrayBox);
            this.Controls.Add(this.quickSortWithoutRecursionCheck);
            this.Controls.Add(this.quickSortWithRecursionCheck);
            this.Controls.Add(this.selectionSortCheck);
            this.Controls.Add(this.insertionSortCheck);
            this.Controls.Add(this.shakerSortCheck);
            this.Controls.Add(this.shellSortCheck);
            this.Controls.Add(this.heapSortCheck);
            this.Controls.Add(this.steps);
            this.Controls.Add(this.arrayBox);
            this.Controls.Add(this.elementBox);
            this.Controls.Add(this.sorting);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.saveFaile);
            this.Controls.Add(this.input);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(511, 489);
            this.MinimumSize = new System.Drawing.Size(511, 489);
            this.Name = "ProgramWindow";
            this.Text = "Методы внутренней сортировки";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.Button saveFaile;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button sorting;
        private System.Windows.Forms.TextBox elementBox;
        private System.Windows.Forms.TextBox arrayBox;
        private System.Windows.Forms.Button steps;
        private System.Windows.Forms.CheckBox heapSortCheck;
        private System.Windows.Forms.CheckBox shellSortCheck;
        private System.Windows.Forms.CheckBox shakerSortCheck;
        private System.Windows.Forms.CheckBox insertionSortCheck;
        private System.Windows.Forms.CheckBox selectionSortCheck;
        private System.Windows.Forms.CheckBox quickSortWithRecursionCheck;
        private System.Windows.Forms.CheckBox quickSortWithoutRecursionCheck;
        private System.Windows.Forms.TextBox sortingArrayBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}