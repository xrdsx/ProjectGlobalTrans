using GlobalTrans.DBcontext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GlobalTrans.Models;

namespace GlobalTrans.Controllers
{
    public class VehicleController : Controller
    {

        private readonly DbConnectionContext _dbConnDb;

        public VehicleController(DbConnectionContext vehicleContext)
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
            return View(_dbConnDb.Vehicle.FirstOrDefault(x => x.id_vehicle == id));
        }

        // GET: VehicleController1/Create
        public ActionResult Create()
        {
            return View(new Vehicle());
        }

        // POST: VehicleController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Vehicle vehicle)
        {
            _dbConnDb.Vehicle.Add(vehicle);
            _dbConnDb.SaveChanges();
            return RedirectToAction(nameof(VehicleList));
        }

        // GET: VehicleController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_dbConnDb.Vehicle.FirstOrDefault(x => x.id_vehicle == id));
        }

        // POST: VehicleController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Vehicle vehiclemodel)
        {
            Vehicle vehicle = _dbConnDb.Vehicle.FirstOrDefault(x => x.id_vehicle == id);
            vehicle.model = vehiclemodel.model;
            vehicle.brand = vehiclemodel.brand;

            _dbConnDb.SaveChanges();
            return RedirectToAction(nameof(VehicleList));

        }

        // GET: VehicleController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_dbConnDb.Vehicle.FirstOrDefault(x => x.id_vehicle == id));
        }

        // POST: VehicleController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Vehicle vehiclemodel)
        {
            Vehicle vehicle = _dbConnDb.Vehicle.FirstOrDefault(x => x.id_vehicle == id);
            _dbConnDb.Vehicle.Remove(vehicle);
            _dbConnDb.SaveChanges();
            return RedirectToAction(nameof(VehicleList));
        }
    }
}
