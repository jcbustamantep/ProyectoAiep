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
    
    public partial class HORAS_TURNOS
    {
        public Nullable<int> HRS_TRABAJO_SEM { get; set; }
        public decimal ID_TURNO { get; set; }
        public Nullable<decimal> RUT_EMPRESA_PROV { get; set; }
        public Nullable<System.DateTime> HORA_INICIO_LABORAL { get; set; }
        public Nullable<System.DateTime> HORA_TERMINO_LABORAL { get; set; }
        public Nullable<int> HORAS_TRABAJADAS { get; set; }
    
        public virtual EMPRESA EMPRESA { get; set; }
    }
}
