namespace ChallengeApp2.Test
{
    public class Test
    {
        [Test]
        public void StatisticsCollectReturnMaxValue()
        {
              //arrange
                var employee = new Employee();
                employee.AddGrade(5);
                employee.AddGrade(6);
                employee.AddGrade(9);
              
                //act
                var statistics = employee.GetStatisticsWithForeEach();

                //assert
                Assert.AreEqual(9, statistics.Max);
        }

        [Test]
        public void StatisticsCollectReturnMinValue()
        {
            //arrange
            var employee = new Employee( );
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(9);

            //act
            var statistics = employee.GetStatisticsWithForeEach();

            //assert
            Assert.AreEqual(5, statistics.Min);
        }

        [Test]
        public void StatisticsCollectReturnAverageValue()
        {
            //arrange
            var employee = new Employee();
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(9);
            
            //act
            var statistics = employee.GetStatisticsWithForeEach();
            Assert.AreEqual(Math.Round(6.666,2) ,  Math.Round(statistics.Average, 2 ));
        }
        [Test]
        public void StatisticsCharLetterA()
        {
            var employee = new Employee();
            employee.AddGrade(80);
            
            var statistics = employee.GetStatisticsWithForeEach();

            Assert.AreEqual('A', statistics.AverageLetther);

        }
        [Test]
        public void StatisticsCharLetterB()
        {
            var employee = new Employee();
            employee.AddGrade(60);

            var statistics = employee.GetStatisticsWithForeEach();

            Assert.AreEqual('B', statistics.AverageLetther);

        }
        [Test]
        public void StatisticsCharLetterC()
        {
            var employee = new Employee();
            employee.AddGrade(40);

            var statistics = employee.GetStatisticsWithForeEach();

            Assert.AreEqual('C', statistics.AverageLetther);

        }
    }
}