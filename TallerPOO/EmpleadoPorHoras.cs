using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO
{
    internal class EmpleadoPorHoras : Empleado
    {
        #region ======== VARIABLES =========

        private double valor_hora;
        private uint horas_trabajadas;

        #endregion

        // ================================================================

        #region CONSTRUCTOR

        public EmpleadoPorHoras(string nombre, double valorHora, uint horas)
            : base(nombre)
        {
            Valor_Hora = valorHora;
            Horas_Trabajadas = horas;
        }

        #endregion

        // ================================================================

        #region ACCESORES

        public double Valor_Hora
        {
            get => valor_hora;
            set => valor_hora = value > 0
                ? value
                : throw new Exception("El valor por hora debe ser mayor que cero, o me denuncian.");
        }

        public uint Horas_Trabajadas
        {
            get => horas_trabajadas;
            set => horas_trabajadas = value; //uint igual es pos
        }

        #endregion

        // ================================================================

        #region METODOS

        public override double CalcularSalario()
        {
            return Valor_Hora * Horas_Trabajadas;
        }

        public double CalcularSalario(uint bonus) //por si trabajó MUY bien
        {
            return (Valor_Hora * Horas_Trabajadas) + bonus;
        }

        public void ModificarHoras(uint horas)
        {
            Horas_Trabajadas = horas;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("===== EMPLEADO POR HORAS =====");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Horas trabajadas: {Horas_Trabajadas}");
            Console.WriteLine($"Salario: {CalcularSalario()}");
        }

        #endregion
    }
}
