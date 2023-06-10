using Microsoft.EntityFrameworkCore;
using Models;
using Services.Users;
using Services.repository;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Identity;
using Services.Transactions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient(typeof(Context));

builder.Services.AddDbContext<Context>(e => { e.UseSqlServer("server=.;database=EPLDB;Trusted_Connection=True");}).AddIdentity<User,IdentityRole>().AddRoles<IdentityRole>().AddEntityFrameworkStores<Context>();
builder.Services.AddTransient(typeof(Irepository<>), typeof(Repository<>));
builder.Services.AddTransient(typeof(IUserService), typeof(UserService));
builder.Services.AddTransient(typeof(ITransServiceInterface1), typeof(TransService));

builder.Services.AddSignalR(e => e.EnableDetailedErrors = true);

builder.Services.AddCors(options => options.AddPolicy(MyAllowSpecificOrigins, builder =>
{
    builder.AllowAnyOrigin();
    builder.AllowAnyMethod();
    builder.AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.UseRouting();

app.MapControllers();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.Run();
