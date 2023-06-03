using System;
using HaberSistemi.Core.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HaberSistemi.Data.Infrastructure
{
    public interface IRepository<I> where I : class
    {
        //Tüm datamızı çeker
        IEnumerable<I> GetAll();


        //Tek bir nesne dönecek
        I GetById(int id);

        I Get(Expression<Func<I, bool>> expression);

        IQueryable<I> GetMany(Expression<Func<I, bool>> expression);

        void Insert(I obj);

        void Update(I obj);

        void Delete(int obj);

        int Count();

        void Save();

    }
}
