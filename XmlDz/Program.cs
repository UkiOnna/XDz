using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XmlDz
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.FullName = "GreySword";
            student.Name = "Carl";
            student.mark = 4;

            XmlDocument document = new XmlDocument();
            string way = (Directory.GetCurrentDirectory() + @"\student.xml");

            using (StreamWriter sw = new StreamWriter(way, true, System.Text.Encoding.Default))
            {
                sw.Write(student.FullName);
                sw.Write(student.Name);
                sw.Write(student.mark);
            }

            Console.WriteLine("Студент записан в файл");

            Console.ReadLine();
        }
    }
}
