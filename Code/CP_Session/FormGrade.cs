using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
            Regex regexMatchAnyCyrillicChar = new Regex(@"(.*[a-zA-Z0-9\W]+.*)|(^[а-я]+.*$)");
            MatchCollection regexMatches = regexMatchAnyCyrillicChar.Matches(textBoxNameDiscipline.Text);

            if (ValidateChildren(ValidationConstraints.Enabled)
                                 && errorProviderGrade.GetError(textBoxNameDiscipline).Length == 0
                                 && textBoxNameDiscipline.TextLength > 5
                                 && errorProviderGrade.GetError(comboBoxScore).Length == 0
                                 && comboBoxScore.SelectedItem != null
                                 && regexMatches.Count == 0)
            {
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
        }

        private void buttonCancelGrade_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBoxNameDiscipline_TextChanged(object sender, EventArgs e)
        {
            Regex regexMatchAnyCyrillicChar = new Regex(@"(.*[a-zA-Z0-9\W]+.*)|(^[а-я]+.*$)");

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

        private void comboBoxScore_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxScore.Text))
            {
                e.Cancel = true;
                errorProviderGrade.SetError(comboBoxScore, "Выберите оценку!");
            }
            else
            {
                e.Cancel = true;
                errorProviderGrade.Clear();
            }
        }

        private void textBoxNameDiscipline_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNameDiscipline.Text))
            {
                e.Cancel = true;
                errorProviderGrade.SetError(textBoxNameDiscipline, "Введите не пустое значение!");
            }
            else
            {
                e.Cancel = true;
                errorProviderGrade.Clear();
            }
        }

        private void comboBoxScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
