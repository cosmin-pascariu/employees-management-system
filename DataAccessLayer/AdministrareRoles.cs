using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareRoles : IStocareRoles
    {
        private const int FIRST_TABLE = 0;
        private const int FIRST_LINE = 0;

        public List<Role> GetRoles()
        {
            var result = new List<Role>();
            var dsRoles = SqlDBHelper.ExecuteDataSet("select * from Roles_SEM", CommandType.Text);

            foreach (DataRow lineFromDB in dsRoles.Tables[FIRST_TABLE].Rows)
            {
                var role = new Role(lineFromDB);
                result.Add(role);
            }
            return result;
        }

        public Role GetRole(int id)
        {
            Role result = null;
            var dsRoles = SqlDBHelper.ExecuteDataSet("select * from Roles_SEM where role_id = :role_id", CommandType.Text,
                new OracleParameter(":IdMasina", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsRoles.Tables[FIRST_TABLE].Rows.Count > 0)
            {
                DataRow lineFromDB = dsRoles.Tables[FIRST_TABLE].Rows[FIRST_LINE];
                result = new Role(lineFromDB);
                //incarca entitatile aditionale
                //result.Companie = new AdministrareCompanii().GetCompanie(result.IdCompanie);
            }
            return result;
        }

        public bool AddRole(Role r)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "insert into Roles_SEM VALUES (seq_Roles_SEM.nextval, :title)", CommandType.Text,
                new OracleParameter(":title", OracleDbType.NVarchar2, r.title, ParameterDirection.Input)
                
            );
        }

        public bool UpdateRole(Role r)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE Roles_SEM set title = :title where role-id = :role_id", CommandType.Text,
             new OracleParameter(":title", OracleDbType.NVarchar2, r.title, ParameterDirection.Input),
                new OracleParameter(":role_id", OracleDbType.Int32, r.role_id, ParameterDirection.Input)
            );
        }
    }
}
