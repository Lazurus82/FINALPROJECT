using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FINALPROJECT;

namespace Visitor
{
    public interface IVisitable
    {
        void AcceptVisitor(IWidgetVisitor visitor);
    }
}
