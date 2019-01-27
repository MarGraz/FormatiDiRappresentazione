using System;

namespace esercizioStringhe
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 500;
            short b = 100;
            //signed byte: sbyte
            sbyte c = -50;
            //long con literal, possibile usare _ come separatore migliaia (utile solo qui, poi in run i separatori vengono rimossi)
            long d = 100_000_000;
            //literal in formato binario. Il numero in binario viene introdotto da 0b...
            int e = 0b10101010;
            //literal in formato esadecimale. Introdotto da 0x... unsigned-short: ushort
            ushort f = 0x0A56;

            //stringa di formato, con numeri progressivi dei campi
            Console.WriteLine("a={0} b={1} c={2} d={3} e={4} f={5}", a, b, c, d, e, f);
            Console.WriteLine("Premi INVIO per continuare...");
            Console.ReadLine();

            //interpolazione di stringhe, sempre preceduto da $ e poi nomi delle variabili
            Console.WriteLine($"a={a} b={b} c={c} d={d} e={e} f={f}");
            Console.WriteLine("Premi INVIO per terminare...");
            Console.ReadLine();
            
        }
    }
}
