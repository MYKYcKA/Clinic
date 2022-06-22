using ClinicApp.Models;
using ClinicApp.Models.ViewModels;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ClinicApp
{
    partial class ClinicAppMain
    {
        private void InitHOITable()
        {
            var history = db.HistoryOfIllness.ToList();
            HOITable.DataSource = new BindingList<HistoryOfIllness>(history);
        }

        private void HOIText_Enter(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox.Text.Equals("DoctorId") || textBox.Text.Equals("PatientId") || textBox.Text.Equals("Date"))
                textBox.Text = String.Empty;
        }

        private void DoctorIdText_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (string.IsNullOrEmpty(textBox.Text))
                textBox.Text = "DoctorId";
        }

        private void PatientIdText_Leave(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (string.IsNullOrEmpty(textBox.Text))
                textBox.Text = "PatientId";
        }

        private void DateText_Leave(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (string.IsNullOrEmpty(textBox.Text))
                textBox.Text = "Date";
        }

        private void PatientIdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            var patientid = 0;
            if (!int.TryParse(textBox.Text, out patientid))
            {
                InitHOITable();
                return;
            }
            if (e.KeyChar == '\r')
            {
                var history = (HOITable.DataSource as BindingList<HistoryOfIllness>).Where(x => x.PatientId == patientid).ToList();
                if (history is null)
                    InitHOITable();
                else
                    HOITable.DataSource = new BindingList<HistoryOfIllness>(history);
            }
        }

        private void DoctorIdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            var doctorid = 0;
            if (!int.TryParse(textBox.Text, out doctorid))
            {
                InitHOITable();
                return;
            }
            if (e.KeyChar == '\r')
            {
                var history = (HOITable.DataSource as BindingList<HistoryOfIllness>).Where(x => x.DoctorId == doctorid).ToList();
                if (history is null)
                    InitHOITable();
                else
                    HOITable.DataSource = new BindingList<HistoryOfIllness>(history);
            }
        }

        private void DateText_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            var date = new DateTime();
            if (!DateTime.TryParse(textBox.Text, out date))
            {
                InitHOITable();
                return;
            }
            if (e.KeyChar == '\r')
            {
                var history = (HOITable.DataSource as BindingList<HistoryOfIllness>).Where(x => x.Start <= date && x.End >= date).ToList();
                HOITable.DataSource = new BindingList<HistoryOfIllness>(history);
            }
            else if (e.KeyChar == '\u001b')
                InitHOITable();
        }

        private void RefreshHOI_Click(object sender, EventArgs e)
        {
            InitHOITable();
        }

        private void DeleteHOI_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in HOITable.SelectedRows)
            {
                var history = row.DataBoundItem as HistoryOfIllness;
                if (history is null)
                    continue;
                var dbHistory = db.HistoryOfIllness.Find(history.Id);
                if (dbHistory is null)
                    continue;
                db.HistoryOfIllness.Remove(db.HistoryOfIllness.FirstOrDefault(x => x.Id == history.Id));
            }
            db.SaveChanges();
            InitHOITable();
        }

        private void SaveHOI_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in HOITable.Rows)
            {
                var history = row.DataBoundItem as HistoryOfIllness;
                if (history is null)
                    continue;
                var dbHistory = db.HistoryOfIllness.Find(history.Id);
                var doctor = db.Doctor.FirstOrDefault(x => x.Id == history.DoctorId);
                var patient = db.Patient.FirstOrDefault(x => x.Id == history.PatientId);
                if (doctor is null)
                {
                    MessageBox.Show($"There is no doctor with such Id: {history.DoctorId}", "Error");
                    continue;
                }
                if (patient is null)
                {
                    MessageBox.Show($"There is no patient with such Id: {history.PatientId}", "Error");
                    continue;
                }
                var hist = db.HistoryOfIllness.Where(x => x.DoctorId == doctor.Id).ToList();
                if (hist.Where(x => x.Start <= history.Start && x.End >= history.Start).Count() > 10)
                {
                    MessageBox.Show($"Sorry doctor can`t take more patients at this time", "Error");
                    continue;
                }
                if (dbHistory != null)
                {
                    dbHistory.Start = history.Start;
                    dbHistory.End = history.End;
                    dbHistory.PatientId = history.PatientId;
                    dbHistory.DoctorId = history.DoctorId;
                    dbHistory.Rate = history.Rate;
                    dbHistory.Characteristic = history.Characteristic;
                    dbHistory.Diagnose = history.Diagnose;
                    dbHistory.OnSpecialCount = history.OnSpecialCount;
                }
                else
                {
                    db.HistoryOfIllness.Add(history);
                }
            }
            db.SaveChanges();
        }
    }
}
