using Microsoft.EntityFrameworkCore;
using ToDoListApp.Data;
using ToDoListApp.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages(opt =>
{
    opt.Conventions.AddPageRoute("/Tasks/Index", "");
});

builder.Services.AddDbContext<ToDoDbContext>(opt => opt.UseSqlite("Data Source=Data/ToDoList.db"));

var app = builder.Build();

app.UseMiddleware<RequestLoggingMiddleware>();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
