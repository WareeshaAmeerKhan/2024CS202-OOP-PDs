using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.BL
{
    internal class DegreeProgram
    {
        public string title;
        public int duration;
        public int seats;
        public double merit;
        public List<Subject> ListOfSubjects;

        public DegreeProgram()
        {
            
        }

        public DegreeProgram(string title, int duration, int seats, double merit)
        {
            this.title = title;
            this.duration = duration;
            this.seats = seats;
            this.merit = merit;
            ListOfSubjects = new List<Subject>();
        }

        public Subject GetSubjectbyCode(string code)
        {
            foreach (Subject subject in ListOfSubjects)
            {
                if (subject.SubCode == code)
                    return subject;
            }
            return null;
        }
        public void AddSubject(Subject subject)
        {
            ListOfSubjects.Add(subject);
        }
    }
}
