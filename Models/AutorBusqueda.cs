namespace ProyectoMVC3.Models
{
    public class AutorBusqueda
    {
        public string id_autor { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string Genero { get; set; }
        public string telefono { get; set; }

        public List<Autor> AutorLista { get; set; }
    }
}
