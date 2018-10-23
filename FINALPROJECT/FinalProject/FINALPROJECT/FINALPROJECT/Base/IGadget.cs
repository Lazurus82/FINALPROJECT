using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECT
{
    public interface IGadget
    {
        GadgetColor ColorType { get; }
        GadgetPower PowerType { get; }
        decimal Price { get; }
        int Buttons { get; }
        int Switches { get; }
        int Quantity { get; set; }
        int SmallWidgets { get; }
        int MediumWidgets { get; }
        int LargeWidgets { get; }

        void Paint(GadgetColor color);

        void CleanGadget();
        void PackageGadget();
        void AddUpc();
    }
}
