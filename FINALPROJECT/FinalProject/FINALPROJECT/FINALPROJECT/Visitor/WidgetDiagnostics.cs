using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FINALPROJECT;

namespace Visitor
{
    public class WidgetDiagnostics : IWidgetVisitor
    {
        public void Visit(IWidget widget)
        {
            Console.WriteLine("Diagnosing the widget");
        }

        public void Visit(Springs springs)
        {
            Console.WriteLine("Diagnosing the springs");
        }

        public void Visit(Gears gears)
        {
            Console.WriteLine("Diagnosing the gears");
        }

        public void Visit(Levers levers)
        {
            Console.WriteLine("Diabnosing the levers");
        }
    }
}
