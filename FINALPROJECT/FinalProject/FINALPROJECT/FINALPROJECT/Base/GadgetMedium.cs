using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECT
{
    
    public class GadgetMedium : AbstractGadget
    {
        private int _buttons = 3, _switches = 3, _quantity = 1, _lights = 2;
        private int _smallWidgets = 2, _mediumWidgets = 2, _largeWidgets = 1;

        public override int Quantity
        {
            set
            {
                this._quantity = Quantity;
            }
            get
            {
                return _quantity;
            }
        }

        public override int Switches
        {
            get
            {
                return _switches;
            }
        }

        public override int Buttons
        {
            get
            {
                return _buttons;
            }
        }

        public int Lights
        {
            get
            {
                return _lights;
            }
        }

        public override int SmallWidgets
        {
            get
            {
                return _smallWidgets;
            }
        }

        public override int MediumWidgets
        {
            get
            {
                return _mediumWidgets;
            }
        }

        public override int LargeWidgets
        {
            get
            {
                return _largeWidgets;
            }
        }

        public override decimal Price
        {
            get { return 6.00m; }
        }

        public GadgetMedium()
            : this(GadgetColor.Unpainted, GadgetPower.Battery)
        {
            Console.WriteLine("This is where we build the Widgets for Medium Gadget");
        }

        public GadgetMedium(GadgetColor color, GadgetPower power)
            : base(color, power)
        {
            Console.WriteLine("This is where we build the Widgets for Medium Gadget");
        }
    }
}
