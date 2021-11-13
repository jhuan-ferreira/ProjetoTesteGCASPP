using ProjetoTesteGCASPP.Entities;

namespace ProjetoTesteGCASPP.Interface
{
    public interface IFuncionarioRepository : IRepositoryBase<Funcionario>
    {
        bool ValidaCamposFuncionarios(double salario);
        int GetIdByName(string nome);
    }
}
