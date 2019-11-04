using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMAIN;

namespace INFRAESTRUCTURE
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(): base("name = MVCAjaxDB")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
