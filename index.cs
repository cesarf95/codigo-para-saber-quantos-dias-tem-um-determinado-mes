using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp44
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string mes = "";
            WriteLine("Digite um mes:");
            mes = ReadLine();
            switch (mes)
            {
                case "Janeiro":
                case "Marco":
                case "Maio":
                case "Julho":
                case "Agosto":
                case "Outubro":
                case "Dezembro":
                    WriteLine("O mes de {0} tem 31 dias.", mes);
                    break;
                case "Fevereiro":
                    WriteLine("O mes de {0} tem 28 ou 29 dias", mes);
                    break;
                default:
                    WriteLine("o Mes de {0} tem 30 dias.");
                    break;
            }
            ReadKey();
        }
    }
 }