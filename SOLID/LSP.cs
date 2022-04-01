using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    // LSP - Temel tartı sadece kilo ölçebilirken akıllı tartı hem kilo ölçüp hem vücut kitle endeksi ölçebiliyor
    abstract class BaseScale
    {
        public abstract void MeasuringWeight();
    }

    interface IMeasuringBMI
    {
        void BMI();
    }
    class Scale : BaseScale
    {
        public override void MeasuringWeight()
        {
            Console.WriteLine("can measure weight");
        }
        
    }
    class SmartScale : BaseScale, IMeasuringBMI
    {
        public override void MeasuringWeight()
        {
            Console.WriteLine("can measure weight");
        }
        public void BMI()
        {
            Console.WriteLine("can measure BMI");
        }

    }
    class ScaleType
    {
  
        readonly BaseScale _basescale = new Scale();     
        readonly SmartScale _smartscale = new SmartScale();

        public void Display()
        {
            _basescale.MeasuringWeight();
            _smartscale.MeasuringWeight();
            _smartscale.BMI();
        }
    }
}
