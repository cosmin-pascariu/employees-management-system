using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareEmployees
    {
        private const int FIRST_TABLE = 0;
        private const int FIRST_LINE = 0;

        public List<Employees> GetEmployees()
        {
            var result = new List<Employees>();
            var dsEmployees = SqlDBHelper.ExecuteDataSet("select * from Employees_SEM", CommandType.Text);

            foreach (DataRow lineFromDB in dsEmployees.Tables[FIRST_TABLE].Rows)
            {
                var employee = new Employees(lineFromDB);
                result.Add(employee);
            }
            return result;
        }

        public Employees GetEmployee(int id)
        {
            Employees result = null;
            var dsEmployees = SqlDBHelper.ExecuteDataSet("select * from Employees_SEM where employee_id = :employee_id", CommandType.Text,
                new OracleParameter(":emmployee_id", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsEmployees.Tables[FIRST_TABLE].Rows.Count > 0)
            {
                DataRow lineFromDB = dsEmployees.Tables[FIRST_TABLE].Rows[FIRST_LINE];
                result = new Employees(lineFromDB);
                //incarca entitatile aditionale
               // result.Companie = new AdministrareCompanii().GetCompanie(result.IdCompanie);
            }
            return result;
        }
    }
}
