using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int time = DateTime.Now.Hour;
            //time = 06;
            //time = 19;
            int dakika = DateTime.Now.Minute;

            if(time >= 6 && time <11)
                Console.WriteLine("günaydın!");

            else if (time <= 18)
                Console.WriteLine("iyi Günler!");
            else
                Console.WriteLine("iyi Akşamlar!"); 
            if (dakika<10)  
                Console.WriteLine("Saat: " +time + ":0" +dakika);
            else
                Console.WriteLine("Saat: " + time + ":" + dakika);
            //Console.ReadLine();
            string sonuc = time <= 18 ? "iyi günler!" : "iyi gecler!";
            sonuc = time >= 6 && time <= 11 ? "günaydın!" : time <= 18 ? "iyi günler" : "iyi geceler";
                Console.WriteLine(sonuc);

            
                
        }
    }
}
