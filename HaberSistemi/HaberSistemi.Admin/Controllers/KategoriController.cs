using HaberSistemi.Admin.Class;
using HaberSistemi.Core.Infrastructure;
using HaberSistemi.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberSistemi.Admin.Controllers
{
    public class KategoriController : Controller
    {

        #region Kategori
        private readonly IKategoriRepository _kategoriRepository;


        public KategoriController(IKategoriRepository kategoriRepository)
        {
            _kategoriRepository = kategoriRepository;
        }
        #endregion
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        #region Kategori Ekle


        [HttpGet]
        public ActionResult Ekle()
        {
            SetKategoriListele();
            return View();
        }

        
        [HttpPost]
        public JsonResult Ekle(Kategori kategori)
        {
            try
            {

                _kategoriRepository.Insert(kategori);
                _kategoriRepository.Save();
                return Json(new ResultJson { Success = true, Message = "Kategori ekleme işlemeniz başarılı. " });

            }
            catch (Exception ex)
            {
                //Loglama yaptırılabilir.
                return Json(new ResultJson { Success = false, Message = "Kategori eklerken hata oluştu! " });

            }
            
        }
        #endregion

        #region Set Kategori
        public void SetKategoriListele()
        {
            var KategoriList = _kategoriRepository.GetMany(x => x.ParentID == 0).ToList();
            ViewBag.Kategori = KategoriList;
        }
        #endregion
    }
}