using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsExceptions
{
    public class Car : AbstractCar
    {
        protected new string model;
        public override string EngineCapacity()
        {
            return "Лошадиные силы=" + HorsePover + ", мощность - " + Watt + "ватт";
        }
        public override string BodyType()
        {
            return "Тип кузова - " + Type;
        }
        public override string CarDrive()
        {
            return "Привод - " + Drive;
        }
        public override string Model()
        {
            return model;
        }

    }
}
