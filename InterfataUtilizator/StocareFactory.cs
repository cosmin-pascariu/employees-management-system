using NivelAccesDate;
using System;
using System.Collections.Generic;
using System.Configuration;
using LibrarieModele;

namespace InterfataUtilizator
{
    /// <summary>
    /// Factory Design Pattern
    /// </summary>
    public class StocareFactory
    {
        public IStocareFactory GetTipStocare(Type tipEntitate)
        {
            var formatSalvare = ConfigurationManager.AppSettings["FormatSalvare"];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "BazaDateOracle":

                        if (tipEntitate == typeof(Companie))
                        {
                            return new AdministrareCompanii();
                        }
                        if (tipEntitate == typeof(Masina))
                        {
                            return new AdministrareMasini();
                        }
                        if (tipEntitate == typeof(Employees))
                        {
                            return new AdministrareEmployees();
                        }
                        if (tipEntitate == typeof(Role))
                        {
                            return new AdministrareRoles();
                        }
                        if (tipEntitate == typeof(Department))
                        {
                            return new AdministrareDepartments();
                        }
                        if(tipEntitate == typeof(EmployeeInDepartment))
                        {
                            return new AdministrareEmployeesInDepartments();
                        }
                        break;
                    case "BIN":
                        //instantiere clase care realizeaza salvarea in fisier binar
                        break;
                }
            }
            return null;
        }
    }
}
