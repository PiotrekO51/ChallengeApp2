using System.Data;

namespace ChallengeApp2
{
    public class Employee
    {
        private const char sex = 'M';

        private List<float> grades = new List<float>();

        public Employee()
        {

        }
        public Employee(string name, string surename)
        {
            this.Name = name;
            this.Surname = surename;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
       
        public void AddGrade(float grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                
                this.grades.Add(grade);
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

        public void AddGrade(double grade)
        {
            var result = (float)grade;
            this.AddGrade(result);
        }

        public void AddGrade(long grade)
        {
            this.AddGrade((float)grade);
        }
        
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);   
            }
            else if (char.TryParse(grade, out char charresult))
            {
                this.AddGrade(charresult);
            }
            else
            {
               throw new Exception("Wprowadzone znaki nie są liczbami ");
            }
        }

        public void AddGrade(char grade)
        { 
            switch (grade)
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
                    throw new Exception("Zła Litera ");
            }
        }

        public Statistics GetStatisticsWithForeEach()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
               
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetther = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetther = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetther = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetther = 'D';
                    break;
                default:
                    statistics.AverageLetther = 'E';
                    break;   
            }

           return statistics;
        }
    }
}
