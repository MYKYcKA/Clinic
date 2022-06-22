using ClinicApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ClinicApp
{
    partial class ClinicAppMain
    {
        List<string> months = new List<string>{"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
        private void InitPerformanceTable()
        {
            var year = 0;
            int.TryParse(YearBox.Text, out year);
            year = year == 0 ? 2021 : year;
            var dt = new DataTable();
            dt.Columns.Add(new DataColumn("Month", typeof(string)));
            var doctors = db.Doctor.ToList();
            foreach (var doctor in doctors)
            {
                dt.Columns.Add(new DataColumn(doctor.Name, typeof(int)));
            }
            foreach (var mon in months)
            {
                dt.Rows.Add(mon);
            }

            int i = 0;
            foreach (var doctor in doctors)
            {
                for (int j = 0; j < months.Count(); j++)
                {
                    var mont = j+1;
                    var daysInMonth = DateTime.DaysInMonth(year: year, month: mont);
                    var date = new DateTime(year, mont, daysInMonth);
                    var patCount = db.HistoryOfIllness.Where(x => x.DoctorId == doctor.Id && x.Start <= date && x.End >= date).Count();
                    dt.Rows[j][i+1] = patCount;
                }
                i++;
            }

            PerformanceTable.DataSource = dt;
        }

        private void YearBox_SelectedValueChanged(object sender, EventArgs e)
        {
            InitPerformanceTable();
        }
    }
}
