using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork2
{
    // Базовый класс насекомые
    class Insect
    {
        
        /// прописываем основные свойста насекомых
        private string type;
        private string color;
       

        public static int Count { get; private set; } // переменная для подсчета созданых объектов

        public string Type{get;  set;}

        public string Color { get;  set; }


        /// Перегрузка конструкторов
        public Insect() { Count++; }

        public Insect(string type)
        {
            this.type = type;
            Count++;                    // добовляем в каждый конструктор чтобы считал кол-во объектов
        }

        public Insect(string type, string color)
        {
            this.type = type;
            this.color = color;
            Count++;
        }

        /// Виртуальный метод для вывода свойств
        public virtual  string PrintValues()
        {
            return $"Тип: {this.type}, Цвет: {this.color}";
        }
    }
}
