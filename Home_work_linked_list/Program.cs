using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            var modelCars = new Model.LinkedList<int>();

            modelCars.Add(1);
            modelCars.Add(2);
            modelCars.Add(3);
            modelCars.Add(4);
            modelCars.Add(5);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
