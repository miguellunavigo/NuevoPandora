namespace BanBif.Nuevo.Pandora.BE.AppsBE.AgendaComercialPJ
{
    public class acClienteBE
    {
        public int CodigoCliente { get; set; }
        public string RUC { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Zona { get; set; }
        public string GiroNegocio { get; set; }
        public string GrupoEconomico { get; set; }
        public string Segmento { get; set; }
        public string Score { get; set; }
        public string CrossCliente { get; set; }
        public string Facturacion { get; set; }
        public string ROE { get; set; }
        public string SOW { get; set; }
        public string Rentabilidad { get; set; }
        public string VolumenNegocio { get; set; }
        public string VolumenPasivos { get; set; }
        public string VolumenActivos { get; set; }
        public string VolumenContingentes { get; set; }
        public string CalificacionBanBif { get; set; }
        public string CalificacionSSFF { get; set; }
        public string SistemaVigilancia { get; set; }
        public string LineaDisponible { get; set; }
        public string DeudaRCC { get; set; }

    }
    public class acClienteContactoBE
    {
        public int CodigoContacto { get; set; }
        public int CodigoCliente { get; set; }
        public string NombreApellido { get; set; }
        public string Cargo { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

    }
    public class acClienteContactoComentarioBE
    {
        public int CodigoComentario { get; set; }
        public int CodigoContacto { get; set; }
        public string Comentario { get; set; }

    }
}
