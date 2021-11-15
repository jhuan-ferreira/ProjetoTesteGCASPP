using System;
<<<<<<< HEAD
using System.Collections.Generic;
=======
>>>>>>> 94308d1dd202ea1a5df42e6530c8cba6729481c7
using System.ComponentModel.DataAnnotations;

namespace ProjetoTesteGCASPP.Entities
{
    public class Funcionario
    {
        [Key]
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public double Salario { get; set; }
<<<<<<< HEAD
        public IEnumerable<Filho> Filhos { get; set; }
=======
>>>>>>> 94308d1dd202ea1a5df42e6530c8cba6729481c7
    }
}
