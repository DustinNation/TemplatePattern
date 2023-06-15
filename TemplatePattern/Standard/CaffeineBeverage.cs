using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.Standard
{
    public abstract class CaffeineBeverage
    {
        public void PrepareBeverage()
        {
            BoilWater();
            Brew();
            Pour();
            AddCondiments();
        }

        public virtual void BoilWater()
        {
            Console.WriteLine("Boiling Water...");
        }

        public virtual void Pour()
        {
            Console.WriteLine("Pouring into the cup...");
        }

        public abstract void Brew();
        public abstract void AddCondiments();

    }
}
