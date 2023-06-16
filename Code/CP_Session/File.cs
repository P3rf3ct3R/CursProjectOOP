using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CP_Session
{
    public static class File
    {
        /// <summary>
        /// Запись данных в файл формата XML
        /// </summary>
        /// <param name="fileName">Название файла</param>
        /// <param name="session">Класс Сессия</param>
        public static void SaveToXml(string fileName, Session<Student> session)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Session<Student>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                serializer.Serialize(fs, session);
            }
        }
        /// <summary>
        /// Чтение данных из файла формата XML
        /// </summary>
        /// <param name="fileName">Название файла</param>
        /// <returns></returns>
        public static Session<Student> LoadFromXml(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Session<Student>));
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    Session<Student> session = (Session<Student>)serializer.Deserialize(fs);
                    return session;
                }
            }
            catch
            {
                return new Session<Student>();
            }
        }
    }
}
