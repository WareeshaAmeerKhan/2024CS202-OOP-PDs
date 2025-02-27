using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.BL
{
    internal class Student
    {
        public string name;
        public int age;
        public double FSCMarks;
        public double EcatMarks;
        public double merit;
        public bool isRegistered;
        public List<Subject> SubjectRegistered;
        public List<DegreeProgram> Preferences;
        public DegreeProgram DegreeRegistered;

        public Student() { }

        public Student(string name, int age, double FSCMarks, double EcatMarks)
        {
            this.name = name;
            this.age = age;
            this.FSCMarks = FSCMarks;
            this.EcatMarks = EcatMarks;
            merit = ((FSCMarks / 12) * 0.5) + ((EcatMarks / 4) * 0.5);
            isRegistered = true;
            SubjectRegistered = new List<Subject>();
            Preferences = new List<DegreeProgram>();
        }

        public void RegisterSubjects(List<Subject> ListOfSubjects)
        {
            SubjectRegistered = ListOfSubjects;
        }
        public double SubjectsFees()
        {
            double sum = 0;
            foreach (Subject subject in SubjectRegistered)
            {
                sum += subject.Fee;
            }
            return sum;
        }

        public void RegisteredDegree()
        {
            foreach (DegreeProgram degree in Preferences)
            {
                if (merit >= degree.merit)
                {
                    DegreeRegistered = degree;
                    isRegistered = true;
                    break;
                }
            }
        }
    }
}
