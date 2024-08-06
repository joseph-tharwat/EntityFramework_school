using Microsoft.EntityFrameworkCore;

namespace EF_simple.Models
{
    public class SchoolDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(Connection.SqlString);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<StudentBook> StudentBooks { get; set; }
        public DbSet<Gender> Genders { get; set; }

        //fluent Api
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Change defualt constraint one by one
            //modelBuilder.Entity<Student>().HasOne(s => s.grade).WithOne(G => G.student).OnDelete(DeleteBehavior.Restrict);
            //modelBuilder.Entity<Department>().HasMany(D => D.students).WithOne(S => S.department).OnDelete(DeleteBehavior.Restrict);

            //Change defualt constraint for all Forign key
            foreach (var ForignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                ForignKey.DeleteBehavior = DeleteBehavior.Cascade;
            }

            //data Annotation
            modelBuilder.Entity<Student>().Property(s => s.Name).HasColumnName("studentName");
            modelBuilder.Entity<Student>().ToTable("std");

            //computed columns
            modelBuilder.Entity<Grade>().Property(g => g.TotalGrade).HasComputedColumnSql("[Physics] + [Math] + [Arabic]");
            modelBuilder.Entity<Student>().Property(s => s.Age).HasDefaultValue(18);

            //add index to a column
            modelBuilder.Entity<Student>().HasIndex("Name");
            //modelBuilder.Entity<Student>().HasIndex(s => s.Name);
            //modelBuilder.Entity<Student>().HasIndex("Name").IsUnique();

            //add sequance between many columns in many tables
            modelBuilder.HasSequence<int>("EnteredOrder").StartsAt(10).IncrementsBy(1);  
            modelBuilder.Entity<Student>().Property(s => s.Order).HasDefaultValueSql("NEXT VALUE FOR EnteredOrder");
            modelBuilder.Entity<Book>().Property(b => b.Order).HasDefaultValueSql("NEXT VALUE FOR EnteredOrder");

            //seed
            modelBuilder.Entity<Gender>().HasData(
                new Gender() { Id=1, Name = "Male"},
                new Gender() { Id=2, Name ="Female"}
                );
        }
    }
}
