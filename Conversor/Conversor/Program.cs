using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para converte numeros Arabicos em Romano digite 'A' ou digite 'R' para obter o oposto: ");
            string escolha = Console.ReadLine();

            //ARABICO PARA ROMANO
            if (escolha == "A" || escolha == "a")
            {
                string rom = "";

                Console.WriteLine("Digite um numero maior que 0 e menor que 4000: ");
                int n = int.Parse(Console.ReadLine());

                while (true)
                {
                    //milhar
                    if (n < 4000 && n > 999)
                    {
                        switch (n / 1000)
                        {
                            case 1: rom += "M"; break;
                            case 2: rom += "MM"; break;
                            case 3: rom += "MMM"; break;
                        }
                        n -= 1000 * (n / 1000);
                    }
                    //centena
                    else if (n < 1000 && n > 99)
                    {
                        switch (n / 100)
                        {
                            case 1: rom += "C"; break;
                            case 2: rom += "CC"; break;
                            case 3: rom += "CCC"; break;
                            case 4: rom += "CD"; break;
                            case 5: rom += "D"; break;
                            case 6: rom += "DC"; break;
                            case 7: rom += "DCC"; break;
                            case 8: rom += "DCC"; break;
                            case 9: rom += "CM"; break;
                        }
                        n -= 100 * (n / 100);
                    }
                    //dezena
                    else if (n < 100 && n > 9)
                    {
                        switch (n / 10)
                        {
                            case 1: rom += "X"; break;
                            case 2: rom += "XX"; break;
                            case 3: rom += "XXX"; break;
                            case 4: rom += "XL"; break;
                            case 5: rom += "L"; break;
                            case 6: rom += "LX"; break;
                            case 7: rom += "LXX"; break;
                            case 8: rom += "LXXX"; break;
                            case 9: rom += "XC"; break;
                        }
                        n -= 10 * (n / 10);
                    }
                    //unidade
                    else if (n < 10 && n > 0)
                    {
                        switch (n)
                        {
                            case 1: rom += "I"; break;
                            case 2: rom += "II"; break;
                            case 3: rom += "III"; break;
                            case 4: rom += "IV"; break;
                            case 5: rom += "V"; break;
                            case 6: rom += "VI"; break;
                            case 7: rom += "VII"; break;
                            case 8: rom += "VIII"; break;
                            case 9: rom += "IX"; break;
                        }
                        n -= n;
                    }
                    else
                    {
                        Console.WriteLine("Valor invalido");
                        break;
                    }
                    if (n == 0) break;
                }
                Console.WriteLine("A conversão para numeros Romanos é: " + rom);
            }

            //ROMANO PARA ARABICO
            else if (escolha == "R" || escolha == "r")
            {
                Console.WriteLine("Digite um numero maior que 0 e menor que 4000 : ");
                string rom = Console.ReadLine();
                int ara = 0;

                if (rom.Length < 9)
                {

                    try
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            switch (rom[i])
                            {
                                case 'M':
                                case 'm':
                                    if (rom == "mmm" || rom == "mm" || rom == "m" || rom == "cm" || rom == "MMM" || rom == "MM" || rom == "M" || rom == "CM")
                                    {
                                        if (rom == "cm" || rom == "CM") ara += 0;
                                        else ara += 1000;
                                    }
                                    break;

                                case 'D':
                                case 'd':
                                    if (rom == "ddd" || rom == "dd" || rom == "d" || rom == "cd" || rom == "DDD" || rom == "DD" || rom == "D" || rom == "CD")
                                    {
                                        if (rom == "cd" || rom == "CD") ara += 0;
                                        else ara += 500;
                                    }
                                    break;

                                case 'C':
                                case 'c':
                                    if (rom == "c" || rom == "cc" || rom == "ccc" || rom == "cm" || rom == "C" || rom == "CC" || rom == "CCC" || rom == "CM")
                                    {

                                        if (rom == "cm" || rom == "CM") ara += 900;
                                        else if (rom == "cd" || rom == "CD") ara += 400;
                                        else if (rom == "xc" || rom == "XC") ara += 90;
                                        else ara += 100;
                                    }
                                    break;

                                case 'L':
                                case 'l':
                                    if (rom == "l" || rom == "xl" || rom == "L" || rom == "XL")
                                    {

                                        if (rom == "xl" || rom == "XL") ara += 40;
                                        else ara += 50;
                                    }
                                    break;

                                case 'X':
                                case 'x':
                                    if (rom == "xxx" || rom == "xx" || rom == "x" || rom == "ix" || rom == "xv" || rom == "xl" || rom == "XXX" || rom == "XX" || rom == "X" || rom == "IX" || rom == "XV" || rom == "XL" || rom == "xc" || rom == "XC")
                                    {

                                        if (rom == "ix" || rom == "IX") ara += 0;
                                        else if (rom == "xl" || rom == "XL") ara += 0;
                                        else if (rom == "xc" || rom == "XC") ara += 0;
                                        else if (rom == "xv" || rom == "XV") ara += 15;
                                        else ara += 10;
                                    }
                                    break;

                                case 'V':
                                case 'v':
                                    if (rom == "v" || rom == "iv" || rom == "xv" || rom == "V" || rom == "IV" || rom == "XV")
                                    {
                                        if (rom == "iv" || rom == "IV") ara += 0;
                                        else if (rom == "xv" || rom == "XV") ara += 0;
                                        else ara += 5;
                                    }
                                    break;

                                case 'I':
                                case 'i':
                                    if (rom == "iii" || rom == "ii" || rom == "i" || rom == "iv" || rom == "ix" || rom == "III" || rom == "II" || rom == "I" || rom == "IV" || rom == "IX")
                                    {
                                        if (rom == "iv" || rom == "IV") ara += 4;
                                        else if (rom == "ix" || rom == "IX") ara += 9;
                                        else ara += 1;
                                    }
                                    break;
                            }
                        }
                    }


                    catch (IndexOutOfRangeException) { };
                }

                else Console.WriteLine("Erro");

                Console.WriteLine("Valor digitado " + rom + " conversao: " + ara);
            }

            // CONVERSÃO ERRADA
            else Console.WriteLine("Comando Invalido ");

            Console.ReadKey();
        }
    }
}
