using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    // ISP - Iphone telefonlar sadece iOS, Android telefonlar ise sadece android işletim sistemine sahip olabilir. Ortak özellikler dışındakiler prensip gereği ayrı bir arayüzde gösterilmiştir.
   public interface IMobilePhone
    {
        void Camera();
        void FPS();
    }
    public interface IIphone
    {
        void iOS();
    }
    public interface IAndroid
    {
        void Android();
    }
    public class Iphone : IMobilePhone, IIphone
    {
        public void iOS()
        {
            Console.WriteLine("iOS operating system");
        }
        public void Camera()
        {
            Console.WriteLine("Camera");
        }
        public void FPS()
        {
            Console.WriteLine("High FPS");
        }

    }
    public class AndroidPhone : IMobilePhone, IAndroid
    {
        public void Android()
        {
            Console.WriteLine("Android operating system");
        }
        public void Camera()
        {
            Console.WriteLine("Camera");
        }
        public void FPS()
        {
            Console.WriteLine("High FPS");
        }

    }

}
