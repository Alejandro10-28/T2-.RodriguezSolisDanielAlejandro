using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Debug1
{
   public class Program
    {
        static void Main(string[] args)
        {
            //Se crea la lista para los estudiantes
            var estudiante = new List<Estudiante>();
            //Se usa agregar de tipo bool para que la iteracion se repita mientras sea cierta
            var agregar = true;
            


             while (agregar)
            {
                //Se utiliza el try para capturar los errores al no ingresar algun dato o que este no fuera el que se
                //esperaba
                try
                {

                    //Se intancia la clase estudiantes
                    var E = new Estudiante();
                    //Se crea S de tipo int para que si el usuario ingresa un valor que no sea
                    //Numerico este regrese un 0.
                    int S = E.NoControl;
                    //Se usa result de tipo bool para posteriormente hacer una condicion
                    bool result;
                    //Se pide que el usario ingrese sus datos.
                    Console.WriteLine("Ingresa tu nombre:");
                    E.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingresa tu semestre:");
                    E.Semestre = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa tu Carrera::");
                    E.Carrera = Console.ReadLine();
                    Console.WriteLine("Ingresa tu telefono:");
                    E.Telefono = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa tu No.Control:");
                    //Utilizamos el int.Tryparse para que si el usuario escribe una letra
                    //En lugar de un número este se convierta en un entero y regrese un 0
                    //El out como ya lo habiamos visto el  para que regrese mas de un solo valor
                    
                    result = int.TryParse(Console.ReadLine(), out S);
                    //Se hace la condicion donde si result guarda un numero sera verdadero si no
                    //Ejecutara el siguiente proceso
                    if (result == false)
                    {
                        //Vuelve a pedir que ingrese exclusicamente un número
                        Console.WriteLine("Ingrese exclusivamente números\nIngrese No.control:");
                        result = int.TryParse(Console.ReadLine(), out S);
                        
                    }
                    //Se agrega a la lista que habiamos instanciado
                    estudiante.Add(E);
                    
                    Console.WriteLine("¿Desea agregar otro usuario?\n1-.Si\n2-.No");
                    //Se hace la siguiente condicion para que si el usuario responde que si este
                    //se siga ejecutando y si es distinto a si se saldra del programa
                    if (Console.ReadLine()!= "si")
                    {
                        agregar = false;
                    }
                }
                //El catch capturara errores cuando no se ingrese un valor o no sea el esperado 
                catch (Exception)//Se usa exception para que sean los errores que pasan durante el 
                //tiempo de ejecución.
                {
                    Console.WriteLine("Error agregando el usuario \nIntente de nuevo");
                    Console.ReadKey();
                }
             }
                 //En pocas palabras el programa funciona bajo la posibilidad de que el usuario pueda ingresar
                 //Datos que no esperamos , por accidente ; lo que hace el try-catch es mas que nada que nos antipemos
                 //a los errores para que le pueda salir el aviso al usuario de en que se equivoco, que ingreso mal
                 //mas que nada.Eso a grandes rasgos es lo que hicimos en este programa el cual fué que el 
                 //usuario ingresara su numero de control y si este ponia una letra en lugar de un número
                 //por medio de una condicion que efectuamos con result este le avisaria al usuario, que debia ser un numero
                 //y el try catch para capturar otros errores durante la ejecucion como saltarse el llenar un dato o escribir
                 //un valor no esperado.
        }
    }
}
