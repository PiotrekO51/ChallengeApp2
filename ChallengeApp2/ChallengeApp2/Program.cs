using ChallengeApp2;

Console.WriteLine("Witamy w Programie oceny Pracowników i Suprevisora S");
Console.WriteLine("========================================");
Console.WriteLine();



var supervisor = new Supervisor("Jan", "Kowalski");
var pracownik = new EmployeeInMemory("Paweł", "Obłój");
var employee1 = new EmployeeInFile("Piotr", "Obłój");

//employee1.AddGrade(20F);
//employee1.AddGrade(33F);
//employee1.AddGrade(55F);
//employee1.AddGrade(32F);

Console.WriteLine(" Dokonaj wyboru pracownika P , S , F ");
var input = Console.ReadLine();

while (input == "F")
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input1 = Console.ReadLine();

    if (input1 == "q")
    {
        break;
    }

    try
    {
        employee1.AddGrade(input1);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Znaleziono wyjątek :  {e.Message}");
    }
}

    if (input == "S")
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

else if (input == "P")
{
    var statistics2 = pracownik.GetStatisticsWithForeEach();
    Console.WriteLine("========================================");
    Console.WriteLine("Statystyki wyników Supervisora ");
    Console.WriteLine("========================================");
    Console.WriteLine($" Wartość Max: {statistics2.Max}");
    Console.WriteLine($" Średnia wartość: {statistics2.Average:N2}");
    Console.WriteLine($" Wartość Min: {statistics2.Min}");
    Console.WriteLine($" Średnia wartość: {statistics2.AverageLetther:N2}");
}

else if (input == "F")
{
    var statistics2 = employee1.GetStatisticsWithForeEach();
    Console.WriteLine("========================================");
    Console.WriteLine("Statystyki wyników Supervisora ");
    Console.WriteLine("========================================");
    Console.WriteLine($" Wartość Max: {statistics2.Max}");
    Console.WriteLine($" Średnia wartość: {statistics2.Average:N2}");
    Console.WriteLine($" Wartość Min: {statistics2.Min}");
    Console.WriteLine($" Średnia wartość: {statistics2.AverageLetther:N2}");
}

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

//Console.WriteLine("Wybierz  pracownika ");
//var input = Console.ReadLine();

//while (input == "P")
//{
//    Console.WriteLine("Podaj kolejną ocenę pracownika");
//    var input1 = Console.ReadLine();

//    if (input1 == "q")
//    {
//        break;
//    }

//    try
//    {
//        employee.AddGrade(input1);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Znaleziono wyjątek :  {e.Message}");
//    }

//}

//while (input == "S")
//{
//    Console.WriteLine("Podaj kolejną ocenę Supervisora od 1 do 6 lub od A do E");
//    var input2 = Console.ReadLine();

//    if (input2 == "q")
//    {
//        break;
//    }

//    try
//    {
//        supervisor.AddGrade(input2);
//    }
//    catch
//    {
//        Console.WriteLine("Znaleziono wyjątek :  ");
//    }

//}
//while (input == "F")
//{
//    Console.WriteLine("Podaj kolejną ocenę pracownika");
//    var input3 = Console.ReadLine();

//    if (input3 == "q")
//    {
//        break;
//    }

//    try
//    {
//        employee1.AddGrade(input3);
//    }
//    catch { }
//}
//catch (Exception e)
//{
//    Console.WriteLine($"Znaleziono wyjątek :  {e.Message}");
//}


//}


//if (input == "P")
//{
//    var statistics = employee.GetStatisticsWithForeEach();
//    Console.WriteLine("========================================");
//    Console.WriteLine("Statystyki wyników Pracownika ");
//    Console.WriteLine("========================================");
//    Console.WriteLine($" Wartość Max: {statistics.Max}");
//    Console.WriteLine($" Średnia wartość: {statistics.Average:N2}");
//    Console.WriteLine($" Wartość Min: {statistics.Min}");
//    Console.WriteLine($" Średnia wartość: {statistics.AverageLetther:N2}");
//}
