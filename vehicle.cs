//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VehiclesProj
{
    using System;
    using System.Collections.Generic;
    
    public partial class vehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vehicle()
        {
            this.vehicleFeatures = new HashSet<vehicleFeature>();
        }
    
        public int vehicleId { get; set; }
        public Nullable<int> modelId { get; set; }
        public Nullable<int> vendorId { get; set; }
        public string color { get; set; }
        public byte[] picture { get; set; }
        public string vin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vehicleFeature> vehicleFeatures { get; set; }
        public virtual vehicleModel vehicleModel { get; set; }
        public virtual vendor vendor { get; set; }
    }
}
