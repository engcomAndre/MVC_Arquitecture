using MVC_Cursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Cursos.Services.AutorServices
{
    public class InMemoryAutorData : IAutorData
    {
        private List<Autor> _autors;

        public InMemoryAutorData()
        {
            _autors = new List<Autor>
            {
                new Autor{id = 1,Name = "Autor 1"},
                new Autor{id = 2,Name = "Autor 2"},
                new Autor{id = 3,Name = "Autor 3"},
                new Autor{id = 4,Name = "Autor 4"},           
                new Autor{id = 5,Name = "Autor 5"}
            };

        }
        public IEnumerable<Autor> GetAllAutors()
        {
            return _autors.OrderBy(autor =>autor.id);
        }
    }
}
