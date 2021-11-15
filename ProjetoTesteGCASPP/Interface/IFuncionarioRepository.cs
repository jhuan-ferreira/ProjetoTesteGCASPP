using ProjetoTesteGCASPP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteGCASPP.Interface
{
    public interface IFuncionarioRepository : IRepositoryBase<Funcionario>
    {
        bool ValidaCamposFuncionarios(double salario);
        int GetIdByName(string nome);
    }
}
