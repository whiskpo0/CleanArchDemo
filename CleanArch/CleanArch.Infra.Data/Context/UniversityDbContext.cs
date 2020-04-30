using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Context
{
    public class UniversityDbContext : DbContext 
    {
        public UniversityDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Course> Course { get; set; }

    }
}
