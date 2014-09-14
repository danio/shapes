using System;
using System.Collections.Generic;
using System.Text;

namespace shapes
{
    public class Drawing
    {
        IList<IWidget> _widgets;
        const string _rule = "----------------------------------------------------------------";

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

            sb.AppendLine(_rule);
            sb.AppendLine("Current Drawing");
            sb.AppendLine(_rule);
            foreach (var widget in _widgets)
            {
                sb.AppendLine(widget.ToString());
            }
            sb.AppendLine(_rule);
            return sb.ToString();
        }
    }
}
