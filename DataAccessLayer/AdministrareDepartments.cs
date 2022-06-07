using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;
using System;

namespace NivelAccesDate
{
    public class AdministrareDepartments : IStocareDepartments
    {
        private const int FIRST_TABLE= 0;
        private const int FIRST_LINE = 0;

        public List<Department> GetDepartments()
        {
            var result = new List<Department>();
            var dsDepartments = SqlDBHelper.ExecuteDataSet("select * from Departments_SEM WHERE isDeleted = 'N'", CommandType.Text);

            foreach (DataRow lineFromDB in dsDepartments.Tables[FIRST_TABLE].Rows)
            {
                var department = new Department(lineFromDB);
                department.Manager = new AdministrareEmployees().GetEmployee(department.manager_id);
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
                result.Manager = new AdministrareEmployees().GetEmployee(result.manager_id);
                result = new Department(lineFromDB);
            }
            return result;
        }

        public bool AddDepartment(Department d)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "insert into Departments_SEM VALUES (seq_Departments_SEM.nextval, :title, :manager_id, :isDeleted)", CommandType.Text, 
                new OracleParameter(":title", OracleDbType.NVarchar2, d.title, ParameterDirection.Input),
                new OracleParameter(":manager_id", OracleDbType.Int32, d.manager_id, ParameterDirection.Input),
                new OracleParameter(":isDeleted", OracleDbType.Char, d.isDeleted, ParameterDirection.Input)
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

        public bool DeleteDepartment(int id)
        {
            return SqlDBHelper.ExecuteNonQuery(
                 "UPDATE Departments_SEM set isDeleted ='Y' WHERE department_id = :department_id", CommandType.Text, new OracleParameter(":department_id", OracleDbType.Int32, id, ParameterDirection.Input)
                );
        }

        public int GetDepartmentsNumber()
        {
            var dsResult = SqlDBHelper.ExecuteDataSet("SELECT COUNT(department_id) AS department_no FROM departments_SEM", CommandType.Text);
            DataRow linieBD = dsResult.Tables[FIRST_TABLE].Rows[FIRST_LINE];
            return int.Parse(linieBD["department_no"].ToString());
        }
    }
}
