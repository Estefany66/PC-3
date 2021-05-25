namespace Busco.Models
{
    public class Solicitud
    {
         public int Id { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; }

        public string Celular { get; set; }

        public string Lugar { get; set; }
        public string Comprador { get; set; }

        public string Categoria { get; set; }

        
    }
}