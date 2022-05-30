using LibrarieModele;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareEmployees : IStocareFactory
    {
        List<Employees> GetEmployees();
        Employees GetEmployee(int id);
        bool AddEmployee(Employees e);
        bool UpdateEmployee(Employees e);
        void DeleteEmployee(int id);
    }
}
