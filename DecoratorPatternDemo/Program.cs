using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent<string> component = new ConcreteComponent();
            Console.WriteLine(component.GetText());

            IComponent<string> plainDecorator = new PlainDecorator(component);
            Console.WriteLine(plainDecorator.GetText());

            IComponent<string> upperCaseDecorator = new UpperCaseDecorator(plainDecorator);
            Console.WriteLine(upperCaseDecorator.GetText());

            IComponent<string> colorDecorator = new ColorDecorator(upperCaseDecorator);
            Console.WriteLine(colorDecorator.GetText());
        }
    }
}

