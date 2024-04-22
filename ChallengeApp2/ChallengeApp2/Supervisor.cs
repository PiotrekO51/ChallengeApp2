using System.ComponentModel.Design;

namespace ChallengeApp2
{
    public class Supervisor : EmployeeBase
    {
        public delegate void GradeAddedDelegdate(object sender, EventArgs args);

        public event GradeAddedDelegdate GradeAdded;

        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname)
             : base(name, surname)
        {

        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
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
            if (float.TryParse(grade, out float result))
            {
                switch (grade)
                {
                    case "6":
                    case "-6":
                        this.AddGrade(100);
                        break;
                    case "5":
                    case "-5":
                        this.AddGrade(80);
                        break;
                    case "4":
                    case "-4":
                        this.AddGrade(60);
                        break;
                    case "3":
                    case "-3":
                        this.AddGrade(40);
                        break;
                    case "2":
                    case "+2":
                        this.AddGrade(20);
                        break;
                    default:
                        throw new Exception("Zła ocena - litery od 1 do 6 -");
                }
            }


            else if (char.TryParse(grade, out char charresult))
            {
                switch (charresult)
                {
                    case 'A':
                    case 'a':
                        this.AddGrade(100);
                        break;
                    case 'B':
                    case 'b':
                        this.AddGrade(80);
                        break;
                    case 'C':
                    case 'c':
                        this.AddGrade(60);
                        break;
                    case 'D':
                    case 'd':
                        this.AddGrade(40);
                        break;
                    case 'E':
                    case 'e':
                        this.AddGrade(20);
                        break;
                    default:
                        throw new Exception("Zła Litera - litery od A do E -");

                }

            }

        }

        public override Statistics GetStatisticsWithForeEach()
        {
            var statistics = new Statistics();
           

            foreach (var grade in this.grades)
            {
             statistics.AddGrade(grade);
            }

            return statistics;
        }

    }
}