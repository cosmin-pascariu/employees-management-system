using LibrarieModele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAccesDate
{
    public interface IStocareEmployees:IStocareFactory
    {
        List<Employees> GetEmployees();
        Employees GetEmployee(int id);
        bool AddEmployee(Employees e);
        bool UpdateEmployee(Employees e);
    }
}
