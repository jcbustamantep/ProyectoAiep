//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAiep.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class COMUNAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMUNAS()
        {
            this.AGENTES = new HashSet<AGENTES>();
            this.EMPRESA_CLI = new HashSet<EMPRESA_CLI>();
            this.RESOLUTORES_TERCEROS = new HashSet<RESOLUTORES_TERCEROS>();
        }
    
        public decimal ID_COMUNA { get; set; }
        public Nullable<decimal> ID_DISTRIRO { get; set; }
        public string NOM_COMUNA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGENTES> AGENTES { get; set; }
        public virtual DISTRITOS DISTRITOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESA_CLI> EMPRESA_CLI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESOLUTORES_TERCEROS> RESOLUTORES_TERCEROS { get; set; }
    }
}