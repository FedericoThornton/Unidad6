using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para ingresar 10 números.
            // El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

          //  int n, condivisores = 0, conprimo = 0;

           // for (int x = 0; x < 3; x++)
          //  {
            //    Console.WriteLine ("Ingrese un nro:");
             //   n = int.Parse (Console.ReadLine());

          //  condivisores = 0;

              //  for (int y = 1; y <= n; y++)
              //  {
              //      if (n % y == 0)
                    
              //          condivisores++;
              //  }
              //  if (condivisores == 2)
              //  {    
              //       conprimo++;

               // }     
              //  }
            
                      
                

               // Console.WriteLine ("La cantidad de nros primos es: " + conprimo);   




                //2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

                //El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
                //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

         //   int n, connum, conimpares, grupoimparesmax = 0, min, conordenados = 0;
         //   float porcentajeimpares, porcentajemaximo = -1;
         //   bool banderaordenados;
            
        //    for (int x = 0; x < 5; x++)
         //   {
         //       banderaordenados = true;
         //       connum = 0;
         //       conimpares = 0;
         //   Console.WriteLine ("ingrese un nro: ");
        //    n = int.Parse (Console.ReadLine());

               
          //       min = n;
         //       while (n != 0)
          //      {
          //          connum++;
                    
         //           if (n % 2 != 0)
          //          {
          //             conimpares++;
                       
             //       }
                
             //       if (n <= min)
             //       {
              //           min = n;
              //      }
               //         else
               //         {
              //              banderaordenados = false;
              //          }
                        
               
             //   Console.WriteLine ("ingrese un nro: ");
             //   n = int.Parse (Console.ReadLine());
            //    } 
                //fuera del while para contar despues todos los nros 
             //   porcentajeimpares = (conimpares * 100) / connum;  
             //   if (porcentajeimpares > porcentajemaximo)
            //    {
            //        porcentajeimpares = porcentajemaximo;
            //        grupoimparesmax = x + 1;
            //    }   

             //   if (banderaordenados)
            //    {
            //        conordenados++;
         //       }     
         //   }
          //  Console.WriteLine ("el nro de grupo con mayor porcentaje de impares es: " + grupoimparesmax);
         //   Console.WriteLine ("la cantidad de grupos ordenados de mayor a menor son: " + conordenados);


           // 3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
           // El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

            // se puede hacer con do while para que entre la primera vez y no modificar el valor de n
            int n = 1, conlista = 0, connumero; 

              while (n >= 0)
              {
              conlista++;
              
              Console.WriteLine ("Ingrese un nro:");
              n = int.Parse (Console.ReadLine());
                 connumero = 0;
                  
                while (n > 0)
            
              {
                connumero++;
                
                Console.WriteLine ("Ingrese un nro: ");         
                n = int.Parse (Console.ReadLine());
              
               
              }
                Console.WriteLine ("La lista " + conlista + " tiene " + connumero + " numeros");
              }
          
            
             
              


            
           
          
                    
                     
            

        }
    }
}
