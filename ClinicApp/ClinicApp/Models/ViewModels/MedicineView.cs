using System;

namespace ClinicApp.Models.ViewModels
{
    public class MedicineView
    {
        public int MedicineId { get; set; }
        public string MedicineName { get; set; }
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public int CompositionId { get; set; }
    }
}
