using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Engineer : Staff
    {
        /// <summary>
        /// Создание поля количество разработанных проектов
        /// </summary>
        private int n;
        /// <summary>
        /// Свойства поля n
        /// </summary>
        public int N { get { return n; } set { n = value; } }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Engineer() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="birth"></param>
        /// <param name="p"></param>
        /// <param name="n"></param>
        public Engineer(string name, string surname, DateTime birth, int p, int n) : base(name, surname, birth, p)
        {
            this.n = n;
        }
        /// <summary>
        /// Метод, который выводит информацию об объекте
        /// </summary>
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Количество разработанных проектов: {n}");
        }
        /// <summary>
        /// Метод, который вычисляет доход, исходя от кол-ва разбработанных проектов
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public override double Income(double k)
        {
            return base.Income(k);
            Console.Write("Кол-во разбработанных проектов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            return 4.8 * n;
        }
    }
}
