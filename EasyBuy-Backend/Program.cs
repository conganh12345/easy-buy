using EasyBuy_Backend.Data;
using EasyBuy_Backend.Models;
using EasyBuy_Backend.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using EasyBuy_Backend.Services;

var builder = WebApplication.CreateBuilder(args);


// **Bước 1: Thêm dịch vụ CORS**
builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowAllOrigins", builder =>
	{
		builder
			.AllowAnyOrigin() // Cho phép tất cả các nguồn
			.AllowAnyMethod() // Cho phép tất cả các phương thức
			.AllowAnyHeader(); // Cho phép tất cả các header
	});
});

// Add services to the container.
builder.Services.AddServices();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Đăng ký MyDbContext với Dependency Injection và cấu hình kết nối đến cơ sở dữ liệu SQL Server
builder.Services.AddDbContext<MyDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddRepositories();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// **Bước 2: Áp dụng chính sách CORS**
app.UseHttpsRedirection();
// Thêm dòng này để áp dụng chính sách CORS
app.UseCors("AllowAllOrigins");

app.UseAuthorization();

app.MapControllers();

app.Run();
