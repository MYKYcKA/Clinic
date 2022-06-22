using System;

namespace ClinicApp.Models.ViewModels
{
    internal class AppointedMedsView
    {
        public int Patientid { get; set; }
        public string PatientName { get; set; }
        public string PatienSurname { get; set; }
        public int MedicineId { get; set; }
        public string MedicineName { get; set; }
        public int HOIId { get; set; }
        public string Diagnose { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
