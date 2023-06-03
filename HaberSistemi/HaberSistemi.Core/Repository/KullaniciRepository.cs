using HaberSistemi.Core.Infrastructure;
using HaberSistemi.Data.DataContext;
using HaberSistemi.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HaberSistemi.Core.Repository
{
    public class KullaniciRepository : IKullaniciRepository
    {
        private readonly HaberContext _context = new HaberContext();

        public IEnumerable<Data.Model.Kullanici> GetAll()
        {
            return _context.Kullanici.Select(x => x); //Tüm haberleri çekecek
        }

        public Kullanici GetById(int id)
        {
            return _context.Kullanici.FirstOrDefault(x => x.ID == id);
        }

        public Data.Model.Kullanici Get(System.Linq.Expressions.Expression<Func<Kullanici, bool>> expression)
        {
            return _context.Kullanici.FirstOrDefault(expression);
        }

        public IQueryable<Kullanici> GetMany(Expression<Func<Kullanici, bool>> expression)
        {
            return _context.Kullanici.Where(expression);
        }

        public void Insert(Kullanici obj)
        {
            _context.Kullanici.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Kullanici obj)
        {
            _context.Kullanici.AddOrUpdate(obj);
        }
        public int Count()
        {
           return _context.Kullanici.Count();
        }

        public void Delete(int id)
        {
            var Kullanici = GetById(id);
            if (Kullanici != null)
            {
                _context.Kullanici.Remove(Kullanici);
            }
        }
        



    }
}
