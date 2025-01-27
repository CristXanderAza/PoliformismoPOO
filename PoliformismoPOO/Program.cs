// See https://aka.ms/new-console-template for more information
using PoliformismoPOO.Domain;

Console.WriteLine("Testing!");
var employees = _getEmployeeTest();
foreach (var employee in employees)
{
    Console.WriteLine(employee);
    Console.WriteLine(" " + employee.CalculateSalary());
}


static Employee[] _getEmployeeTest()
{
    var employees = new Employee[]
    {
        new TeacherPerHour("Alan", "Montero", "809-235-6543", "Curso de 3d", 12),
        new PermanentTeacher("Luis", "Gomez", "829-423-6785", 40000,"Software"),
        new AdministrativeEmployee("Alexander", "Perez", "849-214-3131",60000, "Admisiones")
    };
    employees[1].IsObtiveCompleted = true;
    return employees;
}