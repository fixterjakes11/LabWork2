using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LabWork2
{
    public delegate void Print(string message);
    class ButtflyController
    {
        public List<Butterfly> ButterFly { get; private set; }

        public ButtflyController()
        {
            ButterFly = new List<Butterfly>();
        }
        /// <summary>
        /// Добавление в список бабочек
        /// </summary>
        /// <param name="type"></param>
        /// <param name="color"></param>
        /// <param name="age"></param>
        /// <param name="eat"></param>
        public void Add(string type, string color, string age, string eat)
        {
            ButterFly.Add(new Butterfly
            {
                Type = type,
                Color = color,
                Eat = eat,
                Age = age

            }) ;
        }
        /// <summary>
        /// Вывод списка бабочек с помощью делегата
        /// </summary>
        /// <param name="print"></param>
        public void PrintButtfly(Print print)
        {
            foreach(var i in ButterFly)
            {
                print($"Имя или тип бабочки: {i.Type} -- цвет: {i.Color} -- срок жизни: {i.Age} -- основная пища: {i.Eat}");
            }
        }


    }
}
