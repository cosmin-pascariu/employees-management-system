using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareDepartments : IStocareDepartments
    {
        private const int FIRST_TABLE= 0;
        private const int FIRST_LINE = 0;

        public List<Department> GetDepartments()
        {
            var result = new List<Department>();
            var dsDepartments = SqlDBHelper.ExecuteDataSet("select * from Departments_SEM", CommandType.Text);

            foreach (DataRow lineFromDB in dsDepartments.Tables[FIRST_TABLE].Rows)
            {
                var department = new Department(lineFromDB);
                result.Add(department);
            }
            return result;
        }

        public Department GetDepartment(int id)
        {
            Department result = null;
            var dsDepartments = SqlDBHelper.ExecuteDataSet("select * from Departments_SEM where department_id = :department_id", CommandType.Text,
                new OracleParameter(":department_id", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsDepartments.Tables[FIRST_TABLE].Rows.Count > 0)
            {
                DataRow lineFromDB = dsDepartments.Tables[FIRST_TABLE].Rows[FIRST_LINE];
                result = new Department(lineFromDB);
            }
            return result;
        }

        public bool AddDepartment(Department d)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "insert into Departments_SEM VALUES (seq_Departments_SEM.nextval, :title, :manager_id)", CommandType.Text, 
                new OracleParameter(":title", OracleDbType.NVarchar2, d.title, ParameterDirection.Input),
                new OracleParameter(":manager_id", OracleDbType.Int32, d.manager_id, ParameterDirection.Input)
            ); ;
        }

        public bool UpdateDepartment(Department d)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE Departments_SEM set title = :title, manager_id = :manager_id where department_id = :department_id", CommandType.Text,  
                new OracleParameter(":title", OracleDbType.NVarchar2, d.title, ParameterDirection.Input),
                new OracleParameter(":manager_id", OracleDbType.Int32, d.manager_id, ParameterDirection.Input),
                 new OracleParameter(":department_id", OracleDbType.Int32, d.department_id, ParameterDirection.Input)
            );
        }
    }
}
