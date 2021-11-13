using ProjetoTesteGCASPP.Context;
using ProjetoTesteGCASPP.Interface;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ProjetoTesteGCASPP.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private ContextGCASSP _context = new ContextGCASSP();

        public void Commit()
        {
            _context.SaveChanges();
        }

        public bool Delete(T obj)
        {

            using(var context = new ContextGCASSP())
            {
                _context.Entry(obj).State = EntityState.Deleted;

                return _context.SaveChanges() > 0;
            }
            
        }


        public bool Insert(T data)
        {
            using(var context = new ContextGCASSP())
            {
                _context.Set<T>().Add(data);

                return _context.SaveChanges() > 0;
            }
            
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public bool Update(T data)
        {
            using (var context = new ContextGCASSP())
            {
                _context.Entry(data).State = EntityState.Modified;
                return _context.SaveChanges() > 0;

            }
        }

        public IList<T> FindAll()
        {
            using (var context = new ContextGCASSP())
            {
                _context.Set<T>().ToList();
                return _context.Set<T>().ToList();
            }
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}
