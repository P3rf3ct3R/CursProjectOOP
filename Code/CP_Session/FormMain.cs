using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_Session
{
    public partial class FormMain : Form
    {
        string fileName = "session.xml";
        Session<Student> ss;

        /// <summary>
        /// Инициализация главной формы
        /// </summary>
        public FormMain()
        {
            InitializeComponent();

            FormAbout f2 = new FormAbout();
            f2.ShowDialog();
        }

        private void UpdateComboBoxs()
        {
            var groupedStudents = ss.Students.GroupBy(s => s.Faculty)
                                             .OrderBy(f => f.Key)
                                             .Select(f => new
                                             {
                                                 Faculty = f.Key,
                                                 Specialties = f.GroupBy(s => s.Specialty)
                                                                .OrderBy(sp => sp.Key)
                                                                .Select(sp => new
                                                                {
                                                                    Specialty = sp.Key,
                                                                    Groups = sp.GroupBy(s => s.Group)
                                                                               .OrderBy(g => g.Key)
                                                                               .Select(g => new
                                                                               {
                                                                                   Group = g.Key,
                                                                                   Students = g.Select(s => s)
                                                                                               .OrderBy(s => s.FIO)
                                                                               })
                                                                })
                                             });
            foreach (var faculty in groupedStudents)
            {
                comboBoxFaculty.Items.Add(faculty.Faculty);
                foreach (var specialty in faculty.Specialties)
                {
                    comboBoxSpecialty.Items.Add(specialty.Specialty);
                    foreach (var group in specialty.Groups)
                    {
                        comboBoxGroup.Items.Add(group.Group);
                    }
                }
            }
        }

        /// <summary>
        /// Обновление и заполнение таблицы
        /// </summary>
        private void UpdateDataGridView()
        {
            dataGridViewSession.Rows.Clear();
            dataGridViewSession.Columns.Clear();
            dataGridViewSession.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Id", HeaderText = "ИДК", Width = 70 });
            dataGridViewSession.Columns.Add(new DataGridViewTextBoxColumn() { Name = "FIO", HeaderText = "Ф.И.О.", Width = 150 });
            dataGridViewSession.Columns.Add(new DataGridViewTextBoxColumn() { Name = "DateofBirth", HeaderText = "Дата рождения", Width = 100 });
            dataGridViewSession.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Group", HeaderText = "Группа", Width = 80 });
            dataGridViewSession.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Specialty", HeaderText = "Специальность", Width = 300 });
            dataGridViewSession.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Faculty", HeaderText = "Факультет", Width = 70 });
            dataGridViewSession.Columns.Add(new DataGridViewTextBoxColumn() { Name = "YearOfStudy", HeaderText = "Год обучения", Width = 30 });
            dataGridViewSession.Columns.Add(new DataGridViewTextBoxColumn() { Name = "FormOfStudy", HeaderText = "Форма обучения", Width = 80 });
            dataGridViewSession.Columns.Add(new DataGridViewTextBoxColumn() { Name = "AverageScore", HeaderText = "Средний балл", Width = 90, DefaultCellStyle = new DataGridViewCellStyle() { Format = "N3" } });
            foreach (Student stud in ss.Students)
            {
                dataGridViewSession.Rows.Add(stud.Id, stud.FIO, stud.DateOfBirth.ToShortDateString(), stud.Group, stud.Specialty, stud.Faculty, stud.YearOfStudy, stud.FormOfStudy, stud.AverageScore);
            }
        }

        /// <summary>
        /// Выбранный студент кликом на таблице
        /// </summary>
        Student SelectedStudent
        {
            get => dataGridViewSession.Rows.Count > 0 ? ss.Students[dataGridViewSession.CurrentRow.Index] : null;
        }

        /// <summary>
        /// Нажатие кнопки Сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dataGridViewSession.RowCount > 0)
            {
                if (MessageBox.Show(" Внимание! " + "\n" + "Вы хотите сохранить все данные в файле ?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        File.SaveToXml(fileName, ss);
                        MessageBox.Show("Успешно выполнена передача данных в файл.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(" Ошибка действия с файлом!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Пуста таблица!");
            }
        }

        /// <summary>
        /// Двойный клик на таблице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewSession_DoubleClick(object sender, EventArgs e)
        {
            if (SelectedStudent == null)
            {
                new FormStudent(new Student(), ss).ShowDialog();
            }
            else
            {
                new FormStudent(SelectedStudent, ss).ShowDialog();
            }
            UpdateDataGridView();
            UpdateComboBoxs();
        }

        /// <summary>
        /// Нажатие кнопки Загрузить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            fileName = openFileDialog1.FileName;
            //string fileText = System.IO.File.ReadAllText(filename);
            //textBox1.Text = fileText;
            ss = File.LoadFromXml(fileName);
            MessageBox.Show("Файл открыт");
            UpdateDataGridView();
            UpdateComboBoxs();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (dataGridViewSession.CurrentCell.ColumnIndex == 1 &&
                dataGridViewSession.CurrentCell.FormattedValue.ToString().Contains(textBoxSearch.Text))
            {
                i = dataGridViewSession.CurrentCell.RowIndex + 1;
            }
            while (i < dataGridViewSession.RowCount)
            {
                if (dataGridViewSession[1, i].FormattedValue.ToString().Contains(textBoxSearch.Text))
                {
                    dataGridViewSession.CurrentCell = dataGridViewSession[1, i];
                    return;
                }
                i++;
            }
            MessageBox.Show("Ничего не найдено!");
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            if (dataGridViewSession.RowCount > 0)
            {
                new FormReport(ss).ShowDialog();
            }
            else
            {
                MessageBox.Show("Пуста таблица!");
            }
        }

        private void comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedText = (string)comboBoxFaculty.SelectedItem;

            if (selectedText == "Все")
            {
                UpdateDataGridView();
            }
            else
            {
                var selectedGroup = ss.Students.Where(s => s.Faculty == selectedText).ToList();
                dataGridViewSession.Rows.Clear();
                foreach (Student stud in selectedGroup)
                {
                    dataGridViewSession.Rows.Add(stud.Id, stud.FIO, stud.DateOfBirth.ToShortDateString(), stud.Group, stud.Specialty, stud.Faculty, stud.YearOfStudy, stud.FormOfStudy, stud.AverageScore);
                }
            }
        }

        private void comboBoxSpecialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedText = (string)comboBoxSpecialty.SelectedItem;

            if (selectedText == "Все")
            {
                UpdateDataGridView();
            }
            else
            {
                var selectedGroup = ss.Students.Where(s => s.Specialty == selectedText).ToList();
                dataGridViewSession.Rows.Clear();
                foreach (Student stud in selectedGroup)
                {
                    dataGridViewSession.Rows.Add(stud.Id, stud.FIO, stud.DateOfBirth.ToShortDateString(), stud.Group, stud.Specialty, stud.Faculty, stud.YearOfStudy, stud.FormOfStudy, stud.AverageScore);
                }
            }
        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedText = (string)comboBoxGroup.SelectedItem;

            if (selectedText == "Все")
            {
                UpdateDataGridView();
            }
            else
            {
                var selectedGroup = ss.Students.Where(s => s.Group == selectedText).ToList();
                dataGridViewSession.Rows.Clear();
                foreach (Student stud in selectedGroup)
                {
                    dataGridViewSession.Rows.Add(stud.Id, stud.FIO, stud.DateOfBirth.ToShortDateString(), stud.Group, stud.Specialty, stud.Faculty, stud.YearOfStudy, stud.FormOfStudy, stud.AverageScore);
                }
            }
        }
    }
}
