using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    // Farklı tür aromalı ve soslu dondurmalar sadece aroma ve sosların interface'leri yaratılarak ögeler fazlalaştığında yapıyı kolay entegre edilebilir hale getiriyor.
    public interface IicecreamFlavor
    {
        void Flavor();
    }

    public class Watermelon : IicecreamFlavor
    {
        public void Flavor()
        {
            Console.WriteLine("and watermelon flavored");
        }
    }
    public class Cocoa : IicecreamFlavor
    {
        public void Flavor()
        {
            Console.WriteLine("and cocoa flavored");
        }

    }
    public class Cherry : IicecreamFlavor
    {
        public void Flavor()
        {
            Console.WriteLine("and cherry flavored");
        }

    }

    public class IceCream
    {
        public IicecreamFlavor icecreamFlavor { get; set; }

        public IceCream(IicecreamFlavor icecreamflavor)
        {
            icecreamFlavor = icecreamflavor;
        }
        public virtual void chooseIcecream()
        {
            icecreamFlavor.Flavor();
        }
    }

    public class nutSauce : IceCream
    {
        public nutSauce(IicecreamFlavor flavor)
            : base(flavor)
        {

        }
        public override void chooseIcecream()
        {
            Console.WriteLine("Ice cream is nut sauce ");
            base.chooseIcecream();
        }
    }
    public class chocolateSauce : IceCream
    {
        public chocolateSauce(IicecreamFlavor flavor)
            : base(flavor)
        {

        }
        public override void chooseIcecream()
        {
            Console.WriteLine("Ice cream is chocolate sauce");
            base.chooseIcecream();
        }
    }
    
    class BridgeDP
    {
        static void Main(string[] args)
        {
            IceCream icecream = new chocolateSauce(new Watermelon());
            icecream.chooseIcecream();
            Console.WriteLine();

            IceCream icecream2 = new nutSauce(new Cocoa());
            icecream2.chooseIcecream();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
