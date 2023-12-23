using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Tyuiu.SabarovDA.Sprint7.Task7.V2
{
    public partial class FormProject_SDA : Form
    {
        public FormProject_SDA()
        {
            InitializeComponent();
            DataTable dataTable = new DataTable();
        }

        private void button2_Click(object sender, EventArgs e)
            {
            // Получаем значения из текстовых полей
            string num = textBoxNum_SDA.Text;
            string fio = textBoxFIO_SDA.Text;
            string address = textBoxAdres_SDA.Text;
            string phone = textBoxPhone_SDA.Text;
            string cash = textBoxCash_SDA.Text;

            // Проверка наличия данных в текстовых полях
            if (string.IsNullOrEmpty(num) || string.IsNullOrEmpty(fio) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(cash))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Добавляем новую строку в DataGridView
            dataGridViewRes_SDA.Rows.Add(num, fio, address, phone, cash);

            // Очищаем текстовые поля после добавления данных
            ClearTextBoxes();

            // Сохраняем данные в файл CSV

            // Обновляем график
            UpdateChart();
        }


        private void UpdateChart()
        {
            // Получаем данные из колонны "Выручка" в виде массива
            var revenueData = dataGridViewRes_SDA.Rows
                .Cast<DataGridViewRow>()
                .Select(row => Convert.ToDouble(row.Cells["Выручка"].Value))
                .ToArray();

            // Очищаем существующие точки на графике
            chartRes_SDA.Series["Series1"].Points.Clear();

            // Добавляем новые точки на график
            for (int i = 0; i < revenueData.Length; i++)
            {
                chartRes_SDA.Series["Series1"].Points.AddY(revenueData[i]);
            }
        }

        private void ClearTextBoxes()
        {
            textBoxNum_SDA.Clear();
            textBoxFIO_SDA.Clear();
            textBoxAdres_SDA.Clear();
            textBoxPhone_SDA.Clear();
            textBoxCash_SDA.Clear();
        }



            private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.Title = "Save CSV File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveToCsv(dataGridViewRes_SDA, saveFileDialog.FileName);
            }
        }

        private void SaveToCsv(DataGridView dataGridView, string filePath)
        {
            try
            {
                int columnsCount = dataGridView.Columns.Count;

                // Используем Encoding.GetEncoding("windows-1251") для указания кодировки
                using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.GetEncoding("windows-1251")))
                {
                    // Записываем заголовки столбцов
                    for (int i = 0; i < columnsCount; i++)
                    {
                        sw.Write(dataGridView.Columns[i].HeaderText);
                        if (i < columnsCount - 1)
                            sw.Write(",");
                    }
                    sw.WriteLine();

                    // Записываем данные
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        for (int i = 0; i < columnsCount; i++)
                        {
                            sw.Write(row.Cells[i].Value);
                            if (i < columnsCount - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();
                    }
                }

                MessageBox.Show("Таблица успешно сохранена в файл CSV.", "Сохранение завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInPut_SDA_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.Title = "Open CSV File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadCsvToDataGridView(openFileDialog.FileName);
            }
        }

        private void LoadCsvToDataGridView(string filePath)
        {
            try
            {
                dataGridViewRes_SDA.Rows.Clear();
                dataGridViewRes_SDA.Columns.Clear();
                DataTable dataTable = new DataTable();

                // Используем Encoding.GetEncoding("windows-1251") для указания кодировки
                using (StreamReader sr = new StreamReader(filePath, Encoding.GetEncoding("windows-1251")))
                {
                    // Читаем заголовки столбцов
                    string[] headers = sr.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }

                    // Читаем данные
                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dataRow[i] = rows[i];
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                }

                dataGridViewRes_SDA.DataSource = dataTable;

                MessageBox.Show("Данные успешно загружены из файла CSV.", "Загрузка завершена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_SDA_Click(object sender, EventArgs e)
        {
            ClearCellFormatting();

            string searchText = textBoxSearch_SDA.Text.ToLower(); // Приводим к нижнему регистру для регистронезависимого поиска

            // Проходим по каждой строке в DataGridView
            foreach (DataGridViewRow row in dataGridViewRes_SDA.Rows)
            {
                // Проходим по каждой ячейке в текущей строке
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Если текст в ячейке содержит введенную строку поиска
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        // Выделяем найденную ячейку (может потребоваться отключить этот блок, если не нужно выделять)
                        cell.Style.BackColor = Color.Yellow;
                    }
                }
            }
        }

        // Очистка выделения в DataGridView
        private void ClearCellFormatting()
        {
            foreach (DataGridViewRow row in dataGridViewRes_SDA.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = dataGridViewRes_SDA.DefaultCellStyle.BackColor;
                }
            }
        }

        private void buttonHelp_SDA_Click(object sender, EventArgs e)
        {
            FormAbout_SDA about = new FormAbout_SDA();
            about.ShowDialog();
        }
    }
}