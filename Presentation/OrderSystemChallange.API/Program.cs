using Hangfire;
using OrderSystemChallange.API.Schedules;
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

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var connectionString = configuration.GetValue<string>("ConnectionString");

builder.Services.AddHangfire(x => x.UseSqlServerStorage(connectionString));
builder.Services.AddHangfireServer();


var app = builder.Build();

app.UseHangfireDashboard("/job", new DashboardOptions());



if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseHangfireServer(new BackgroundJobServerOptions());
GlobalJobFilters.Filters.Add(new AutomaticRetryAttribute { Attempts = 3 });

RecurringJobs.HourlyCarrierReport();
app.Run();
