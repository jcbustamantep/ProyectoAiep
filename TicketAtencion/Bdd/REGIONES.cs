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
    
    public partial class REGIONES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REGIONES()
        {
            this.DISTRITOS = new HashSet<DISTRITOS>();
        }
    
        public decimal ID_REGION { get; set; }
        public Nullable<decimal> ID_PAIS { get; set; }
        public string NOMBRE_REGION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DISTRITOS> DISTRITOS { get; set; }
        public virtual PAISES PAISES { get; set; }
    }
}