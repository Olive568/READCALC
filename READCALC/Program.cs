using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.CodeDom.Compiler;
using System.Data.Common;

namespace DictionaryDemonstration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Start = new string[] { };
            string line = "";
            List<string> setting = new List<string>();
            int number = 0;
        
            using(StreamReader sr = new StreamReader("Setup.ini"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Start = line.Split("=");
                    for (int i = 0; i < 2; i++)
                    {
                        setting.Add(Start[i]);
                    }
                }
            }
            int basenum = int.Parse(setting[1]);
            string op = setting[3];           
            using(StreamWriter sr = new StreamWriter("Write.txt"))
            {
                sr.WriteLine("the base number is " + basenum);
                sr.WriteLine("The function is " + op);
                for (int x = 5; x < setting.Count; x += 2)
                {
                    if (op == "+")
                    {
                        sr.Write(number + " + " + setting[x] + " = ");
                        number += int.Parse(setting[x]);
                        sr.Write(number);
                    }
                    else if (op == "-")
                    {
                        sr.WriteLine(number -= int.Parse(setting[x]));
                        number += int.Parse(setting[x]);
                        sr.Write(number);
                    }
                    else if (op == "*")
                    {
                        sr.WriteLine(number *= int.Parse(setting[x]));
                        number += int.Parse(setting[x]);
                        sr.Write(number);
                    }
                    else if (op == "/")
                    {
                        sr.WriteLine(number /= int.Parse(setting[x]));
                        number += int.Parse(setting[x]);
                        sr.Write(number);
                    }
                    sr.WriteLine();
                }
            }
            Console.WriteLine("Calculations are complete");
            Console.ReadKey();
        }
    }
}







            