using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class BeachHouse : IHome
    {
        public void Dwell()
        {
            Console.WriteLine("You are moving into your new beach house!");
        }
    }
}
