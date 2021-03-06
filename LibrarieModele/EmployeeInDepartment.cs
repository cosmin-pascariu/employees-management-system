using System;
using System.Data;

namespace LibrarieModele
{
    public class EmployeeInDepartment
    {
        public int id { get; set; }
        public int employee_id { get; set; }
        public int department_id { get; set; }
        public int role_id { get; set; }
        public DateTime start_date { get; set; }
        public DateTime stop_date { get; set; }
        public char active { get; set; }
        public char isDeleted { get; set; }

        //Load adtional entities
        public virtual Employees Employee { get; set; }
        public virtual Department Department { get; set; }
        public virtual Role Role { get; set; }

        public EmployeeInDepartment()
        { }
        public EmployeeInDepartment(DateTime start_date, DateTime stop_date, char active, int employee_id = 0,int department_id = 0, int role_id = 0, int id = 0, char isDeleted = 'N')
        {
            this.employee_id = employee_id;
            this.department_id = department_id;
            this.role_id = role_id;
            this.start_date = start_date;
            this.stop_date = stop_date;
            this.active = active;
            this.id = id;
            this.isDeleted = isDeleted;
        }

        public EmployeeInDepartment(DataRow lineFromDB)
        {
            this.id = Convert.ToInt32(lineFromDB["id"].ToString());
            this.employee_id = Convert.ToInt32(lineFromDB["employee_id"].ToString());
            this.department_id = Convert.ToInt32(lineFromDB["department_id"].ToString()); ;
            this.role_id = Convert.ToInt32(lineFromDB["role_id"].ToString()); ;
            this.start_date = Convert.ToDateTime(lineFromDB["start_date"].ToString());
            this.stop_date = Convert.ToDateTime(lineFromDB["stop_date"].ToString());
            this.active = Convert.ToChar(lineFromDB["active"].ToString());
            this.isDeleted = Convert.ToChar(lineFromDB["isDeleted"].ToString());
        }
    }
}
