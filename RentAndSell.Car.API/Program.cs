using HttpMethod = Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpMethod;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

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

app.Map("/", async (context) =>
{
    if (context.Request.Method == "OPTIONS")
    {
        context.Response.Headers.Accept = "Accept Info : All Browsers";
        context.Response.Headers.AcceptCharset = "UTF-8";
        context.Response.Headers.AcceptLanguage = "tr-TR";
        context.Response.Headers.AccessControlAllowOrigin = "*";
        context.Response.Headers.AccessControlAllowMethods = "GET,POST,PUT";
    }
    //return "<b>Text Plain</b>";

    //context.Response.StatusCode = 404;
});

app.MapGet("/", async (context) =>
{
    if (context.Request.Headers.UserAgent.ToString().Contains("Postman"))
        context.Response.StatusCode = 404;
    else
    {
        string response = ("Herhangi bir þey <b>bu yazý bold</b>");

        context.Response.StatusCode = 200;
        context.Response.ContentLength = response.Length;
        context.Response.ContentType = "text/plain";
    }


    //return "<b>Text Plain</b>";

    //context.Response.StatusCode = 404;
});

#region Car CRUD Operations

List<Car> cars = new List<Car>();


//GET    https://localhost:7168/Cars         => AllCars

app.MapGet("/Cars", () =>
{
    return cars;
});

//GET    https://localhost:7168/Cars/{id}    => Car With Id

app.MapGet("/Cars/{id}", (int id) =>
{
    return cars.Where(c => c.Id == id).SingleOrDefault();
});

//POST   https://localhost:7168/Cars         => jsonData Model ile New Car

app.MapPost("/Cars", (Car car) =>
{
    //int lastId = cars.MaxBy(c => c.Id).Id;
    //car.Id = lastId + 1;

    cars.Add(car);
    return car;
});

//PUT    https://localhost:7168/Cars/{id}    => jsonData Model ve Id ile Edit Car

app.MapPut("/Cars/{id}", (int id, Car car) =>
{
    Car findOriginalCar = cars.Where(c => c.Id == id).SingleOrDefault();
    int findOriginalIndex = cars.IndexOf(findOriginalCar);

    cars[findOriginalIndex] = car;
    return car;
});

//DELETE https://localhost:7168/Cars/{id}    => Car Id ile Delete Car 

app.MapDelete("/Cars/{id}", (int id) =>
{
    Car removedCar = cars.Where(c => c.Id == id).SingleOrDefault();
    cars.Remove(removedCar);
    return removedCar;
});

#endregion


app.Run();


