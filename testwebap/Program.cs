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
    app.UseExceptionHandler("Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();


app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
    );
});

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
