using EPAM.CoreModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.DataAccess.EntityFramework
{
    public class EPAMDBContext : DbContext
    {
        //readonly string connectionString = ConfigurationManager.ConnectionStrings["EPAMConnectionString"].ConnectionString;
        public EPAMDBContext() : base("EPAMConnectionString")
        {
            
        }
        public DbSet<Employees> EmployeesTable { get; set; }
        public DbSet<Master_Gender> MasterGenders { get; set; }
        public DbSet<Master_Quarter> MasterQuarters { get; set; }
        public DbSet<Master_Stream> MasterStreams { get; set; }



        //public DbSet<EmployeesParameters> EmployeesTable { get; set; }

    }
}
