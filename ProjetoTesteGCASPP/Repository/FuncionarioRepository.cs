using ProjetoTesteGCASPP.Context;
using ProjetoTesteGCASPP.Entities;
using ProjetoTesteGCASPP.Interface;
using System.Linq;

namespace ProjetoTesteGCASPP.Repository
{
    class FuncionarioRepository : RepositoryBase<Funcionario>, IFuncionarioRepository //RepositoryBase<Funcionario>
    {
        public int GetIdByName(string nome)
        {
            using (var context = new ContextGCASSP())
            {

                return context.funcionario.Where(p => p.Nome == nome).Select(p => p.IdFuncionario).FirstOrDefault();
            }
        }

        public bool ValidaCamposFuncionarios(double salario)
        {
            if (!(salario <= 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
