using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.BL;
using Problem1.UI;

namespace Problem1.DL
{
    internal class StudentCRUD
    {
        public static List<Student> ListOfStudents= new List<Student>();

        public static void AddStudent(Student NewStudent)
        {
            ListOfStudents.Add(NewStudent);
        }
        public static void RegisterStudentInDegrees()
        {
            foreach (Student student in ListOfStudents)
            {
                student.RegisteredDegree();
            }
        }

        public static Student SearchStudent(string name)
        {
            foreach (Student student in ListOfStudents)
            {
                if (student.name == name)
                {
                    return student;
                }
            }
            return null;
        }
        public static void ReadFromFile()
        {
            StreamReader file = new StreamReader("Student.txt");
            string record;

            if (File.Exists("Student.txt"))
            {

                while ((record = file.ReadLine()) != null)
                {
                    string[] Record = record.Split(',');

                    string name = Record[0];
                    int age = int.Parse(Record[1]);
                    double fscMarks = double.Parse(Record[2]);
                    double ecatMarks = double.Parse(Record[3]);

                    string[] RecordForPreference = Record[4].Split(';');

                    List<DegreeProgram> pref = new List<DegreeProgram>();
                    for (int x = 0; x < RecordForPreference.Length; x++)
                    {
                        DegreeProgram d = DegreeCRUD.GetDegree(RecordForPreference[x]);
                        if (d != null)
                        {
                            if (!(pref.Contains(d)))
                            {
                                pref.Add(d);
                            }
                        }
                    }
                    Student s = new Student(name, age, fscMarks, ecatMarks);
                    s.Preferences = pref;
                    ListOfStudents.Add(s);
                }
                file.Close();

            }
        }
        public static void WriteIntoFile(Student s)
        {
            using (StreamWriter file = new StreamWriter("Student.txt", true))
            {
                file.WriteLine();
                file.Write(s.name+","+s.age+","+s.FSCMarks+","+s.EcatMarks+",");

                for (int x = 0; x < s.Preferences.Count; x++)
                {
                    file.Write(s.Preferences[x].title);
                    if (x < s.Preferences.Count - 1)
                    {
                        file.Write(";");
                    }
                }

            }
        }
    }
}
