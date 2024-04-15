using ChallengeApp2;

Console.WriteLine("Witamy w Programie oceny Pracowników XYZ");
Console.WriteLine("========================================");
Console.WriteLine();
Console.WriteLine("Podaj ocenę Pracownika : ");

var employee = new Employee ();

while(true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
   
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatisticsWithForeEach();
Console.WriteLine($" Wartość Max: {statistics.Max}");
Console.WriteLine($" Średnia wartość: {statistics.Average:N2}");
Console.WriteLine($" Wartość Min: {statistics.Min}");
Console.WriteLine($" Średnia wartość: {statistics.AverageLetther:N2}");




