using Dimension_Data_MVC_CORE_Project2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dimension_Data_MVC_CORE_Project2.Data
{
    public class EmployeeContext : DbContext
    {

        public EmployeeContext(DbContextOptions<EmployeeContext> options) 
            : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
