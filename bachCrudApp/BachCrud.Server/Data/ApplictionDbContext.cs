using BachCrud.Server.Models;
using BlazorCrud.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace BachCrud.Server.Data;

public class ApplictionDbContext : DbContext
{
    public ApplictionDbContext(DbContextOptions<ApplictionDbContext> options) : base(options)
    {
        
    }
    
    public virtual DbSet<Employee> Employees { get; set;  }
    public virtual DbSet<Department> Departments { get; set; }
    public virtual DbSet<Student> Students { get; set; }
    public virtual DbSet<Course>  Courses{ get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        modelBuilder.Entity<Employee>().HasData(new Employee
        {
            Id= 1,
            FullName = "knaan Mohamed",
            HireData = DateTime.Now,
            Salary = 98,
            DepartmentId = 1


        }); 
        
        modelBuilder.Entity<Employee>().HasData(new Employee
        {
            Id = 2,
            FullName = "knaan Mohamed",
            HireData = DateTime.Now,
            Salary = 98,
           DepartmentId = 2


        }); 
        
        modelBuilder.Entity<Department>().HasData(new Department
        {
           Id = 1, 
           Name = "HR",


        }); 
        
        modelBuilder.Entity<Department>().HasData(new Department
        {
            Id = 2, 
            Name = "IT",


        });





        modelBuilder.Entity<Student>().HasData(new Student
        {
             Id = 1, 
             FirstName = "knaan", 
             LastName = "Mohamed",
             Age = 23,
             Email = "mohamedzekaria@uia.no", 
             PhoneNumber = "0045845858", 
             RegistrationDate = DateTime.Today, 
             CourseId = 1
             


        });
        
        
        
        modelBuilder.Entity<Student>().HasData(new Student                       
        {                                                                        
            Id = 2,                                                             
            FirstName = "zeka",                                                
            LastName = "Mohamed",                                               
            Email = "moham@uia.no", 
            Age = 24,
            PhoneNumber = "0045845858",                                         
            RegistrationDate = DateTime.Today,                                  
            CourseId = 2                                                        
                                                                           
                                                                           
                                                                           
        });   
        
        
        
        modelBuilder.Entity<Student>().HasData(new Student          
        {                                                           
            Id = 3,                                                 
            FirstName = "Mo",                                     
            LastName = "Ali",                                   
            Email = "mo@uia.no",                                 
            PhoneNumber = "004348",
            Age = 25,
            RegistrationDate = DateTime.Today,                      
            CourseId = 3                                            
                                                             
                                                             
                                                             
        });

        modelBuilder.Entity<Course>().HasData(new Course
        {
            Id = 1,
            Name = "IKT-205"

        });
        
        
        modelBuilder.Entity<Course>().HasData(new Course           
        {                                                          
            Id = 2,                                                
            Name = "IKT-206"                                       
                                                             
        });
        
        modelBuilder.Entity<Course>().HasData(new Course           
        {                                                          
            Id = 3,                                                
            Name = "IKT-203"                                       
                                                             
        });                                                        
        
       
    }
}