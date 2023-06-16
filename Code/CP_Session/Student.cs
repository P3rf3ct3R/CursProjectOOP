using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Session
{
    public class Student : IComparable<Student>
    {
        #region Properties
        /// <summary>
        /// Номер карточки студента
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Имя студента
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Отечество студента
        /// </summary>
        public string Patronymic { get; set; }
        /// <summary>
        /// Фамилия студента
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Ф.И.О. студента
        /// </summary>
        public string FIO
        {
            get
            {
                string fio = Surname;
                if (Name.Length > 0)
                {
                    fio += " " + Name[0] + ".";
                }
                if (Patronymic.Length > 0)
                {
                    fio += Patronymic[0] + ".";
                }
                return fio;
            }
        }
        /// <summary>
        /// Дата рождения студента
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Группа
        /// </summary>
        public string Group { get; set; }
        /// <summary>
        /// Форма обучения
        /// </summary>
        public string FormOfStudy { get; set; }
        /// <summary>
        /// Виды обучения
        /// </summary>
        public static readonly string[] Forms = new[] { "очная", "заочная" };
        /// <summary>
        /// Год обучения
        /// </summary>
        public int YearOfStudy { get; set; }
        /// <summary>
        /// Специальность
        /// </summary>
        public string Specialty { get; set; }
        /// <summary>
        /// Факультет
        /// </summary>
        public string Faculty { get; set; }
        /// <summary>
        /// Список дисциплин с оценками
        /// </summary>
        private List<Discipline> disciplines;
        public List<Discipline> Disciplines { get => disciplines; }
        #endregion
        /// <summary>
        /// Конструктор
        /// </summary>
        public Student()
        {
            Id = 0;
            Name = "";
            Patronymic = "";
            Surname = "";
            DateOfBirth = DateTime.Now.AddYears(-18);
            Group = "";
            FormOfStudy = "";
            YearOfStudy = 1;
            Specialty = "";
            Faculty = "";
            disciplines = new List<Discipline>();
        }
        public Student(Student student)
        {
            if (student != null)
            {
                Id = student.Id;
                Name = student.Name;
                Patronymic = student.Patronymic;
                Surname = student.Surname;
                DateOfBirth = student.DateOfBirth;
                Group = student.Group;
                FormOfStudy = student.FormOfStudy;
                YearOfStudy = student.YearOfStudy;
                Specialty = student.Specialty;
                Faculty = student.Faculty;
                disciplines = student.Disciplines;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
        /// <summary>
        /// Усреднение баллов сдачи экзаменов
        /// </summary>
        public double AverageScore
        {
            get
            {
                try
                {
                    return Disciplines.Select(score => score.Value).Average();
                }
                catch
                {
                    return 0;
                }
            }
        }
        /// <summary>
        /// Количество несданных экзаменов
        /// </summary>
        public int DebtsCount
        {
            get
            {
                int count = 0;
                foreach (Discipline discipline in disciplines)
                {
                    if (discipline.IsDebt)
                        count++;
                }
                return count;
            }
        }

        /// <summary>
        /// Определяет номер последнего семестра, за который есть оценки
        /// </summary>
        protected int LastSemestr
        {
            get
            {
                int maxSemester = 1;
                foreach (Discipline gr in disciplines)
                {
                    if (gr.Semester > maxSemester)
                        maxSemester = gr.Semester;
                }
                return maxSemester;
            }
        }
        /// <summary>
        /// Для упорядочивания списка студентов по имени
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public int CompareTo(Student student)
        {
            if (student == null)
                throw new ArgumentNullException();
            return this.Id.CompareTo(student.Name);
        }
    }
}
