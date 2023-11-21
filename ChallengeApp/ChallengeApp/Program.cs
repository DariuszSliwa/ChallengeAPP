using ChallengeApp;

var employee1 = new Employee("Adam", "Nowicki", 33);

employee1.AddGrade("Dariusz");
employee1.AddGrade("4999");
employee1.AddGrade(10);
employee1.AddGrade(8);
employee1.AddGrade('0');

var statistics1 = employee1.GetStatisticsForEach();
var statistics2 = employee1.GetStatisticsFor();
var statistics3 = employee1.GetStatisticsDoWhile();
var statistics4 = employee1.GetStatisticsWhile();

Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");

Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");

Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");