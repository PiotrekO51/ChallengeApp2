using static ChallengeApp2.EmployeeBase;

namespace ChallengeApp2
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname {  get; }

        void AddGrade(float grade);

        void AddGrade(int grade);

        void AddGrade(double grade);

        void AddGrade(string grade);

        void AddGrade(char grade);

        event GradeAddedDelegdate GradeAdded;


        Statistics GetStatisticsWithForeEach();
    }
}
