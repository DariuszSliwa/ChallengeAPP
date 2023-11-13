namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void TestMin()
        {
            // arrange
            var employee = new Employee("Dariusz", "Nowicki", 33);
            employee.AddGrade(5);
            employee.AddGrade(5);
            employee.AddGrade(2);

            // act
            var statistics = employee.GetStatistics();

            //action
            Assert.AreEqual(2, statistics.Min);
        }

        [Test]
        public void TestMax()
        {
            // arrange
            var employee = new Employee("Dariusz", "Nowicki", 33);
            employee.AddGrade(8);
            employee.AddGrade(5);
            employee.AddGrade(2);

            // act
            var statistics = employee.GetStatistics();

            //action
            Assert.AreEqual(8, statistics.Max);
        }

        [Test]
        public void TestAverage()
        {
            // arrange
            var employee = new Employee("Dariusz", "Nowicki", 33);
            employee.AddGrade(5);
            employee.AddGrade(5);
            employee.AddGrade(10);
            employee.AddGrade(10);

            // act
            var statistics = employee.GetStatistics();

            //action
            Assert.AreEqual(7.5, statistics.Average);
        }
    }
}