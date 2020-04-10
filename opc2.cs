using System;
using System.Collections.Generic;
using System.Text;

namespace COVID19
{
    class opc2
    {

     //   private static List<opc1.Registro> listaRegistro = new List<opc1.Registro>();
    
        public static void verEstadistica()
        {
        
            foreach (Registro r in opc1.listaRegistro)
            {

                Console.WriteLine("Provincia:" + r.Provincia);
                Console.WriteLine("Total de casos:" + r.CantCasos);
                Console.WriteLine("Total de fallecidos:" + r.CantFallecidos);
                Console.WriteLine("Total de recuperados:" + r.CantRecuperados);
                foreach(Registro a in opc1.listaRegistro)
                {
                    foreach(Registro b in opc1.listaRegistro)
                    {
                        if (a.Provincia == b.Provincia)
                        {
                            if(DateTime.Compare(a.date, b.date) != 0 && DateTime.Compare(a.date, b.date) < 0)
                                {
                                int fContagio = (b.CantCasos / a.CantCasos);
                                int estimacion = (fContagio * b.CantCasos);
                                int variacion = (b.CantCasos / a.CantCasos);
                                Console.WriteLine($"{b.date.ToShortDateString(),-20}|{b.Provincia,-20}|{b.CantCasos,-20}|{b.CantFallecidos,-20}|{b.CantFallecidos,-20}|" + $"{variacion,-20}{estimacion - 20}");
}
                        }
                    }
                }
                // Console.WriteLine(listaRegistro);
                Console.ReadKey();
            }
            


        }

    }
}
