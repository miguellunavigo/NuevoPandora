//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BanBif.Nuevo.Pandora.DA.ModelApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class agendapjEntities : DbContext
    {
        public agendapjEntities()
            : base("name=agendapjEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBL_mAGENDACOMERCIAL_CLIENTE> TBL_mAGENDACOMERCIAL_CLIENTE { get; set; }
        public virtual DbSet<TBL_mAGENDACOMERCIAL_CLIENTE_CONTACTO> TBL_mAGENDACOMERCIAL_CLIENTE_CONTACTO { get; set; }
        public virtual DbSet<TBL_mAGENDACOMERCIAL_CLIENTE_CONTACTO_COMENTARIOS> TBL_mAGENDACOMERCIAL_CLIENTE_CONTACTO_COMENTARIOS { get; set; }
    }
}
