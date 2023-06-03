using HaberSistemi.Core.Infrastructure;
using HaberSistemi.Data.DataContext;
using HaberSistemi.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HaberSistemi.Core.Repository
{
    public class RolRepository : IRolRepository
    {
        private readonly HaberContext _context = new HaberContext();

        public IEnumerable<Data.Model.Rol> GetAll()
        {
            return _context.Rol.Select(x => x); //Tüm haberleri çekecek
        }

        public Rol GetById(int id)
        {
            return _context.Rol.FirstOrDefault(x => x.ID == id);
        }

        public Data.Model.Rol Get(System.Linq.Expressions.Expression<Func<Rol, bool>> expression)
        {
            return _context.Rol.FirstOrDefault(expression);
        }

        public IQueryable<Rol> GetMany(System.Linq.Expressions.Expression<Func<Rol, bool>> expression)
        {
            return _context.Rol.Where(expression);
        }

        public void Insert(Rol obj)
        {
            _context.Rol.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Rol obj)
        {
            _context.Rol.AddOrUpdate(obj);
        }
        public int Count()
        {
            return _context.Rol.Count();
        }

        public void Delete(int id)
        {
            var Rol = GetById(id);
            if (Rol != null)
            {
                _context.Rol.Remove(Rol);
            }
        }
    }
}
