﻿namespace ChallengeApp2
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname {  get; }

        void AddGrade(float grade);

        void AddGrade(string grade);

        void AddGrade(char grade);
        


        Statistics GetStatisticsWithForeEach();
    }
}
