using EF_simple.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}








app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


test();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();



void test()
{

    SchoolDbContext db = new SchoolDbContext();

    //var std = db.Students
    //                    .Include(s => s.department) // Eager loading of related data
    //                    .FirstOrDefault(s => s.Id == 2);
    //Console.WriteLine(std.department.Name);

    //var std = db.Students.FirstOrDefault(s => s.Id == 2);
    //db.Entry(std).Reference(s => s.department).Load(); //Explicit loading
    //Console.WriteLine(std.department.Name);

    //var std = db.Students.FirstOrDefault(s => s.Id == 2); 
    //Console.WriteLine(std.department.Name); // lazy loading, But must use proxicy in OnConfiguring in dbContext


    var trans = db.Database.BeginTransaction();
    try
    {
        db.Students.Add(new Student() { Name = "trans11", DepartmentId = 1 });
        db.Students.Add(new Student() { Name = "trans22", DepartmentId = 1 });
        db.SaveChanges();
        trans.CreateSavepoint("point1");
        db.Students.Add(new Student() { Name = "trans33" });
        db.Students.Add(new Student() { Name = "trans44", DepartmentId = 1 });
        db.SaveChanges();

        trans.Commit();
        Console.WriteLine("done");
    }
    catch(Exception)
    {
        try
        {
            trans.RollbackToSavepoint("point1");
            trans.Commit();
            Console.WriteLine("part one saved");
        }
        catch (Exception)
        {
            trans.Rollback();
            Console.WriteLine("Mothing saved");
        }
        
    }
    

    



}