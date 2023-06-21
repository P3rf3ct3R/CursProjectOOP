using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CP_Session
{
    public partial class FormReport : Form
    {
        List<Student> students;

        public FormReport(Session<Student> ss)
        {
            InitializeComponent();

            students = ss.Students;
            WriteReport();
        }

        private void WriteReport()
        {
            richTextBoxReport.Clear();
            var groupedStudents = students.GroupBy(s => s.Faculty)
                                          .Select(f => new
                                          {
                                              Faculty = f.Key,
                                              Specialties = f.GroupBy(s => s.Specialty).Select(sp => new
                                              {
                                                  Specialty = sp.Key,
                                                  Groups = sp.GroupBy(s => s.Group).Select(g => new
                                                  {
                                                      Group = g.Key,
                                                      Students = g.Select(s => s)
                                                  })
                                              })
                                          });
            foreach (var faculty in groupedStudents)
            {
                richTextBoxReport.AppendText($"Факультет {faculty.Faculty}:\n");
                foreach (var specialty in faculty.Specialties)
                {
                    richTextBoxReport.AppendText($"\tСпециальность {specialty.Specialty}:\n");
                    richTextBoxReport.AppendText($"\t===========================================\n");
                    foreach (var group in specialty.Groups)
                    {
                        richTextBoxReport.AppendText($"\t\tГруппа {group.Group}:\n");
                        richTextBoxReport.AppendText($"\t\t+++++++++++++++++++++++++++++++++++++++++++\n");
                        foreach (var student in group.Students)
                        {
                            richTextBoxReport.AppendText($"\t\t\t {student.FIO} - {student.AverageScore:N2}\n");
                            richTextBoxReport.AppendText($"\t\t\t -------------------------------------------\n");
                            foreach (var discipline in student.Disciplines)
                            {
                                richTextBoxReport.AppendText($"\t\t\t\t {discipline.Name} - {discipline.Score}\n");
                            }
                            richTextBoxReport.AppendText($"\t\t\t -------------------------------------------\n");
                        }
                        richTextBoxReport.AppendText($"\t\t+++++++++++++++++++++++++++++++++++++++++++\n");
                    }
                    richTextBoxReport.AppendText($"\t===========================================\n");
                }
                richTextBoxReport.AppendText($"************************************************\n");

            }
        }
    }
}
