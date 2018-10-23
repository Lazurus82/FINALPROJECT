using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FINALPROJECT;

namespace Visitor
{
    public interface IWidgetVisitor
    {
        void Visit(IWidget widget);
        void Visit(Springs springs);
        void Visit(Levers levers);
        void Visit(Gears gears);
    }
}
