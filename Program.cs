//Import de Librerias
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;// Import arreglos, listas
using System.Linq;// Import libreria para conexion a una DB
using System.Runtime.InteropServices;
using System.Text;// Import libreria de texto
using System.Threading.Tasks;

namespace Semana2 //namespace para guardar espacios de memoria para un codigo especifico
{
    internal class Program
    {
        //No puede ir dentro de un metodo
        struct Empleado
        {
            public int codigo;
            public string nombre;
            public float salario;

        }//fin del struct
        static void Main(string[] args)
        {

            //Tipo de datos Primitivos
            int num1, num2;// Numero entero
            short sh = 1;
            float flotante = 3.14f;//32 Bits
            double b= 15.2;// 64 Bits
            decimal deci = 15.15m;// 128 Bits
            byte by = 25;
            long large = 5000;
            ulong ularge = 564651515615;
            Boolean x = true;
            char letra = 'a';
            string texto = "A";

            // var // dynamic
            var variable = 20; // variable fija para usarse con cualquier tipo de dato

            dynamic dinamica = 25.3f;
            dinamica = "Nombres";
            dinamica = true;
            dinamica = 'c';
            Empleado emp;
            emp.codigo = 1;
            emp.salario = 1000;
            emp.nombre = "Luis";

            //tipos de datos compuestos
            //arreglos
            int n = 4;

            string[] musico = new string[n];
            musico[0] = "Carlos";
            musico[1] = "Maria";
            musico[2] = "Sofia";
            musico[3] = "Eva";

            float[] salario = new float[4];
            for (int i = 0; i < salario.Length; i++)
            {
                Console.WriteLine("Digite el Salario");
                salario[1] = float.Parse(Console.ReadLine());

            }

            Console.WriteLine("Listado de musicos");
            Console.WriteLine(musico[0]);
            Console.WriteLine(musico[1]);
            Console.WriteLine(musico[2]);
            Console.WriteLine(musico[3]);
        }//fin del main






    }// FIN INTERNAL CLASS
}// FIN NAMESPACE