using System;
using System.Collections;
using System.Collections.Generic;

namespace LabWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Butterfly butterfly = new Butterfly("Бабочка", "Red");
            Console.WriteLine(butterfly.PrintValues());

            Butterfly butterfly1 = new Butterfly("Бабочка", "Blue", "Цветы", "12 day");
            Console.WriteLine(butterfly1.PrintValues());
            Console.WriteLine(Butterfly.number());

            ButtflyController controller = new ButtflyController();
            controller.Add("jhdhjh", "hjhdch", "jhcducdhuhs", "jhcdchsjdj");
            Print print = MyPrint;
            controller.PrintButtfly(print);
        }

        private static void MyPrint(string message)
        {
            Console.WriteLine(message); ;
        }

    }
}














//public static void AddButfly()
//{
//    ButtflyController controller = new ButtflyController();
//    Console.WriteLine("Type: ");
//    string type = Console.ReadLine();
//    Console.WriteLine("Color: ");
//    string color = Console.ReadLine();
//    Console.WriteLine("Day: ");
//    string day = Console.ReadLine();
//    Console.WriteLine("Eat: ");
//    string eat = Console.ReadLine();

//    controller.Add(type, color, day, eat);
//    Print print = MyPrint;
//    controller.PrintButtfly(print);

//}