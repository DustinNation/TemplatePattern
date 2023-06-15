using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.WithHook
{
    internal class TeaWithHook: CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea...");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding lemon...");
        }

        public override bool CustomerWantsCondiments()
        {
            var answer = GetUserInput();

            return answer.ToLower().StartsWith('y');
        }

        private static string GetUserInput()
        {
            var answer = string.Empty;

            Console.WriteLine("Would you like lemon with your tea (y/n)?");

            try
            {
                answer = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error trying to read your answer.");
            }

            return string.IsNullOrEmpty(answer) ? "No" : answer;
        }
    }
}
