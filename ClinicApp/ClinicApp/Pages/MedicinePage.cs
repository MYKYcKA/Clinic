using ClinicApp.Models.ViewModels;
using ClinicApp.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ClinicApp
{
    partial class ClinicAppMain
    {
        public void InitMedicineViewTable()
        {
            var medicines = (from composition in db.Composition
                             join medicine in db.Medicines on composition.MedicineId equals medicine.Id
                             join ingredient in db.Ingredients on composition.IngredientId equals ingredient.Id
                             select new MedicineView
                             {
                                 MedicineId = medicine.Id,
                                 MedicineName = medicine.Name,
                                 IngredientId = ingredient.Id,
                                 IngredientName = ingredient.Name,
                                 CompositionId = composition.Id,
                             }).ToList();
            MedicineTable.DataSource = medicines;
        }

        private void EditMedicines_Click(object sender, EventArgs e)
        {
            var tech = new MedicineTech();
            tech.medicineView = this;
            tech.Show();
        }

        private void CleanTextOnEnter_Enter(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox.Text.Equals("MedicineId") || textBox.Text.Equals("IngredientId") || textBox.Text.Equals("CompositionId"))
                textBox.Text = String.Empty;
        }

        private void MedicineIdText_Leave(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (string.IsNullOrEmpty(textBox.Text))
                textBox.Text = "MedicineId";
        }

        private void IngredientIdText_Leave(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (string.IsNullOrEmpty(textBox.Text))
                textBox.Text = "IngredientId";
        }

        private void CompositionIdText_Leave(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (string.IsNullOrEmpty(textBox.Text))
                textBox.Text = "CompositionId";
        }

        private void MedicineIdText_KeyPress(object sender, KeyPressEventArgs e)
        {

            var textBox = sender as TextBox;
            var medId = 0;
            if (!int.TryParse(textBox.Text, out medId))
            {
                InitHOITable();
                return;
            }
            if (e.KeyChar == '\r')
            {
                FilterBy(medId, "Medicine");
            }
        }

        private void IngredientIdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            var ingId = 0;
            if (!int.TryParse(textBox.Text, out ingId))
            {
                InitHOITable();
                return;
            }
            if (e.KeyChar == '\r')
            {
                FilterBy(ingId, "Ingredient");
            }
        }

        private void CompositionIdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            var compId = 0;
            if (!int.TryParse(textBox.Text, out compId))
            {
                InitHOITable();
                return;
            }
            if (e.KeyChar == '\r')
            {
                FilterBy(compId, "Composition");
            }
        }

        private void FilterBy(int id, string filterBy)
        {
            var medicineVew = new List<MedicineView>();
            var tableData = MedicineTable.DataSource as List<MedicineView>;
            switch (filterBy)
            {
                case "Medicine":
                    medicineVew = tableData.Where(x => x.MedicineId == id).ToList();
                    break;
                case "Ingredient":
                    medicineVew = tableData.Where(x => x.IngredientId == id).ToList();
                    break;
                case "Composition":
                    medicineVew = tableData.Where(x => x.CompositionId == id).ToList();
                    break;
            }
            if (medicineVew.Count == 0)
                InitMedicineViewTable();
            else
                MedicineTable.DataSource = medicineVew;
        }
    }
}
