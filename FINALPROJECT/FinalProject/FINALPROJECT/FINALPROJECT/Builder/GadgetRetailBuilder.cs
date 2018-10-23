using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FINALPROJECT;

namespace Builder
{
    public class GadgetRetailBuilder : GadgetBuilder
    {
        private AbstractRetailGadget gadgetRetailInProgress;

        public override IGadget Gadget
        {
            get { return gadgetRetailInProgress; }
        }

        public GadgetRetailBuilder(AbstractRetailGadget retailGadget)
        {
            this.gadgetRetailInProgress = retailGadget;
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
