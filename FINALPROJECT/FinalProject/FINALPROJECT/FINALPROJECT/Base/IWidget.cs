using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace FINALPROJECT
{
    public interface IWidget : IVisitable
    {
        int Size { get; }
        WidgetColor Colortype { get;}

        void Paint(WidgetColor color);
        
    }
}
