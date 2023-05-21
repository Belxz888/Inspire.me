using Microsoft.EntityFrameworkCore; 
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Infrastructure;
namespace test {

        public class ApiDbContext : DbContext 
        { 
            public ApiDbContext(DbContextOptions<ApiDbContext> options):base(options) {  } 
        }
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
            File.WriteAllText("JsonDeSerialize.json", jsonString);
            Console.WriteLine(jsonString); 

            string fileName = "JsonDeSerialize.json";
            string jsonDeString = File.ReadAllText(fileName);
            IdDeSerialize idDeSerialize = JsonSerializer.Deserialize<IdDeSerialize>(jsonDeString)!;

            Console.WriteLine($"Date: {idDeSerialize.Date}");
            Console.WriteLine($"TemperatureCelsius: {idDeSerialize.TemperatureCelsius}");
            Console.WriteLine($"Summary: {idDeSerialize.Summary}");
              
            
        }   
            
    }

}