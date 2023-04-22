using System;
using System.Text.Json;
using System.Text.Json.Serialization;

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

            /*
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World");

            app.Run();
            */
        }
    }
}