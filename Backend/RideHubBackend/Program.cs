var builder = WebApplication.CreateBuilder(args);

// Enable CORS for Angular (Frontend)
builder.Services.AddCors(options =>
{
    options.AddPolicy("RideHubPolicy", policy =>
    {
        policy.WithOrigins("http://localhost:4200") // Allow only Angular
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddControllers();
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors("RideHubPolicy");

//if (app.Environment.IsDevelopment()) // Ensure Swagger runs in development mode
//{
//    app.UseSwagger();
//    app.UseSwaggerUI(c =>
//    {
//        c.SwaggerEndpoint("/swagger/v1/swagger.json", "RideHub API v1");
//    });
//}

app.UseAuthorization();
app.MapControllers();

app.Run();
