namespace ChallengeApp2
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.text";


        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {

        }
        //public override void SayHellow()
        //{
        //    Console.WriteLine("Hi !!");
        //    base.SayHellow();
        //}
       
        public override void AddGrade(float grade)
        {

        }
        public override void AddGrade(char grade)
        {
        }

        public override void AddGrade(string grade)
        {
            using (var writer = File.AppendText(fileName))
            writer.WriteLine(grade);

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
                }
            }
            return grades;
        }

        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);

                    statistics.Average += grade;
                }
                
            }
            statistics.Average /= grades.Count;

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