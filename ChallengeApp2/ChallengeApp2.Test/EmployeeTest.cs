namespace ChallengeApp2.Test
{
    public class Test
    {
        [Test]
        public void StatisticsCollectReturnMaxValue()
        {
              //arrange
                var employee = new Employee("Piotr", "Ob³ój");
                employee.AddGrade(5);
                employee.AddGrade(6);
                employee.AddGrade(9);
              
                //act
                var statistics = employee.GetStatistics();

                //assert
                Assert.AreEqual(9, statistics.Max);
        }

        [Test]
        public void StatisticsCollectReturnMinValue()
        {
            //arrange
            var employee = new Employee("Piotr", "Ob³ój");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(9);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(5, statistics.Min);
        }

        [Test]
        public void StatisticsCollectReturnAverageValue()
        {
            //arrange
            var employee = new Employee("Piotr", "Ob³ój");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(9);
            
            //act
            var statistics = employee.GetStatistics();
            Assert.AreEqual(Math.Round(6.666,2) ,  Math.Round(statistics.Average, 2 ));
        }
    }
}