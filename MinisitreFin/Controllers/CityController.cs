using MinisitreFin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MinisitreFin.Controllers
{
    public class CityController : Controller
    {
        // GET: City
        public ActionResult Index()
        {
            IEnumerable<CityModel> city = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://ksipragmatic212.conveyor.cloud/api/");
                var responseTask = client.GetAsync("AllCitys");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<CityModel>>();
                    readJob.Wait();
                    city = readJob.Result;
                }
                else
                {
                    city = Enumerable.Empty<CityModel>();
                    ModelState.AddModelError(string.Empty, "Error");
                }
            }
            return View(city);
        }
        //POST: City 
        public ActionResult Creat()
        {
            return View(); 
        }
        [HttpPost]
        public ActionResult Creat(CityModel city)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://ksipragmatic212.conveyor.cloud/api/");
                var postjob = client.PostAsJsonAsync<CityModel>("AddCity", city);
                postjob.Wait();

                var postResult = postjob.Result;
                if (postResult.IsSuccessStatusCode)
                    return RedirectToAction("index");
            }
                return View(city);
        }

        //PUT :City
        public ActionResult Edit(int id)
        {
            CityModel city = null; 
            using ( var client  = new HttpClient())
            {
                client.BaseAddress = new Uri("https://ksipragmatic212.conveyor.cloud/api/");
                var responseTask = client.GetAsync("OneCitys/" + id.ToString());
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<CityModel>();
                    readTask.Wait();
                    city = readTask.Result;
                }

            }
            return View(city);
        }

        //Action Post pour editer data de city 

        [HttpPost]

        public ActionResult Edit(CityModel city)
        {
            using (var client = new  HttpClient())
            {
                client.BaseAddress = new Uri("https://ksipragmatic212.conveyor.cloud/api/");
                var putTask = client.PutAsJsonAsync<CityModel>("EditCity" , city);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                 return RedirectToAction("index");

                return View(city);

                
            }

        }

        //Delet action 
         public ActionResult Delete (int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://ksipragmatic212.conveyor.cloud/api/");
                var deleteTask = client.DeleteAsync("DeletCily/" + id.ToString());
                deleteTask.Wait();
                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                    return RedirectToAction("index");
                

            }
            return RedirectToAction("index");
        }
    }
}