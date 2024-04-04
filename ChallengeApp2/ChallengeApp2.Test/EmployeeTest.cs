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
                employee.AddGrade(10);
                

                //act

                var statistics = employee.GetStatistics();



                //assert

                Assert.AreEqual(10, statistics.Max);
        }

        [Test]
        public void StatisticsCollectReturnMinValue()
        {


            //arrange

            var employee = new Employee("Piotr", "Ob³ój");

            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(10);


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
            employee.AddGrade(10);


            //act

            var statistics = employee.GetStatistics();



            //assert

            Assert.AreEqual(7, statistics.Average);
        }

    }
}