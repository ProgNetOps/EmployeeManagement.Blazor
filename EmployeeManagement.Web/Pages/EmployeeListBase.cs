using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages;

public class EmployeeListBase:ComponentBase
{
    public IEnumerable<Employee> Employees { get; set; }

    protected override async Task OnInitializedAsync()
    {
       await Task.Run(LoadEmployees);
    }

    private void LoadEmployees()
    {

        System.Threading.Thread.Sleep(3000);
        Employee e1 = new()
        {
            EmployeeId = 1,
            FirstName = "Joe",
            LastName = "Stones",
            Email = "Joe@ourcompany.com",
            DateOfBirth = new DateOnly(1980, 5, 12),
            Gender = Gender.Female,
            Department = new Department { DepartmentId = 1, DepartmentName = "Accounts" },
            PhotoPath = "images/john.jpeg"
        };

        Employee e2 = new()
        {
            EmployeeId = 1,
            FirstName = "James",
            LastName = "Hastings",
            Email = "James@ourcompany.com",
            DateOfBirth = new DateOnly(1981, 6, 11),
            Gender = Gender.Male,
            Department = new Department { DepartmentId = 2, DepartmentName = "HR" },
            PhotoPath = "images/james.jpeg"
        };

        Employee e3 = new()
        {
            EmployeeId = 1,
            FirstName = "Jude",
            LastName = "Hastings",
            Email = "Jude@ourcompany.com",
            DateOfBirth = new DateOnly(1982, 7, 10),
            Gender = Gender.Other,
            Department = new Department { DepartmentId = 3, DepartmentName = "Technical" },
            PhotoPath = "images/jude.jpeg"
        };

        Employees = new List<Employee> { e1, e2, e3};
    }
}
