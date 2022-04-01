using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    // DIP - Alt sınıflar ve üst sınıflar birbirinden bağımsız
interface IAutomessage
    {
        void message();
    }
class DelayMessage : IAutomessage
    {
        public void message()
        {
            Console.WriteLine("Delay message send");
        }
    }
class MessageSender 
    {
        private readonly IAutomessage _automessage;
        public MessageSender(IAutomessage automessage)
        {
            _automessage = automessage;
        }
        public void message()
        {
            _automessage.message();
        }
    }
}
