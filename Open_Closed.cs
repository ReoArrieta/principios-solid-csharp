using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I
{
    /// <summary>
    /// O: Open/closed principle o Principio de abierto/cerrado
    /// </summary>
    /// 
    //// No descomentar
    //class Open_Closed
    //{
    //    string marca;
    //    Open_Closed(String marca) { this.marca = marca; }
    //    string GetMarcaCelular() { return marca; }

    //    static void Main(string[] args)
    //    {
    //        string[] Celular = {
    //            new string("Lenovo"),
    //            new string("Xiaomi")
    //        };
    //        imprimirPrecioMedioCelular(Celular);

    //    }

    //    public static void imprimirPrecioMedioCelular(string[] celularArray)
    //    {
    //        for (int i = 0; i < celularArray.Length; i++)
    //        {
    //            if (celularArray[i].Equals("Lenovo")) Console.WriteLine(18000);
    //            if (celularArray[i].Equals("Xiaomi")) Console.WriteLine(25000);
    //        }
    //    }
    //}



    //abierto/cerrado
    public abstract class Celular
    {
        public abstract int PrecioMedioCelular();
    }

    class Lenovo : Celular
    {
        public override int PrecioMedioCelular() { return 18000; }
    }

    class Xiaomi : Celular
    {
        public override int PrecioMedioCelular() { return 25000; }
    }

    class Samsung : Celular
    {
        public override int PrecioMedioCelular() { return 27000; }
    }

    class Open_Closed
    {
        ////Descomentarea para usar
        //static void Main(string[] args)
        //{
        //    Celular[] Celular = {
        //        new Lenovo(),
        //        new Xiaomi(),
        //        new Samsung()
        //    };
        //    imprimirPrecioMedioCelular(Celular);

        //}

        public static void imprimirPrecioMedioCelular(Celular[] CelularArray)
        {
            for (int i = 0; i < CelularArray.Length; i++)
            {
                Console.WriteLine(CelularArray[i].PrecioMedioCelular());
            }
        }
    }
}
