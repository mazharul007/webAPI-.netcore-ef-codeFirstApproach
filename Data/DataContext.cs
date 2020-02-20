using DattingAppAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DattingAppAPI.Data
{
    public class DataContext  : DbContext 
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Resource>Resources { get; set; }



    }
}
