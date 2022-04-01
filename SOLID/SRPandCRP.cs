using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    //------------------SRP and OCP--------------
    // SRP - Her metod tek bir işlebi gerçekleştiriyor.
    // OCP - istendikçe diğer sınıflar etkilenmeden bölümler artırılabilir.
    public interface IDentalOperation
    {
        void Operation(AgeControl control, int age);
    }
    public class Endodonti : IDentalOperation          
    {
        public void Operation(AgeControl control, int age)
        {
            if (!control.IsValid(age))
                throw new Exception("Input is not valid");

             Console.WriteLine("Endodonti randevusı alındı");
        }
    }
    public class Periodontoloji : IDentalOperation
    {
        public void Operation(AgeControl control, int age)
        {
            if (!control.IsValid(age))
                throw new Exception("Input is not valid");

           Console.WriteLine("Periodontoloji randevusu alındı");
        }
    }

    public class ChooseOperation
    {
        private IDentalOperation operation;
        private AgeControl control = new AgeControl();
        public ChooseOperation(IDentalOperation _operation)
        {
            operation = _operation;
        }

        public void Control(int age)
        {
          operation.Operation(control, age);
        }
    }
    public class AgeControl                                 
    {  
        public bool IsValid(int age)
        {
            return age <=18
                   ? false
                   : true;
        }
    }
}

