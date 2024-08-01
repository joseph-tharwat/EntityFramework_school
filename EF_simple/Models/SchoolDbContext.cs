using Microsoft.EntityFrameworkCore;

namespace EF_simple.Models
{
    public class SchoolDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connection.SqlString);
        }

        private DbSet<Student> Students { get; set; }
        private DbSet<Department> Departments { get; set; }
        private DbSet<Grade> Grades { get; set; }
        private DbSet<Book> Books { get; set; }
        private DbSet<StudentBook> StudentBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Student>().HasOne(s => s.grade).WithOne(G => G.student).OnDelete(DeleteBehavior.Restrict);
            //modelBuilder.Entity<Department>().HasMany(D => D.students).WithOne(S => S.department).OnDelete(DeleteBehavior.Restrict);

            foreach (var ForignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                ForignKey.DeleteBehavior = DeleteBehavior.Cascade;
            }
        }
    }
}
