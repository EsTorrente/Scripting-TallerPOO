using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO
{
    abstract class Empleado
    {
        #region ======== VARIABLES =========

        private static uint id_contador = 10000;
        private readonly uint id; //readonly pq solo lo voy a asignar del constructor, no se ingresa ni modifica manual
        private string nombre;

        #endregion

        // ================================================================

        #region CONSTRUCTOR

        public Empleado(string nombre)
        {
            id = id_contador;
            id_contador++; //pq la gente es dañina, entonces mejor que el id no lo manejen ellos sino que sea automático. No quedan repetidos :>

            Nombre = nombre;
        }

        #endregion

        // ================================================================

        #region ACCESORES

        public uint Id
        {
            get => id;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = !String.IsNullOrWhiteSpace(value)
                ? value
                : throw new Exception("El nombre no es válido >:(");
        }

        #endregion

        // ================================================================

        #region METODOS

        public abstract double CalcularSalario();
        public abstract void MostrarInformacion();

        #endregion
    }
}
