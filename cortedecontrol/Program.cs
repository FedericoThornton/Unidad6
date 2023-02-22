using System;

namespace cortedecontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            // CORTE DE CONTROL: lotes de datos  agrupados

            int edad, codigoEquipo, legajo; 
            float sueldo;
            int codigoEquipoact;

            Console.WriteLine ("Ingrese edad del jugador");
            edad = int.Parse (Console.ReadLine());
            Console.WriteLine ("Ingrese legajo del jugador");
            legajo = int.Parse (Console.ReadLine());
            Console.WriteLine ("Ingrese sueldo del jugador");
            sueldo = float.Parse (Console.ReadLine());
            Console.WriteLine ("Ingrese codigo del equipo");
            codigoEquipo = int.Parse (Console.ReadLine());

            while (sueldo > 0)

            {
            codigoEquipoact = codigoEquipo;

                while (codigoEquipo == codigoEquipoact)
                {


                        // aca procesamos




                Console.WriteLine ("Ingrese edad del jugador");
                edad = int.Parse (Console.ReadLine());
                Console.WriteLine ("Ingrese legajo del jugador");
                legajo = int.Parse (Console.ReadLine());
                Console.WriteLine ("Ingrese sueldo del jugador");
                sueldo = float.Parse (Console.ReadLine());
                Console.WriteLine ("Ingrese codigo del equipo");
                codigoEquipo = int.Parse (Console.ReadLine());


                        // aca muestra resultados de cada registro
                }


                    // aca tambien muestra resultados de cada sublote

            }

            // aca tambien se pueden mostrar resultados de cada lote
        }
    }
}
