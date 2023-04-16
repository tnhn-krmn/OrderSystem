using Hangfire;
using OrderSystemChallange.Application;
using OrderSystemChallange.Persistence;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices();

builder.Services.AddHangfire(x => x.UseSqlServerStorage(Configuration.ConnectionString));
builder.Services.AddHangfireServer();


var app = builder.Build();

app.UseHangfireDashboard("/job", new DashboardOptions());

app.UseHangfireServer(new BackgroundJobServerOptions());
//RecurringJobs.HourlyCarrierReportOperation();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
