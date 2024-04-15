using ChallengeApp2;
using System;
using System.Reflection;

Console.WriteLine("Witamy w Programie oceny Pracowników XYZ");
Console.WriteLine("========================================");
Console.WriteLine();


var employee = new Employee ();

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

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Znaleziono wyjątek :  {e.Message}");
    }
}

var statistics = employee.GetStatisticsWithForeEach();
Console.WriteLine("========================================");
Console.WriteLine("Statystyki wyników : ");
Console.WriteLine("========================================");
Console.WriteLine($" Wartość Max: {statistics.Max}");
Console.WriteLine($" Średnia wartość: {statistics.Average:N2}");
Console.WriteLine($" Wartość Min: {statistics.Min}");
Console.WriteLine($" Średnia wartość: {statistics.AverageLetther:N2}");




