using Microsoft.EntityFrameworkCore;
using PequenosEncantos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PequenosEncantos.Infrasctructure.Persistence
{
    public class PequenosEncantosDbContext : DbContext
    {
        public PequenosEncantosDbContext(DbContextOptions<PequenosEncantosDbContext> options) : base(options)
        {

        }

        public DbSet<JobCriation> JobCriation { get; set; }
    }
}
