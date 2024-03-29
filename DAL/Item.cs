//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestAPI.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            this.Requisitions = new HashSet<Requisition>();
            this.Requisitions1 = new HashSet<Requisition>();
            this.StockTables = new HashSet<StockTable>();
            this.StockTables1 = new HashSet<StockTable>();
        }
    
        public int Id { get; set; }
        public string ItemName { get; set; }
        public Nullable<int> CurrentStock { get; set; }
        public Nullable<int> SafetyStock { get; set; }
        public Nullable<int> ActualStock { get; set; }
        public Nullable<int> OrderQuantity { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> UnitId { get; set; }
        public Nullable<int> ReorderLevelId { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string UserCreated { get; set; }
        public string AuthorizationStatus { get; set; }
        public Nullable<System.DateTime> AuthorizationDate { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string Brand { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ReorderLevel ReorderLevel { get; set; }
        public virtual Unit Unit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requisition> Requisitions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requisition> Requisitions1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockTable> StockTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockTable> StockTables1 { get; set; }
    }
}
