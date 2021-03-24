using System;

namespace Empresa
{
    class Empresa
    {
         string[] nombres;
         float[] sueldo;

        public void Cargar()
        {
            nombres = new string[5];
            sueldo = new float[5];
            for (int f = 0; f < nombres.Length; f++)
            {
                Console.Write("Ingrese el nombre del empleado:");
                nombres[f] = Console.ReadLine();
                Console.Write("Ingrese el sueldo:");
                string linea;
                linea = Console.ReadLine();
                sueldo[f] = float.Parse(linea);
            }
        }

        public void MayorSueldo()
        {
            float mayor;
            int pos;
            mayor = sueldo[0];
            pos = 0;
            for (int f = 1; f < nombres.Length; f++)
            {
                if (sueldo[f] > mayor)
                {
                    mayor = sueldo[f];
                    pos = f;
                }
            }
            Console.WriteLine("El empleado con sueldo mayor es " + nombres[pos]);
            Console.WriteLine("Tiene un sueldo:" + mayor);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Empresa calulo = new Empresa();
            calulo.Cargar();
            calulo.MayorSueldo();
        }
    }
}