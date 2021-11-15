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
        public DbSet<Filho> filho { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
