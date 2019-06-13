namespace EverData.Models.Models
{
    public class Employee
    {   
        //LOS ATRIBUTOS TIENEN LA VISIBILIDAD DE LA CLASE CONTENIDA A NO SER QUE SEAN DECLARADOS EXPLICITAMENTE
        public int EmployeeId { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        public int CategoriaId { get; set; }
        public int ProyectoId { get; set; }
        public int LineaId { get; set; }
        public int CeldaId { get; set; }
        public int CentroId { get; set; }
        public int TecnologiaId { get; set; }
        public int TitulacionId { get; set; }
        public string Supervisor { get; set; }
        public string Tutor { get; set; }
    }
}
