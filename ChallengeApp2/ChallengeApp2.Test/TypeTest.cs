namespace ChallengeApp2.Test
{
    public class TypeTest
    {
        [Test]
        public void DifferentNumberTest()
        {
            //arrange
            int numb1 = 2;
            int numb2 = 2;

            //act

            //assert
            Assert.AreEqual(numb1, numb2);
        }

        [Test]
        public void DifferentNumberTest2()
        {
            //arrange
            float numb3 = 2;
            int numb4 = 2;

            //act

            //assert
            Assert.AreEqual(numb3, numb4);
        }

        [Test]
        public void DifferentNameTest()
        {
            //arrange
            string name1 = ("Piotr");
            string name2 = ("Piotr");

            //act

            //assert
            Assert.AreEqual(name1,name2);
        }
        [Test]
        public void GetEmployeeReturnDifferentName()
        {
            //arrange
            var employee1 = GetEmployee("Piotr", "Nowak");
            var employee2 = GetEmployee("Piotr", "Nowak");

            //act

            //assert
            Assert.AreEqual(employee1.Name , employee2.Name);
        }
        [Test]
        public void GetEmployeeReturnDifferentSurname()
        {
            //arrange
            var employee1 = GetEmployee("Piotr", "Nowak");
            var employee2 = GetEmployee("Piotr", "Nowak");

            //act

           //assert
            Assert.AreEqual(employee1.Surname, employee2.Surname);
        }

        private EmployeeInMemory GetEmployee(string name, string surname)
        {
            return new EmployeeInMemory(name, surname);
        }
    }
}

