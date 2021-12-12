using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class StorageController : Controller
    {
        private readonly ApplicationDbContext _db;
        public StorageController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Storage> objList = _db.Storages;
            return View(objList);
        }

        //CREATE - GET
        public IActionResult Create()
        {
            return View();
        }

        //CREATE - POST
        [HttpPost]
        public IActionResult Create(Storage obj)
        {
            _db.Storages.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
