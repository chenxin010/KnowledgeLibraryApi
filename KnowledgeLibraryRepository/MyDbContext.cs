using KnowledgeLibraryCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeLibraryRepository
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {

        }
        public virtual DbSet<CategoryInfo> CategoryInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Database=KnowledgeLibrary;Data Source=101.43.35.19;User Id=root;Password=Ct990505;pooling=true;CharSet=utf8;port=3306;Allow User Variables=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cc = modelBuilder.Entity<CategoryInfo>(entity =>
            {
                entity.HasKey(y => y.Id);
                entity.ToTable("CategoryInfo");
            });
        }
    }
}
