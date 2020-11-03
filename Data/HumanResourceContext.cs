using Dimension_Data_MVC_CORE_Project2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dimension_Data_MVC_CORE_Project2.Data
{
    public class HumanResourceContext : DbContext
    {

        public HumanResourceContext(DbContextOptions<HumanResourceContext> options)
            : base(options)
        {
        }

        public DbSet<HumanResource> HumanResources { get; set; }
    }
}
