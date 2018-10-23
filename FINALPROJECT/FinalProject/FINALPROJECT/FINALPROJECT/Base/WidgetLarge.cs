using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECT
{
   
    public class WidgetLarge : AbstractWidget
    {
        public WidgetLarge(int size)
            : this(size, WidgetColor.Unpainted)
        {
            Console.WriteLine("This is a Large widget");
            //Gears = 9
            //Springs = 4
            //Levers = 2
        }

        public WidgetLarge(int size, WidgetColor color)
            : base(size, color)
        {

        }
    }
}
