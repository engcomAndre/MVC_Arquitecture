using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Cursos.Models
{
    public class Autor
    {
        public int id{ get; set; }
        public string Name { get; set; }
        

        public Autor()
        {

        }

        public Autor(string Name)
        {
            this.Name = Name;
        }

        public Autor(int id, string name)
        {
            this.id = id;
            Name = name;
        }
    }
}
