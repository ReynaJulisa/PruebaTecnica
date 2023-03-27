namespace WebApplication1.Models
{

    using System;
    using System.Collections.Generic;


    public partial class Empleados
    {
        public int ID { get; set; }
        public string Nombre_Empleado { get; set; }
        public int Cantidad_Hijos { get; set; }
        public int Salario { get; set; }
        public int Bono { get; set; }
    }
}
