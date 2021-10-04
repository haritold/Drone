using System.Collections.Generic;
using DronOfFuture.App.Dominio;

namespace DronOfFuture.App.Persistencia
{
    public interface IRepositorioCliente
    {
        IEnumerable<Clientes> GetAllClientes();
        Clientes AddClientes(Clientes cliente);
        Clientes UpdateClientes(Clientes cliente);
        void DeleteClientes(int idCliente);
        Clientes GetClientes(int idCliente);
    }
}

