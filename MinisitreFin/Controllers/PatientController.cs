using MinisitreFin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MinisitreFin.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient
        public ActionResult Index()

        {
            IEnumerable<PatientsInfoModel> patients = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://ksipragmatic212.conveyor.cloud/api/");
                var responseTask = client.GetAsync("AllPatients");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<PatientsInfoModel>>();
                    readJob.Wait();
                    patients = readJob.Result;
                }
                else
                {
                    patients = Enumerable.Empty<PatientsInfoModel>();
                    ModelState.AddModelError(string.Empty, "Error");
                }
            }
            return View(patients);
        }
    }

}