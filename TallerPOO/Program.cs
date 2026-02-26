namespace TallerPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region CREACIÓN DE EMPLEADOS

                Empleado e1 = new EmpleadoTiempoCompleto("Ana", 2500000);
                Empleado e2 = new EmpleadoPorHoras("Carlos", 20000, 120);
                Empleado e3 = new EmpleadoTiempoCompleto("Laura", 3000000);
                Empleado e4 = new EmpleadoPorHoras("Miguel", 18000, 90);

                // Le agregamos 4 ausencias a Laura (no debería recibir aumento)
                if (e3 is EmpleadoTiempoCompleto etc)
                {
                    etc.AumentarAusencias();
                    etc.AumentarAusencias();
                    etc.AumentarAusencias();
                    etc.AumentarAusencias();
                }

                #endregion

                // ===============================================================

                #region COLLECCIÓN

                List<Empleado> empleados = new List<Empleado>();

                empleados.Add(e1);
                empleados.Add(e2);
                empleados.Add(e3);
                empleados.Add(e4);

                #endregion

                // ===============================================================

                #region RECORRER

                Console.WriteLine("======= LISTADO DE EMPLEADOS =======\n");

                //foreach (Empleado emp in empleados)
                //{
                //emp.MostrarInformacion();
                //Console.WriteLine("------------------------------------");
                //}

                //PORQUE QUEDÉ TRAUMADA!!!!!!!!!!!!!!!!!!!!
                for (int i = 0; i < empleados.Count; i++)
                {
                    empleados[i].MostrarInformacion();
                    Console.WriteLine("------------------------------------");
                }

                #endregion

                // ======================================

                #region COSITO DE INTERFAZ

                Console.WriteLine("\n======= EVALUACIONES =======\n");

                for (int i = 0; i < empleados.Count; i++)
                {
                    if (empleados[i] is IEvaluado evaluado)
                    {
                        evaluado.AplicarEvaluacion(0.10); //10% aumento
                    }
                }

                #endregion

                // ===================================

                #region ESCRIBIR

                Console.WriteLine("\n======= SALARIOS ACTUALIZADOS =======\n");

                for (int i = 0; i < empleados.Count; i++)
                {
                    Console.WriteLine($"Empleado {empleados[i].Nombre} gana: {empleados[i].CalcularSalario()}");
                }

                #endregion

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
