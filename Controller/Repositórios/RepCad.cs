using Controller.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Repositórios
{
    public class RepCad
    {
        public void Cadastrar(Cliente obj)
        {
            using (var ctx = new SistemaContext())
            {
                ctx.Clientes.Add(obj);
                ctx.SaveChanges();
            }
        }
        public Cliente Buscar(int id)
        {
            Cliente obj = new Cliente();
            using (var ctx = new SistemaContext())
            {
                obj = ctx.Clientes.Find(id);
            }
            return obj;
        }
        public List<Cliente> Listar()
        {

            using (var ctx = new SistemaContext())
            {
                var Clientes = (from obj in ctx.Clientes select obj).OrderBy(z => z.Nome).ToList();

                return Clientes;
            }


        }
        public void Deletar(int id)
        {
            using (var ctx = new SistemaContext())
            {
                Cliente obj = ctx.Clientes.Find(id);
                ctx.Clientes.Remove(obj);
                ctx.SaveChanges();
            }
        }
        public void Editar(Cliente objNovo)
        {
            using (var ctx = new SistemaContext())
            {
                Cliente objAntigo = ctx.Clientes.Find(objNovo.Id);
                objAntigo.Nome = objNovo.Nome;
                objAntigo.CPF = objNovo.CPF;
                objAntigo.RG = objNovo.RG;
                objAntigo.Endereco = objNovo.Endereco;
                objAntigo.N_Endereco = objNovo.N_Endereco;
                objAntigo.Bairro = objNovo.Bairro;
                objAntigo.CEP = objNovo.CEP;
                objAntigo.Cidade = objNovo.Cidade;
                objAntigo.Estado = objNovo.Estado;
                ctx.SaveChanges();

            }
        }
    }
}


