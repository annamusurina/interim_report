//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client_organization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client_organization()
        {
            this.Orders = new HashSet<Orders>();
        }
    
        public int Code_client_org { get; set; }
        public string Title_client { get; set; }
        public string Representative { get; set; }
        public string Adress { get; set; }
        public string Telephone { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
        public override string ToString() => Title_client + " " + Representative;
    }
}
