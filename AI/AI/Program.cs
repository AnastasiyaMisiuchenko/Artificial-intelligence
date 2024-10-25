using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> responses = new Dictionary<string, List<string>>()
        {
            {"привет", new List<string>(){"Привет!", "Здравствуй!", "Приветствую!"}},
            {"how are you", new List<string>(){"Хорошо, спасибо!", "Я в порядке, как вы?", "Не жалуюсь!"}},
            {"bye", new List<string>(){"До свидания!", "Пока!", "До встречи!"}},
            {"default", new List<string>(){"Извините, я не понял.", "Можете повторить?", "Интересный вопрос."}}
        };

            Console.WriteLine("Привет! Я чат-бот на C#. Можете начать общение.");
            while (true)
            {
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "bye" || userInput == "exit")
                {
                    Console.WriteLine("Бот: До свидания!");
                    break;
                }
                else if (userInput.Contains("hello"))
                {
                    Console.WriteLine("Бот: " + GetRandomResponse(responses["hello"]));
                }
                else if (userInput.Contains("how are you"))
                {
                    Console.WriteLine("Бот: " + GetRandomResponse(responses["how are you"]));
                }
                else
                {
                    Console.WriteLine("Бот: " + GetRandomResponse(responses["default"]));
                }
            }
        }

        static string GetRandomResponse(List<string> responses)
        {
            Random rand = new Random();
            return responses[rand.Next(responses.Count)];
        }
    }
    
}
