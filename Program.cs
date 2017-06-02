using System;

namespace Euler7
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 start = 5; // startgetal is het derde priemgetal
            Int64 nummer = start -2; // nummer is het getal wat test of het startgetal een priemgetal is
            int teller = 2; // de teller houdt bij op welk priemgetal we zitten. Bij de start is dat 2 en na het testen van het eerste startgetal wordt dat 3 (omdat 5 een priemgetal is)
            double startTime = Environment.TickCount;

            for (start = start; nummer > 2; start = start + 2)
            {
                if (start % nummer == 0)
                {
                    continue;
                }
                else
                {
                    nummer = (start / 2) + 1; // hiermee halveert de berekeningstijd en blijft de berekening zelf kloppend
                    for (start = start; start % nummer != 0; nummer = nummer - 1)
                    {
                        if (nummer <=2)
                        {
                            teller = teller + 1;                            
                            if (teller == 10001) //zodra de teller de 10.001ste priemgetal heeft bereikt, dan kan deze geprint worden
                            {
                                double endTime = Environment.TickCount;
                                Console.WriteLine("the " + teller + "th prime number is: " + start);
                                Console.WriteLine("time to compute in ms: " + (endTime - startTime));
                                Console.ReadKey();
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    nummer = (start /2) + 1; // hiermee halveert de berekeningstijd en blijft de berekening zelf kloppend
                }                                              
            }
        }
    }
}
