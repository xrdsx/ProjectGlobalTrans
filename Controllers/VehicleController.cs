using GlobalTrans.DBcontext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GlobalTrans.Controllers
{
    public class VehcileController : Controller
    {

        private readonly DbConnectionContext _dbConnDb;

        public VehcileController(DbConnectionContext vehicleContext)
        {
            _dbConnDb = vehicleContext;
        }


        // GET: VehicleController1
        public ActionResult VehicleList()
        {
            return View(_dbConnDb.Vehicle.ToList());
        }

        // GET: VehicleController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VehicleController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehicleController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VehicleController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VehicleController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VehicleController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VehicleController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
