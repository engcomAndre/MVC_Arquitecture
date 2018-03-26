using MVC_Cursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Cursos.ViewModels.AvaliationViewModel
{
    public class AvaliationIndexViewModel
    {
        public IEnumerable<Avaliation> Avaliations;
        public string AvaliationCurrentMessage { get; set; }
    }
}
