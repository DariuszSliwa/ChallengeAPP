namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectTwoScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Dariusz", "Nowicki", 33);
            employee.AddScore(5);
            employee.AddScore(5);
            employee.AddScore(2);
            employee.AddScore(-12);

            // act
            var result = employee.Result;

            //action
            Assert.AreEqual(0, result);
        }
    }
}