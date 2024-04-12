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