using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class ClientController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ClientController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Client> objList = _db.Clients;
            return View(objList);
        }

        //CREATE - GET
        public IActionResult Create()
        {
            return View();
        }

        //CREATE - POST
        [HttpPost]
        public IActionResult Create(Client obj)
        {
            _db.Clients.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
