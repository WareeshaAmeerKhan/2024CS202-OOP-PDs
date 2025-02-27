using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.BL;

namespace Problem1.DL
{
    internal class SubjectCRUD
    {
        static List<Subject> ListOfSubjects = new List<Subject>();

        public static Subject GetSubject(string name)
        {
            for (int i = 0; i < ListOfSubjects.Count; i++)
            {
                if (name == ListOfSubjects[i].Type) return ListOfSubjects[i];
            }
            return null;
        }
        public static void ReadFromFile()
        {
            StreamReader f = new StreamReader("Subject.txt");
            string record;
            if (File.Exists("Subject.txt"))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] Record = record.Split(',');
                    string code = Record[0];
                    string type = Record[1];
                    int creditHours = int.Parse(Record[2]);
                    int subjectFees = int.Parse(Record[3]);
                    Subject s = new Subject(code, creditHours, type, subjectFees);
                    AddSubjectIntoList(s);
                }
                f.Close();
            }
        }
        public static void WriteIntoFile(Subject s)
        {
            using (StreamWriter f = new StreamWriter("Subject.txt", true))
            {
                f.WriteLine();
                f.Write(s.SubCode+","+s.Type+","+s.CreditHours+","+s.Fee);
            }
        }
        public static void AddSubjectIntoList(Subject s)
        {
            ListOfSubjects.Add(s);
        }
    }
}
