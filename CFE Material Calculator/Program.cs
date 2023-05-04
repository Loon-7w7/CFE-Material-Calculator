using AutoMapperService.Mappers;
using CFE_Material_Calculator.Data;
using CFE_Material_Calculator.Exceptios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Writers;
using Persistence;
using Services.Implementacion;
using Services.Repositorios;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
//apis controlers
builder.Services.AddMvc(options => options.EnableEndpointRouting = false)
    .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);
builder.Services.AddControllers
    (
        options => options.Filters.Add(typeof(GlobalExceptionHandler))
    );
// Servicios
builder.Services.AddScoped<DeviceRepository,DeviceService>();
builder.Services.AddScoped<MaterialRepository, MaterialService>();
builder.Services.AddScoped<ConsultationRepository, ConsultationService>();
///AutoMapper
builder.Services.AddAutoMapper(typeof(DeviceMapper), typeof(MaterialMapper));
// Context
builder.Services.AddDbContext<DataBaseContext>
    (
        option => option.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection")))
    );
// Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Mi API", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
using (var Scope = app.Services.CreateScope())
{
    var aplicarionContext = Scope.ServiceProvider.GetRequiredService<DataBaseContext>();
    aplicarionContext.Database.Migrate();
}
//Swagger
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");

});
app.UseMvcWithDefaultRoute();
app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
