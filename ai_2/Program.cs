using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ai_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[] questions = { "привет", "как тебя зовут", "как дела" };
            List<string> questions = new List<string>();
            questions.Add("привет");
            questions.Add("как тебя зовут");
            questions.Add("как дела");

            //string[] answers = { "здравствуйте", "Абоба", "хорошо" };
            List<string> answers = new List<string>();
            answers.Add("здравствуйте");
            answers.Add("Лада");
            answers.Add("хорошо");

            string question = null;

            do
            {
                question = Console.ReadLine();

                for (int i = 0; i < questions.Count; i++)
                {
                    if (question == questions[i])
                    {
                        Console.WriteLine(answers[i]);

                        break;
                    }
                    else if (i == questions.Count - 1)
                    {
                        Console.WriteLine("Я еще маленькая, объясни мне!");

                        questions.Add(question);
                        string answer = Console.ReadLine();
                        answers.Add(answer);
                        Console.WriteLine("я запомнила");
                    }
                }
            } while (true);

        }
    }
}
