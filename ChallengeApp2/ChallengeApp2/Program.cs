using ChallengeApp2;

var employee = new Employee("Piotr", "Obłój");
employee.AddGrade('2');
employee.AddGrade("ABC");
employee.AddGrade(-5);
employee.AddGrade(3);
employee.AddGrade(11);
employee.AddGrade(5);
employee.AddGrade("12");
var statistics = employee.GetStatisticsWithForeEach();
var statistics1 = employee.GetStatisticsWithFor();
var statistics2 = employee.GetStatisticsWithDoWhile();
var statistics3 = employee.GetStatisticsWithWhile();

Console.WriteLine("====================================");
Console.WriteLine(" Metoda z wykorzystaniem pętli  ForeEach ");
Console.WriteLine($"Wartość Max: {statistics.Max}");
Console.WriteLine($"Średnia wartość: {statistics.Average:N2}");
Console.WriteLine($"Wartość Min: {statistics.Min}");

Console.WriteLine("====================================");
Console.WriteLine(" Metoda z wykorzystaniem pętli  For ");
Console.WriteLine($"Wartość Max: {statistics1.Max}");
Console.WriteLine($"Średnia wartość: {statistics1.Average:N2}");
Console.WriteLine($"Wartość Min: {statistics1.Min}");

Console.WriteLine("====================================");
Console.WriteLine(" Metoda z wykorzystaniem pętli  do while ");
Console.WriteLine($"Wartość Max: {statistics2.Max}");
Console.WriteLine($"Średnia wartość: {statistics2.Average:N2}");
Console.WriteLine($"Wartość Min: {statistics2.Min}");

Console.WriteLine("====================================");
Console.WriteLine(" Metoda z wykorzystaniem pętli while ");
Console.WriteLine($"Wartość Max: {statistics3.Max}");
Console.WriteLine($"Średnia wartość: {statistics3.Average:N2}");
Console.WriteLine($"Wartość Min: {statistics3.Min}");
Console.WriteLine("====================================");


