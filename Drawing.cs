using System;
using System.Collections.Generic;
//using System.Linq;

namespace shapes
{
    class Drawing
    {
        IList<IWidget> _widgets;
        internal static readonly string _rule = "----------------------------------------------------------------" + Environment.NewLine;

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
            string s = _rule + "Current Drawing" + Environment.NewLine + _rule;
            foreach (var widget in _widgets)
                s = s + widget.ToString() + Environment.NewLine;
            s = s + _rule;
            return s;
        }
    }
}
