using GlobalTrans.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GlobalTrans.Models;


namespace GlobalTrans.Controllers
{
    public class DriverController : Controller
    {


        private readonly DriverContext _driverContext;

        public DriverController(DriverContext driverContext)
        {
            _driverContext = driverContext;
        }







        // GET: DriverController
        public ActionResult Index()
        {

            
            return View(_driverContext.Driver.ToList());
        }

        // GET: DriverController/Details/5
        public ActionResult Details(int id)
        {
            return View(_driverContext.Driver.FirstOrDefault(x => x.id_driver == id));
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

            // var getNumberId = _driverContext.Driver.

            //driver.id_driver = _driverContext.Driver.Max(p => p.id_driver);





            _driverContext.Driver.Add(driver);
            _driverContext.SaveChanges();
           
                return RedirectToAction(nameof(Index));
            
            
        }

        // GET: DriverController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_driverContext.Driver.FirstOrDefault(x => x.id_driver == id));
        }

        // POST: DriverController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Driver drivermodel)
        {

            Driver driver = _driverContext.Driver.FirstOrDefault(x => x.id_driver == id);

            driver.name = drivermodel.name;
            driver.surname = drivermodel.surname;
            driver.zipCode = drivermodel.zipCode;
            driver.city = drivermodel.city;
            driver.street = drivermodel.street;
            driver.houseNumber = drivermodel.houseNumber;
            driver.flatNumber = drivermodel.flatNumber;
            driver.phoneNumber = drivermodel.phoneNumber;
            driver.mail = drivermodel.mail;


            return RedirectToAction(nameof(Index));
            
            
        }

        // GET: DriverController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_driverContext.Driver.FirstOrDefault(x => x.id_driver == id));
        }

        // POST: DriverController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Driver drivermodel)
        {
                Driver driver = _driverContext.Driver.FirstOrDefault(x => x.id_driver == id);
                Driver.drivers.Remove(driver);
                return RedirectToAction(nameof(Index));
            
            
        }

        //GET: Driver/Done

        


    }
}
