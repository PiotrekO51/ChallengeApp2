namespace ChallengeApp2
{
    public class Employee
    {
        private List<int> rtp = new List<int>();

        // To jest konstruktor
        public Employee(string name, string surname, string age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            //this.rtp = 0;

        }
        // To jest property ( pole)

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }

        public int Result
        {
            get
            {
                return this.rtp.Sum();
            }
        }

        // To jest metoda. metoda obsługuje wprowadzanie i zarządzanie zmiennymi  

        public void AddRtp(int number)
        {
            // this.rtp = this.rtp + number; inny zapis ale też poprawny
            this.rtp.Add(number);
        }
    }

}
