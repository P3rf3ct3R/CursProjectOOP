using System;
using System.Drawing;
using System.Text.RegularExpressions;
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
            textBoxNameStudent.Focus();
        }

        private void buttonOKStudent_Click(object sender, EventArgs e)
        {
            errorProviderStudent.Clear();
            foreach (Control textBox in this.Controls)
            {
                if (textBox is TextBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        errorProviderStudent.SetError(textBox, "Введите не пустое значение!");
                        return;
                    }
                    if (textBox.ForeColor == Color.Red)
                    {
                        errorProviderStudent.SetError(textBox, "Введите правильное значение!");
                        return;
                    }
                }
            }

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

        private void buttonCancelStudent_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            Regex regexMatchAnyCyrillicChar = new Regex(@"(.*[0-9]+.*)|(^[а-яa-z]+.*$)");
            MatchCollection regexMatches = regexMatchAnyCyrillicChar.Matches((sender as TextBox).Text);

            if (regexMatches.Count > 0)
            {
                errorProviderStudent.SetError((sender as TextBox), "Вводите название дисциплины в кириллице, с большой буквы. Латинские буквы, цифры и спецсимволы запрещены.");
                (sender as TextBox).ForeColor = Color.Red;
            }
            else
            {
                (sender as TextBox).ForeColor = SystemColors.WindowText;
                errorProviderStudent.Clear();
            }
        }

        private void textBoxGroup_TextChanged(object sender, EventArgs e)
        {
            Regex regexMatchChar = new Regex(@"(^[0-9]{2}[А-ЯA-Z]\S)$");
            MatchCollection regexMatches = regexMatchChar.Matches(textBoxGroup.Text);

            if (regexMatches.Count > 0)
            {
                errorProviderStudent.SetError(textBoxGroup, "Вводите название группы.");
                textBoxGroup.ForeColor = Color.Red;
            }
            else
            {
                textBoxGroup.ForeColor = SystemColors.WindowText;
                errorProviderStudent.Clear();
            }
        }
    }
}
