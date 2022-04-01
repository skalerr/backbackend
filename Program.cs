// using AutoMapper;
// dotnet ef migrations add -c datacontext1 init2
global using backbackend.Data;
global using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using backbackend.Models;
//var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins";


var builder = WebApplication.CreateBuilder(args);
//enable cors
//builder.Services.AddCors(c =>
//{
//    c.AddPolicy("AllowOrigin", options => options.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
//});



// builder.Services.AddCors(options =>
// {
//     options.AddPolicy(name: MyAllowSpecificOrigins,
//                       builder =>
//                       {
//                           builder.AllowAnyHeader().AllowAnyMethod().WithMethods("PUT", "DELETE", "GET", "OPTIONS");
//                         //   WithOrigins("http://localhost:8080/",
//                         //                       "http://www.contoso.com")
//                       });
// });

// Add services to the container.
// json serializer
//builder.Services.AddControllers().AddJsonOptions(options => { options.JsonSerializerOptions.PropertyNamingPolicy = null; });
// builder.Services.AddControllersWithViews().NewtonsoftJson(options=>
//     options.SerializerSettings.ReferenceLoopHandling=Newtonsoft.Json.ReferenceLoopHandling.Ignore).AddNewtonsoftJson(options=>
//     options.SerializerSettings.ContactResolver=new DefaultContractResolver());

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// builder.Services.AddAutoMapper(typeof(Program));
// builder.Services.AddScoped<ICharacterService, CharacterService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// json serializer


// app.UseHttpsRedirection();
//app.UseCors(MyAllowSpecificOrigins);
//app.UseCors(options=>options.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// app.Run(async (context) =>
// {
//     var response = context.Response;
//     var request = context.Request;
//     if (request.Path == "/api/user")
//     {
//         var responseText = "Некорректные данные";   // содержание сообщения по умолчанию

//         if (request.HasJsonContentType())
//         {
//             var person = await request.ReadFromJsonAsync<UserData>();
//             if (person != null)
                
//         }
//         await response.WriteAsJsonAsync(new { text = responseText });
//     }
// });
 
app.Run();
