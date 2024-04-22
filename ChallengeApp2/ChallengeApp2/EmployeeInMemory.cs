namespace ChallengeApp2
{
    public class EmployeeInMemory : EmployeeBase
    {

        public delegate void GradeAddedDelegdate(object sender, EventArgs args);

        public event GradeAddedDelegdate GradeAdded;

        private List<float> grades = new List<float>();

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }
     
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }

            else if (grade < 0)
            {
                throw new Exception("Wartość nie może być mniejsza od 0 ");
            }

            else if (grade > 100)
            {
                throw new Exception("Wartość nie może być większa niż 100 ");
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

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
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
                        AddGrade(60);
                        break;
                    case 'D':
                    case 'd':
                        AddGrade(40);
                        break;
                    case 'E':
                    case 'e':
                        AddGrade(20);
                        break;
                    default:
                        throw new Exception("Zła Litera ");
                }
            }

            else
            {
                throw new Exception("Wprowadzone znaki nie są liczbami. ");
            }
        }

        public override void AddGrade(char grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
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
