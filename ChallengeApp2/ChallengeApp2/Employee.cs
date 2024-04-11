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
            if (float.TryParse(grade, out float value))
            //var value = float.Parse(grade);
            { 
            this.AddGrade(value);
            }
            else
            {
                Console.WriteLine("Wpisano tekst zamiast wartości ");
            }
        }

        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                float gradeAsFloat = (float)grade;
                this.AddGrade(gradeAsFloat);
            }
            else
            {
                Console.WriteLine("Wpisano tekst zamiast wartości ");
            }
        }

        public void AddGrade(long grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                float gradeAsFloat = (float)grade;
                this.grades.Add(gradeAsFloat);
            }
            else if (grade < 0)
            {
                Console.WriteLine("Wartość nie może być mniejsza od zera ");
            }
            else if (grade > 100)
            {
                Console.WriteLine("Wartość nie może być większa niż 100 ");
            }
        }

        public void AddGrade(char grade)
        {
            if (char.IsLetter(grade))
            {
                Console.WriteLine($"Wpisano Literę {grade} zamiast wartości liczbowej ");
            }
            else
            {
                float gradeAsFloat = float.Parse(grade.ToString());
                this.AddGrade(gradeAsFloat);
            }
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
