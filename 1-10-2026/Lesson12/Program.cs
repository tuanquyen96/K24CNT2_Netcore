using Microsoft.EntityFrameworkCore;
using VTQNetCoreCrud.Data;
using VTQNetCoreCrud.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("AppConnection");

builder.Services.AddDbContext<VTQAppDbContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<VTQAppDbContext>();

    context.Database.EnsureCreated();

    if (!await context.Categories.AnyAsync())
    {
        context.Categories.AddRange(
            new VTQCategory
            {
                Name = "Đồ uống",
                Status = 1,
                CreatedDate = DateTime.Now
            },
            new VTQCategory
            {
                Name = "Đồ ăn",
                Status = 1,
                CreatedDate = DateTime.Now
            },
            new VTQCategory
            {
                Name = "Bánh ngọt",
                Status = 1,
                CreatedDate = DateTime.Now
            }
        );

        await context.SaveChangesAsync();
    }
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();