using Microsoft.EntityFrameworkCore;
using test;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
        builder.Services.AddEntityFrameworkNpgsql().AddDbContext<ApiDbContext>(opt => 
        opt.UseNpgsql(builder.Configuration.GetConnectionString("SampleDbConnection")));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
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
       
        
   /* public class Program 
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

            

            
           
           
            
        }   
            
    }
    */