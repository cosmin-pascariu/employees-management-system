using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Employees
    {
        public int employee_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string cnp { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public DateTime birth_date { get; set; }
        public DateTime hire_date { get; set; }
        public double salary { get; set; }


        public Employees()
        {

        }

        public Employees( string firstName, string lastName,string cnp, string email, string phoneNumber,DateTime birthDate, DateTime hireDate,double salary, int employeeId = 0)
        {
            employee_id = employeeId;
            first_name = firstName;
            last_name = lastName;
            this.cnp = cnp;
            this.email = email;
            phone_number = phoneNumber;
            birth_date = birthDate;
            hire_date = hireDate;
            this.salary = salary;
        }

        public Employees(DataRow lineFromDB)
        {
            employee_id = Convert.ToInt32(lineFromDB["employee_id"].ToString());
            first_name = lineFromDB["first_name"].ToString();
            last_name = lineFromDB["last_name"].ToString();
            cnp = lineFromDB["cnp"].ToString();
            this.email = lineFromDB["email"].ToString();
            phone_number = lineFromDB["phone_number"].ToString();
            birth_date = Convert.ToDateTime(lineFromDB["birth_date"].ToString());
            hire_date = Convert.ToDateTime(lineFromDB["hire_date"].ToString());
            this.salary = Convert.ToDouble(lineFromDB["salary"].ToString());
        }
    }
}
