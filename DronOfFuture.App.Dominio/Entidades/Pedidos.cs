using System;

namespace DronOfFuture.App.Dominio
{
    public class Pedidos
    {
        public int IdPedido{get;set;}
        public string Contenido{get;set;}
        public int IdDron{get;set;}
        public int IdCliente{get;set;}
        //protected Clientes Cliente{get;set;}
        public int IdEncargado{get;set;}
        //protected Encargados Encargado{get;set;}
        public string Fecha{get;set;}
        public int Satisfaccion{get;set;}
        public string Descripcion{get;set;}
    }
}