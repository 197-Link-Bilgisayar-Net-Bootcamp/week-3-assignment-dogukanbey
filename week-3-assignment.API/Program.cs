using Microsoft.EntityFrameworkCore;
using System.Reflection;
using week_3_assignment.Data;
using week_3_assignment.Data.Repositories;
using week_3_assignment.Data.UOW;
using week_3_assignment.Service.Mapping;
using week_3_assignment.Service.Services;
using week_3_assignment.Services.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductFeatureService, ProductFeatureService>();

builder.Services.AddAutoMapper(cfg => cfg.AddProfile<MapProfile>());

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("LocalMSSqlConnection"),
        action => {
            action.MigrationsAssembly("week-3-assignment.Data");
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
