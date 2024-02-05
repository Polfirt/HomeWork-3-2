using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ff
{
    public abstract class ArrayBase
    {
        protected int[] dimensions;

        public ArrayBase(params int[] dimensions)
        {
            this.dimensions = dimensions;
        }

        public abstract void Initialize();

        public abstract void RandomInitialize();
        public abstract void Print();
        public abstract double CalculateAverage();
    }
}
