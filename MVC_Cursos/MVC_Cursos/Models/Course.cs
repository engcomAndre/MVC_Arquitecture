using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Cursos.Models
{
    public class Course
    {
        public int id { get; set; }
        public String Title{ get; set; }

        public int idAutor { get; set; }
        public Autor Autor { get; set; }

        List<Avaliation> receivedAvaliations;

        public Course()
        {
            List<Avaliation> receivedAvaliations = new List<Avaliation>();
        }

        public Course(int id, string Title,Autor autor)
        {
            this.id = id;
            this.Title = Title;
            this.Autor = Autor;
            List<Avaliation> receivedAvaliations = new List<Avaliation>();
        }

    }
}
