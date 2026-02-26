using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO
{
    internal class EmpleadoTiempoCompleto : Empleado, IEvaluado
    {
        #region ======== VARIABLES =========

        private double salario_fijo;
        private byte ausencias_semestre_contador;

        #endregion

        // ================================================================

        #region CONSTRUCTOR

        public EmpleadoTiempoCompleto(string nombre, double salario)
            : base(nombre)
        {

            Salario_Fijo = salario;

            ausencias_semestre_contador = 0; //recién contratado, no tiene faltas
            Ausencias_ = ausencias_semestre_contador;
        }

        #endregion

        // ================================================================

        #region ACCESORES

        public double Salario_Fijo
        {
            get => salario_fijo;
            set => salario_fijo = value > 0
                ? value
                : throw new Exception("El salario debe ser mayor que cero, porque si no me denuncian");
        }

        public byte Ausencias_
        {
            get => ausencias_semestre_contador;
            private set => ausencias_semestre_contador = value; //es byte, entonces igual no puede ser neg. Tampoco lo pueden modificar aumentar sin usar el método
        }

        #endregion

        // ================================================================

        #region METODOS

        public override double CalcularSalario()
        {
            return salario_fijo;
        }

        public void AplicarEvaluacion(double porcentajeAumento)
        {
            if (Ausencias_ <= 3 && porcentajeAumento>0)
            {
                Salario_Fijo += Salario_Fijo * porcentajeAumento;
                Console.WriteLine($"Aumento realizado exitosamente a {Nombre}. Nuevo salario:{salario_fijo}");
            }
            else
            {
                Console.WriteLine($"{Nombre} no califica para aumento.");
            }
        }

        public void AumentarAusencias()
        {
            Ausencias_++;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("===== EMPLEADO TIEMPO COMPLETO =====");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Salario: {CalcularSalario()}");
            Console.WriteLine($"# de ausencias semestrales: {Ausencias_}");
        }

        #endregion
    }
}
