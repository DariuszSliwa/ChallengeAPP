using ChallengeApp;

var employee1 = new Employee("Adam", "Nowicki", 33);

employee1.AddGrade("Dariusz");
employee1.AddGrade("4999");
employee1.AddGrade(10);
employee1.AddGrade(8);
employee1.AddGrade('0');

var statistics = employee1.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");