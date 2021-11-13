using ProjetoTesteGCASPP.Entities;
using ProjetoTesteGCASPP.Interface;

namespace ProjetoTesteGCASPP.Repository
{
    class FuncionarioRepository : RepositoryBase<Funcionario>, IFuncionarioRepository //RepositoryBase<Funcionario>
    {

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
