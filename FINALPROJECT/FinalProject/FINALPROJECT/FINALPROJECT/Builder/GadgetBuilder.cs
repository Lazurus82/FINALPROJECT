using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FINALPROJECT;

namespace Builder
{
    public abstract class GadgetBuilder
    {
        public abstract IGadget Gadget { get; }

        public virtual void BuildSwitches()
        {

        }

        public virtual void BuildButtons()
        {

        }

        public virtual void BuildPower()
        {

        }

        public virtual void BuildWidgets()
        {

        }
    }
}
