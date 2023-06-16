using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Session
{
    public class Discipline
    {
        /// <summary>
        /// Номер семестра
        /// </summary>
        public int Semester { get; set; }
        /// <summary>
        /// Название дисциплины
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Оценка за сдачу экзамена
        /// </summary>
        public string Score { get; set; }
        /// <summary>
        /// Виды оценок с баллами
        /// </summary>
        public static Dictionary<string, int> ExamGrade = new Dictionary<string, int>()
        {
            { "отлично", 5 },
            { "хорошо", 4 },
            { "удовлетворительно", 3 },
            { "неудовлетворительно", 2 },
            { "неявка", 0 }
        };
        /// <summary>
        /// Значение балла
        /// </summary>
        public int Value
        {
            get
            {
                return ExamGrade[Score];
            }
        }
        /// <summary>
        /// Наличие несдачи экзамена
        /// </summary>
        public bool IsDebt
        {
            get
            {
                return Value <= 2;
            }
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        public Discipline()
        {
            Semester = 1;
            Name = "";
            Score = "";
        }
        public Discipline(int semester, string name, string score)
        {
            Semester = semester;
            Name = name;
            Score = score;
        }
        /// <summary>
        /// Список оценок
        /// </summary>
        /// <returns></returns>
        public static string[] GetGradeNames()
        {
            return new List<string>(ExamGrade.Keys).ToArray();
        }
    }
}
