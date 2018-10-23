using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FINALPROJECT;

namespace Builder
{
    public class GadgetCustomDirector : GadgetDirector
    {
        public override IGadget Build(GadgetBuilder builder)
        {
            builder.BuildButtons();
            builder.BuildPower();
            builder.BuildSwitches();
            builder.BuildWidgets();
            return builder.Gadget;
        }
    }
}
