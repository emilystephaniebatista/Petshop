using System;
using System.Collections.Generic;
using System.Text;

namespace PetshopOA.Shared
{
    public class Contrato
    {
        public int Id { get; set; }

        public int Numerocontrato { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
