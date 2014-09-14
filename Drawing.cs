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
            string s = "Drawing";
            foreach (var widget in _widgets)
                s = s + widget.ToString();
            return s;
        }
    }
}
