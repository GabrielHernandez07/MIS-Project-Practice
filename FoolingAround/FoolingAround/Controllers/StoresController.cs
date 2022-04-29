using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FoolingAround.Models;

namespace FoolingAround.Controllers
{
    public class StoresController : Controller
    {
        private DB_128040_hobbylobbyEntities db = new DB_128040_hobbylobbyEntities();

        // GET: Stores
        public ActionResult Index()
        {
            return View(db.Stores.ToList());
        }

        // GET: Stores/Details/5

        List<int> number = new List<int>();

        public ActionResult Details(int id)
        {
            number.Add(id);

            List<Request> request = new List<Request>();
            foreach (var r in db.Requests)
            {
                if (r.StoreNumber == id)
                {
                    request.Add(r);
                }
            }
            var tables = new StoreRequestView
            {
                RequestClass = request,
                StoreClass = db.Stores.Find(id),
                RequestName = db.Requests.Find(id)
            };
            return View(tables);
        }

        public ActionResult Back()
        {
            int? num;
            StoreRequestView tables;
            List<Request> request = new List<Request>();
            for (int i = 0; i < number.Count(); i++)
            {
                num = number[0];
                foreach (var r in db.Requests)
                {
                    if (r.StoreNumber == number[i])
                    {
                        request.Add(r);
                    }
                }
                tables = new StoreRequestView
                {
                    RequestClass = request,
                    StoreClass = db.Stores.Find(num),
                    RequestName = db.Requests.Find(num)
                };
            }
            //foreach (var r in db.Requests)
            //{
            //    if (r.StoreNumber == number[i])
            //    {
            //        request.Add(r);
            //    }
            //}

            //var tables = new StoreRequestView
            //{
            //    RequestClass = request,
            //    StoreClass = db.Stores.Find(num),
            //    RequestName = db.Requests.Find(num)
            //};
            return View(tables);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
