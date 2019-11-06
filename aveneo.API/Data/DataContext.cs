using aveneo.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aveneo.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<BusinessEntity> BusinessEntities { get; set; }

        public DbSet<HttpHeaders> HttpHeaders { get; set; }
    }
}