using HaberSistemi.Core.Infrastructure;
using HaberSistemi.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberSistemi.Admin.Controllers
{
    public class AccountController : Controller
    {
        #region Kullanıcı
        public readonly IKullaniciRepository _kullaniciRepository;
        public AccountController(IKullaniciRepository kullaniciRepository)
        {
            _kullaniciRepository = kullaniciRepository;
        }
        #endregion

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(Kullanici kullanici)
        {
            var KullaniciVarMi = _kullaniciRepository.GetMany(x => x.Email == kullanici.Email && x.Sifre == kullanici.Sifre && x.Aktif == true).SingleOrDefault();
            
            if (KullaniciVarMi!=null)
            {
                if(KullaniciVarMi.Rol.RolAdi=="Admin")
                {
                    Session["KullaniciEmail"] = KullaniciVarMi.Email;
                    return RedirectToAction("Index", "Home");

                }
                ViewBag.Mesaj = "Yetkisiz Kullanıcı";
                return View();

            }
            ViewBag.Mesaj = "Kullanıcı bulunamadı.";
            
            
            return View();

        }
    }
}