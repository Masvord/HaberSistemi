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
    public class HaberRepository : IHaberRepository
    {
        private readonly HaberContext _context = new HaberContext();


        public IEnumerable<Data.Model.Haber> GetAll()
        {
            return _context.Haber.Select(x => x); //Tüm haberleri çekecek
        }

        public Data.Model.Haber GetById(int id)
        {
            return _context.Haber.FirstOrDefault(x => x.ID==id);
        }

        
        public Haber Get(Expression<Func<Haber, bool>> expression)
        {
            return _context.Haber.FirstOrDefault(expression);
        }

        public IQueryable<Haber> GetMany(Expression<Func<Haber, bool>> expression)
        {
            return _context.Haber.Where(expression);
        } 
        
       


        public void Insert(Haber obj)
        {
            _context.Haber.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Haber obj)
        {
            _context.Haber.AddOrUpdate(obj);
        }
        public int Count()
        {
            return _context.Haber.Count();
        }

       
        public void Delete(int obj)
        {
            var Haber = GetById(obj);
            if (Haber != null)
            {
                _context.Haber.Remove(Haber);
            }
        }
    }
}
