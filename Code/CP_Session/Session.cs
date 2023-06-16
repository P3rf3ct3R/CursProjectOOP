using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Session
{
    public class Session<T> : IEnumerable<T> where T : Student
    {
        /// <summary>
        /// Список студентов
        /// </summary>
        public List<T> Students;
        /// <summary>
        /// Конструктор без параметра
        /// </summary>
        public Session()
        {
            Students = new List<T>();
        }
        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="session">Сессия</param>
        public Session(IEnumerable<T> session)
        {
            Students = new List<T>(session);
        }
        /// <summary>
        /// Добавление студента
        /// </summary>
        /// <param name="student"></param>
        public void AddStudent(T student)
        {
            if (!Students.Contains(student))
            {
                Students.Add(student);
            }
        }
        /// <summary>
        /// Удаление студента
        /// </summary>
        /// <param name="student"></param>
        public void RemoveStudent(T student)
        {
            if (Students.Contains(student))
            {
                Students.Remove(student);
            }
        }
        /// <summary>
        /// Количество студентов
        /// </summary>
        public int Count
        {
            get
            {
                return Students.Count;
            }
        }
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public T this[int ind]
        {
            get
            {
                if (ind < 0 || ind >= Count)
                    throw new IndexOutOfRangeException();
                return Students[ind];
            }
            set
            {
                if (ind < 0 || ind >= Count)
                    throw new IndexOutOfRangeException();
                Students[ind] = value;
            }
        }
        /// <summary>
        /// Поиск студента по фамилии
        /// </summary>
        /// <param name="surname"></param>
        /// <returns></returns>
        public T GetByName(string surname)
        {
            return
                Students.FirstOrDefault(s => s.Surname.CompareTo(surname) == 0);
        }
        /// <summary>
        /// Добавление студента (для XML-файла)
        /// </summary>
        /// <param name="student"></param>
        public void Add(T student)
        {
            Students.Add(student);
        }
        /// <summary>
        /// Удаление студента (для XML-файла)
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public T Remove(T student)
        {
            var item = Students.FirstOrDefault(h => h == student);
            if (item != null)
            {
                Students.Remove(item);
                return item;
            }
            throw new NullReferenceException();
        }
        /// <summary>
        /// Сортировка
        /// </summary>
        public void Sort()
        {
            Students.Sort();
        }
        /// <summary>
        /// Очистка
        /// </summary>
        public void Clear()
        {
            Students.Clear();
        }
        /// <summary>
        /// Проверка на существование студента
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public bool Contains(T student)
        {
            return Students.Contains(student);
        }
        /// <summary>
        /// Копирование студента по индексу
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            Students.CopyTo(array, arrayIndex);
        }
        /// <summary>
        /// Нумератор
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return Students.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
