using MVC_Cursos.Models;
using System.Collections.Generic;

namespace MVC_Cursos.ViewModels.AutorViewModel
{
    public class AutorIndexViewModel
    {
        public IEnumerable<Autor> Autors;
        public string AutorCurrentMessage;
    }
}
