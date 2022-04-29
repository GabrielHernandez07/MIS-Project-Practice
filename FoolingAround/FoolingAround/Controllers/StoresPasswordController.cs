using FoolingAround.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoolingAround.Controllers
{
    public class StoresPasswordController : Controller
    {
        // GET: StoresPassword

        private DB_128040_hobbylobbyEntities db = new DB_128040_hobbylobbyEntities();

        public ActionResult StorePassword()
        {
            
            return View(db.Stores.ToList());
            
        }
    }
}