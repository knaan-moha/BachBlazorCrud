using BachCrud.Server.Models;
using BlazorCrud.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace BachCrud.Server.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    
  
    public virtual DbSet<Student> Students { get; set; }
    public virtual DbSet<Course>  Courses{ get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        

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
        modelBuilder.Entity<Student>().HasData(new Student          
        {                                                           
            Id = 4,                                                 
            FirstName = "Mo",                                     
            LastName = "Ali",                                   
            Email = "mo@uia.no",                                 
            PhoneNumber = "004348",
            Age = 25,
            RegistrationDate = DateTime.Today,                      
            CourseId = 2                                            
                                                             
                                                             
                                                             
        });

        var numberOfStudentsData = 20;
        var students = new List<Student>();
        var random = new Random(); 
        
        var firstNames = new List<string>
        {
            "Alisa",
            "Alisia",
            "Alisain",
            "Alex ",
            "Alita",
            "Alix",
            "Aliza",
            "Alla",
            "Allan",
            "Alleen",
            "Allegra",
            "Allen",
            "Allen",
            "Allena",
            "Allene",
            "Allie",
            "Alline",
            "Allison",
            "Allyn",
            "Allyson",
           
        };
        var lastNames = new List<string>
        {
            "Buffy",
            "Buford",
            "Bula",
            "Bulah",
            "Bunny",
            "Burl",
            "Burma",
            "Burt",
            "Burton",
            "Buster",
            "Byron",
            "Caitlin",
            "Caitlyn",
            "Calandra",
            "Caleb",
            "Calista",
            "Callie",
            "Calvin",
            "Camelia",
            "Camellia",

            
        };

        for (int i = 1; i <= numberOfStudentsData; i++)
        {
            var firstNameIndex = random.Next(firstNames.Count);
            var lastNameIndex = random.Next(lastNames.Count);
            var firstName = firstNames[firstNameIndex];
            var lastName = lastNames[lastNameIndex];
            var age = random.Next(18, 45); 
            
            students.Add(new Student
            {
                Id = 4 + i, 
                FirstName = firstName, 
                LastName = lastName, 
                Email = $"{firstName.ToLower()}{i}@uia.no", 
                Age = age, 
                PhoneNumber = $"486797{i}",
                RegistrationDate = DateTime.Today, 
                CourseId = random.Next(1, 4), 
            });
            
        }
        
        modelBuilder.Entity<Student>().HasData(students); 

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