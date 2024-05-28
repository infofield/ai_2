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
            string[] questions = { "привет", "как тебя зовут", "как дела" };
            string[] answers = { "здравствуйте", "Абоба", "хорошо" };

            string question = null;

            do
            {
                question = Console.ReadLine();

                for (int i = 0; i < questions.Length; i++)
                {
                    if (question == questions[i])
                    {
                        Console.WriteLine(answers[i]);

                        break;
                    }
                    else if (i == questions.Length - 1)
                    {
                        Console.WriteLine("Я еще маленький, объясни мне!");
                    }
                }
            } while (true);

        }
    }
}
