using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECT
{
    public class GadgetSmall : AbstractGadget
    {
        private int _buttons = 1, _switches = 2,  _quantity = 1;
        private int _smallWidgets = 1, _mediumWidgets = 1, _largeWidgets = 0;

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
            get { return 3.00m; }
        }

        public GadgetSmall()
            : this(GadgetColor.Unpainted, GadgetPower.Battery)
        {
            Console.WriteLine("This is where we build the Widgets for Small Gadget");
        }
    

        public GadgetSmall(GadgetColor color, GadgetPower power)
            : base(color, power)
        {
            Console.WriteLine("This is where we build the Widgets for Small Gadget");
        }

    }
}
