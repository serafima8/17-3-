using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Manager : Staff
    {
        /// <summary>
        /// Создание поля объем продаж
        /// </summary>
        private int volume;
        /// <summary>
        /// Свойства поля volume
        /// </summary>
        public int Volume { get { return volume; } set { volume = value; } }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="birth"></param>
        /// <param name="p"></param>
        /// <param name="volume"></param>
        public Manager(string name, string surname, DateTime birth, int p, int volume) : base(name, surname, birth, p)
        {
            this.volume = volume;
        }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Manager() { }
        /// <summary>
        /// Метод, который выводит всю информацию об объекте
        /// </summary>
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Объем продаж: {volume}");
        }
        /// <summary>
        /// Метод, который вычисляет доход менеджера, исходя от условия
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public override double Income(double k)
        {
            return base.Income(k);
            Console.Write("Доход менеджера составляет: ");
            double h = Convert.ToDouble(Console.ReadLine());
            if (volume > h)
            {
                return base.Income(k) + 0.01 * h;
            }
            else
            {
                return base.Income(k);
            }
        }
    }
}
