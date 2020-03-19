//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            this.Advertisements = new HashSet<Advertisement>();
        }
    
        public int CarId { get; set; }
        public Nullable<int> ModelId { get; set; }
        public Nullable<System.DateTime> Year { get; set; }
        public Nullable<int> FuelId { get; set; }
        public Nullable<int> GearId { get; set; }
        public Nullable<long> KM { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> HP { get; set; }
        public Nullable<int> EngineCapacity { get; set; }
        public Nullable<int> ColorId { get; set; }
        public Nullable<bool> State { get; set; }
        public string Details { get; set; }
        public Nullable<bool> ABS { get; set; }
        public Nullable<bool> ESP { get; set; }
        public Nullable<bool> HillSupport { get; set; }
        public Nullable<bool> Airbag { get; set; }
        public Nullable<bool> Sunroof { get; set; }
        public Nullable<bool> LeatherCouch { get; set; }
        public Nullable<bool> TripComputer { get; set; }
        public Nullable<bool> AC { get; set; }
        public Nullable<bool> ParkingSensor { get; set; }
        public Nullable<bool> XenonFar { get; set; }
        public Nullable<bool> Bluetooth { get; set; }
        public Nullable<bool> Navigation { get; set; }
        public Nullable<bool> USB_AUX { get; set; }
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public string Picture3 { get; set; }
        public string Picture4 { get; set; }
        public string Picture5 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Advertisement> Advertisements { get; set; }
        public virtual Color Color { get; set; }
        public virtual Fuel Fuel { get; set; }
        public virtual Gear Gear { get; set; }
        public virtual Model Model { get; set; }
    }
}
