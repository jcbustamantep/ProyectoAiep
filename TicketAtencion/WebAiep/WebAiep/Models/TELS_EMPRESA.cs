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
    
    public partial class TELS_EMPRESA
    {
        public string TEL_EMPRESA { get; set; }
        public decimal ID_TEL_EMRPESA { get; set; }
        public Nullable<decimal> RUT_EMPRESA_PROV { get; set; }
    
        public virtual EMPRESA EMPRESA { get; set; }
    }
}
