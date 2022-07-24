using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using HastaTakip.Models.Entity;
using HastaTakip.Models;

namespace HastaTakip.Controllers
{
   
    public class PatientsController : Controller
    {
        Context c = new Context();
        hastatakipdbEntities db = new hastatakipdbEntities();
        // GET: Patients
        
        public ActionResult Index()
        {
            var hastalar = db.hastaTb.ToList();
            return View(hastalar);
        }
        
        [HttpGet]

        public  ActionResult HastaEkle()
        {
            return View();
            
        }


        [HttpPost]

        public ActionResult HastaEkle(hastaTb s1)
        {
            db.hastaTb.Add(s1);
            db.SaveChanges();
            
            return View();
        }
       
       
        

        public ActionResult sil(int id)
        {
            var hastalar = db.hastaTb.Find(id);
            db.hastaTb.Remove(hastalar);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult grs(doktorTb r)
        {
            var bilgiler = db.doktorTb.FirstOrDefault(x => x.doktorKullanici == r.doktorKullanici && x.doktorSifre == r.doktorSifre);
            if (bilgiler != null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

            

        }
        public ActionResult HastaGetir(int id)
        {
            var hastalar = db.hastaTb.Find(id);
            return View("HastaGetir", hastalar);
        }

        public ActionResult Düzenle(hastaTb p1)
        {
            var hastalar = db.hastaTb.Find(p1.hastaId);
            hastalar.hastaId = p1.hastaId;
            hastalar.hastaAd = p1.hastaAd;
            hastalar.hastaSoyad = p1.hastaSoyad;
            hastalar.hastaDogtar = p1.hastaDogtar;
            hastalar.hastaTelefon = p1.hastaTelefon;
            hastalar.hastaAdres = p1.hastaAdres;
            hastalar.fotoId = p1.fotoId;
            hastalar.sikayet = p1.sikayet;
            hastalar.teshis = p1.teshis;
            hastalar.hastaGiris = p1.hastaGiris;
            hastalar.hastaCikis = p1.hastaCikis;
            db.SaveChanges();
            return RedirectToAction("Index");
            

        }

        [HttpGet]
        public ActionResult addfoto()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addfoto(hastaTb f1)
        {
            if (Request.Files.Count > 0)
            {
                string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
                string uzanti = Path.GetExtension(Request.Files[0].FileName);
                string path = "~/fotolar/" + dosyaadi + uzanti;
                Request.Files[0].SaveAs(Server.MapPath(path));
                f1.fotografPath = "/fotolar/" + dosyaadi + uzanti;                         
            }
            

            return View();
            
        }
        
        

    }
    
}