
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Map
{
    internal class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            this.ToTable("Cliente");
            this.HasKey(c => c.Id);
            this.Property(c => c.Nome).HasColumnName("Nome");
            this.Property(c => c.CPF).HasColumnName("CPF");
            this.Property(c => c.RG).HasColumnName("RG");
            this.Property(c => c.Endereco).HasColumnName("Endereco");
            this.Property(c => c.N_Endereco).HasColumnName("N_Endereco");
            this.Property(c => c.Bairro).HasColumnName("Bairro");
            this.Property(c => c.CEP).HasColumnName("CEP");
            this.Property(c => c.Cidade).HasColumnName("Cidade");
            this.Property(c => c.Estado).HasColumnName("Estado");

        }
    }
}
