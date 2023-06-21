using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CP_Session
{
    public partial class FormStudent : Form
    {
        Student student;
        Session<Student> session;

        public FormStudent(Student _student, Session<Student> _session)
        {
            if (_student == null)
                return;

            InitializeComponent();

            this.student = _student;
            this.Text += $" {_student.FIO}";
            this.session = _session;

            LoadDataStudent();
        }

        private void LoadDataStudent()
        {
            textBoxIdStudent.Text = student.Id.ToString();
            textBoxNameStudent.Text = student.Name;
            textBoxPatronymicStudent.Text = student.Patronymic;
            textBoxSurnameStudent.Text = student.Surname;
            textBoxDateOfBirth.Text = student.DateOfBirth.ToShortDateString();
            textBoxGroup.Text = student.Group;
            textBoxFormOfStudy.Text = student.FormOfStudy;
            textBoxYearOfStudy.Text = student.YearOfStudy.ToString();
            textBoxSpecialty.Text = student.Specialty;
            textBoxFaculty.Text = student.Faculty;

            listViewDisciplines.Groups.Clear();
            for (int i = 1; i <= 12; i++)
                listViewDisciplines.Groups.Add(i.ToString(), "Семестр " + i);
            UpdateDisciplines();
        }

        private void UpdateDisciplines()
        {
            listViewDisciplines.Items.Clear();
            foreach (var discipline in student.Disciplines)
            {
                var item = listViewDisciplines.Items.Add(discipline.Name);
                item.Group = listViewDisciplines.Groups[discipline.Semester.ToString()];
                item.SubItems.Add(discipline.Score);
            }
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student();
            newStudent.Group = student.Group;
            newStudent.FormOfStudy = student.FormOfStudy;
            newStudent.YearOfStudy = student.YearOfStudy;
            newStudent.Specialty = student.Specialty;
            newStudent.Faculty = student.Faculty;

            var formEditStudent = new FormEditStudent(newStudent);
            if (formEditStudent.ShowDialog() == DialogResult.OK)
            {
                newStudent = formEditStudent.NewStudent;
                if (checkBoxAddDisciplines.Checked)
                {
                    newStudent.Disciplines.AddRange(student.Disciplines);
                }
                session.AddStudent(newStudent);
                student = newStudent;
                LoadDataStudent();
            }
        }

        private void buttonModifyStudent_Click(object sender, EventArgs e)
        {
            List<Discipline> tempDisciplines = new List<Discipline>();
            tempDisciplines = student.Disciplines;
            var formEditStudent = new FormEditStudent(student);
            if (formEditStudent.ShowDialog() == DialogResult.OK)
            {
                if (session.Students.Count > 0)
                {
                    int indexStudent = session.Students.IndexOf(student);
                    student = formEditStudent.NewStudent;
                    student.Disciplines.AddRange(tempDisciplines);
                    session.Students[indexStudent] = student;
                    LoadDataStudent();
                }
                else
                {
                    student = formEditStudent.NewStudent;
                    session.AddStudent(student);
                    LoadDataStudent();
                }
                
            }
        }

        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Внимание! " + "\n" + "Вы хотите удалить все данные о студенте ?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                session.RemoveStudent(student);
                Close();
            }
        }

        private void buttonCloseInfoStudent_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddDiscipline_Click(object sender, EventArgs e)
        {
            var formGrade = new FormGrade();
            if (formGrade.ShowDialog() == DialogResult.OK)
            {
                student.Disciplines.Add(formGrade.Discipline);
                UpdateDisciplines();
            }
        }

        private void buttonModifyDiscipline_Click(object sender, EventArgs e)
        {
            if (listViewDisciplines.Items.Count > 0)
            {
                var formGrade = new FormGrade(student.Disciplines[listViewDisciplines.FocusedItem.Index]);
                formGrade.ShowDialog();
                UpdateDisciplines();
            }
        }

        private void buttonDeleteDiscipline_Click(object sender, EventArgs e)
        {
            if (listViewDisciplines.FocusedItem != null)
            {
                student.Disciplines.RemoveAt(listViewDisciplines.FocusedItem.Index);
                UpdateDisciplines();
            }
        }
    }
}
