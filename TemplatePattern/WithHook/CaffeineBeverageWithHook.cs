using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.WithHook
{
    public abstract class CaffeineBeverageWithHook
    {
        public void PrepareBeverage()
        {
            BoilWater();
            Brew();
            Pour();

            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        public virtual void BoilWater()
        {
            Console.WriteLine("Boiling Water...");
        }

        public virtual void Pour()
        {
            Console.WriteLine("Pouring into the cup...");
        }

        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }

        public abstract void Brew();
        public abstract void AddCondiments();
    }
}
