using System;
using DronOfFuture.App.Dominio;
using DronOfFuture.App.Persistencia;

namespace DronOfFuture.App.Consola
{
    class Program
    {
        private static IRepositorioCliente _repoCliente = new RepositorioCliente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World! Prueba de consola");
            //AddClientes();
            //BuscarCliente(1);
            EliminarCliente(2);
            //hola mundo
        }
        
        private static void AddClientes()
        {
            var persona = new Clientes
            {     
                Nombre = "Andres",
                Apellido = "Perez",
                Telefono = "326581",
                Correo = "Perez@ucaldas.com",
                Direccion = "Manizales, Col"
            };

            _repoCliente.AddClientes(persona);
        }

        private static void BuscarCliente(int idPersona)
        {
            var persona = _repoCliente.GetClientes(idPersona);
            Console.WriteLine(persona.Nombre + " " + persona.Apellido);

        }
        private static void EliminarCliente(int idPersona)
        {
            _repoCliente.DeleteClientes(idPersona);

        }
    }
}
