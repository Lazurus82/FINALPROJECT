using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FINALPROJECT;
using Visitor;

namespace FINALPROJECT
{
    public abstract class AbstractWidget : IWidget
    {
        private int _size;
        private Springs _springs;
        private Levers _levers;
        private Gears _gears;
        private WidgetColor _color1;

        public WidgetColor Colortype => _color1;

        public AbstractWidget(int size)
            : this(size, WidgetColor.Unpainted)
        {}

        public AbstractWidget(int size, WidgetColor color)
          
        {
            this._size = size;
            this._color1 = color;
            _springs = new Springs();
            _levers = new Levers();
            _gears = new Gears();
        }

        public void Paint(WidgetColor color)
        {
        Console.WriteLine("Painting Widget");
        }
  
                
        public virtual int Size
        {
            get
            {
                return _size;
            }
        }

        public void AcceptVisitor(IWidgetVisitor visitor)
        {
            _springs.AcceptVisitor(visitor);
            _levers.AcceptVisitor(visitor);
            _gears.AcceptVisitor(visitor);
        }
    }
}
