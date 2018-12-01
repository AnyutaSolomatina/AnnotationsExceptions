using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsExceptions
{
    public abstract class AbstractCar : IComparable<AbstractCar>
    {
        protected string model;
        protected double HorsePover;
        protected double Watt;
        protected string Type;
        protected string Drive;
        public abstract string EngineCapacity();
        public abstract string BodyType();
        public abstract string CarDrive();
        public abstract string Model();

        public int CompareTo(AbstractCar other)
        {
            if (HorsePover > other.HorsePover)
                return 1;
            else if (HorsePover < other.HorsePover)
                return -1;
            else
                return 0;
        }
    }
}
