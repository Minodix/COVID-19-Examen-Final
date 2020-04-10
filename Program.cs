using System;

namespace COVID19
{
    class Program
    {
        static void Main(string[] args)
        
        {
            while (true)
            {
                
                Console.Clear();
                Console.WriteLine("*****Sistem de seguimiento del COVID-19****");
                Console.WriteLine("[1-]Registrar dia\n[2-]Ver estadistica");
                int opc = Convert.ToInt32(Console.ReadLine());
                if (opc < 1 && opc > 2)
                {
                    Console.WriteLine("Ingrese una opcion valida");
                }
                while (opc < 1 && opc > 2) ;

                switch (opc)
                {
                    case 1:
                        opc1.registrarDia();
                        
                        break;

                    case 2:
                        opc2.verEstadistica();
                        Console.ReadLine();
                        break;
                }
            }

        }
    }
}
