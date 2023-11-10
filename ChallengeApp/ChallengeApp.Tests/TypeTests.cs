namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void ComperingIntType()
        {
            // arrange
            int number1 = 2;
            int number2 = 2;

            // act

            //action
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void ComperingStringType()
        {
            // arrange
            string name1 = "Darek";
            string name2 = "Darek";

            // act

            //action
            Assert.AreEqual(name1, name2);
        }

        [Test]
        public void ComperingReferenceType()
        {
            // arrange
            var employee1 = GetEmployee("Andrzej", "Kowalski", 49);
            var employee2 = GetEmployee("Michał", "Sapalski", 32);

            // act

            //action
            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
