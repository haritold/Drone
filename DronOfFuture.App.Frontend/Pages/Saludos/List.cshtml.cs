using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HolaWeb.App.Dominio;
{
     
}

namespace HolaWeb.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        //private string[] saludos = {"Bdias","BTardes","BNoches"};
        //public List<string> ListaSaludos{get;set;}
        private readonly IRepositorioCliente repositorioClientes;
        public IEnumerable<Cliente>Cliente{get;set;}
        public ListModel(IRepositorioCliente repositorioClientes)

        public void OnGet()
        {
            //ListaSaludos = new List<string>();
            //ListaSaludos.AddRange(saludos);
            Cliente = repositorioClientes.getAll();
        }
    }
}
