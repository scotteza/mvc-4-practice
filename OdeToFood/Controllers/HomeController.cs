using OdeToFood.Models;
using System.Linq;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        OdeToFoodDb _db = new OdeToFoodDb();

        public ActionResult Index()
        {
            var model =
                _db.Restaurants
                .OrderByDescending(restaurant => restaurant.Reviews.Average(review => review.Rating))
                .Select(r => new RestaurantListViewModel
                    {
                    Id = r.Id,
                    Name = r.Name,
                    City = r.City,
                    Country = r.Country,
                    CountOfReviews = r.Reviews.Count()
                })
                .ToList();

            return View(model);
        }

        public ActionResult About()
        {
            var model = new AboutModel
            {
                Location = "London",
                Name = "Scott"
            };

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
