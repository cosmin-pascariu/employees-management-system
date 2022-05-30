using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Role
    {
        public int role_id { get; set; }
        public string title { get; set; }

        public Role()
        {

        }

        public Role(string title, int role_id = 0)
        {
            this.title = title;
            this.role_id = role_id;
        }

        public Role(DataRow lineFromDB)
        {
            role_id = Convert.ToInt32(lineFromDB["role_id"].ToString());
            title = lineFromDB["title"].ToString();
        }
    }  
}
