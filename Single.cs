using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I
{
    /// <summary>
    /// S: Single responsibility principle o Principio de responsabilidad única
    /// </summary>

    //// No descomentar
    //class Single
    //{
    //    readonly string RAM = "8 GB";
    //    Single(string RAM) => this.RAM = RAM;
    //    string GetRAMPC() { return RAM; }
    //    void GuardarPCDB(Single single) { Console.WriteLine(single.RAM); }
    //}



    //Responsabilidad Única
    class Single
    {
        readonly string RAM = "8 GB";
        Single(string RAM) => this.RAM = RAM;
        string GetRAMPC() { return RAM; }

        class PCDB
        {
            void GuardarPCDB(Single single) { Console.WriteLine(single.RAM); }
            void EliminarPCDB(Single single) { Console.WriteLine("Eliminar" + single.RAM); }
        }
    }

}
