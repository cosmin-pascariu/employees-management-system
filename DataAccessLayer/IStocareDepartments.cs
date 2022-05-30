using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelAccesDate
{
    public interface IStocareDepartments:IStocareFactory
    {
        List<Department> GetDepartments();
        Department GetDepartment(int id);
        bool AddDepartment(Department d);

        bool UpdateDepartment(Department d);
    }
}
