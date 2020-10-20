using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using apijarus.Models;
using Newtonsoft.Json;

namespace apijarus.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            HttpClient Client = new HttpClient();
            HttpResponseMessage response = Client.GetAsync("http://localhost:49496/api/jarus/GetQuotes").Result;
            response.EnsureSuccessStatusCode();
            Models.Quote quote = response.Content.ReadAsAsync<Models.Quote>().Result;
            ViewBag.Title = "Quotes";
            return View(quote);
        }

        // GET: Home/Details/5
        public ActionResult Details(Person p)
        {
            HttpClient Client = new HttpClient();
            HttpResponseMessage response = Client.GetAsync("http://localhost:49496/api/jarus/FindPeople?Firstname=" + p.PersonFirstName + "&Lastname=" + p.PersonLastName).Result;
            response.EnsureSuccessStatusCode();
            List<Models.Person> people = response.Content.ReadAsAsync<List<Models.Person>>().Result;
            if(people == null)
            {
                ViewBag.ErrorMessage = "Results Not Found";
                people = new List<Person>();
            }
            ViewBag.Title = "People";
            return View(people);
        }

        public ActionResult search()
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

   
        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            HttpClient Client = new HttpClient();
            HttpResponseMessage response = Client.GetAsync("http://localhost:49496/api/jarus/GetAdditionalInsured?PersonId="+ id).Result;
            response.EnsureSuccessStatusCode();
            //Models.AdditionalInsured quote = response.Content.ReadAsAsync<Models.AdditionalInsured>().Result;
            List<Models.AdditionalInsured> people = response.Content.ReadAsAsync<List<Models.AdditionalInsured>>().Result;
            ViewBag.Title = "All Quotes";
            //return Json(people, JsonRequestBehavior.AllowGet);
            return View(people);
        }

    }
}
