using BrainRing.Data.Context;
using BrainRing.Hubs;
using BrainRing.Interfaces;
using BrainRing.Repositories;
using BrainRing.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("SQLiteDB");

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSignalR();

builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlite(connectionString));

builder.Services.AddScoped<ITeamAnswerRepository, TeamAnswerRepository>();
builder.Services.AddScoped<ITeamAnswerService, TeamAnswerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.MapHub<AnswerHub>("/answerHub");

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "admin",
    pattern: "admin",
    defaults: new { controller = "Home", action = "Admin" });

app.Run();
