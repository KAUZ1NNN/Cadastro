using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Interfacess
{
    [ServiceContract]
    public interface ICliente
    {
        [OperationContract]
        void Cadastrar(ICliente obj);

        [OperationContract]
        Cliente Buscar(int id);

        [OperationContract]
        List<Cliente> Listar();

        [OperationContract]
        void Deletar(int id);

        [OperationContract]
        void Editar(Cliente objNovo);
    }
}
