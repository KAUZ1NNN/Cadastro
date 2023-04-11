using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public long CPF { get; set; } 
        public long RG { get; set; }
        public string Endereco { get; set; }
        public int N_Endereco { get; set; } 
        public string Bairro { get; set; }
        public long CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    
}
}
