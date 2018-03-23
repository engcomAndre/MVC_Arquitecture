using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Cursos.Models
{
    public class Avaliation
    {
        public int id;
        public int idCourse;
        public int idTrainee;
        public int score;
        public Avaliation()
        {

        }
        
        public Avaliation(int id, int idCourse, int idTrainee, int score)
        {
            this.id = id;
            this.idCourse = idCourse;
            this.idTrainee = idTrainee;
            this.score = score;
        }
    }
}
