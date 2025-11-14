using ComicsWebApi.Data;
using ComicsWebApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddIdentity<User, IdentityRole>(op =>
{
    op.SignIn.RequireConfirmedEmail = true;
    op.User.RequireUniqueEmail = true;
    op.Password.RequiredLength = 6;
    op.Password.RequireUppercase = true;
    op.Password.RequireDigit = true;
    op.Password.RequireLowercase = true;

}).AddDefaultTokenProviders().AddSignInManager();

builder.Services.AddDbContext<AppDbContext>(op => op.UseSqlServer(builder.Configuration["ConnectionStrings:Default"]));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();



app.Run();

