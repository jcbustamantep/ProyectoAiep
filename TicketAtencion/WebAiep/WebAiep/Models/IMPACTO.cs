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
    
    public partial class IMPACTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IMPACTO()
        {
            this.TKT = new HashSet<TKT>();
        }
    
        public decimal ID_IMPACTO { get; set; }
        public string NOMBRE_IMPACTO { get; set; }
        public string DESCRIPCION_IMPACTO { get; set; }
        public byte VALOR_IMPACTO { get; set; }
        public string RUT_EMPRESA_PROV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TKT> TKT { get; set; }
    }
}