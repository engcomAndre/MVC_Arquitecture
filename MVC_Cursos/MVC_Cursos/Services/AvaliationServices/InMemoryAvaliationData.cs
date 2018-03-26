using MVC_Cursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC_Cursos.Services.AvaliationServices
{
    public class InMemoryAvaliationData : IAvaliationData
    {
        private List<Avaliation> _avaliations;

        public InMemoryAvaliationData()
        {
            Random random = new Random();
            _avaliations = new List<Avaliation>();
            for (int i = 0; i < 10; i++)
            {
                _avaliations.Add(new Avaliation
                {
                    id = random.Next(100),
                    idCourse = random.Next(5),
                    idTrainee = random.Next(5),
                    score = random.Next(11),
                });
            }
        }

        public IEnumerable<Avaliation> GetAllAvaliations()
        {
            return _avaliations.OrderBy(aval => aval.id);
        }

        public Avaliation GetAvaliationsById(int id)
        {
            return _avaliations.FirstOrDefault(aval => aval.id == id);
        }
    }
}
