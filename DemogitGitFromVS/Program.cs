﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemogitGitFromVS
{
    class Program
    {
        static void Main(string[] args)
        {
            var saludo = new Saludo();
            Console.WriteLine(saludo.Mensaje);
            Console.Read();
        }
    }
}
