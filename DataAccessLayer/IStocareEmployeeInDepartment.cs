using LibrarieModele;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareEmployeeInDepartment : IStocareFactory
    {
        List<EmployeeInDepartment> GetEmployeesInDepartments();
        EmployeeInDepartment GetEmployeeInDepartment(int id);
        bool AddEmployeeInDepartment(EmployeeInDepartment ed);

        bool UpdateEmployeeInDepartment(EmployeeInDepartment ed);
    }
}
