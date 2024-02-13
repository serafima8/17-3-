using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Staff> staffs = new List<Staff>();
            staffs.Add(new Staff("Николай", "Иванов", new DateTime(2005, 12, 02), 3000));
            staffs.Add(new Staff("Михаил", "Кравченко", new DateTime(2000, 11, 20), 3200));
            staffs.Add(new Staff("Лариса", "Соколова", new DateTime(2012, 07, 13), 3300));
            staffs.Add(new Staff("Дмитрий", "Котов", new DateTime(2002, 01, 01), 5800));
            staffs.Add(new Staff("Василий", "Титов", new DateTime(1999, 09, 14), 1900));
            staffs.Add(new Manager("Иван", "Рубцов", new DateTime(2006, 04, 05), 4000, 10));
            staffs.Add(new Manager("Алина", "Смирнова", new DateTime(2001, 10, 08), 2000, 20));
            staffs.Add(new Manager("Кристина", "Кузнецова", new DateTime(2008, 03, 12), 2500, 13));

            foreach (var st in staffs)
            {
                st.Print();
                Console.Write("Повышающий коэффициент k: ");
                double k = Convert.ToDouble(Console.ReadLine());
                Console.Write("Кол-во разбработанных проектов: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Доход: {st.Income(k)}");
            }

            Console.ReadKey();
        }
    }
}
