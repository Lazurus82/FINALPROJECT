using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FINALPROJECT;

namespace Builder
{
    public class GadgetCustomBuilder : GadgetBuilder
    {
        private AbstractCustomGadget gadgetCustomInProgress;

        public override IGadget Gadget
        {
            get { return gadgetCustomInProgress; }
        }

    public GadgetCustomBuilder(AbstractCustomGadget customGadget)
    {
        this.gadgetCustomInProgress = customGadget;
    }

    public override void BuildSwitches()
    {

    }

    public override void BuildButtons()
    {

    }

    public override void BuildPower()
    {

    }

    public override void BuildWidgets()
    {

    }

    }
}
