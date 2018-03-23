using Microsoft.Extensions.Configuration;

namespace MVC_Cursos
{
    public interface IGreeter
    {
        string GetMessageOfDay();
    }

    public class Greeter : IGreeter
    {
        private IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetMessageOfDay()
        {
            return "The Greeting of Method 'GetMessageOfDay() in class Greetings'";
        }


    }
}