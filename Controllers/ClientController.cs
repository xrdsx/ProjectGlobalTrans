using GlobalTrans.DBcontext;
using GlobalTrans.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GlobalTrans.Controllers
{
    public class ClientController : Controller


    {

        private readonly DbConnectionContext _dbConnDb;

        public ClientController(DbConnectionContext driverContext)
        {
            _dbConnDb = driverContext;
        }





        // GET: ClientController
        public ActionResult ClientList()
        {
            return View(_dbConnDb.Client.ToList());
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            return View(_dbConnDb.Client.FirstOrDefault(x =>x.id_client == id));
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View(new Client());
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Client client)
        {
            _dbConnDb.Client.Add(client);
            _dbConnDb.SaveChanges();

            return RedirectToAction(nameof(ClientList));
            
           
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_dbConnDb.Client.FirstOrDefault(x => x.id_client == id));
        }

        // POST: ClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Client clientmodel)
        {
            Client client = _dbConnDb.Client.FirstOrDefault(x => x.id_client == id);

            client.name_company = clientmodel.name_company;
            client.nip = clientmodel.nip;
            client.zipCode = clientmodel.zipCode;
            client.city = clientmodel.city;
            clientmodel.street = clientmodel.street;
            client.phoneNumber = clientmodel.phoneNumber;
            client.mail = clientmodel.mail;

            _dbConnDb.SaveChanges();
            return RedirectToAction(nameof(ClientList));

        }

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_dbConnDb.Client.FirstOrDefault(x => x.id_client == id));
            
        }

        // POST: ClientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Client clientmodel)
        {
            Client client = _dbConnDb.Client.FirstOrDefault(x => x.id_client == id);
            _dbConnDb.Client.Remove(client);
            _dbConnDb.SaveChanges();
            return RedirectToAction(nameof(ClientList));
        }
    }
}
