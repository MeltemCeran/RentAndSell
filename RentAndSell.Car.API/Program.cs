using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using RentAndSell.Car.API;
using RentAndSell.Car.API.Data.Context;
using RentAndSell.Car.API.Services;
using System.Text;
using HttpMethod = Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpMethod;

var builder = WebApplication.CreateBuilder(args);

//Add services to the container.
builder.Services.AddAuthentication("YetkiKontrol").AddScheme<AuthenticationSchemeOptions,YetkiKontrolYakalayicisi>("YetkiKontrol",null);

builder.Services.AddDbContext<CarRentDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("CarRentDbCon"));
});

builder.Services.AddControllers(); //MVC de addcontrollerswithviews yapýyoruz.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapControllers(); 

//GET | POST | PUT | PATCH | DELETE | OPTIONS

#region Senkron Main Method

//app.Map("/", (context) =>
//{
//    //return "Hello World All Methods GET | POST | PUT | PATCH | DELETE | OPTIONS";

//    await context.Response.WriteAsync("aa");
//}); 
#endregion

#region Asenkron With Context Method

//app.Map("/", async (context) =>
//{
//    await context.Response.WriteAsync("Hello World All Methods GET | POST | PUT | PATCH | DELETE | OPTIONS\n");

//    if (context.Request.Method == HttpMethod.Get.ToString().ToUpper())
//        await context.Response.WriteAsync("Hello World Only GET");
//    if (context.Request.Method == HttpMethod.Post.ToString().ToUpper())
//        await context.Response.WriteAsync("Hello World Only POST");
//    if (context.Request.Method == HttpMethod.Put.ToString().ToUpper())
//        await context.Response.WriteAsync("Hello World Only PUT");
//    if (context.Request.Method == HttpMethod.Patch.ToString().ToUpper())
//        await context.Response.WriteAsync("Hello World Only PATCH");
//    if (context.Request.Method == HttpMethod.Delete.ToString().ToUpper())
//        await context.Response.WriteAsync("Hello World Only DELETE");
//    if (context.Request.Method == HttpMethod.Options.ToString().ToUpper(new System.Globalization.CultureInfo("en-US")))
//        await context.Response.WriteAsync("Hello World Only OPTIONS");

//});
#endregion

#region Http All Verbs EndPoint Map 
////GET
//app.MapGet("/", () =>
//{
//    return "Hello World Only GET";
//});

////Post
//app.MapPost("/", () =>
//{
//    return "Hello World Only POST";
//});

////PUT
//app.MapPut("/", () =>
//{
//    return "Hello World Only PUT";
//});

////PATCH
//app.MapPatch("/", () =>
//{
//    return "Hello World Only PATCH";
//});

////DELETE
//app.MapDelete("/", () =>
//{
//    return "Hello World Only DELETE";
//}); 
#endregion

#region bununda illaki bi adý vardýr ama hatýrlamýyorum
//app.Map("/", async (context) =>
//{
//if (context.Request.Method == "OPTIONS")
//{
//context.Response.Headers.Accept = "Accept Info : All Browsers";
//context.Response.Headers.AcceptCharset = "UTF-8";
//context.Response.Headers.AcceptLanguage = "tr-TR";
//context.Response.Headers.AccessControlAllowOrigin = "*";
//context.Response.Headers.AccessControlAllowMethods = "GET,POST,PUT";
//}
//    //return "<b>Text Plain</b>";

//    //context.Response.StatusCode = 404;
//}); 
#endregion

#region Content-Type örnekler

//app.MapGet("/", async (context) =>
//{
//if (context.Request.Headers.UserAgent.ToString().Contains("Postman"))
//context.Response.StatusCode = 404;
//else
//{
//string responseContent = ("Herhangi bir þey <b>bu yazý bold</b>");

//context.Response.StatusCode = 200;
//context.Response.ContentLength = Encoding.UTF8.GetByteCount(responseContent); //normal Lengt alamayýz çünkü karakter setlerindeki boyutlandýrma farklý.
//context.Response.ContentType = "text/plain ; charset=utf-8"; //"text/html ; charset=utf-8";

//await context.Response.WriteAsync(responseContent);
//}
//}); 
#endregion

#region Burasý fiziksel css dosyasý istemediðimde bir baþka projenin cshtml sayfalarýna url linki vererek yaptýðým deðiþiklikler.
//app.MapGet("/{cssFileName}", async (HttpContext context, string cssFileName) =>
//{
//string cssContent = "";

//switch (cssFileName)
//{
//case "user.css":
//    cssContent = @"p { color: red; font-size: 8px }";
//    break;
//case "main.css":
//    cssContent = @"p { color: blue; font-size: 24px }";
//    break;
//case "index.css":
//    cssContent = @"p { color: yellow; font-size: 48px }";
//    break;
//}

//context.Response.StatusCode = 200;
//context.Response.ContentLength = Encoding.UTF8.GetByteCount(cssContent);
//context.Response.ContentType = "text/css; charset=utf-8";

//await context.Response.WriteAsync(cssContent);

//}); 
#endregion
#region Car CRUD Operations

//List<Car> cars = new List<Car>();


////GET    https://localhost:7168/Cars         => AllCars

//app.MapGet("/Cars", () =>
//{
//    return cars;
//});

////GET    https://localhost:7168/Cars/{id}    => Car With Id

//app.MapGet("/Cars/{id}", (int id) =>
//{
//    return cars.Where(c => c.Id == id).SingleOrDefault();
//});

////POST   https://localhost:7168/Cars         => jsonData Model ile New Car

//app.MapPost("/Cars", (Car car) =>
//{
//    //int lastId = cars.MaxBy(c => c.Id).Id;
//    //car.Id = lastId + 1;

//    cars.Add(car);
//    return car;
//});

////PUT    https://localhost:7168/Cars/{id}    => jsonData Model ve Id ile Edit Car

//app.MapPut("/Cars/{id}", (int id, Car car) =>
//{
//    Car findOriginalCar = cars.Where(c => c.Id == id).SingleOrDefault();
//    int findOriginalIndex = cars.IndexOf(findOriginalCar);

//    cars[findOriginalIndex] = car;
//    return car;
//});

////DELETE https://localhost:7168/Cars/{id}    => Car Id ile Delete Car 

//app.MapDelete("/Cars/{id}", (int id) =>
//{
//    Car removedCar = cars.Where(c => c.Id == id).SingleOrDefault();
//    cars.Remove(removedCar);
//    return removedCar;
//});

#endregion


app.Run();


