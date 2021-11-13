using System;
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
    }
}
