using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECT
{
    public class WidgetMedium : AbstractWidget
    {
        public WidgetMedium(int size)
            : this(size, WidgetColor.Unpainted)
        {
            Console.WriteLine("This is a medium widget");
            //Gears = 4
            //Springs = 5
            //Levers = 3
        }

        public WidgetMedium(int size, WidgetColor color)
            : base(size, color)
        {
                
        }
    }
}
