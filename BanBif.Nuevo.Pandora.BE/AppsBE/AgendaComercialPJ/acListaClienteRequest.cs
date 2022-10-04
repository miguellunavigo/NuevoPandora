

namespace BanBif.Nuevo.Pandora.BE.AppsBE.AgendaComercialPJ
{
    public class acListaClienteRequest
    {
        public int CodigoCliente { get; set; }
        public string ZONA { get; set; }
        public string SEGMENTO { get; set; }
        public string GIRONEGOCIO { get; set; }
    }
    public class acListaClienteContactoRequest
    {
        public int CodigoContacto { get; set; }
        public int CodigoCliente { get; set; }
        public string NombreApellido { get; set; }
        public string Cargo { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

    }
    public class acListaClienteContactoComentarioRequest
    {
        public int CodigoContacto { get; set; }
    }
    public class NewPandoraResponse<T>
    {
        public bool Result { get; set; }
        public string Mensaje { get; set; }
        public T data { get; set; }
    }
}
