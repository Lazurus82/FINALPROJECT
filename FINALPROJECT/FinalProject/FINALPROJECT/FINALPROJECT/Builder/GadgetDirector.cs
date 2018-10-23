using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FINALPROJECT;

namespace Builder
{
    public abstract class GadgetDirector
    {
        public abstract IGadget Build(GadgetBuilder builder);
    }
}
