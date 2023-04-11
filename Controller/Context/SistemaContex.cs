using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Runtime.Remoting.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller.Map;
using Entidades;


namespace Controller.Context
{
    internal class SistemaContext : DbContext
    {
        public SistemaContext() : base("Server=DESKTOP-I4B2Q50; Database=Cadastro; Integrated Security=true;")
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SistemaContext>(null);
            modelBuilder.Configurations.Add(new ClienteMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
