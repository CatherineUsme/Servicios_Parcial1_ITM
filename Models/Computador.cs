//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComputadoresITM.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class Computador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Computador()
        {
            this.Ventas = new HashSet<Venta>();
        }
    
        public int IDComputador { get; set; }
        public int NumeroProcesadores { get; set; }
        public string MarcaProcesador { get; set; }
        public string TamanoDiscoDuro { get; set; }
        public string TamanoMemoria { get; set; }
        public string Componentes { get; set; }
        public int IDTipoComputador { get; set; }
    
        
        [JsonIgnore]
        public virtual TipoComputador TipoComputador { get; set; }
        
        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta> Ventas { get; set; }
    }
}
