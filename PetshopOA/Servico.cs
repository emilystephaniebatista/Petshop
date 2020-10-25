using System;
using System.Collections.Generic;
using System.Text;

namespace PetshopOA.Shared
{
    public class Servico
    {
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
        
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
