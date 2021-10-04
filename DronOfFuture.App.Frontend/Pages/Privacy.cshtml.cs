using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DronOfFuture.App.Frontend.Pages
{
    public class PrivacyModel : PageModel
    {
        private string[] programadores = {"Harold Gómez 😄","Esteban Toro",
        "Hilan Hernandez","Juan Carlos Agudelo","Daniel"};
        public List<string> ListaPro{get;set;}



        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ListaPro = new List<string>();
            ListaPro.AddRange(programadores);
        }
    }
}
