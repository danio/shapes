using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    class Drawing
    {
        IList<IWidget> _widgets;

        public Drawing()
        {
            _widgets = new List<IWidget>();
        }

        public void Add(IWidget widget)
        {
            _widgets.Add(widget);
        }

        public override string ToString()
        {
            string s = "----------------------------------------------------------------\nCurrent Drawing\n----------------------------------------------------------------\n";
            foreach (var widget in _widgets)
                s = s + widget.ToString() + "\n";
            s = s + "----------------------------------------------------------------\n";
            return s;
        }
    }
}
