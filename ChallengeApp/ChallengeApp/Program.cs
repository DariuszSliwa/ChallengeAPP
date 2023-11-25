using ChallengeApp;

var employee = new EmployeeInFile("Adam", "Nowicki", 'M', 33);

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

employee.AddGrade(55);
employee.AddGrade('a');
employee.AddGrade("100");
employee.AddGrade("22");
employee.AddGrade("22");

//while (true)
//{
//    Console.WriteLine("Podaj ocenę pracownika: ");
//    var input = Console.ReadLine();

//    if (input == "q")
//    {
//        break;
//    }

//    try
//    {
//        employee.AddGrade(input);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Exception catched: {e.Message}");
//    }
//}

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");