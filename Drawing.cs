using System;
using System.Collections.Generic;
using System.Text;

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
            StringBuilder sb = new StringBuilder();

            sb.Append(_rule);
            sb.Append("Current Drawing");
            sb.Append(Environment.NewLine);
            sb.Append(_rule);
            foreach (var widget in _widgets)
            {
                sb.Append(widget);
                sb.Append(Environment.NewLine);
            }
            sb.Append(_rule);
            return sb.ToString();
        }
    }
}
