using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages;

public class EmployeeListBase:ComponentBase
{
    public IEnumerable<Employee> Employees { get; set; }

    protected override async Task OnInitializedAsync()
    {
       LoadEmployees();
    }

    private void LoadEmployees()
    {
        Employee e1 = new()
        {
            EmployeeId = 1,
            FirstName = "John",
            LastName = "Hastings",
            Email = "John@ourcompany.com",
            DateOfBirth = new DateOnly(1980, 5, 12),
            Gender = Gender.Male,
            Department = new Department { DepartmentId = 1, DepartmentName = "Accounts" },
            PhotoPath = "images/john.png"
        };

        Employee e2 = new()
        {
            EmployeeId = 1,
            FirstName = "James",
            LastName = "Hastings",
            Email = "James@ourcompany.com",
            DateOfBirth = new DateOnly(1981, 6, 111),
            Gender = Gender.Female,
            Department = new Department { DepartmentId = 2, DepartmentName = "HR" },
            PhotoPath = "images/james.png"
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
            PhotoPath = "images/jude.png"
        };

        Employees = new List<Employee> { e1, e2, e3};
    }
}
