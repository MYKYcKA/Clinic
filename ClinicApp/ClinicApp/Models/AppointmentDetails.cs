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
    
    public partial class AppointmentDetails
    {
        public int Id { get; set; }
        public int MedicineId { get; set; }
        public int AppointmentId { get; set; }
    
        public virtual Appointment Appointment { get; set; }
        public virtual Medicines Medicines { get; set; }
    }
}
