using Microsoft.EntityFrameworkCore;
using PetshopOA.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petshop.Server
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<PetshopOA.Shared.Petshop> Petshops { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<PetshopOA.Shared.Servico> Servico { get; set; }
        public DbSet<PetshopOA.Shared.Contrato> Contrato { get; set; }
    }
}
