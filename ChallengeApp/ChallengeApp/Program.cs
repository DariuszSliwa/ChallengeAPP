using ChallengeApp;

var employee1 = new Employee("Adam", "Nowicki", 33);
var employee2 = new Employee("Dariusz", "Malinowski", 23);
var employee3 = new Employee("Aleksandra", "Makowiecka", 28);

employee1.AddGrade(5);
employee1.AddGrade(10);
employee1.AddGrade(8);

employee2.AddGrade(9);
employee2.AddGrade(8);
employee2.AddGrade(7);

employee3.AddGrade(1);
employee3.AddGrade(4);
employee3.AddGrade(10);

var statistics = employee1.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");