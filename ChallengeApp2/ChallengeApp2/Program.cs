﻿using ChallengeApp2;

var employee = new Employee("Piotr", "Obłój");
employee.AddGrade('2');
employee.AddGrade("ABC");
employee.AddGrade(-5);
employee.AddGrade(6.5);
employee.AddGrade(11);
employee.AddGrade(101);
var statistics = employee.GetStatistics();

Console.WriteLine($"Wartość Max: {statistics.Max}");
Console.WriteLine($"Średnia wartość: {statistics.Average:N2}");
Console.WriteLine($"Wartość Min: {statistics.Min}");

