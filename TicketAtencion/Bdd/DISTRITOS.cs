//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bdd
{
    using System;
    using System.Collections.Generic;
    
    public partial class DISTRITOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DISTRITOS()
        {
            this.COMUNAS = new HashSet<COMUNAS>();
            this.METADATA = new HashSet<METADATA>();
        }
    
        public decimal ID_DISTRIRO { get; set; }
        public Nullable<decimal> ID_REGION { get; set; }
        public string NOM_DISTRITO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMUNAS> COMUNAS { get; set; }
        public virtual REGIONES REGIONES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<METADATA> METADATA { get; set; }
    }
}