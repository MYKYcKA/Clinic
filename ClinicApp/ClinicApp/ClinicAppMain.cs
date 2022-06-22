using ClinicApp.Models;
using ClinicApp.Models.ViewModels;
using ClinicApp.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicApp
{
    public partial class ClinicAppMain : Form
    {
        private ClinicEntities1 db = new ClinicEntities1();
        public ClinicAppMain()
        {
            InitializeComponent();
            InitPatientsTable();
            InitDoctorsTable();
            InitHOITable();
            InitMedicineViewTable();
            InitMedPatViewTable();
            InitPerformanceTable();
        }
    }
}
