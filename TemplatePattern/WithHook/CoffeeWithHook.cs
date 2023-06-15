using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplatePattern.Standard;

namespace TemplatePattern.WithHook
{
    public class CoffeeWithHook: CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter...");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk...");
        }

        public override bool CustomerWantsCondiments()
        {
            var answer = GetUserInput();

            return answer.ToLower().StartsWith('y');
        }

        private static string GetUserInput()
        {
            var answer = string.Empty;

            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)?");

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
