using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsExceptions
{
    [My(HorsePoverHondaCivic=142)]
    public class HondaCivic : Car
    {
        public HondaCivic()
        {
            var type = this.GetType();
            var attributeValue = Attribute.GetCustomAttribute(type, typeof(MyAttribute))
           as MyAttribute;
            HorsePover = attributeValue.HorsePoverHondaCivic;
            Watt = 104441;
            Type = "хэтчбек";
            Drive = "передний";
            model = "HondaCivic";
        }
    }
}
