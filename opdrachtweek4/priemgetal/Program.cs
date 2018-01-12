using System;

namespace Priemgetal
{
    class Program
    {

        static void Main(string[] args){
            int number = promptNumber();
            if (number < 100){
                for(int i = 0; i < (number+1); i++){
                    Console.WriteLine(i + isPriemgetal(i));
                }
            }
            else{
                Console.WriteLine("Het getal is groter dan 100");
            }
        }

        static int promptNumber ()
        {
            Console.WriteLine("Geef een getal in (kleiner dan 100)");
            int getal = Convert.ToInt32((Console.ReadLine()));
            return getal;
        }    

        static string isPriemgetal(int getal){
            int teller = 0;
            for (int i = 1; i < (getal+1); i++){
                if((getal%i) == 0){
                    teller++;
                }
            }
            if(teller == 2){
                return " = priemgetal";
            }else{
                return " = geen priemgetal";
 
            }
            
        }
    }
}
