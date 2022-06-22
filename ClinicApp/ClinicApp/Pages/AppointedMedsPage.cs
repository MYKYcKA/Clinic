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
        public void InitMedPatViewTable()
        {
            var appoitments = (from history in db.HistoryOfIllness
                             join patient in db.Patient on history.PatientId equals patient.Id
                             join appointment in db.Appointment on history.Id equals appointment.HistoryOfIllnessId
                             join appointmentDet in db.AppointmentDetails on appointment.Id equals appointmentDet.AppointmentId
                             join medicine in db.Medicines on appointmentDet.MedicineId equals medicine.Id
                             select new AppointedMedsView
                             {
                                 Patientid = patient.Id,
                                 PatientName = patient.Name,
                                 PatienSurname = patient.Surname,
                                 MedicineId = medicine.Id,
                                 MedicineName = medicine.Name,
                                 AppointmentDate = appointment.AppointmentDate,
                                 HOIId = history.Id,
                                 Diagnose = history.Diagnose,
                             }).ToList();
            PatMedTable.DataSource = appoitments;
        }

        private void EditAppointments_Click(object sender, EventArgs e)
        {
            var tech = new AppointmentsTech();
            tech.appointmentsView = this;
            tech.Show();
        }

        private void CleanTextOnEnterAM_Enter(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox.Text.Equals("MedicineId") || textBox.Text.Equals("HistoryId") || textBox.Text.Equals("PatientId"))
                textBox.Text = String.Empty;
        }

        private void HistoryIdText_Leave(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (string.IsNullOrEmpty(textBox.Text))
                textBox.Text = "HistoryId";
        }

        private void MedText_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            var medId = 0;
            if (!int.TryParse(textBox.Text, out medId))
            {
                InitMedPatViewTable();
                return;
            }
            if (e.KeyChar == '\r')
            {
                FilterByAM(medId, "Medicine");
            }
        }

        private void PatText_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            var patId = 0;
            if (!int.TryParse(textBox.Text, out patId))
            {
                InitMedPatViewTable();
                return;
            }
            if (e.KeyChar == '\r')
            {
                FilterByAM(patId, "Patient");
            }
        }

        private void HOIText_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            var hoiId = 0;
            if (!int.TryParse(textBox.Text, out hoiId))
            {
                InitMedPatViewTable();
                return;
            }
            if (e.KeyChar == '\r')
            {
                FilterByAM(hoiId, "History");
            }
        }

        private void FilterByAM(int id, string filterBy)
        {
            var appointmentsView = new List<AppointedMedsView>();
            var tableData = PatMedTable.DataSource as List<AppointedMedsView>;
            switch (filterBy)
            {
                case "Medicine":
                    appointmentsView = tableData.Where(x => x.MedicineId == id).ToList();
                    break;
                case "Patient":
                    appointmentsView = tableData.Where(x => x.Patientid == id).ToList();
                    break;
                case "History":
                    appointmentsView = tableData.Where(x => x.HOIId == id).ToList();
                    break;
            }
            if (appointmentsView.Count == 0)
                InitMedPatViewTable();
            else
                PatMedTable.DataSource = appointmentsView;
        }
    }
}
