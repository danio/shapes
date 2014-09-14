using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    class Square : IWidget
    {
        private int _size;

        public Square(int size)
        {
            _size = size;
        }

        public void Print()
        {
            Console.WriteLine("Square size={0}", _size);
        }
    }
}
