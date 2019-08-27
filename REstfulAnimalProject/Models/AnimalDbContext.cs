using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REstfulAnimalProject.Models {
    public class AnimalDbContext : DbContext{

        public DbSet<Animal> Animals { get; set; }

     


        public AnimalDbContext(DbContextOptions options) : base(options) { }

    }
}
