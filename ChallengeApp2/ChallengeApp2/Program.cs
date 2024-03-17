// Sytem oceny pracownika

using ChallengeApp2;

Employee emp1 = new Employee("Piotr", "Nowak", "51");
Employee emp2 = new Employee("Zuza", "Kowalska", "22");
Employee emp3 = new Employee("Andrzej", "Czaszkowski", "58");


// pracownicy
emp1.AddRtp(2);
emp1.AddRtp(5);
emp1.AddRtp(4);
emp1.AddRtp(5);
emp1.AddRtp(4);

emp2.AddRtp(3);
emp2.AddRtp(7);
emp2.AddRtp(5);
emp2.AddRtp(9);
emp2.AddRtp(5);

emp3.AddRtp(1);
emp3.AddRtp(1);
emp3.AddRtp(2);
emp3.AddRtp(8);
emp3.AddRtp(3);



int result = emp1.Result;
int result2 = emp2.Result;
int result3 = emp3.Result;

Console.WriteLine(emp1.Name + " Wynik " + emp1.Result);
Console.WriteLine(emp2.Name + " Wynik " + emp2.Result);
Console.WriteLine(emp3.Name + " Wynik " + emp3.Result);

List<Employee> emps = new List<Employee>()

{
    emp1, emp2, emp3
};


int maxResult = 0;

Employee empMaxResult = null;

foreach (var emp in emps)
{

    if (emp.Result > maxResult)
    {
        maxResult = emp.Result;
        empMaxResult = emp;
    }
}

Console.WriteLine("====================================");
Console.WriteLine("    Najlepszy wynik osiąga ");
Console.WriteLine("     " + empMaxResult.Name + " " + empMaxResult.Surname + " lat " + empMaxResult.Age);
Console.WriteLine("      Z wynikiem " + maxResult + " pkt ");
Console.WriteLine("====================================");
