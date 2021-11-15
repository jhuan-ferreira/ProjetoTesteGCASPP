using System.Data.Entity;
using ProjetoTesteGCASPP.Entities;

namespace ProjetoTesteGCASPP.Context
{
    public class ContextGCASSP : DbContext
    {
        //public ContextGCASSP() : base(System.Configuration.ConfigurationSettings.AppSettings["DbContextGCASPP"].ToString())
        //{

        //}

        public DbSet<Funcionario> funcionario { get; set; }
<<<<<<< HEAD
        public DbSet<Filho> filho { get; set; }
=======
>>>>>>> 94308d1dd202ea1a5df42e6530c8cba6729481c7

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
