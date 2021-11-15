<<<<<<< HEAD
﻿using ProjetoTesteGCASPP.Context;
using ProjetoTesteGCASPP.Entities;
using ProjetoTesteGCASPP.Interface;
using System.Linq;
=======
﻿using ProjetoTesteGCASPP.Entities;
using ProjetoTesteGCASPP.Interface;
>>>>>>> 94308d1dd202ea1a5df42e6530c8cba6729481c7

namespace ProjetoTesteGCASPP.Repository
{
    class FuncionarioRepository : RepositoryBase<Funcionario>, IFuncionarioRepository //RepositoryBase<Funcionario>
    {
<<<<<<< HEAD
        public int GetIdByName(string nome)
        {
            using (var context = new ContextGCASSP())
            {

                return context.funcionario.Where(p => p.Nome == nome).Select(p => p.IdFuncionario).FirstOrDefault();
            }
        }
=======
>>>>>>> 94308d1dd202ea1a5df42e6530c8cba6729481c7

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
