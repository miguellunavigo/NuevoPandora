namespace BanBif.Nuevo.Pandora.BE.AppsBE.AgendaComercialPJ
{
    public class acListaClienteResponse<T>
    {
        public string Mensaje { get; set; }
        public bool Result { get; set; }
        public T data { get; set; }
    }
}
