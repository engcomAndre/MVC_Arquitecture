using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Cursos.Models
{
    public class Trainee
    {
        public int id { get; set; }
        public string Name { get; set; }

        public Trainee()
        {

        }

        public Trainee(int id,string Name)
        {
            this.id = id;
            this.Name = Name;
        }
    }
}
