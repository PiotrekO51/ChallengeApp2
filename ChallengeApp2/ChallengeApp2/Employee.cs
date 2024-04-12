
using System.Diagnostics;

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
           if (grade >= 0 && grade <= 100)
            { 
                this.grades.Add(grade);
            }
           else if (grade < 0) 
            {
                Console.WriteLine("Wartość nie może być mniejsza od zera ");
            }
            else if(grade >100)
            {
                Console.WriteLine("Wartość nie może być większa niż 100 ");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float gradeAsFloat))
            //var value = float.Parse(grade);
            { 
            this.AddGrade(gradeAsFloat);
            }
            else
            {
                Console.WriteLine($"Wpisano tekst {grade} zamiast wartości ");
            }
        }

        public void AddGrade(double grade)
        {
                var result = (float)grade;
                this.AddGrade(result);
        }

        public void AddGrade(long grade)
        {
                var result = (float)grade;
                this.AddGrade(result);
        }

        public void AddGrade(char grade)
        {
            if (char.IsLetter(grade))
            {
                Console.WriteLine($"Wpisano Literę {grade} zamiast wartości liczbowej ");
            }
            else
            {
                var gradeAsFloat = float.Parse(grade.ToString());
                this.AddGrade(gradeAsFloat);
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
                //statistics.Average = statistics.Average + grade; (równoważne z statistics.Average += grade;)
                statistics.Average += grade;
            }
        
            //statistics.Average = statistics.Average / this.grades.Count;
            statistics.Average /= this.grades.Count;

            return statistics;
        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics1 = new Statistics();
            statistics1.Average = 0;
            statistics1.Max = float.MinValue;
            statistics1.Min = float.MaxValue;
            var index = 0;

            for (var i = 0; i < this.grades.Count; i++)
            {
                statistics1.Max = Math.Max(statistics1.Max, grades[index]);
                statistics1.Min = Math.Min(statistics1.Min, grades[index]);

                statistics1.Average += grades[index];
                index++;
            }
            statistics1.Average /= this.grades.Count;
            return statistics1;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics2 = new Statistics();
            statistics2.Average = 0;
            statistics2.Max = float.MinValue;
            statistics2.Min = float.MaxValue;
            var index = 0;

            do
            {
                statistics2.Max = Math.Max(statistics2.Max, grades[index]);
                statistics2.Min = Math.Min(statistics2.Min, grades[index]);

                statistics2.Average += grades[index];
                index++;
            } while (index < this.grades.Count);

            statistics2.Average /= this.grades.Count;
            return statistics2;
            }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics3 = new Statistics();
            statistics3.Average = 0;
            statistics3.Max = float.MinValue;
            statistics3.Min = float.MaxValue;
            var index = 0;

            while (index < this.grades.Count)
            {
                statistics3.Max = Math.Max(statistics3.Max, grades[index]);
                statistics3.Min = Math.Min(statistics3.Min, grades[index]);
                statistics3.Average += grades[index];
                index++;
            }

            statistics3.Average /= this.grades.Count;

            return statistics3;
        }


    }
}
