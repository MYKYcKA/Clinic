using ClinicApp.Models;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ClinicApp.Pages
{
    public partial class AppointmentsTech : Form
    {
        private ClinicEntities1 db = new ClinicEntities1();
        public ClinicAppMain appointmentsView = null;
        public AppointmentsTech()
        {
            InitializeComponent();
            InitAppo();
            InitAppoDet();
            InitContraindication();
        }

        #region Appointments
        private void InitAppo()
        {
            var appointments = db.Appointment.ToList();
            AppTable.DataSource = new BindingList<Appointment>(appointments);
        }

        private void DeleteAppo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in AppTable.SelectedRows)
            {
                var appo = row.DataBoundItem as Appointment;
                if (appo is null)
                    continue;
                var dbAppo = db.Appointment.Find(appo.Id);
                if (dbAppo is null)
                    continue;
                db.Appointment.Remove(db.Appointment.FirstOrDefault(x => x.Id == appo.Id));
            }
            db.SaveChanges();
            InitAppo();
            appointmentsView.InitMedPatViewTable();
        }

        private void SaveAppo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in AppTable.Rows)
            {
                var appo = row.DataBoundItem as Appointment;
                if (appo is null)
                    continue;
                var dbAppo = db.Appointment.Find(appo.Id);
                if (!db.HistoryOfIllness.Any(x => x.Id == appo.HistoryOfIllnessId))
                {
                    MessageBox.Show($"There is no history with such id: {appo.HistoryOfIllnessId}");
                    continue;
                }
                if (dbAppo != null)
                {
                    dbAppo.HistoryOfIllnessId = appo.HistoryOfIllnessId;
                    dbAppo.AppointmentDate = appo.AppointmentDate;
                }
                else
                {
                    db.Appointment.Add(appo);
                }
            }
            db.SaveChanges();
            appointmentsView.InitMedPatViewTable();
        }

        private void RefreshAppo_Click(object sender, EventArgs e)
        {
            InitAppo();
        }
        #endregion

        #region Appointment details
        private void InitAppoDet()
        {
            var appoDet = db.AppointmentDetails.ToList();
            AppDetTable.DataSource = new BindingList<AppointmentDetails>(appoDet);
        }

        private void DeleteAppoDet_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in AppDetTable.SelectedRows)
            {
                var appoDet = row.DataBoundItem as AppointmentDetails;
                if (appoDet is null)
                    continue;
                var dbAppoDet = db.AppointmentDetails.Find(appoDet.Id);
                if (dbAppoDet is null)
                    continue;
                db.AppointmentDetails.Remove(db.AppointmentDetails.FirstOrDefault(x => x.Id == appoDet.Id));
            }
            db.SaveChanges();
            InitAppoDet();
            appointmentsView.InitMedPatViewTable();
        }

        private void SaveAppoDet_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in AppDetTable.Rows)
            {
                var appoDet = row.DataBoundItem as AppointmentDetails;
                if (appoDet is null)
                    continue;
                var bannedMedicines = (from history in db.HistoryOfIllness
                                       join appointment in db.Appointment on history.Id equals appointment.HistoryOfIllnessId
                                       join appointmentDet in db.AppointmentDetails on appointment.Id equals appointmentDet.AppointmentId
                                       join contr in db.Contraindication on history.PatientId equals contr.PatientId
                                       where appointmentDet.Id == appoDet.Id
                                       select new
                                       {
                                           PatientId = contr.PatientId,
                                           MedicineId = contr.MedicineId
                                       }).ToList();
                var appo = db.Appointment.FirstOrDefault(x => x.Id == appoDet.AppointmentId);
                if (appo is null)
                {
                    MessageBox.Show($"There is no appointment with such id: {appoDet.AppointmentId}");
                    continue;
                }
                if (bannedMedicines.Any(x => x.MedicineId == appoDet.MedicineId))
                {
                    MessageBox.Show($"Unfortunately patient have contraindication with this medicine MedicineId: {appoDet.MedicineId}");
                    continue;
                }
                var dbAppoDet = db.AppointmentDetails.Find(appoDet.Id);
                if (dbAppoDet != null)
                {
                    dbAppoDet.AppointmentId = appoDet.AppointmentId;
                    dbAppoDet.MedicineId = appoDet.MedicineId;
                }
                else
                {
                    db.AppointmentDetails.Add(appoDet);
                }
            }
            db.SaveChanges();
            appointmentsView.InitMedPatViewTable();
        }

        private void RefreshAppoDet_Click(object sender, EventArgs e)
        {
            InitAppoDet();
        }
        #endregion

        #region Contraindication
        private void InitContraindication()
        {
            var contr = db.Contraindication.ToList();
            ContrTable.DataSource = new BindingList<Contraindication>(contr);
        }

        private void DeleteContr_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ContrTable.SelectedRows)
            {
                var contr = row.DataBoundItem as Contraindication;
                if (contr is null)
                    continue;
                var dbContr = db.Contraindication.Find(contr.Id);
                if (dbContr is null)
                    continue;
                db.Contraindication.Remove(db.Contraindication.FirstOrDefault(x => x.Id == contr.Id));
            }
            db.SaveChanges();
            InitContraindication();
            appointmentsView.InitMedPatViewTable();
        }

        private void SaveContr_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ContrTable.Rows)
            {
                var contr = row.DataBoundItem as Contraindication;
                if (contr is null)
                    continue;
                var patient = db.Patient.FirstOrDefault(x => x.Id == contr.PatientId);
                if (patient is null)
                {
                    MessageBox.Show($"There is no patient with such id: {contr.PatientId}");
                    continue;
                }
                if (!db.Medicines.Any(x => x.Id == contr.MedicineId))
                {
                    MessageBox.Show($"There is no medicine with such id: {contr.MedicineId}");
                    continue;
                }
                var dbContr = db.Contraindication.Find(contr.Id);
                if (dbContr != null)
                {
                    dbContr.PatientId = contr.PatientId;
                    dbContr.MedicineId = contr.MedicineId;
                }
                else
                {
                    db.Contraindication.Add(contr);
                }
            }
            db.SaveChanges();
            appointmentsView.InitMedPatViewTable();
        }

        private void RefreshContr_Click(object sender, EventArgs e)
        {
            InitContraindication();
        }
        #endregion
    }
}
