using BugTracer.Data;
using BugTracer.Services.Priority_Service;
using BugTracer.Services.Project_Service;
using BugTracer.Services.Resource_Service;
using BugTracer.Services.Status_Service;
using BugTracer.Services.Ticket_Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<BugTracerDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCors();

builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IProjectService, ProjectService>();
builder.Services.AddTransient<IResourceService, ResourceService>();
builder.Services.AddTransient<ITicketService, TicketService>();
builder.Services.AddTransient<IPriorityService, PriorityService>();
builder.Services.AddTransient<IStatusService, StatusService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();
