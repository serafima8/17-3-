using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Staff
    {
        /// <summary>
        /// Создание поля имени 
        /// </summary>
        private string name;
        /// <summary>
        /// Создание поля фамилии 
        /// </summary>
        private string surname;
        /// <summary>
        /// Создание поля день рождение 
        /// </summary>
        private DateTime birth;
        /// <summary>
        /// Создание поля минимальная зарплата
        /// </summary>
        private int p;
        /// <summary>
        /// Свойства поля name
        /// </summary>
        public string Name { get { return name; } set { name = value; } }
        /// <summary>
        /// Свойства поля surname
        /// </summary>
        public string Surname { get { return surname; } set { surname = value; } }
        /// <summary>
        /// Свойства поля birth
        /// </summary>
        public DateTime Birth { get { return birth; } set { birth = value; } }
        /// <summary>
        /// Свойства поля p
        /// </summary>
        public int P { get { return p; } set { p = value; } }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Staff() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="birth"></param>
        /// <param name="p"></param>
        public Staff(string name, string surname, DateTime birth, int p)
        {
            this.name = name;
            this.surname = surname;
            this.birth = birth;
            this.p = p;

        }
        /// <summary>
        /// Метод, который вычисляет доход по формуле
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        virtual public double Income(double k)
        {
            return k * p;
        }
        /// <summary>
        /// Метод, который выводит всю информацию об объекте
        /// </summary>
        virtual public void Print()
        {
            Console.WriteLine($"Имя: {name}\nФамилия: {surname}\nДата рождения: {birth}\nМинимальная зарплата: {p}\n");
        }
    }
}
