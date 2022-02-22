using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork2
{
    /// <summary>
    /// Создаем класс бабочек и наследуем от насекомых свойста, так как бабочки это тоже насекомые(наверное)
    /// </summary>
    class Butterfly : Insect
    {
        /// <summary>
        /// Добовляем характерные для бабочек свойства
        /// </summary>
        private string eat;
        private string age;
        public string Age { get; set; }
        public string Eat { get; set; }


        /// Берем конструкто от базового класса, потом добовляем ему уже свойства класса наследника
        public Butterfly() : base() { }
        public Butterfly(string type, string color) : base(type, color) { }

        public Butterfly(string type, string color, string eat) : base(type, color)
        {
            this.eat = eat;
        }
        public Butterfly(string type, string color, string eat, string age) : base(type, color)
        {
            this.eat = eat;
            this.age = age;
        }



        /// <summary>
        /// Выводим значения
        /// </summary>
        public override string PrintValues()
        {
            return $" {base.PrintValues()}, живет до  {age}, основная еда {eat}";
        }
        /// <summary>
        /// Подсчет кол-во созданых бабочек
        /// </summary>
        public static string number() // подсчет созданых бабочек
        {
            return $"Бабочеk в списке: {Count}";
        }

    }
}
