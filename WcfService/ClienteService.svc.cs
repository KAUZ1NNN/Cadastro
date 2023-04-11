using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Controller.Repositórios;
using Entidades;
using Interfacess;

namespace WcfService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class ClienteService : ICliente
    {
        public RepCad rep = new RepCad();
        
        public void Cadastrar(Cliente obj)
        {
            rep.Cadastrar(obj);
        }
        public Cliente Buscar(int id)
        {
           return rep.Buscar(id);
        }
        public List<Cliente> Listar()
        {
            return rep.Listar();
        }
        public void Deletar(int id)
        {
            rep = new RepCad();
        }
        public void Editar(Cliente objNovo)
        {
            rep.Editar(objNovo);
        }

        public void Cadastrar(ICliente obj)
        {
            throw new NotImplementedException();
        }
    }
}
