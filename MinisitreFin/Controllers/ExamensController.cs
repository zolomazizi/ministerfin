using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MinisitreFin.Models;

namespace MinisitreFin.Controllers
{
    [ValidateInput(false)]
    public class ExamensController : Controller
    {
        private MinistreFinEntitiesDB db = new MinistreFinEntitiesDB();

        public static IEnumerable<SelectListItem> QA_AnswersList()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                
                new SelectListItem{Text = "Oui ;Je reviens de Voyage d’une Zone à Risque", Value = "Oui ; Je reviens de Voyage d’une Zone à Risque"},
                new SelectListItem{Text = "Non ; Je ne me suis pas déplacé dans une Zone à Risque durant les 15 derniers jours. ", Value = "Non ; Je ne me suis pas déplacé dans une Zone à Risque durant les 15 derniers jours. "},
                new SelectListItem{Text = "Je ne peux pas qualifier les Zones dans lesquelles je me suis déplacé les 15 derniers jours. ", Value = "Je ne peux pas qualifier les Zones dans lesquelles je me suis déplacé les 15 derniers jours."},

            };
            return items;
        }
        public static IEnumerable<SelectListItem> QB_AnswersList()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                
                new SelectListItem{ Text="Oui, J’ai été en contact avec une personne « malade confirmée » durant les 15 derniers jours.", Value = "Oui, J’ai été en contact avec une personne « malade confirmée » durant les 15 derniers jours." },
                new SelectListItem{ Text="Non, je n’ai pas été en en contact avec une personne « malade avérée » durant les 15 derniers jours.", Value = "Non, je n’ai pas été en en contact avec une personne « malade avérée » durant les 15 derniers jours." },
                new SelectListItem{ Text="Je ne peux pas répondre à une telle question.", Value = "Je ne peux pas répondre à une telle question." }
            };
            return items;
        }
        public static IEnumerable<SelectListItem> QC_AnswersList()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                
                new SelectListItem{Text="Oui, ma Toux est SECHE",Value="Oui, ma Toux est SECHE"},
                new SelectListItem{Text="Oui , ma Toux est GRASSE",Value="Oui , ma Toux est GRASSE"},
                new SelectListItem{Text="Non, Je ne tousse pas",Value="Non, Je ne tousse pas"}

            };
            return items;
        }
        public static IEnumerable<SelectListItem> QD_AnswersList()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                
                new SelectListItem{Text="Oui,Ma Fièvre est Supérieure à 38,5° Celsius depuis 5 Jours et +.",Value="Oui,Ma Fièvre est Supérieure à 38,5° Celsius depuis 5 Jours et +."},
                new SelectListItem{Text="Oui, Ma Fièvre est Supérieure à 38,5° Celsius depuis 2 Jours",Value="Oui, Ma Fièvre est Supérieure à 38,5° Celsius depuis 2 Jours"},
                new SelectListItem{Text="Oui, Ma Fièvre est Inférieure à 38,5° Celsius. ",Value="Oui, Ma Fièvre est Inférieure à 38,5° Celsius."},
                new SelectListItem{Text="Non, ma Température est NORMALE, 37° Celsius.  ",Value="Non, ma Température est NORMALE, 37° Celsius."},
                new SelectListItem{Text="Je n’ai pas le moyen de le contrôler. ",Value="Je n’ai pas le moyen de le contrôler. "}

            };
            return items;
        }
        public static IEnumerable<SelectListItem> QE_AnswersList()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                
                new SelectListItem{Text="Oui, je souffre de mal de tête ou de migraine.",Value="Oui, je souffre de mal de tête ou de migraine."},
                new SelectListItem{Text="Non , Je ne souffre pas de mal de tête ou de migraine.",Value="Non , Je ne souffre pas de mal de tête ou de migraine. "},
                

            };
            return items;
        }
        public static IEnumerable<SelectListItem> QF_AnswersList()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                
               new SelectListItem{Text="Oui, je souffre de diarrhée ou de vomissement ACTUELLEMENT.",Value="Oui, je souffre de diarrhée ou de vomissement ACTUELLEMENT. "},
               new SelectListItem{Text="Oui, je souffrais de diarrhée ou de vomissement LES DEUX DERNIERS JOURS.",Value="Oui, je souffrais de diarrhée ou de vomissement LES DEUX DERNIERS JOURS."},
               new SelectListItem{Text="Non, je ne souffre pas de diarrhée. ",Value="Non, je ne souffre pas de diarrhée. "},
               

            };
            return items;
        }

        public static IEnumerable<SelectListItem> QG_AnswersList()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                
                new SelectListItem{Text="Oui, Je souffre de maladies Chroniques et /ou de co morbidités. ",Value="Oui, Je souffre de maladies Chroniques et /ou de co morbidités."},
               new SelectListItem{Text="Non, je ne souffre pas de maladies chroniques et ne présente pas de co morbidités.",Value="Non, je ne souffre pas de maladies chroniques et ne présente pas de co morbidités."},
               new SelectListItem{Text="Je ne peux pas répondre à cette question.",Value="Je ne peux pas répondre à cette question."}

            };
            return items;
        }

        public static IEnumerable<SelectListItem> QH_AnswersList()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                
                 new SelectListItem{Text="Oui, je prends des Antibiotiques ou des Anti-inflammatoires",Value="Oui, je prends des Antibiotiques ou des Anti-inflammatoires"},
                new SelectListItem{Text="Oui, je prends des médicaments, mais je ne sais pas les qualifier",Value="Oui, je prends des médicaments, mais je ne sais pas les qualifier"},
                new SelectListItem{Text="Non, je ne prends pas de médicaments ",Value="Non, je ne prends pas de médicaments "}

            };
            return items;
        }
        public static IEnumerable<SelectListItem> QI_AnswersList()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                
                new SelectListItem{Text = "Oui, je souffre d’une conjonctivite ", Value = "Oui, je souffre d’une conjonctivite"},
                new SelectListItem{Text = "Non, je ne souffre pas de conjonctivite", Value = "Non, je ne souffre pas de conjonctivite"},

            };
            return items;
        }
        public static IEnumerable<SelectListItem> QJ_AnswersList()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                
               new SelectListItem{Text = "Oui, je souffre d’une conjonctivite", Value = "Oui, je souffre d’une conjonctivite"},
                new SelectListItem{Text = "Non, je ne souffre pas de conjonctivite ", Value = "Non, je ne souffre pas de conjonctivite "},


            };
            return items;
        }
        public static IEnumerable<SelectListItem> ListStatut()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                
                new SelectListItem{Value="Tres Vraisemblable" ,Text="Tres Vraisemblable"},
                new SelectListItem{Value="Vraisemblance Elecee",Text="Vraisemblance Elecee"},
                new SelectListItem{Value="Vraisemblance Moyenne",Text="Vraisemblance Moyenne"},
                new SelectListItem{Value="Vraisemblance Faible",Text="Vraisemblance Faible"}

            };
            return items;
        }
        // GET: Examens
        public ActionResult Index()
        {
            var examens = db.Examens.ToList();
            return View(examens);
        }

        // GET: Examens/Details/5
        public ActionResult Details(int? id,int? idpatient)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Examens examens = db.Examens.Find(id);
            if (examens == null)
            {
                return HttpNotFound();
            }
            return View(examens);
        }
        public ActionResult ExamenPatient(int? idpatient)
        {
            if (idpatient == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var examens = db.Examens.Where(e => e.PatientId == idpatient).ToList();
            if (examens == null)
            {
                return HttpNotFound();
            }
            return View(examens);
        }

        // GET: Examens/Create
        public ActionResult Create(int? idpatient)
        {

            ViewBag.PatientId = new SelectList(db.Patient, "Id", "Nom");

            ViewBag.A = new SelectList(QA_AnswersList(), "value", "text");
            ViewBag.B = new SelectList(QB_AnswersList(), "value", "text");
            ViewBag.C = new SelectList(QC_AnswersList(), "value", "text");
            ViewBag.D = new SelectList(QD_AnswersList(), "value", "text");
            ViewBag.E = new SelectList(QE_AnswersList(), "value", "text");
            ViewBag.F = new SelectList(QF_AnswersList(), "value", "text");
            ViewBag.G = new SelectList(QG_AnswersList(), "value", "text");
            ViewBag.H = new SelectList(QH_AnswersList(), "value", "text");
            ViewBag.I = new SelectList(QI_AnswersList(), "value", "text");
            ViewBag.J = new SelectList(QJ_AnswersList(), "value", "text");
            ViewBag.Statut = new SelectList(ListStatut(), "value", "text");
            
            ViewData["idpatient"] = idpatient;

            return View();
        }

        // POST: Examens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Examens examens)
        {
            if (ModelState.IsValid)
            {
                //Examens evm = new Examens();
                //evm.A = examens.A;
                //evm.B= examens.B;
                //evm.C = examens.C;
                //evm.D = examens.D;
                //evm.E = examens.E;
                //evm.F = examens.F;
                //evm.G = examens.G;
                //evm.H = examens.H;
                //evm.I = examens.I;
                //evm.J = examens.J;
                //evm.A_Text = examens.A_Text;
                //evm.B_Text = examens.B_Text;
                //evm.C_Text = examens.C_Text;
                //evm.D_Text = examens.D_Text;
                //evm.E_Text = examens.E_Text;
                //evm.F_Text = examens.F_Text;
                //evm.G_Text = examens.G_Text;
                //evm.H_Text = examens.H_Text;
                //evm.I_Text = examens.I_Text;
                //evm.J_Text = examens.J_Text;
                //evm.Patient = db.Patient.FirstOrDefault(p => p.Id == examens.PatientId);
                //evm.PatientId = examens.PatientId;
                //evm.Statut = examens.Statut;
                //db.Examens.Add(examens);
                //db.SaveChanges();
                //return RedirectToAction("Index", "Patients");
                db.Examens.Add(examens);
                db.SaveChanges();
                return RedirectToAction("Index", "Patients");

            }

            ViewBag.PatientId = new SelectList(db.Patient, "Id", "Nom", examens.PatientId);
            return View(examens);
        }

        // GET: Examens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Examens examens = db.Examens.Find(id);
            if (examens == null)
            {
                return HttpNotFound();
            }
            ViewBag.PatientId = new SelectList(db.Patient, "Id", "Nom", examens.PatientId);
            return View(examens);
        }

        // POST: Examens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PatientId,A,A_Text,B,B_Text,C,C_Text,D,D_Text,E,E_Text,F,F_Text,G,G_Text,H,H_Text,I,I_Text,J,J_Text,Statut")] Examens examens)
        {
            if (ModelState.IsValid)
            {
                db.Entry(examens).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PatientId = new SelectList(db.Patient, "Id", "Nom", examens.PatientId);
            return View(examens);
        }

        // GET: Examens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Examens examens = db.Examens.Find(id);
            if (examens == null)
            {
                return HttpNotFound();
            }
            return View(examens);
        }

        // POST: Examens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Examens examens = db.Examens.Find(id);
            db.Examens.Remove(examens);
            db.SaveChanges();
            return RedirectToAction("Index");
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
