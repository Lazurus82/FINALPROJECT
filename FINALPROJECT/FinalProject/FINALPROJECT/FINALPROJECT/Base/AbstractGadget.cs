using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECT
{
    public abstract class AbstractGadget : IGadget
    {
        private GadgetColor _color;
        private GadgetPower _gadgetPower;
        private string _paintColor;

        public abstract int Buttons { get; }
        public abstract int Switches { get; }
        public abstract int Quantity { get; set; }
        public abstract int SmallWidgets { get; }
        public abstract int MediumWidgets { get; }
        public abstract int LargeWidgets { get; }


        public abstract decimal Price { get; }

        public AbstractGadget()
            : this(GadgetColor.Unpainted,GadgetPower.Battery)
        {

        }

        public AbstractGadget(GadgetColor color, GadgetPower power)
        {
            this._gadgetPower = power;
            this._color = color;
        }

        public GadgetColor ColorType
        {
            get
            {
                return _color;
            }
        }

        public GadgetPower PowerType
        {
            get
            {
                return _gadgetPower;
            }
        }

       
        public virtual void CleanGadget()
        {
            Console.WriteLine ("Cleaning Gadget...");
        }

        public virtual void PackageGadget()
        {
            Console.WriteLine("Packaging Gadget...");
        }

        public virtual void AddUpc()
        {
            Console.WriteLine("Adding UPC to Package");
        }

        public virtual void Paint(GadgetColor color)
        {
            Console.WriteLine("Painting Gadget");
        }

        public override string ToString()
        {
            return this.GetType().Name + "Gadgets color is " +_color + "and it costs $" + Price;
        }
    }
}
