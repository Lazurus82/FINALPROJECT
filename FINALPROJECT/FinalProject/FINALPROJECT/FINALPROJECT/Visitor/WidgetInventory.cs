using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FINALPROJECT;

namespace Visitor
{
    public class WidgetInventory : IWidgetVisitor
    {
        private int _springsCount;
        private int _gearsCount;
        private int _leversCount;

        public WidgetInventory()
        {
            _springsCount = 10;
            _gearsCount = 10;
            _leversCount = 10;
        }

        public void Visit(IWidget widget)
        {
            Console.WriteLine("The widget has: " + _springsCount + " springs and " + _gearsCount + " gears and " + _leversCount + "bearings.");
        }

        public void Visit(Springs springs)
        {
            _springsCount++;
        }

        public void Visit(Levers levers)
        {
            _leversCount++;
        }

        public void Visit(Gears gears)
        {
            _gearsCount++;
        }
    }
}
