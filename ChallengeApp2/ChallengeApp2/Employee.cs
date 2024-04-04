using System.ComponentModel.DataAnnotations;

namespace ChallengeApp2
{
    public class Employee
    {

        private List<float> grades = new List<float>();

        public Employee(string name, string surename)
        {
            this.Name = name;
            this.Surname = surename;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }


        public void AddGrade(float grade)
        {
        this.grades.Add(grade);
        }

        public Statistics GetStatistics() 
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                //statistics.Average = statistics.Average + grade; (równoważne z statistics.Average += grade;)
                statistics.Average += grade;
            }

            //statistics.Average = statistics.Average / this.grades.Count;
            statistics.Average /= this.grades.Count;

            return statistics;
        }
    }
}
