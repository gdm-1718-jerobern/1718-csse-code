using System;
using System.Threading;

namespace week11
{
    class Program
    {
     
        delegate int numberReached(int num);
        event numberReached myEvent;
        public static int number = 0;

        public Program()
        {            
            this.myEvent += new numberReached(checkNumber);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Geef een maximumwaarde  ");
            int num;
            if (int.TryParse(Console.ReadLine(), out num))
            {
                Program program = new Program();
                int result = program.myEvent(number);
                threadInit(num);
            }
            else
            {
                Console.WriteLine("Geef een getal op!");
            }

        }

         public static int checkNumber(int a)
            {

            while (number < a){
                number++;  
                Console.WriteLine(number);              
            };  

            if (number == a) {
                DateTime now = DateTime.Now;
                Console.WriteLine(now);
                Console.WriteLine("De maximumwaarde is " + a);
            }                
            return number;
        }

        public static void threadInit(int num){
            Thread.CurrentThread.Name = "main";
            Thread worker1 = new Thread(()=>checkNumber(num));
            worker1.Name = "worker1";
            Console.WriteLine("Worker naam: " + worker1.Name);
            worker1.Start();
        }
        
    }
}
