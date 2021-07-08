using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I
{
    /// <summary>
    /// I: Interface segregation principle o Principio de segregación de la interfaz
    /// </summary>

    //// No descomentar
    //interface ICalculadora
    //{
    //    public static int Suma(int a, int b)
    //    {
    //        int suma = a + b;
    //        return suma;
    //    }
    //    public static int Resta(int a, int b)
    //    {
    //        int resta = a - b;
    //        return resta;
    //    }
    //    public static int Mult(int a, int b)
    //    {
    //        int mult = a * b;
    //        return mult;
    //    }
    //    public static int Dividir(int a, int b)
    //    {
    //        int division = a / b;
    //        return division;
    //    }
    //}

    //class Interface : ICalculadora
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine(ICalculadora.Suma(2, 2));
    //        Console.WriteLine(ICalculadora.Resta(2, 2));
    //    }
    //}



    //Segregación
    interface ISuma
    {
        public static int Suma(int a, int b)
        {
            int suma = a + b;
            return suma;
        }
    }
    interface IResta
    {
        public static int Resta(int a, int b)
        {
            int resta = a - b;
            return resta;
        }
    }
    interface IMult
    {
        public static int Mult(int a, int b)
        {
            int mult = a * b;
            return mult;
        }
    }

    interface IDivision
    {
        public static int Division(int a, int b)
        {
            int division = a / b;
            return division;
        }
    }

    class Interface : ISuma, IResta
    {
        ////Descomentarea para usar
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(ISuma.Suma(2, 2));
        //    Console.WriteLine(IResta.Resta(2, 2));
        //}
    }

}
