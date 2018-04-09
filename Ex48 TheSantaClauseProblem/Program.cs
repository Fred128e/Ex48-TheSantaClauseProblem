using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace Ex48_TheSantaClauseProblem
{
    class Program
    {
        
        List<Thread> threads = new List<Thread>();
        int RensdyrIStalden = 0;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }
        public void Run()
        {
            Thread Rensdyr1 = new Thread(GåIndIStalden);
            Rensdyr1.Name = "Rensdyr1";
            Thread.Sleep(1000);
            Rensdyr1.Start(Rensdyr1.Name + " er gået ind i stalden");

            Thread Rensdyr2 = new Thread(GåIndIStalden);
            Rensdyr2.Name = "Rensdyr2";
            Thread.Sleep(1000);
            Rensdyr2.Start(Rensdyr2.Name + " er gået ind i stalden");

            Thread Rensdyr3 = new Thread(GåIndIStalden);
            Rensdyr3.Name = "Rensdyr3";
            Thread.Sleep(1000);
            Rensdyr3.Start(Rensdyr3.Name + " er gået ind i stalden");

            Thread Rensdyr4 = new Thread(GåIndIStalden);
            Rensdyr4.Name = "Rensdyr4";
            Thread.Sleep(1000);
            Rensdyr4.Start(Rensdyr4.Name + " er gået ind i stalden");

            Thread Rensdyr5 = new Thread(GåIndIStalden);
            Rensdyr5.Name = "Rensdyr5";
            Thread.Sleep(1000);
            Rensdyr5.Start(Rensdyr5.Name + " er gået ind i stalden");

            Thread Rensdyr6 = new Thread(GåIndIStalden);
            Rensdyr6.Name = "Rensdyr6";
            Thread.Sleep(1000);
            Rensdyr6.Start(Rensdyr6.Name + " er gået ind i stalden");

            Thread Rensdyr7 = new Thread(GåIndIStalden);
            Rensdyr7.Name = "Rensdyr7";
            Thread.Sleep(1000);
            Rensdyr7.Start(Rensdyr7.Name + " er gået ind i stalden");

            Thread Rensdyr8 = new Thread(GåIndIStalden);
            Rensdyr8.Name = "Rensdyr8";
            Thread.Sleep(1000);
            Rensdyr8.Start(Rensdyr8.Name + " er gået ind i stalden");

            Thread Rensdyr9 = new Thread(GåIndIStalden);
            Rensdyr9.Name = "Rensdyr9";
            Thread.Sleep(1000);
            Rensdyr9.Start(Rensdyr9.Name + " er gået ind i stalden");

            Console.ReadKey();
        }

        public void GåIndIStalden(object msgObject)
        {
            RensdyrIStalden = RensdyrIStalden + 1;
            string message = (string)msgObject;
            Console.WriteLine(message);
            Console.WriteLine("Der er nu " +RensdyrIStalden+" Rensdyr i stalden");
            Console.WriteLine();

        }
    }
}
