using ClinicApp.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ClinicApp.Pages
{
    public partial class MedicineTech : Form
    {
        private ClinicEntities1 db = new ClinicEntities1();
        public ClinicAppMain medicineView = null;
        public MedicineTech()
        {
            InitializeComponent();
            InitMedicine();
            InitIngredient();
            InitComposition();
        }

        #region Medicine
        private void InitMedicine()
        {
            var medicines = db.Medicines.ToList();
            MedTable.DataSource = new BindingList<Medicines>(medicines);
        }

        private void DeleteMed_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in MedTable.SelectedRows)
            {
                var med = row.DataBoundItem as Medicines;
                if (med is null)
                    continue;
                var dbMed = db.Medicines.Find(med.Id);
                if (dbMed is null)
                    continue;
                db.Medicines.Remove(db.Medicines.FirstOrDefault(x => x.Id == med.Id));
            }
            db.SaveChanges();
            InitMedicine();
            medicineView.InitMedicineViewTable();
        }

        private void SaveMed_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in MedTable.Rows)
            {
                var med = row.DataBoundItem as Medicines;
                if (med is null)
                    continue;
                var dbMed = db.Medicines.Find(med.Id);
                if (dbMed != null)
                {
                    dbMed.Name = med.Name;
                }
                else
                {
                    db.Medicines.Add(med);
                }
            }
            db.SaveChanges();
            medicineView.InitMedicineViewTable();
        }

        private void RefreshMed_Click(object sender, EventArgs e)
        {
            InitMedicine();
        }
        #endregion

        #region Ingredient
        private void InitIngredient()
        {
            var ing = db.Ingredients.ToList();
            IngTable.DataSource = new BindingList<Ingredients>(ing);
        }

        private void DeleteIng_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in IngTable.SelectedRows)
            {
                var ing = row.DataBoundItem as Ingredients;
                if (ing is null)
                    continue;
                var dbIng = db.Ingredients.Find(ing.Id);
                if (dbIng is null)
                    continue;
                db.Ingredients.Remove(db.Ingredients.FirstOrDefault(x => x.Id == ing.Id));
            }
            db.SaveChanges();
            InitIngredient();
            medicineView.InitMedicineViewTable();
        }

        private void SaveIng_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in IngTable.Rows)
            {
                var ing = row.DataBoundItem as Ingredients;
                if (ing is null)
                    continue;
                var dbIng = db.Ingredients.Find(ing.Id);
                if (dbIng != null)
                {
                    dbIng.Name = ing.Name;
                }
                else
                {
                    db.Ingredients.Add(ing);
                }
            }
            db.SaveChanges();
            medicineView.InitMedicineViewTable();
        }

        private void RefreshIng_Click(object sender, EventArgs e)
        {
            InitIngredient();
        }
        #endregion

        #region Composition
        private void InitComposition()
        {
            var comp = db.Composition.ToList();
            CompTable.DataSource = new BindingList<Composition>(comp);
        }

        private void DeleteComp_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in CompTable.SelectedRows)
            {
                var comp = row.DataBoundItem as ClinicApp.Models.Composition;
                if (comp is null)
                    continue;
                var dbComp = db.Composition.Find(comp.Id);
                if (dbComp is null)
                    continue;
                db.Composition.Remove(db.Composition.FirstOrDefault(x => x.Id == comp.Id));
            }
            db.SaveChanges();
            InitComposition();
            medicineView.InitMedicineViewTable();
        }

        private void SaveComp_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in CompTable.Rows)
            {
                var comp = row.DataBoundItem as ClinicApp.Models.Composition;
                if (comp is null)
                    continue;
                var medicine = db.Medicines.FirstOrDefault(x => x.Id == comp.MedicineId);
                var ingredient = db.Ingredients.FirstOrDefault(x => x.Id == comp.IngredientId);
                if (medicine is null)
                {
                    MessageBox.Show($"There is no medicine with such id: {comp.MedicineId}");
                    continue;
                }
                if (ingredient is null)
                {
                    MessageBox.Show($"There is no ingredient with such id: {comp.IngredientId}");
                    continue;
                }
                var dbComp = db.Composition.Find(comp.Id);
                if (dbComp != null)
                {
                    dbComp.MedicineId = comp.MedicineId;
                    dbComp.IngredientId = comp.IngredientId;
                }
                else
                {
                    db.Composition.Add(comp);
                }
            }
            db.SaveChanges();
            medicineView.InitMedicineViewTable();
        }

        private void RefreshComp_Click(object sender, EventArgs e)
        {
            InitComposition();
        }
        #endregion
    }
}
