using System.Data;
using System.Diagnostics;

namespace ChallengeApp2
{
    public class EmployeeInFile : EmployeeBase
    {
        public delegate void GradeAddedDelegdate(object sender, EventArgs args);

        public event GradeAddedDelegdate GradeAdded;

        private const string fileName = "grades.Text";


        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(char grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }


        public override void AddGrade(string grade)
        {
            using (var writer = File.AppendText(fileName))
            {

                switch (grade)
                {
                    case "A":
                    case "a":
                        writer.WriteLine(100);
                        break;
                    case "B":
                    case "b":
                        writer.WriteLine(80);
                        break;
                    case "c":
                    case "C":
                        writer.WriteLine(60);
                        break;
                    case "D":
                    case "d":
                        writer.WriteLine(40);
                        break;
                    case "E":
                    case "e":
                        writer.WriteLine(20);
                        break;
                    case "f":
                    case "F":
                        writer.WriteLine(0);
                        break;
                    case "6":
                        writer.WriteLine(100);
                        break;
                    case "5":
                        writer.WriteLine(80);
                        break;
                    case "4":
                        writer.WriteLine(60);
                        break;
                    case "3":
                        writer.WriteLine(40);
                        break;
                    case "2":
                        writer.WriteLine(20);
                        break;
                    case "1":
                        writer.WriteLine(0);
                        break;
                         default:
                        throw new Exception("Zła Litera lub wartość ");
                }

                if (GradeAdded != null )
                {
                    GradeAdded(this, new EventArgs());
                }
            }
        }

        public override Statistics GetStatisticsWithForeEach()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }
        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }

                }
            }
            return grades;
        }

        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            

            foreach (var grade in grades)
            {
                statistics.AddGrade(grade); 
            }
           
            return statistics;
        }
    }
}

