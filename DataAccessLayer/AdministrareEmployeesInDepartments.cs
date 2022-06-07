using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareEmployeesInDepartments : IStocareEmployeeInDepartment
    {
        private const int FIRST_TABLE = 0;
        private const int FIRST_LINE = 0;

        public List<EmployeeInDepartment> GetEmployeesInDepartments()
        {
            var result = new List<EmployeeInDepartment>();
            var dsEmployeesInDepartments = SqlDBHelper.ExecuteDataSet("select * from EmployeesInDepartments WHERE isDeleted = 'N'", CommandType.Text);

            foreach (DataRow lineFromDB in dsEmployeesInDepartments.Tables[FIRST_TABLE].Rows)
            {
                var employeeInDepartment = new EmployeeInDepartment(lineFromDB);
                employeeInDepartment.Employee = new AdministrareEmployees().GetEmployee(employeeInDepartment.employee_id);
                employeeInDepartment.Department = new AdministrareDepartments().GetDepartment(employeeInDepartment.department_id);
                employeeInDepartment.Role = new AdministrareRoles().GetRole(employeeInDepartment.role_id);
                result.Add(employeeInDepartment);
            }
            return result;
        }

        public EmployeeInDepartment GetEmployeeInDepartment(int id)
        {
            EmployeeInDepartment result = null;
            var dsEmployeesInDepartments = SqlDBHelper.ExecuteDataSet("select * from EmployeesInDepartments where id = :id", CommandType.Text,
                new OracleParameter(":id", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsEmployeesInDepartments.Tables[FIRST_TABLE].Rows.Count > 0)
            {
                DataRow lineFromDB = dsEmployeesInDepartments.Tables[FIRST_TABLE].Rows[FIRST_LINE];
                result = new EmployeeInDepartment(lineFromDB);
                result.Employee = new AdministrareEmployees().GetEmployee(result.employee_id);
                result.Department = new AdministrareDepartments().GetDepartment(result.department_id);
                result.Role = new AdministrareRoles().GetRole(result.role_id);
            }
            return result;
        }

        public bool AddEmployeeInDepartment(EmployeeInDepartment ed)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "insert into EmployeesInDepartments VALUES (seq_EmployeesInDepartments.nextval,:employee_id, :department_id, :role_id, :start_date, :stop_date, :active, :isDeleted)", CommandType.Text,
                new OracleParameter(":employee_id", OracleDbType.Int32, ed.employee_id, ParameterDirection.Input),
                new OracleParameter(":department_id", OracleDbType.Int32, ed.department_id, ParameterDirection.Input),
                  new OracleParameter(":role_id", OracleDbType.Int32, ed.role_id, ParameterDirection.Input),
                new OracleParameter(":start_date", OracleDbType.Date, ed.start_date, ParameterDirection.Input),
                new OracleParameter(":stop_date", OracleDbType.Date, ed.stop_date, ParameterDirection.Input),
                new OracleParameter(":active", OracleDbType.Char, ed.active, ParameterDirection.Input),
                new OracleParameter(":isDeleted", OracleDbType.Char, ed.isDeleted, ParameterDirection.Input)
            );
        }

        public bool UpdateEmployeeInDepartment(EmployeeInDepartment ed)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE EmployeesInDepartments set employee_id = :employee_id, department_id = :department_id, role_id = :role_id, start_date = :start_date, stop_date = :stop_date, active = :active where id = :id", CommandType.Text,
                new OracleParameter(":employee_id", OracleDbType.Int32, ed.employee_id, ParameterDirection.Input),
                 new OracleParameter(":department_id", OracleDbType.Int32, ed.department_id, ParameterDirection.Input),
                  new OracleParameter(":role_id", OracleDbType.Int32, ed.role_id, ParameterDirection.Input),
                new OracleParameter(":start_date", OracleDbType.Date, ed.start_date, ParameterDirection.Input),
                new OracleParameter(":stop_date", OracleDbType.Date, ed.stop_date, ParameterDirection.Input),
                new OracleParameter(":active", OracleDbType.Char, ed.active, ParameterDirection.Input),
                new OracleParameter(":id", OracleDbType.Int32, ed.id, ParameterDirection.Input)
            );
        }

        public bool DeleteEmployeeInDepartment(int id)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE EmployeesInDepartments set isDeleted ='Y' WHERE id = :id", CommandType.Text, new OracleParameter(":id", OracleDbType.Int32, id, ParameterDirection.Input)
                );
        }
    }
}
