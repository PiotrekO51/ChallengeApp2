using ChallengeApp2;
using System.ComponentModel.Design;

Console.WriteLine("Witamy w Programie oceny Pracownikó i Suprevisora");
Console.WriteLine("========================================");
Console.WriteLine();


var employee = new Employee("Piotr", "Obłój");
var supervisor = new Supervisor("Jan", "Kowalski");
//try
//{
//    Employee emp = null;
//    var name = emp.Surname;
//}
//catch(Exception exception)
//{
//    Console.WriteLine(exception.Message);
//}
//finally 
//{
//    Console.WriteLine("Finally here : ");
//}

Console.WriteLine("Wybierz pracownika P lub supervisora S ");
var input = Console.ReadLine();

while (input == "P")
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input1 = Console.ReadLine();

    if (input1 == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input1);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Znaleziono wyjątek :  {e.Message}");
    }

}

while (input == "S")
{
    Console.WriteLine("Podaj kolejną ocenę Supervisora od 1 do 6 lub od A do E");
    var input2 = Console.ReadLine();

    if (input2 == "q")
    {
        break;
    }

    try
    {
        supervisor.AddGrade(input2);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Znaleziono wyjątek :  {e.Message}");
    }

}

if (input == "P")
{
    var statistics = employee.GetStatisticsWithForeEach();
    Console.WriteLine("========================================");
    Console.WriteLine("Statystyki wyników Pracownika ");
    Console.WriteLine("========================================");
    Console.WriteLine($" Wartość Max: {statistics.Max}");
    Console.WriteLine($" Średnia wartość: {statistics.Average:N2}");
    Console.WriteLine($" Wartość Min: {statistics.Min}");
    Console.WriteLine($" Średnia wartość: {statistics.AverageLetther:N2}");
}

else if (input == "S")
{
    var statistics2 = supervisor.GetStatisticsWithForeEach();
    Console.WriteLine("========================================");
    Console.WriteLine("Statystyki wyników Supervisora ");
    Console.WriteLine("========================================");
    Console.WriteLine($" Wartość Max: {statistics2.Max}");
    Console.WriteLine($" Średnia wartość: {statistics2.Average:N2}");
    Console.WriteLine($" Wartość Min: {statistics2.Min}");
    Console.WriteLine($" Średnia wartość: {statistics2.AverageLetther:N2}");
}