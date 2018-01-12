using System;

namespace Fibonacci {
    class Program {
        static void Main(string[] args) {
            int input = geefWillekeurigGetal();
            fibonacci(input);
        }
        
        static void fibonacci(int input) {
            int[] a = new int[input];
            a[0] = 0;
            a[1] = 1;
            for (int i = 2; i < input; i++) {
                a[i] = a[i - 1] + a[i - 2];
            }
            int teller = 0;
            foreach(int j in a) {
                Console.WriteLine(a[teller]);
                teller++;
            } 
        }

        static int geefWillekeurigGetal() {
            Console.WriteLine("Geef een lengte voor de fibonacci reeks?");
            int lengte = Convert.ToInt32((Console.ReadLine()));
            return lengte;
        }

    }
}