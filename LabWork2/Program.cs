using System;
using System.Collections;
using System.Collections.Generic;

namespace LabWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Butterfly butterfly = new Butterfly("Бабочка", "Red",  "Капуста");
            Console.WriteLine(butterfly.PrintValues());

            Butterfly butterfly1 = new Butterfly("Бабочка", "Blue", "Цветы", "12 day");
            Console.WriteLine(butterfly1.PrintValues());

            ButtflyController controller = new ButtflyController();
            controller.Add("Бабочка", "Blue", "12 дней", "капуста");

 
            Print print = MyPrint;
            controller.PrintButtfly(print);
            Console.WriteLine(Butterfly.number());
        }

        private static void MyPrint(string message)
        {
            Console.WriteLine(message); ;
        }
    }
}
