using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECT
{
    public class WidgetSmall : AbstractWidget   
    {
        public WidgetSmall(int size)
            : this(size, WidgetColor.Unpainted)
        {
            Console.WriteLine("This is a small widget");
            //Gears = 2
            //Springs = 3
            //Levers = 1

        }

        public WidgetSmall(int size, WidgetColor color)
            : base(size, color)
        {

        }
    }
}
