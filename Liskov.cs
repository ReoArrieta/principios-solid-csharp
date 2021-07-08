using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I
{
    /// <summary>
    /// L: Liskov substitution principle o Principio de sustitución de Liskov
    /// </summary>

    //// No descomentar
    //class Liskov
    //{
    //    string marca;
    //    Liskov(String marca) { this.marca = marca; }
    //    string GetMarcaCoche() { return marca; }

    //    static void Main(string[] args)
    //    {
    //        string[] Coche = {
    //                new string("Renault"),
    //                new string("Audi")
    //            };
    //        imprimirPrecioMedioCoche(Coche);

    //    }

    //    public static void imprimirPrecioMedioCoche(string[] cocheArray)
    //    {
    //        for (int i = 0; i < cocheArray.Length; i++)
    //        {
    //            if (cocheArray[i].Equals("Renault")) Console.WriteLine(18000);
    //            if (cocheArray[i].Equals("Audi")) Console.WriteLine(25000);
    //        }
    //    }
    //}


    //Substitución 
    public abstract class Coche
    {
        public abstract int PrecioMedioCoche();
    }

    class Renault : Coche
    {
        public override int PrecioMedioCoche() { return 18000; }
    }

    class Audi : Coche
    {
        public override int PrecioMedioCoche() { return 25000; }
    }

    class Mercedes : Coche
    {
        public override int PrecioMedioCoche() { return 27000; }
    }

    class Liskov
    {
        ////Descomentar para usar
        //static void Main(string[] args)
        //{
        //    Coche[] Coche = {
        //        new Renault(),
        //        new Audi(),
        //        new Mercedes()
        //    };
        //    imprimirPrecioMedioCoche(Coche);

        //}

        public static void imprimirPrecioMedioCoche(Coche[] cocheArray)
        {
            for (int i = 0; i < cocheArray.Length; i++)
            {
                Console.WriteLine(cocheArray[i].PrecioMedioCoche());
            }
        }
    }
}
