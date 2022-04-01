using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    //Kapalı alan ve açık alan için belli olan fotoğrafik özellikler paket halinde hazır tutularak tekrar tekrar ayarlamalar yapılmamış oluyor.
   interface IoutdoorMode
    {
        void openOutdoorMode();
    }

    class outdoorMode : IoutdoorMode
    {
        public void openOutdoorMode()
        {
            Console.WriteLine("Flash turned off");
            Console.WriteLine("Contrast reduced");
        }
    }

    interface IindoorMode
    {
        void openIndoorMode();
    }

    class indoorMode : IindoorMode
    {
        public void openIndoorMode()
        {
            Console.WriteLine("Flash turned on");
            Console.WriteLine("Contrast increased");
            Console.ReadLine();
        }
    }

    class Facade
    {
        public IoutdoorMode _outdoor;
        public IindoorMode _indoor;

        public Facade()
        {
            _outdoor = new outdoorMode();
            _indoor = new indoorMode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade._outdoor.openOutdoorMode();
            facade._indoor.openIndoorMode();
        }
            

    }
    
}
