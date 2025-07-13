using Application.Interface;
using Blazorise;
using Blazorise.Bootstrap;
using Infrastructures.Context;
using Infrastructures.Services;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<IAboutMeService, AboutMeService>();

// ➕ EF Core DbContext
builder.Services.AddDbContext<TodoDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TodoDb")));

// ➕ Servisi Dependency Injection'a ekle
builder.Services.AddScoped<ITodoService, TodoService>();

builder.Services
    .AddBlazorise(options => { options.Immediate = true; })
    .AddBootstrapProviders();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
