using Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CoreContext : DbContext
    {
        public CoreContext(DbContextOptions<CoreContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Company> Company { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Contactdata> Contactdatas { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Project> ProjectList { get; set; }
        public DbSet<ArticleHistory> ArticleHistory { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Article> ArticleList { get; set; }
    }
}

