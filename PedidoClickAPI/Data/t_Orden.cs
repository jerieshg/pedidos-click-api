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
    
    public partial class t_Orden
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_Orden()
        {
            this.t_OrdenDetalle = new HashSet<t_OrdenDetalle>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdOrdenEstado { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string Identidad { get; set; }
        public string Calle { get; set; }
        public string Avenida { get; set; }
        public string Colonia { get; set; }
        public string Ciudad { get; set; }
        public string Comentario { get; set; }
        public Nullable<System.DateTime> FechaCreo { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public Nullable<int> IdAsignado { get; set; }
        public Nullable<int> IdTienda { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
        public Nullable<int> IdZona { get; set; }
    
        public virtual t_OrdenEstado t_OrdenEstado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_OrdenDetalle> t_OrdenDetalle { get; set; }
        public virtual t_Cliente t_Cliente { get; set; }
        public virtual t_Usuario t_Usuario { get; set; }
        public virtual t_Tienda t_Tienda { get; set; }
    }
}
