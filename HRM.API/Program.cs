using HRM.Data;
using HRM.Services.API.benefits;
using HRM.Services.API.department;
using HRM.Services.API.employee;
using HRM.Services.API.performance;
using HRM.Services.API.position;
using HRM.Services.API.recruitment;
using HRM.Services.API.salary;
using HRM.Services.API.shift;
using HRM.Services.API.training;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBenefitsServices,BenefitsServices>();
builder.Services.AddScoped<IDepartmentServices,DepartmentServices>();
builder.Services.AddScoped<IEmployeeServices,EmployeeServices>();
builder.Services.AddScoped<IPerformanceServices, PerformanceServices>();
builder.Services.AddScoped<IPositionServices, PositionServices>();
builder.Services.AddScoped<IRecruitmentServices, RecruitmentServices>();
builder.Services.AddScoped<ISalaryServices, SalaryServices>();
builder.Services.AddScoped<IShiftServices, ShiftServices>();
builder.Services.AddScoped<ITrainingServices, TrainingServices>();

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
