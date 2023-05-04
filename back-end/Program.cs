using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Npgsql;
using Microsoft.EntityFrameworkCore;

namespace Main
{
        public class IdSerialize
        {
            public DateTimeOffset DateS { get; set; }
            public int TemperatureCelsiusS { get; set; }
            public string? SummaryS { get; set; }
        }
        public class IdDeSerialize
        {
            public DateTimeOffset Date {get; set; } 
            public int TemperatureCelsius { get; set; }
            public string? Summary{ get; set; }
        }
        public class User
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public int Age { get; set; }
        }
        public class ApplicationContext : DbContext
        {
                public DbSet<User> Users { get; set; } = null!;
            
                public ApplicationContext()
                {
                    Database.EnsureCreated();
                }
                protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                {
                    optionsBuilder.UseNpgsql("Host=http://localhost:7034;Port=5432;Database=postgresql;Username=postgres;Password=123");
                }
        }
    public class Program 
    {
        

        public static void Main()
        {
            var idSerialize= new IdSerialize
            {
                DateS = DateTime.Parse("2019-08-01"),
                TemperatureCelsiusS = 25,
                SummaryS = "Hot"   
            };

            string jsonString = JsonSerializer.Serialize(idSerialize);
            File.WriteAllText("JsonSerialize.json", jsonString);
            Console.WriteLine(jsonString);
            

            //Десериализация
            string jsonDeString =
            @"{
            ""Date"": ""2019-08-01T00:00:00-07:00"",
            ""TemperatureCelsius"": 25,
            ""Summary"": ""Hot""
            }
            ";

            Deserialize? deSerialize = 
                JsonSerializer.Deserialize<Deserialize>(jsonDeString);

            File.WriteAllText("JsonDeSerialize.json", jsonDeString);
            Console.WriteLine(jsonDeString);

            
            using (ApplicationContext db = new ApplicationContext())
            {
                // создаем два объекта User
                User user1 = new User { Name = "Tom", Age = 33 };
                User user2 = new User { Name = "Alice", Age = 26 };
            
                // добавляем их в бд
                db.Users.AddRange(user1, user2);
                db.SaveChanges();
            }
            // получение данных
            using (ApplicationContext db = new ApplicationContext())
            {
                // получаем объекты из бд и выводим на консоль
                var users = db.Users.ToList();
                Console.WriteLine("Users list:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }
            /*
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World");

            app.Run();
            */
        }   
            
    }
}