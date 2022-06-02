using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareEmployees : IStocareEmployees
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
            }
            return result;
        }

        public bool AddEmployee(Employees e)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "insert into Employees_SEM VALUES (seq_Employees_SEM.nextval, :first_name, :last_name, :cnp, :email, :phone_number, :birth_date, :hire_date, :salary)", CommandType.Text,
                new OracleParameter(":first_name", OracleDbType.NVarchar2, e.first_name, ParameterDirection.Input),
                new OracleParameter(":last_name", OracleDbType.NVarchar2, e.last_name, ParameterDirection.Input),
                new OracleParameter(":cnp", OracleDbType.NVarchar2, e.cnp, ParameterDirection.Input),
                new OracleParameter(":email", OracleDbType.NVarchar2, e.email, ParameterDirection.Input),
                new OracleParameter(":phone_number", OracleDbType.NVarchar2, e.phone_number, ParameterDirection.Input),
                new OracleParameter(":birth_date", OracleDbType.Date, e.birth_date, ParameterDirection.Input),
                new OracleParameter(":hire_date", OracleDbType.Date, e.hire_date, ParameterDirection.Input),
                new OracleParameter(":salary", OracleDbType.Int32, e.salary, ParameterDirection.Input)

            );
        }

        public bool UpdateEmployee(Employees e)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE Employees_SEM set first_name = :first_name, last_name = :last_name, cnp =:cnp, email =:email, phone_number = :phone_number, birth_date = :birth_date, hire_date = :hire_date, salary = :salary where employee_id = :employee_id", CommandType.Text,
                new OracleParameter(":first_name", OracleDbType.NVarchar2, e.first_name, ParameterDirection.Input),
                new OracleParameter(":last_name", OracleDbType.NVarchar2, e.last_name, ParameterDirection.Input),
                new OracleParameter(":cnp", OracleDbType.NVarchar2, e.cnp, ParameterDirection.Input),
                new OracleParameter(":email", OracleDbType.NVarchar2, e.email, ParameterDirection.Input),
                new OracleParameter(":phone_number", OracleDbType.NVarchar2, e.phone_number, ParameterDirection.Input),
                new OracleParameter(":birth_date", OracleDbType.Date, e.birth_date, ParameterDirection.Input),
                new OracleParameter(":hire_date", OracleDbType.Date, e.hire_date, ParameterDirection.Input),
                new OracleParameter(":salary", OracleDbType.Int32, e.salary, ParameterDirection.Input),
                new OracleParameter(":employee_id", OracleDbType.Int32, e.employee_id, ParameterDirection.Input)
            );
        }

        public bool DeleteEmployee(int id)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "DELETE from Employees_SEM WHERE employee_id = :employee_id", CommandType.Text, new OracleParameter(":emmployee_id", OracleDbType.Int32, id, ParameterDirection.Input)
                );
        }
    }
}
