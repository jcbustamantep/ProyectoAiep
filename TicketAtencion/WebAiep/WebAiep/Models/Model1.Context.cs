﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_A255CD_MoDeskBDDEntities : DbContext
    {
        public DB_A255CD_MoDeskBDDEntities()
            : base("name=DB_A255CD_MoDeskBDDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AGENTES> AGENTES { get; set; }
        public virtual DbSet<ALERTAS> ALERTAS { get; set; }
        public virtual DbSet<AREA> AREA { get; set; }
        public virtual DbSet<CALENDARIO> CALENDARIO { get; set; }
        public virtual DbSet<CAMBIO_MONEDA> CAMBIO_MONEDA { get; set; }
        public virtual DbSet<COMUNAS> COMUNAS { get; set; }
        public virtual DbSet<DATOS_EXTRAS> DATOS_EXTRAS { get; set; }
        public virtual DbSet<DISTRITOS> DISTRITOS { get; set; }
        public virtual DbSet<EMPRESA> EMPRESA { get; set; }
        public virtual DbSet<EMPRESA_CLI> EMPRESA_CLI { get; set; }
        public virtual DbSet<ESTADOS> ESTADOS { get; set; }
        public virtual DbSet<HIJOS> HIJOS { get; set; }
        public virtual DbSet<HISTORIA> HISTORIA { get; set; }
        public virtual DbSet<HITOS_NO_LABORALES> HITOS_NO_LABORALES { get; set; }
        public virtual DbSet<HORAS_TURNOS> HORAS_TURNOS { get; set; }
        public virtual DbSet<IMPACTO> IMPACTO { get; set; }
        public virtual DbSet<LOGIN> LOGIN { get; set; }
        public virtual DbSet<METADATA> METADATA { get; set; }
        public virtual DbSet<MODULO> MODULO { get; set; }
        public virtual DbSet<MONEDA> MONEDA { get; set; }
        public virtual DbSet<PAISES> PAISES { get; set; }
        public virtual DbSet<REGIONES> REGIONES { get; set; }
        public virtual DbSet<RESOLUTORES_TERCEROS> RESOLUTORES_TERCEROS { get; set; }
        public virtual DbSet<ROL> ROL { get; set; }
        public virtual DbSet<ROL_MODULO> ROL_MODULO { get; set; }
        public virtual DbSet<SERVICIO> SERVICIO { get; set; }
        public virtual DbSet<SERVICIO_EMPRESA> SERVICIO_EMPRESA { get; set; }
        public virtual DbSet<SLA> SLA { get; set; }
        public virtual DbSet<TELS_EMPRESA> TELS_EMPRESA { get; set; }
        public virtual DbSet<TELS_RESOL_TER> TELS_RESOL_TER { get; set; }
        public virtual DbSet<TIPIFICACION> TIPIFICACION { get; set; }
        public virtual DbSet<TIPOS_METADTA> TIPOS_METADTA { get; set; }
        public virtual DbSet<TKT> TKT { get; set; }
        public virtual DbSet<URGENCIA> URGENCIA { get; set; }
        public virtual DbSet<USUARIO_FINAL> USUARIO_FINAL { get; set; }
        public virtual DbSet<VALORES> VALORES { get; set; }
    }
}
