namespace ChallengeApp2
{


    public abstract class EmployeeBase : IEmployee
    { 
        public delegate void GradeAddedDelegdate(object sender, EventArgs args);

        public event GradeAddedDelegdate GradeAdded;

        public EmployeeBase(string name, string surname)
          
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }


        public abstract void AddGrade(float grade);

        public abstract void AddGrade(string grade);
        public virtual void SayHellow()
        {
            Console.WriteLine($"Hello ! I em {Name} {Surname}");
        }
        public abstract void AddGrade(char grade);

        public abstract Statistics GetStatisticsWithForeEach();

       
    }
}
