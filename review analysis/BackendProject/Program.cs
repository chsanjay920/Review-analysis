
using Microsoft.AspNetCore.SpaServices.AngularCli;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuring ASP.NET Core to Serve Angular Files
builder.Services.AddSpaStaticFiles(configuration =>
    {
        configuration.RootPath = "frontend-project/dist/frontend-project";
    });
//cors
builder.Services.AddCors();
builder.Services.AddMvc()
        .AddSessionStateTempDataProvider();
builder.Services.AddSession();

var app = builder.Build();

//cors
app.UseCors(builder =>
        builder.WithOrigins("https://localhost:5001"));

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();
if (!app.Environment.IsDevelopment())
{
    app.UseSpaStaticFiles();
}
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "api/{controller}/{action=Index}/{id?}");
            });
app.UseSpa(spa =>
{
    spa.Options.SourcePath = "frontend-project";
    if (app.Environment.IsDevelopment())
    {
        spa.UseAngularCliServer(npmScript: "start");
    }
});


app.MapControllers();

app.Run();
