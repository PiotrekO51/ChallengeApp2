namespace ChallengeApp2.Test
{
    public class Test
    {
        
        [Test]
        public void EmployeesPointAdditionTest()
        {
            
        
              //arrange

                var emps = new Employee("Piotr", "Nowak", "45cgbgb");

                emps.AddRtp(5);
                emps.AddRtp(6);
                emps.AddRtp(10);
                emps.AddRtp(4);

                //act

                var result = emps.Result;



                //assert

                Assert.AreEqual(25, result);
        }

        [Test]
        public void EmployeesPointAdditionTest2()
        {


            //arrange

            var emps = new Employee("Piotr", "Nowak", "45cgbgb");

            emps.AddRtp(0);
            emps.AddRtp(6);
            emps.AddRtp(10);
            emps.AddRtp(-5);

            //act

            var result = emps.Result;



            //assert

            Assert.AreEqual(11, result);
        }

    }
}