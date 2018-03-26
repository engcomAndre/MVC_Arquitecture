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

        public Autor Add(Autor newAutor)
        {
            newAutor.id = _autors.Max(autor=>autor.id) + 1;
            _autors.Add(newAutor);

            return newAutor;            
        }

        public IEnumerable<Autor> GetAllAutors()
        {
            return _autors.OrderBy(autor =>autor.id);
        }

        public Autor GetAutorById(int id)
        {
            return _autors.FirstOrDefault(autor => autor.id == id);
        }

        public Autor GetAutorByName(string autorName)
        {
            return _autors.FirstOrDefault(autor => autor.Name == autorName);
        }
    }
}
