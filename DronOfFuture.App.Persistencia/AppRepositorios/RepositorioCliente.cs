using System.Collections.Generic;
using System.Linq;
using DronOfFuture.App.Dominio;

namespace DronOfFuture.App.Persistencia
{
    public class RepositorioCliente:IRepositorioCliente
    {
        ///<summary>
        ///</summary>
        private readonly AppContext _appContext;

        ///<summary>
        ///</summary>
        ///</param name="appContext"> </param>

        public RepositorioCliente()
        {
            clientes = new List<Clientes>()
            {
                new Cliente{Nombre = "Andres", Apellido = "Perez",
                Telefono = "326581", Correo = "Perez@ucaldas.com",
                Direccion = "Manizales, Col"}
            }
        }
        public RepositorioCliente(AppContext appContext)
        {
            _appContext = appContext;
        }

        Clientes IRepositorioCliente.AddClientes(Clientes persona)
        {
            var personaInsertada = _appContext.Clientes.Add(persona);
            _appContext.SaveChanges();
            return personaInsertada.Entity;
        }

        void IRepositorioCliente.DeleteClientes(int idPersona)
        {
            var personaEncontrada = _appContext.Clientes.FirstOrDefault(p => p.Id == idPersona);
            if(personaEncontrada == null){
                return;
            }
            _appContext.Clientes.Remove(personaEncontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<Clientes> IRepositorioCliente.GetAllClientes()
        {
            return _appContext.Clientes;
        }
        
        Clientes IRepositorioCliente.UpdateClientes(Clientes persona){
             var personaEncontrada = _appContext.Clientes.FirstOrDefault(p => p.Id == persona.Id);
             if(personaEncontrada != null)
            {
                personaEncontrada.Nombre = persona.Nombre;
                // y asi sucesivamenbte para todos los atributos

                _appContext.SaveChanges();

            }

            return personaEncontrada;
        }
        
        Clientes IRepositorioCliente.GetClientes(int idPersona){
            var personaEncontrada = _appContext.Clientes.FirstOrDefault(p => p.Id == idPersona);
            return personaEncontrada;
            //return
        }
    }
}