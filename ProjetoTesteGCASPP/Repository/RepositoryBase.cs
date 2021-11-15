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
<<<<<<< HEAD
                context.Entry(obj).State = EntityState.Deleted;

                return context.SaveChanges() > 0;
=======
                _context.Entry(obj).State = EntityState.Deleted;

                return _context.SaveChanges() > 0;
>>>>>>> 94308d1dd202ea1a5df42e6530c8cba6729481c7
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
<<<<<<< HEAD
             using (var context = new ContextGCASSP())
             {
                context.Set<T>().Attach(data);
                context.Entry(data).State = EntityState.Modified;

                return context.SaveChanges() > 0;
=======
            using (var context = new ContextGCASSP())
            {
                _context.Entry(data).State = EntityState.Modified;
                return _context.SaveChanges() > 0;
>>>>>>> 94308d1dd202ea1a5df42e6530c8cba6729481c7

            }
        }

        public IList<T> FindAll()
        {
            using (var context = new ContextGCASSP())
            {
<<<<<<< HEAD
                return context.Set<T>().ToList();
=======
                _context.Set<T>().ToList();
                return _context.Set<T>().ToList();
>>>>>>> 94308d1dd202ea1a5df42e6530c8cba6729481c7
            }
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}
