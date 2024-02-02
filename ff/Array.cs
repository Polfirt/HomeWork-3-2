using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ff
{
    public abstract class Array
    {
        protected int[] dimensions;

        public Array(params int[] dimensions)
        {
            this.dimensions = dimensions;
        }

        public abstract void Initialize();
        public abstract void Print();
        public abstract double CalculateAverage();
    }
}
