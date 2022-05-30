﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Department
    {
        public int department_id { get; set; }
        public string title { get; set; }
        public int manager_id { get; set; }

        public Department()
        { }
        public Department(string title, int manager_id , int department_id = 0)
        {
            this.department_id = department_id;
            this.title = title;
            this.manager_id = manager_id;
        }

        public Department(DataRow lineFromDB)
        {
            department_id = Convert.ToInt32(lineFromDB["department_id"].ToString());
            title = lineFromDB["title"].ToString();
            manager_id = Convert.ToInt32(lineFromDB["manager_id"].ToString());
        }
    }
}
