using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CP_Session
{
    public partial class FormGrade : Form
    {
        public Discipline Discipline { get; set; }

        public FormGrade()
        {
            InitializeComponent();
        }

        public FormGrade(Discipline discipline)
        {
            InitializeComponent();

            Discipline = discipline;
            numericUpDownSemester.Value = Discipline.Semester;
            textBoxNameDiscipline.Text = Discipline.Name;
            comboBoxScore.Text = Discipline.Score;
        }

        private void btOKGrade_Click(object sender, EventArgs e)
        {
            errorProviderGrade.Clear();

            if (string.IsNullOrEmpty(textBoxNameDiscipline.Text))
            {
                errorProviderGrade.SetError(textBoxNameDiscipline, "Введите не пустое значение!");
                return;
            }

            if (textBoxNameDiscipline.Text.Length < 5)
            {
                errorProviderGrade.SetError(textBoxNameDiscipline, "Очень короткое название!");
                return;
            }

            if (textBoxNameDiscipline.ForeColor == Color.Red)
            {
                errorProviderGrade.SetError(textBoxNameDiscipline, "Введите правильное значение!");
                return;
            }

            if (comboBoxScore.SelectedItem == null)
            {
                errorProviderGrade.SetError(comboBoxScore, "Выберите оценку!");
                return;
            }

            if (Discipline == null)
            {
                Discipline = new Discipline((int)numericUpDownSemester.Value,
                                                textBoxNameDiscipline.Text,
                                                comboBoxScore.Text);
            }
            else
            {
                Discipline.Semester = (int)numericUpDownSemester.Value;
                Discipline.Name = textBoxNameDiscipline.Text;
                Discipline.Score = comboBoxScore.Text;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancelGrade_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBoxNameDiscipline_TextChanged(object sender, EventArgs e)
        {
            Regex regexMatchAnyCyrillicChar = new Regex(@"(.*[a-zA-Z0-9]+.*)|(^[а-я]+.*$)");
            MatchCollection regexMatches = regexMatchAnyCyrillicChar.Matches(textBoxNameDiscipline.Text);

            if (regexMatches.Count > 0)
            {
                errorProviderGrade.SetError(textBoxNameDiscipline, "Вводите название дисциплины в кириллице, с большой буквы. Латинские буквы, цифры и спецсимволы запрещены.");
                textBoxNameDiscipline.ForeColor = Color.Red;
            }
            else
            {
                textBoxNameDiscipline.ForeColor = SystemColors.WindowText;
                errorProviderGrade.Clear();
            }
        }

        private void comboBoxScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
