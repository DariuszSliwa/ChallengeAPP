using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    public interface IEmployee
    {
        event GradeAddedDelegate GradeAdded;
        string Name { get; }
        string Surname { get; }
        char Sex { get; }
        int Age { get; }

        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(long grade);
        void AddGrade(int grade);
        void AddGrade(double grade);
        void AddGrade(char grade);

        Statistics GetStatistics();
    }
}
