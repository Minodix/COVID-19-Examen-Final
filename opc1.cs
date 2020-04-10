using System;
using System.Collections.Generic;
using System.Text;

using System.Runtime.Serialization.Json;
using System.IO.IsolatedStorage;
using System.IO;

namespace COVID19
{
    [Serializable()]
    
    class opc1
    {
        public static List<Registro> listaRegistro = new List<Registro>();



        public static void registrarDia()
        {

            Registro newRegistro = new Registro();

            Console.WriteLine("Ingrese el nombre de la provincia:");
            newRegistro.Provincia = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de casos en total:");
            newRegistro.CantCasos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de fallecidos:");
            newRegistro.CantFallecidos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de recuperados:");
            newRegistro.CantRecuperados = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha en el siguiente formato 'yyyy/mm/dd': ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            newRegistro.date = date;

            listaRegistro.Add(newRegistro);
          

        }


        
    }
}
