//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Appointment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Appointment()
        {
            this.AppointmentDetails = new HashSet<AppointmentDetails>();
        }
    
        public int Id { get; set; }
        public System.DateTime AppointmentDate { get; set; }
        public int HistoryOfIllnessId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppointmentDetails> AppointmentDetails { get; set; }
        public virtual HistoryOfIllness HistoryOfIllness { get; set; }
    }
}