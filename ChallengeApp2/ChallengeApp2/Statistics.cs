
namespace ChallengeApp2
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public float Count { get; private set; }

        public float Average
        {
            get 
            {
                return this.Sum / this.Count;
            }
        }
        public char AverageLetther 
        { 
            get
            {
                switch (this.Average)
                {
                    case var average when average >= 80:
                        return 'A';
                        break;
                    case var average when average >= 60:
                        return 'B';
                        break;
                    case var average when average >= 40:
                        return 'C';
                        break;
                    case var average when average >= 20:
                        return 'D';
                        break;
                    default:
                        return'E';
                        break;
                }
            }
        }

        public Statistics()
        {
            this.Count = 0; 
            this.Sum = 0;
            this.Min = float.MaxValue;
            this.Max = float.MinValue;
        }
        public void AddGrade(float grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Min = Math.Min(grade, this.Min);
            this.Max = Math.Max(grade, this.Max);
        }
    }
}
