using GlobalTrans.DBcontext;
using GlobalTrans.Models;
using Microsoft.AspNetCore.Mvc;

namespace GlobalTrans.Controllers
{
    public class RouteToDriver : Controller
    {

        private readonly DbConnectionContext _dbConnDb;

        public RouteToDriver(DbConnectionContext driverContext)
        {
            _dbConnDb = driverContext;
        }

        public IActionResult Index()
        {
            return View(_dbConnDb.RoadToDriver.ToList());
        }
        public ActionResult Create()
        {
            return View(new RoadToDriver());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RoadToDriver roadToDriver)
        {
            
                return RedirectToAction(nameof(Index));
           
            
                return View();
            
        }
    }
}
