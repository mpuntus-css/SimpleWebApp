using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);


// Dependency Injection for IDataService
builder.Services.AddSingleton<IDataService>(sp =>
{
    var jsonDataService = new JsonDataService("data.json");
    return new LoggingDataService(jsonDataService);
});


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
