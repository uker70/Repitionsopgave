using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_test
{
    class Program
    {
        static double GetDoubleFromUser(string spørgsmål)
        {
            Console.Write(spørgsmål);
            string input;
            double resultat;
            input = Console.ReadLine();

            while (!double.TryParse(input, out resultat))
            {
                Console.Write("Fejl, prøv igen");
                input = Console.ReadLine();
            }
            return resultat;
        }

        static int GetIntFromUser(string spørgsmål)
        {
            Console.Write(spørgsmål);
            string input;
            int resultat;
            input = Console.ReadLine();

            while (!int.TryParse(input, out resultat))
            {
                Console.Write("Fejl, prøv igen");
                input = Console.ReadLine();
            }
            return resultat;
        }
        static void Main(string[] args)
        {
            int i;
            int tal = 0;
            double[] array1 = new double[4];
            int over100 = 0;
            int uligetal = 0;
            int ligetal = 0;
            int negativtal = 0;
            int afslut = 1;

            do
            {
                Console.WriteLine("Skriv 1 for at vælge opgave 1: vudering af tal");
                Console.WriteLine("Skriv 2 for at vælge opgave 2: udskriv liste af tal");
                Console.WriteLine("Skriv 3 for at vælge opgave 3: alder");
                Console.WriteLine("Skriv 4 for at afslutte");
                string str = Console.ReadLine();
                int opgave1234 = Int32.Parse(str);
                Console.WriteLine();

                switch (opgave1234)
                {
                    case 1:
                        //opgave 1, skriv 4 tal og får information
                        do
                        {
                            array1[tal] = GetDoubleFromUser("Indtast et tal: ");
                            tal++;

                        } while (tal != array1.Length);
                        Console.WriteLine();
                        Array.Sort(array1);
                        for (i = 0; i < 4; i++)
                        {
                            Console.WriteLine("Tal [{0}] = {1}", i, array1[i]);
                        }

                        for (i = 0; i < 4; i++)
                        {
                            if (array1[i] % 2 == 0)
                            {
                                ligetal++;
                            }
                            else
                            {
                                uligetal++;
                            }
                        }

                        for (i = 0; i < 4; i++)
                        {
                            if (array1[i] > 100)
                            {

                                over100++;

                            }
                        }

                        for (i = 0; i < 4; i++)
                        {
                            if (array1[i] < 0)
                            {

                                negativtal++;

                            }
                        }

                        Console.WriteLine();

                        Console.WriteLine(ligetal + " tal som er lige");
                        Console.WriteLine(uligetal + " tal som er ulige");
                        Console.WriteLine(over100 + " tal over 100");
                        Console.WriteLine(negativtal + " tal som er negative");
                        Console.ReadKey();
                        break;

                    case 2:
                        //opgave 2
                        int[] array2 = new int[2];
                        int tal1 = 0;
                        double divideret;
                        do
                        {
                            array2[tal1] = GetIntFromUser("Indtast et tal: ");
                            tal1++;

                        } while (tal1 != array2.Length);
                        Array.Sort(array2);
                        Console.WriteLine();
                        Console.WriteLine("Lige tal mellem dine 2 valgte tal");
                        for (i = array2[0]; i < array2[1] + 1; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.Write(i + " ");
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Hvor mange gange det mindste af dine 2 tal går op i det største");

                        if (array2[0] == 0)
                        {
                            Console.WriteLine("Man kan ikke dividere noget med 0");
                        }
                        else
                        {
                            divideret = array2[1] / array2[0];
                            Console.WriteLine(divideret);
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        int årstal;
                        int måned;
                        int dag;
                        int resultat;

                        Console.WriteLine("Skriv det år du var født i, minimum årstal er 0 og maks er 2018, tallet nul er ikke inkluderet");
                        string str1 = Console.ReadLine();
                        årstal = Int32.Parse(str1);
                        while (!(0 < årstal || 2019 > årstal))
                        {
                            Console.WriteLine("Fejl, tallet var ikke mellem 0 og 2018, prøv igen");
                            string str4 = Console.ReadLine();
                            årstal = Int32.Parse(str4);
                        }

                        Console.WriteLine("Skriv den måned du er født i, ikke navnet, men det nummer den måned har");
                        string str3 = Console.ReadLine();
                        måned = Int32.Parse(str3);
                        while (!(0 < måned || 13 > måned))
                        {
                            Console.WriteLine("Fejl, du skrev ikke et tal eller også var det ikke mellem 1 og 12, begge tal inkluderet");
                            string str2 = Console.ReadLine();
                            måned = Int32.Parse(str2);
                        }

                        Console.WriteLine("Skriv den dag du er født i, ikke navnet, men det nummer den dag har i måneden");
                        if (måned == 1 || måned == 3 || måned == 5 || måned == 7 || måned == 8 || måned == 10 || måned == 12)
                        {
                            Console.WriteLine("Skriv den dag du er født, mellem 1 og 31, begge dage inkluderet");
                            string str6 = Console.ReadLine();
                            dag = Int32.Parse(str6);
                            while (!(0 < dag || 32 > dag))
                            {
                                Console.WriteLine("Fejl, du skrev ikke et tal som var godkendt, prøv igen");
                                string str8 = Console.ReadLine();
                                dag = Int32.Parse(str8);
                            }
                        }
                        else if (måned == 2)
                        {
                            Console.WriteLine("Skriv den dag du er født, mellem 1 og 28, begge tal inkluderet");
                            string str6 = Console.ReadLine();
                            dag = Int32.Parse(str6);
                            while (!(0 < dag || 29 > dag))
                            {
                                Console.WriteLine("Fejl, du skrev ikke et tal som var godkendt, prøv igen");
                                string str8 = Console.ReadLine();
                                dag = Int32.Parse(str8);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Skriv den dag du er født, mellem 1 og 30, begge tal inkluderet");
                            string str6 = Console.ReadLine();
                            dag = Int32.Parse(str6);
                            while (!(0 < dag || 31 > dag))
                            {
                                Console.WriteLine("Fejl, du skrev ikke et tal som var godkendt, prøv igen");
                                string str8 = Console.ReadLine();
                                dag = Int32.Parse(str8);
                            }
                        }
                        Console.WriteLine();

                        //2018 4 17
                        resultat = 2018 - årstal;
                        if (måned > 4)
                        {
                            resultat--;
                        }
                        else if (måned == 4)
                        {
                            if (dag > 17)
                            {
                                resultat--;
                            }
                        }

                        Console.WriteLine("Du er " + resultat + " år gammel");
                        Console.ReadKey();
                        break;

                    case 4:
                        afslut++;
                        break;
                }
                Console.WriteLine();
            } while (afslut == 1);
        }

    }
}

