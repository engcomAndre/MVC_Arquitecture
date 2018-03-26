using MVC_Cursos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_Cursos.ViewModels.CourseViewModel
{
    public class CourseEditModel
    {
        public String Title { get; set; }
        public string AutorName { get; set; }
        public TecnologyType Tecnology { get; set; }

        public IEnumerable<Autor> Autors;
        public IEnumerable<TecnologyType> tecnologyTypes;
        

        public CourseEditModel()
        {
            Autors = new List<Autor>();            
        }       

    }
}
