using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Export
{
    public class ExportData
    {

        public string OpenFaile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            string text = "";
            try
            {
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    openFileDialog.Title = "Открыть Файл ...";
                    openFileDialog.Filter = "Текстовые файлы|*.txt";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        StreamReader sr = File.OpenText(openFileDialog.FileName);
                        text = sr.ReadLine();
                        sr.Close();
                    }
                }
                else
                {
                    throw new Exception("Файл не выбран!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return text;
        }

        public void SaveFaile(TextBox textBox)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    saveFileDialog.Title = "Сохранить как ...";
                    saveFileDialog.Filter = "Текстовые файлы|*.txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter sw = File.CreateText(saveFileDialog.FileName);
                        string line;
                        for (int i = 0; i < textBox.Lines.Length; i++)
                        {
                            line = textBox.Lines[i].ToString();
                            sw.WriteLine(line);
                        }

                        sw.Close();
                    }
                    MessageBox.Show("Файл успешно сохранен!");
                }
                else
                    MessageBox.Show("Файл не был сохранен!");

            }       
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка сохранения файла!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
