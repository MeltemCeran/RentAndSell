using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RentAndSell.Car.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private static List<Car> cars = new List<Car>();

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(cars);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(cars.Where(c => c.Id == id).SingleOrDefault());
        }
        [HttpPost]
        public ActionResult Post(Car car)
        {
            cars.Add(car);
            return Ok(car);
        }
        [HttpPut("{id}")]
        public ActionResult Put(int id, Car car)
        {
            Car findOriginalCar = cars.Where(c => c.Id == id).SingleOrDefault();
            int findOriginalIndex = cars.IndexOf(findOriginalCar);

            cars[findOriginalIndex] = car;
            return Ok(car);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id, Car car)
        {
            Car removedCar = cars.Where(c => c.Id == id).SingleOrDefault();
            cars.Remove(removedCar);
            return Ok(removedCar);
        }
        //Burada IActionResult kullanmamızın nedeni viewlerimizin olmamasından ötürü.
        [HttpGet("Year/{id}")]
        public ActionResult GetYear(int year)
        {
            return Ok("Çalıştım");
        }
        //Burada diğer get metodu ile karşmaması için rotalamaya metoddaki year eklendi.
    }
}

