using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinantialOrganizationAPI_ASP.NetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace FinantialOrganizationAPI_ASP.NetCore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Financial> Financials { get; set; }
        
    }
}