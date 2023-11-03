using ChallengeApp;

Employee employee1 = new Employee("Adam", "Nowicki", 33);
Employee employee2 = new Employee("Dariusz", "Malinowski", 23);
Employee employee3 = new Employee("Aleksandra", "Makowiecka", 28);

employee1.AddScore(5);
employee1.AddScore(10);
employee1.AddScore(8);

employee2.AddScore(9);
employee2.AddScore(8);
employee2.AddScore(7);

employee3.AddScore(1);
employee3.AddScore(4);
employee3.AddScore(10);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine(employeeWithMaxResult.showInformationAboutEmployee);