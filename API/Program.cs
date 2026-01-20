using BookingsApi.Interfaces;
using BookingsApi.Repositories;
using BookingsApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add MVC controller support
builder.Services.AddControllers();
// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//DI for BookingService, BookingRepository
builder.Services.AddScoped<IBookingService, BookingService>();
builder.Services.AddScoped<IBookingRepository, BookingRepository>();
var app = builder.Build();

// Enable Swagger  middleware ONLY in Development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Bookings API V1");
    });
}

app.UseHttpsRedirection();

// Map controller endpoints
app.MapControllers();

app.Run();
