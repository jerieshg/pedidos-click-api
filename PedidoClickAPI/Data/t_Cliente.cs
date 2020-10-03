//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PedidoClickAPI.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_Cliente()
        {
            this.t_Categoria = new HashSet<t_Categoria>();
            this.t_Usuario = new HashSet<t_Usuario>();
            this.t_Orden = new HashSet<t_Orden>();
            this.t_CategoriaTienda = new HashSet<t_CategoriaTienda>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Logo { get; set; }
        public Nullable<System.DateTime> ValidoHasta { get; set; }
        public Nullable<bool> Valido { get; set; }
        public Nullable<bool> Borrado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_Categoria> t_Categoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_Usuario> t_Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_Orden> t_Orden { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_CategoriaTienda> t_CategoriaTienda { get; set; }
    }
}
