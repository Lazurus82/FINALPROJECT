using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECT.Base
{
    public class GadgetLarge : AbstractGadget
    {
        private int _buttons = 4, _switches = 4, _quantity = 1, _lights = 3;
        private int _smallWidgets = 3, _mediumWidgets = 6, _largeWidgets = 3;

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


        public GadgetLarge()
            : this(GadgetColor.Unpainted, GadgetPower.Generator)
        {
            Console.WriteLine("This is where we build the Widgets for Large Gadget");
        }

        public GadgetLarge(GadgetColor color, GadgetPower power)
            : base(color, power)
        {
            Console.WriteLine("This is where we build the Widgets for Large Gadget")
        }

        public override decimal Price
        {
            get { return 9.00m; }
        }
    }
}
