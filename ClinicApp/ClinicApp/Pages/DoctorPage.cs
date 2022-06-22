using ClinicApp.Models.ViewModels;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ClinicApp
{
    partial class ClinicAppMain
    {
        private void InitDoctorsTable()
        {
            var doctors = (from doctor in db.Doctor
                           join address in db.Address on doctor.AddressId equals address.Id
                           select new DoctorView
                           {
                               Id = doctor.Id,
                               AddressId = doctor.AddressId,
                               Name = doctor.Name,
                               MiddleName = doctor.MiddleName,
                               Surname = doctor.Surname,
                               Specialization = doctor.Specialization,
                               City = address.City,
                               Street = address.Street,
                               House = address.House,
                               Apartment = address.Apartment
                           }).ToList();

            DoctorsTable.DataSource = new BindingList<DoctorView>(doctors);
        }

        private void DeleteDoctors_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DoctorsTable.SelectedRows)
            {
                var doctor = row.DataBoundItem as DoctorView;
                if (doctor is null)
                    continue;
                var dbDoctor = db.Doctor.Find(doctor.Id);
                if (dbDoctor is null)
                    continue;
                db.Address.Remove(db.Address.FirstOrDefault(x => x.Id == doctor.AddressId));
                db.Doctor.Remove(db.Doctor.FirstOrDefault(x => x.Id == doctor.Id));
            }
            db.SaveChanges();
            InitDoctorsTable();
        }

        private void SaveDoctors_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DoctorsTable.Rows)
            {
                var doctor = row.DataBoundItem as DoctorView;
                if (doctor is null)
                    continue;
                var dbDoctor = db.Doctor.Find(doctor.Id);
                if (dbDoctor != null)
                {
                    dbDoctor.Name = doctor.Name;
                    dbDoctor.MiddleName = doctor.MiddleName;
                    dbDoctor.Surname = doctor.Surname;
                    dbDoctor.Specialization = doctor.Specialization;
                    dbDoctor.Address.City = doctor.City;
                    dbDoctor.Address.Street = doctor.Street;
                    dbDoctor.Address.House = doctor.House;
                    dbDoctor.Address.Apartment = doctor.Apartment;
                }
                else
                {
                    db.Doctor.Add(doctor.ToDoctor());
                    db.Address.Add(doctor.ToAddress());
                }
            }
            db.SaveChanges();
        }

        private void RefreshDoctors_Click(object sender, EventArgs e)
        {
            InitDoctorsTable();
        }
    }
}
