using ProjetoTesteGCASPP.Entities;
<<<<<<< HEAD
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 94308d1dd202ea1a5df42e6530c8cba6729481c7

namespace ProjetoTesteGCASPP.Interface
{
    public interface IFuncionarioRepository : IRepositoryBase<Funcionario>
    {
        bool ValidaCamposFuncionarios(double salario);
<<<<<<< HEAD
        int GetIdByName(string nome);
=======
>>>>>>> 94308d1dd202ea1a5df42e6530c8cba6729481c7
    }
}
