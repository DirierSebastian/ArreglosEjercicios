using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
        internal class Ejercicios
        {
            public void ArrayUnidimensional()
            {
                int[] arreglo = new int[5];
                Console.WriteLine("Ingrese un numero");
                arreglo[0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero");
                arreglo[1] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero");
                arreglo[2] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero");
                arreglo[3] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero");
                arreglo[4] = Convert.ToInt32(Console.ReadLine());
            }
            public void ArrayBucle()
            {
                int[] arreglo = new int[5];
                for (int i = 0; i < arreglo.Length; i++)
                {
                    Console.WriteLine("Ingresa un numero");
                    arreglo[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < arreglo.Length; i++)
                {
                    Console.WriteLine(arreglo[i]);
                }
            }

            public void MediaArray()
            {
                int[] arreglo = new int[10];
                double suma = 0;
                for (int i = 0; i < arreglo.Length; i++)
                {
                    Console.WriteLine("Ingresa un numero");
                    arreglo[i] = Convert.ToInt32(Console.ReadLine());

                }
                foreach (var item in arreglo)
                {
                    suma += item;
                }
                Console.WriteLine("La media es " + suma / 10);
            }

            public void ArrayMultiplo()
            {
                Console.WriteLine("Ingrese el tamaño del array(numero de multiplos del valor)");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[size];

                Console.WriteLine("Ingrese un numero al cual sacar el multiplo");
                int multiplo = Convert.ToInt32(Console.ReadLine());
                int valor = multiplo;

                for (int i = 1; i <= array.Length; i++)
                {
                    array[i] = multiplo * i;
                    Console.WriteLine("El multiplo es " + array[i]);
                }
            }

            public void LongitudNombre()
            {
                Console.WriteLine("Ingrese el tamaño del array(cuantos nombres quieres ver)");
                int size = Convert.ToInt32(Console.ReadLine());
                string[] arrayNombre = new string[size];
                int[] arrayLength = new int[size];
                for (int i = 0; i < arrayNombre.Length; i++)
                {
                    Console.WriteLine("Ingrese un nombre");
                    arrayNombre[i] = Console.ReadLine();
                    arrayLength[i] = arrayNombre[i].Length;
                }
                for (int i = 0; i < arrayNombre.Length; i++)
                {
                    Console.WriteLine("Nombre: " + arrayNombre[i] + ", longitud: " + arrayLength[i]);
                }
            }



        }
}

