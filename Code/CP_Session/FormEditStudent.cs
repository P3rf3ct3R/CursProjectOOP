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
    public partial class FormEditStudent : Form
    {
        public Student NewStudent { get; private set; }
        public FormEditStudent(Student _student)
        {
            InitializeComponent();

            NewStudent = new Student();
            textBoxIdStudent.Text = _student.Id.ToString();
            textBoxNameStudent.Text = _student.Name;
            textBoxPatronymicStudent.Text = _student.Patronymic;
            textBoxSurnameStudent.Text = _student.Surname;
            pickerDateOfBirth.Value = _student.DateOfBirth;
            textBoxGroup.Text = _student.Group;
            comboBoxFormOfStudy.Text = _student.FormOfStudy;
            numericYearOfStudy.Value = _student.YearOfStudy;
            textBoxSpecialty.Text = _student.Specialty;
            textBoxFaculty.Text = _student.Faculty;
        }

        private void buttonOKStudent_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                NewStudent.Id = int.Parse(textBoxIdStudent.Text);
                NewStudent.Name = textBoxNameStudent.Text;
                NewStudent.Patronymic = textBoxPatronymicStudent.Text;
                NewStudent.Surname = textBoxSurnameStudent.Text;
                NewStudent.DateOfBirth = pickerDateOfBirth.Value;
                NewStudent.Group = textBoxGroup.Text;
                NewStudent.FormOfStudy = comboBoxFormOfStudy.Text;
                NewStudent.YearOfStudy = (int)numericYearOfStudy.Value;
                NewStudent.Specialty = textBoxSpecialty.Text;
                NewStudent.Faculty = textBoxFaculty.Text;
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void buttonCancelStudent_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                e.Cancel = true;
                errorProviderStudent.SetError(sender as TextBox, "Введите не пустое значение!");
            }
            else
            {
                errorProviderStudent.Clear();
            }
        }
    }
}
