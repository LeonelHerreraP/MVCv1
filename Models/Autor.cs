using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoMVC3.Models
{
    public class Autor
    {
        [Key]
        [Column(TypeName = "nvarchar(15)")]
        public string? id_autor { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        [DisplayName("Apellido")]
        public string? apellido { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        [DisplayName("Nombre")]
        public string? nombre { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        [DisplayName("Teléfono")]
        public string? telefono { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Dirección")]
        public string? direccion { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [DisplayName("Ciudad")]
        public string? ciudad { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        [DisplayName("Estado")]
        public string? estado { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("País")]
        public string? pais { get; set; }
        [DisplayName("Código Postal")]
        public int cod_postal { get; set; }
        [Column(TypeName = "nvarchar(1)")]
        public string? Genero { get; set; }
    }
}
