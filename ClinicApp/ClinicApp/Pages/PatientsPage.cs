using ClinicApp.Models.ViewModels;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ClinicApp
{
    partial class ClinicAppMain
    {
        private void InitPatientsTable()
        {
            var patients = (from patient in db.Patient
                            join address in db.Address on patient.AddressId equals address.Id
                            select new PatientView
                            {
                                Id = patient.Id,
                                AddressId = address.Id,
                                Name = patient.Name,
                                Surname = patient.Surname,
                                City = address.City,
                                Street = address.Street,
                                House = address.House,
                                Apartment = address.Apartment
                            }).ToList();

            PatientsTable.DataSource = new BindingList<PatientView>(patients);
        }

        private void DeletePatients_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in PatientsTable.SelectedRows)
            {
                var patient = row.DataBoundItem as PatientView;
                if (patient is null)
                    continue;
                var dbPatient = db.Patient.Find(patient.Id);
                if (dbPatient is null)
                    continue;
                db.Address.Remove(db.Address.FirstOrDefault(x=>x.Id == patient.AddressId));
                db.Patient.Remove(db.Patient.FirstOrDefault(x => x.Id == patient.Id));
            }
            db.SaveChanges();
            InitPatientsTable();
        }

        private void SavePatients_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in PatientsTable.Rows)
            {
                var patient = row.DataBoundItem as PatientView;
                if (patient is null)
                    continue;
                var dbPatient = db.Patient.Find(patient.Id);
                if (dbPatient != null)
                {
                    dbPatient.Name = patient.Name;
                    dbPatient.Surname = patient.Surname;
                    dbPatient.Address.City = patient.City;
                    dbPatient.Address.Street = patient.Street;
                    dbPatient.Address.House = patient.House;
                    dbPatient.Address.Apartment = patient.Apartment;
                }
                else
                {
                    db.Patient.Add(patient.ToPatient());
                    db.Address.Add(patient.ToAddress());
                }
            }
            db.SaveChanges();
        }

        private void RefreshPatients_Click(object sender, EventArgs e)
        {
            InitPatientsTable();
        }
    }
}
