using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DZ_4_Timer
{
    class Program
    {
        /*
         Используя таймер, написать код, выводящий значение времени по следующим правилам:
	    - первые 10 секунд каждую секунду, первый вывод через 3 секунды после запуска программы;
	    - вторые 10 секунд каждые 2 секунды.
         */
        static void Main(string[] args)
        {
            Timer timer = new Timer(TenSecondMethod, null, 3000, 1000);
            Console.WriteLine("Таймер запущен, через 3 секунды начнется отсчет");
            Thread.Sleep(10000);
            Console.WriteLine("А сейчас таймер будет отображаться каждые 2 секунды");
            timer.Change(0, 2000);
            Thread.Sleep(10000);
            timer.Dispose();

            Console.ReadKey();
        }

        private static void TenSecondMethod(object state)
        {
            Console.WriteLine( $"{DateTime.Now.ToLongTimeString()}"); ;
        }
    }
}
