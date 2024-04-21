using ChallengeApp2;

Console.WriteLine("Witamy w Programie oceny Pracowników i Suprevisora S");
Console.WriteLine("========================================");
Console.WriteLine();

var employee = new EmployeeInMemory("Piotr", "Obłój");
var employee1 = new Supervisor("Andrzej", "Obłój");
var employee2 = new EmployeeInFile("Paweł", "Obłój");

employee.GradeAdded += EmployeeGradeAdded;
employee1.GradeAdded += EmployeeGradeAdded;
employee2.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded (object sender, EventArgs arg)
{
    Console.WriteLine("dodano ocenę");
}

Console.WriteLine(" Dokonaj wyboru pracownika P , S , F ");
var input = Console.ReadLine();

while (input == "P" || input == "p")
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
while (input == "S" || input == "s")
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input2 = Console.ReadLine();

    if (input2 == "q")
    {
        break;
    }

    try
    {
        employee1.AddGrade(input2);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Znaleziono wyjątek :  {e.Message}");
    }
}

while (input == "F" || input == "f")
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input3 = Console.ReadLine();

    if (input3 == "q")
    {
        break;
    }

    try
    {
        employee2.AddGrade(input3);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Znaleziono wyjątek :  {e.Message}");
    }
}

if (input == "P" || input == "p")
{
    var statistics = employee.GetStatisticsWithForeEach();
    Console.WriteLine("========================================");
    Console.WriteLine("Statystyki wyników pracownika Piotr ");
    Console.WriteLine("========================================");
    Console.WriteLine($" Wartość Max: {statistics.Max}");
    Console.WriteLine($" Średnia wartość: {statistics.Average:N2}");
    Console.WriteLine($" Wartość Min: {statistics.Min}");
    Console.WriteLine($" Średnia wartość: {statistics.AverageLetther:N2}");
}

else if (input == "S" || input == "s")
{
    var statistics2 = employee1.GetStatisticsWithForeEach();
    Console.WriteLine("========================================");
    Console.WriteLine("Statystyki wyników Paweł ");
    Console.WriteLine("========================================");
    Console.WriteLine($" Wartość Max: {statistics2.Max}");
    Console.WriteLine($" Średnia wartość: {statistics2.Average:N2}");
    Console.WriteLine($" Wartość Min: {statistics2.Min}");
    Console.WriteLine($" Średnia wartość: {statistics2.AverageLetther:N2}");
}
else if (input == "F" || input == "f")
{
    var statistics3 = employee2.GetStatisticsWithForeEach();
    Console.WriteLine("========================================");
    Console.WriteLine("Statystyki wyników Supervizora ");
    Console.WriteLine("========================================");
    Console.WriteLine($" Wartość Max: {statistics3.Max}");
    Console.WriteLine($" Średnia wartość: {statistics3.Average:N2}");
    Console.WriteLine($" Wartość Min: {statistics3.Min}");
    Console.WriteLine($" Średnia wartość: {statistics3.AverageLetther:N2}");
}