using GlobalTrans.DBcontext;
using GlobalTrans.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GlobalTrans.Controllers
{
    public class LoadController : Controller
    {

        private readonly DbConnectionContext _dbConnDb;

        public LoadController(DbConnectionContext loadContext)
        {
            _dbConnDb = loadContext;
        }


        // GET: LoadController1
        public ActionResult LoadList()
        {
            return View(_dbConnDb.Load.ToList());
        }

        // GET: LoadController1/Details/5
        public ActionResult Details(int id)
        {
            return View(_dbConnDb.Load.FirstOrDefault(x => x.id_load == id));
        }

        // GET: LoadController1/Create
        public ActionResult Create()
        {
            return View(new Load());
        }

        // POST: LoadController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Load load )
        {
            _dbConnDb.Load.Add(load);
            _dbConnDb.SaveChanges();

            return RedirectToAction(nameof(LoadList));

        }

        // GET: LoadController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_dbConnDb.Load.FirstOrDefault(x => x.id_load == id));
        }

        // POST: LoadController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Load loadmodel)
        {
            Load load  = _dbConnDb.Load.FirstOrDefault(x => x.id_load == id);

            load.weightLoad = loadmodel.weightLoad;
            load.lengthLoad = loadmodel.lengthLoad;
            load.kindOf = loadmodel.kindOf;

            _dbConnDb.SaveChanges();


            return RedirectToAction(nameof(LoadList));

        }

        // GET: LoadController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_dbConnDb.Load.FirstOrDefault(x => x.id_load == id));
        }

        // POST: LoadController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Load loadmodel)
        {
            Load load = _dbConnDb.Load.FirstOrDefault(x => x.id_load == id);
            _dbConnDb.Load.Remove(load);
            _dbConnDb.SaveChanges();
            return RedirectToAction(nameof(LoadList));

        }
    }
}
