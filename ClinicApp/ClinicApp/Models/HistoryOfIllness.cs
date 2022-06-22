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
    
    public partial class HistoryOfIllness
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HistoryOfIllness()
        {
            this.Appointment = new HashSet<Appointment>();
        }
    
        public int Id { get; set; }
        public string Diagnose { get; set; }
        public System.DateTime Start { get; set; }
        public Nullable<System.DateTime> End { get; set; }
        public short Rate { get; set; }
        public string Characteristic { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public bool OnSpecialCount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointment { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
