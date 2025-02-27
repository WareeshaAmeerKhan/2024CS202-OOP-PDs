using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.BL;

namespace Problem1.DL
{
    internal class DegreeCRUD
    {
        static public List<DegreeProgram> DegreesList = new List<DegreeProgram>();
        public static DegreeProgram AvailablePreferenceDegree(string degreeName)
        {
            foreach (DegreeProgram degree in DegreesList)
            {
                if (degree.title == degreeName)
                {
                    return degree;
                }
            }
            return null;
        }
        public static DegreeProgram GetDegree(string name)
        {
            for (int i = 0; i < DegreesList.Count; i++)
            {
                if (DegreesList[i].title == name)
                {
                    return DegreesList[i];
                }
            }
            return null;
        }

        public static void AddDegree(DegreeProgram NewDegree)
        {
            DegreesList.Add(NewDegree);
        }

        public static void ReadFromFile()
        {
            StreamReader file = new StreamReader("Degree.txt");
            string record;
            if (File.Exists("Degree.txt"))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] Record = record.Split(',');
                    string degreeName = Record[0];
                    int degreeDuration = int.Parse(Record[1]);
                    int seats = int.Parse(Record[2]);
                    double merit = double.Parse(Record[3]);
                    string[] RecordForSubject = Record[4].Split(';');
                    DegreeProgram d = new DegreeProgram(degreeName, degreeDuration, seats, merit);
                    for (int x = 0; x < RecordForSubject.Length; x++)
                    {

                        Subject s = SubjectCRUD.GetSubject(RecordForSubject[x]);
                        d.AddSubject(s);
                    }
                    DegreesList.Add(d);
                }
                file.Close();
            }

        }
        public static void WriteIntoFile(DegreeProgram d)
        {
            using (StreamWriter f = new StreamWriter("Degree.txt", true))
            {
                f.WriteLine();
                f.Write(d.title+","+d.duration+","+d.seats+","+d.merit+",");

                for (int x = 0; x < d.ListOfSubjects.Count; x++)
                {
                    f.Write(d.ListOfSubjects[x].Type);
                    if (x < d.ListOfSubjects.Count - 1)
                    {
                        f.Write(";");
                    }
                }

            }
        }
    }
}
