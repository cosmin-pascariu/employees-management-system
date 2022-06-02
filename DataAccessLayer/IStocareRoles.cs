using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelAccesDate
{
    public interface IStocareRoles : IStocareFactory
    {
        List<Role> GetRoles();
        Role GetRole(int id);
        bool AddRole(Role r);
        bool UpdateRole(Role r);
        bool DeleteRole(int id);
    }
}
