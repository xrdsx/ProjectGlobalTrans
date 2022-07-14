using GlobalTrans.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GlobalTrans.DBcontext;

namespace GlobalTrans.Controllers
{
    public class DriverController : Controller
    {


        private readonly DbConnectionContext _dbConnDb;

        public DriverController(DbConnectionContext driverContext)
        {
            _dbConnDb = driverContext;
        }



        // GET: DriverController
        public ActionResult DriverList()
        {

            
            return View(_dbConnDb.Driver.ToList());
        }

        // GET: DriverController/Details/5
        public ActionResult Details(int id)
        {
            return View(_dbConnDb.Driver.FirstOrDefault(x => x.id_driver == id));
        }

        // GET: DriverController/Create
        public ActionResult Create()
        {
            return View(new Driver());
        }

        // POST: DriverController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Driver driver)

        {
            
            

            _dbConnDb.Driver.Add(driver);
            _dbConnDb.SaveChanges();
           
             return RedirectToAction(nameof(DriverList));
            
            
            
        }

        // GET: DriverController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_dbConnDb.Driver.FirstOrDefault(x => x.id_driver == id));
        }

        // POST: DriverController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Driver drivermodel)
        {

            Driver driver = _dbConnDb.Driver.FirstOrDefault(x => x.id_driver == id);

            driver.name = drivermodel.name;
            driver.surname = drivermodel.surname;
            driver.zipCode = drivermodel.zipCode;
            driver.city = drivermodel.city;
            driver.street = drivermodel.street;
            driver.houseNumber = drivermodel.houseNumber;
            driver.flatNumber = drivermodel.flatNumber;
            driver.phoneNumber = drivermodel.phoneNumber;
            driver.mail = drivermodel.mail;

            _dbConnDb.SaveChanges();

            return RedirectToAction(nameof(DriverList));
            
            
        }

        // GET: DriverController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_dbConnDb.Driver.FirstOrDefault(x => x.id_driver == id));
        }

        // POST: DriverController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Driver drivermodel)
        {
                Driver driver = _dbConnDb.Driver.FirstOrDefault(x => x.id_driver == id);
                _dbConnDb.Driver.Remove(driver);
                _dbConnDb.SaveChanges();
                return RedirectToAction(nameof(DriverList));
            
            
        }

        //GET: Driver/Done

        


    }
}
