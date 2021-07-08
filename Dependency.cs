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
    //class DatabaseService { public void getDatos() { } }
    //class Dependency
    //{
    //    private DatabaseService databaseService;
    //    public Dependency(DatabaseService databaseService)
    //    {
    //        this.databaseService = databaseService;
    //    }
    //    void getDatos()
    //    {
    //        databaseService.getDatos();
    //    }
    //}


    //segregación
    interface Conexion
    {
        void getDatos();
        void setDatos();
    }

    class Dependency
    {

        private Conexion conexion;

        public Dependency(Conexion conexion)
        {
            this.conexion = conexion;
        }

        void getDatos()
        {
            conexion.getDatos();
        }
    }

}
