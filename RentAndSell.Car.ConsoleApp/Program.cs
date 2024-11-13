//Http isteği atmak istiyorum kime?
//https://localhost:7168/api/Cars adresine istek atacağız nasıl?

using RentAndSell.Car.ConsoleApp.Models;
using System.Net.Http.Json;

//var httpClientHandler = new HttpClientHandler();
//httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) =>
//{
//    return true;
//};

//HttpClient httpClient = new HttpClient(httpClientHandler);
HttpClient httpClient = new HttpClient();

httpClient.BaseAddress = new Uri("https://localhost:7168/api/");

#region HttpClient İstek Tipleri
//HttpResponseMessage httpResponseMessage = httpClient.GetAsync("Cars").Result;
//HttpContent content = httpResponseMessage.Content;
////var responseContentJson = content.ReadFromJsonAsync(typeof(List<ArabaViewModel>)).Result;

////string responseContent = content.ReadAsStringAsync().Result;
////var responseContentJson = content.ReadFromJsonAsync(typeof(List<ArabaViewModel>)).Result;
//List<ArabaViewModel> arabaViewModelList = content.ReadFromJsonAsync<List<ArabaViewModel>>().Result;

////List<ArabaViewModel> arabaViewModels = (List<ArabaViewModel>)httpClient.GetFromJsonAsync("Cars",typeof(List<ArabaViewModel>)).Result;
////Burası 11-12-13. satırları tekte veren kod.
//List<ArabaViewModel> arabaViewModels = httpClient.GetFromJsonAsync<List<ArabaViewModel>>("Cars").Result;
////Burasıda aynı işi yapıyor. bunu tercih edebiliriz. header bilgisine falan bakmak istersek content üzerinden içeriğini okuruz.  bunu dışarda kullanıcam.
#endregion
List<ArabaViewModel> arabaViewModels = httpClient.GetFromJsonAsync<List<ArabaViewModel>>("Cars").Result;

Console.WriteLine("---------Araba Listesi---------");

foreach (ArabaViewModel araba in arabaViewModels)
{
    Console.WriteLine($"{araba.Marka} {araba.Model} {araba.Yili}");
}
Console.WriteLine("----------------------------");
Console.WriteLine("---------Yani Kayıt---------");

Console.Write("Marka : ");
string marka = Console.ReadLine();
Console.Write("Model : ");
string model = Console.ReadLine();
Console.Write("Yili : ");
string yili = Console.ReadLine();
Console.Write("Yakıt Türü : ");
string yakitTuru = Console.ReadLine();
Console.Write("Motor Tipi : ");
string motorTipi = Console.ReadLine();
Console.Write("Sanziman Tipi : ");
string sanzimanTipi = Console.ReadLine();

ArabaViewModel yeniAraba = new ArabaViewModel();

yeniAraba.Marka = marka;
yeniAraba.Model = model;
yeniAraba.Yili = short.Parse(yili);
yeniAraba.YakitTuru = int.Parse(yakitTuru);
yeniAraba.MotorTipi = int.Parse(motorTipi);
yeniAraba.SanzimanTipi = int.Parse(sanzimanTipi);

HttpResponseMessage responsePostMessage = httpClient.PostAsJsonAsync("Cars", yeniAraba).Result;

if (responsePostMessage.IsSuccessStatusCode)
{
    Console.WriteLine("Yeni araba kayıt edildi.");
    var responseData = await responsePostMessage.Content.ReadAsStringAsync();

    Console.WriteLine("Yanıt: " + responseData);
}

arabaViewModels = httpClient.GetFromJsonAsync<List<ArabaViewModel>>("Cars").Result;

Console.WriteLine("---------Güncel Araba Listesi---------");
foreach (ArabaViewModel araba in arabaViewModels)
{
    Console.WriteLine($"{araba.Marka} {araba.Model} {araba.Yili}");
}
Console.WriteLine("----------------------------");
Console.ReadLine();