namespace ClinicApp
{
    partial class ClinicAppMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ClinicTabs = new System.Windows.Forms.TabControl();
            this.Patients = new System.Windows.Forms.TabPage();
            this.Patientslayout = new System.Windows.Forms.TableLayoutPanel();
            this.PatientsTable = new System.Windows.Forms.DataGridView();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.House = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SavePatients = new System.Windows.Forms.Button();
            this.DeletePatients = new System.Windows.Forms.Button();
            this.RefreshPatients = new System.Windows.Forms.Button();
            this.Doctors = new System.Windows.Forms.TabPage();
            this.DoctorLayout = new System.Windows.Forms.TableLayoutPanel();
            this.DoctorsTable = new System.Windows.Forms.DataGridView();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveDoctors = new System.Windows.Forms.Button();
            this.DeleteDoctors = new System.Windows.Forms.Button();
            this.RefreshDoctors = new System.Windows.Forms.Button();
            this.HOI = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DateText = new System.Windows.Forms.TextBox();
            this.DoctorIdText = new System.Windows.Forms.TextBox();
            this.HOITable = new System.Windows.Forms.DataGridView();
            this.DoctorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Characteristic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnSpecialCount = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SaveHOI = new System.Windows.Forms.Button();
            this.DeleteHOI = new System.Windows.Forms.Button();
            this.RefreshHOI = new System.Windows.Forms.Button();
            this.PatientIdText = new System.Windows.Forms.TextBox();
            this.Medicines = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.EditButton = new System.Windows.Forms.Button();
            this.CompositionText = new System.Windows.Forms.TextBox();
            this.IngredientText = new System.Windows.Forms.TextBox();
            this.MedicineTable = new System.Windows.Forms.DataGridView();
            this.MedicineText = new System.Windows.Forms.TextBox();
            this.PatMed = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.HOIText = new System.Windows.Forms.TextBox();
            this.PatMedEdit = new System.Windows.Forms.Button();
            this.MedText = new System.Windows.Forms.TextBox();
            this.PatText = new System.Windows.Forms.TextBox();
            this.PatMedTable = new System.Windows.Forms.DataGridView();
            this.Performance = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.PerformanceTable = new System.Windows.Forms.DataGridView();
            this.YearBox = new System.Windows.Forms.ComboBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyOfIllnessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicineIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patienSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOIIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnoseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointedMedsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClinicTabs.SuspendLayout();
            this.Patients.SuspendLayout();
            this.Patientslayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsTable)).BeginInit();
            this.Doctors.SuspendLayout();
            this.DoctorLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsTable)).BeginInit();
            this.HOI.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HOITable)).BeginInit();
            this.Medicines.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineTable)).BeginInit();
            this.PatMed.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatMedTable)).BeginInit();
            this.Performance.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyOfIllnessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointedMedsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClinicTabs
            // 
            this.ClinicTabs.Controls.Add(this.Patients);
            this.ClinicTabs.Controls.Add(this.Doctors);
            this.ClinicTabs.Controls.Add(this.HOI);
            this.ClinicTabs.Controls.Add(this.Medicines);
            this.ClinicTabs.Controls.Add(this.PatMed);
            this.ClinicTabs.Controls.Add(this.Performance);
            this.ClinicTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClinicTabs.Location = new System.Drawing.Point(0, 0);
            this.ClinicTabs.Name = "ClinicTabs";
            this.ClinicTabs.SelectedIndex = 0;
            this.ClinicTabs.Size = new System.Drawing.Size(800, 450);
            this.ClinicTabs.TabIndex = 0;
            // 
            // Patients
            // 
            this.Patients.Controls.Add(this.Patientslayout);
            this.Patients.Location = new System.Drawing.Point(4, 25);
            this.Patients.Name = "Patients";
            this.Patients.Padding = new System.Windows.Forms.Padding(3);
            this.Patients.Size = new System.Drawing.Size(792, 421);
            this.Patients.TabIndex = 0;
            this.Patients.Text = "Patients";
            this.Patients.UseVisualStyleBackColor = true;
            // 
            // Patientslayout
            // 
            this.Patientslayout.AutoSize = true;
            this.Patientslayout.ColumnCount = 5;
            this.Patientslayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.Patientslayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.Patientslayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.Patientslayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Patientslayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.Patientslayout.Controls.Add(this.PatientsTable, 0, 1);
            this.Patientslayout.Controls.Add(this.SavePatients, 0, 0);
            this.Patientslayout.Controls.Add(this.DeletePatients, 1, 0);
            this.Patientslayout.Controls.Add(this.RefreshPatients, 2, 0);
            this.Patientslayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Patientslayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.Patientslayout.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Patientslayout.Location = new System.Drawing.Point(3, 3);
            this.Patientslayout.Name = "Patientslayout";
            this.Patientslayout.RowCount = 2;
            this.Patientslayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Patientslayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Patientslayout.Size = new System.Drawing.Size(786, 415);
            this.Patientslayout.TabIndex = 0;
            // 
            // PatientsTable
            // 
            this.PatientsTable.AutoGenerateColumns = false;
            this.PatientsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PatientsTable.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.PatientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.City,
            this.Street,
            this.House,
            this.Apartment});
            this.Patientslayout.SetColumnSpan(this.PatientsTable, 5);
            this.PatientsTable.DataSource = this.patientViewBindingSource;
            this.PatientsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatientsTable.Location = new System.Drawing.Point(3, 53);
            this.PatientsTable.Name = "PatientsTable";
            this.PatientsTable.RowHeadersWidth = 51;
            this.PatientsTable.RowTemplate.Height = 24;
            this.PatientsTable.Size = new System.Drawing.Size(780, 359);
            this.PatientsTable.TabIndex = 0;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            // 
            // Street
            // 
            this.Street.DataPropertyName = "Street";
            this.Street.HeaderText = "Street";
            this.Street.MinimumWidth = 6;
            this.Street.Name = "Street";
            // 
            // House
            // 
            this.House.DataPropertyName = "House";
            this.House.HeaderText = "House";
            this.House.MinimumWidth = 6;
            this.House.Name = "House";
            // 
            // Apartment
            // 
            this.Apartment.DataPropertyName = "Apartment";
            this.Apartment.HeaderText = "Apartment";
            this.Apartment.MinimumWidth = 6;
            this.Apartment.Name = "Apartment";
            // 
            // SavePatients
            // 
            this.SavePatients.BackColor = System.Drawing.Color.Teal;
            this.SavePatients.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SavePatients.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SavePatients.Location = new System.Drawing.Point(3, 3);
            this.SavePatients.Name = "SavePatients";
            this.SavePatients.Size = new System.Drawing.Size(77, 44);
            this.SavePatients.TabIndex = 4;
            this.SavePatients.Text = "Save";
            this.SavePatients.UseVisualStyleBackColor = false;
            this.SavePatients.Click += new System.EventHandler(this.SavePatients_Click);
            // 
            // DeletePatients
            // 
            this.DeletePatients.BackColor = System.Drawing.Color.OrangeRed;
            this.DeletePatients.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeletePatients.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeletePatients.Location = new System.Drawing.Point(86, 3);
            this.DeletePatients.Name = "DeletePatients";
            this.DeletePatients.Size = new System.Drawing.Size(76, 44);
            this.DeletePatients.TabIndex = 3;
            this.DeletePatients.Text = "Delete";
            this.DeletePatients.UseVisualStyleBackColor = false;
            this.DeletePatients.Click += new System.EventHandler(this.DeletePatients_Click);
            // 
            // RefreshPatients
            // 
            this.RefreshPatients.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RefreshPatients.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshPatients.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RefreshPatients.Location = new System.Drawing.Point(168, 3);
            this.RefreshPatients.Name = "RefreshPatients";
            this.RefreshPatients.Size = new System.Drawing.Size(77, 44);
            this.RefreshPatients.TabIndex = 5;
            this.RefreshPatients.Text = "Refresh";
            this.RefreshPatients.UseVisualStyleBackColor = false;
            this.RefreshPatients.Click += new System.EventHandler(this.RefreshPatients_Click);
            // 
            // Doctors
            // 
            this.Doctors.Controls.Add(this.DoctorLayout);
            this.Doctors.Location = new System.Drawing.Point(4, 25);
            this.Doctors.Name = "Doctors";
            this.Doctors.Padding = new System.Windows.Forms.Padding(3);
            this.Doctors.Size = new System.Drawing.Size(792, 421);
            this.Doctors.TabIndex = 1;
            this.Doctors.Text = "Doctors";
            this.Doctors.UseVisualStyleBackColor = true;
            // 
            // DoctorLayout
            // 
            this.DoctorLayout.AutoSize = true;
            this.DoctorLayout.ColumnCount = 5;
            this.DoctorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.DoctorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.DoctorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.DoctorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DoctorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.DoctorLayout.Controls.Add(this.DoctorsTable, 0, 1);
            this.DoctorLayout.Controls.Add(this.SaveDoctors, 0, 0);
            this.DoctorLayout.Controls.Add(this.DeleteDoctors, 1, 0);
            this.DoctorLayout.Controls.Add(this.RefreshDoctors, 2, 0);
            this.DoctorLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoctorLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.DoctorLayout.ImeMode = System.Windows.Forms.ImeMode.On;
            this.DoctorLayout.Location = new System.Drawing.Point(3, 3);
            this.DoctorLayout.Name = "DoctorLayout";
            this.DoctorLayout.RowCount = 2;
            this.DoctorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.DoctorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DoctorLayout.Size = new System.Drawing.Size(786, 415);
            this.DoctorLayout.TabIndex = 1;
            // 
            // DoctorsTable
            // 
            this.DoctorsTable.AutoGenerateColumns = false;
            this.DoctorsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DoctorsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DoctorsTable.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.DoctorsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.MiddleName,
            this.surnameDataGridViewTextBoxColumn1,
            this.specializationDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.houseDataGridViewTextBoxColumn,
            this.apartmentDataGridViewTextBoxColumn});
            this.DoctorLayout.SetColumnSpan(this.DoctorsTable, 5);
            this.DoctorsTable.DataSource = this.doctorViewBindingSource;
            this.DoctorsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoctorsTable.Location = new System.Drawing.Point(3, 53);
            this.DoctorsTable.Name = "DoctorsTable";
            this.DoctorsTable.RowHeadersWidth = 51;
            this.DoctorsTable.RowTemplate.Height = 24;
            this.DoctorsTable.Size = new System.Drawing.Size(780, 359);
            this.DoctorsTable.TabIndex = 0;
            // 
            // MiddleName
            // 
            this.MiddleName.DataPropertyName = "MiddleName";
            this.MiddleName.HeaderText = "MiddleName";
            this.MiddleName.MinimumWidth = 6;
            this.MiddleName.Name = "MiddleName";
            // 
            // SaveDoctors
            // 
            this.SaveDoctors.BackColor = System.Drawing.Color.Teal;
            this.SaveDoctors.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveDoctors.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveDoctors.Location = new System.Drawing.Point(3, 3);
            this.SaveDoctors.Name = "SaveDoctors";
            this.SaveDoctors.Size = new System.Drawing.Size(77, 44);
            this.SaveDoctors.TabIndex = 4;
            this.SaveDoctors.Text = "Save";
            this.SaveDoctors.UseVisualStyleBackColor = false;
            this.SaveDoctors.Click += new System.EventHandler(this.SaveDoctors_Click);
            // 
            // DeleteDoctors
            // 
            this.DeleteDoctors.BackColor = System.Drawing.Color.OrangeRed;
            this.DeleteDoctors.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteDoctors.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeleteDoctors.Location = new System.Drawing.Point(86, 3);
            this.DeleteDoctors.Name = "DeleteDoctors";
            this.DeleteDoctors.Size = new System.Drawing.Size(76, 44);
            this.DeleteDoctors.TabIndex = 3;
            this.DeleteDoctors.Text = "Delete";
            this.DeleteDoctors.UseVisualStyleBackColor = false;
            this.DeleteDoctors.Click += new System.EventHandler(this.DeleteDoctors_Click);
            // 
            // RefreshDoctors
            // 
            this.RefreshDoctors.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RefreshDoctors.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshDoctors.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RefreshDoctors.Location = new System.Drawing.Point(168, 3);
            this.RefreshDoctors.Name = "RefreshDoctors";
            this.RefreshDoctors.Size = new System.Drawing.Size(77, 44);
            this.RefreshDoctors.TabIndex = 5;
            this.RefreshDoctors.Text = "Refresh";
            this.RefreshDoctors.UseVisualStyleBackColor = false;
            this.RefreshDoctors.Click += new System.EventHandler(this.RefreshDoctors_Click);
            // 
            // HOI
            // 
            this.HOI.Controls.Add(this.tableLayoutPanel1);
            this.HOI.Location = new System.Drawing.Point(4, 25);
            this.HOI.Name = "HOI";
            this.HOI.Size = new System.Drawing.Size(792, 421);
            this.HOI.TabIndex = 2;
            this.HOI.Text = "HistoryofIllness";
            this.HOI.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.Controls.Add(this.DateText, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.DoctorIdText, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.HOITable, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SaveHOI, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DeleteHOI, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RefreshHOI, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.PatientIdText, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 421);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // DateText
            // 
            this.DateText.Location = new System.Drawing.Point(680, 3);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(100, 22);
            this.DateText.TabIndex = 9;
            this.DateText.Text = "Date";
            this.DateText.Enter += new System.EventHandler(this.HOIText_Enter);
            this.DateText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DateText_KeyPress);
            this.DateText.Leave += new System.EventHandler(this.DateText_Leave);
            // 
            // DoctorIdText
            // 
            this.DoctorIdText.Location = new System.Drawing.Point(571, 3);
            this.DoctorIdText.Name = "DoctorIdText";
            this.DoctorIdText.Size = new System.Drawing.Size(100, 22);
            this.DoctorIdText.TabIndex = 8;
            this.DoctorIdText.Text = "DoctorId";
            this.DoctorIdText.Enter += new System.EventHandler(this.HOIText_Enter);
            this.DoctorIdText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoctorIdText_KeyPress);
            this.DoctorIdText.Leave += new System.EventHandler(this.DoctorIdText_TextChanged);
            // 
            // HOITable
            // 
            this.HOITable.AutoGenerateColumns = false;
            this.HOITable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HOITable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.HOITable.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.HOITable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HOITable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.DoctorId,
            this.PatientId,
            this.Diagnose,
            this.Start,
            this.End,
            this.Rate,
            this.Characteristic,
            this.OnSpecialCount});
            this.tableLayoutPanel1.SetColumnSpan(this.HOITable, 7);
            this.HOITable.DataSource = this.historyOfIllnessBindingSource;
            this.HOITable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HOITable.Location = new System.Drawing.Point(3, 53);
            this.HOITable.Name = "HOITable";
            this.HOITable.RowHeadersWidth = 51;
            this.HOITable.RowTemplate.Height = 24;
            this.HOITable.Size = new System.Drawing.Size(786, 365);
            this.HOITable.TabIndex = 0;
            // 
            // DoctorId
            // 
            this.DoctorId.DataPropertyName = "DoctorId";
            this.DoctorId.HeaderText = "DoctorId";
            this.DoctorId.MinimumWidth = 6;
            this.DoctorId.Name = "DoctorId";
            // 
            // PatientId
            // 
            this.PatientId.DataPropertyName = "PatientId";
            this.PatientId.HeaderText = "PatientId";
            this.PatientId.MinimumWidth = 6;
            this.PatientId.Name = "PatientId";
            // 
            // Diagnose
            // 
            this.Diagnose.DataPropertyName = "Diagnose";
            this.Diagnose.HeaderText = "Diagnose";
            this.Diagnose.MinimumWidth = 6;
            this.Diagnose.Name = "Diagnose";
            // 
            // Start
            // 
            this.Start.DataPropertyName = "Start";
            this.Start.HeaderText = "Start";
            this.Start.MinimumWidth = 6;
            this.Start.Name = "Start";
            // 
            // End
            // 
            this.End.DataPropertyName = "End";
            this.End.HeaderText = "End";
            this.End.MinimumWidth = 6;
            this.End.Name = "End";
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Rate";
            this.Rate.HeaderText = "Rate";
            this.Rate.MinimumWidth = 6;
            this.Rate.Name = "Rate";
            // 
            // Characteristic
            // 
            this.Characteristic.DataPropertyName = "Characteristic";
            this.Characteristic.HeaderText = "Characteristic";
            this.Characteristic.MinimumWidth = 6;
            this.Characteristic.Name = "Characteristic";
            // 
            // OnSpecialCount
            // 
            this.OnSpecialCount.DataPropertyName = "OnSpecialCount";
            this.OnSpecialCount.HeaderText = "OnSpecialCount";
            this.OnSpecialCount.MinimumWidth = 6;
            this.OnSpecialCount.Name = "OnSpecialCount";
            // 
            // SaveHOI
            // 
            this.SaveHOI.BackColor = System.Drawing.Color.Teal;
            this.SaveHOI.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveHOI.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveHOI.Location = new System.Drawing.Point(3, 3);
            this.SaveHOI.Name = "SaveHOI";
            this.SaveHOI.Size = new System.Drawing.Size(77, 44);
            this.SaveHOI.TabIndex = 4;
            this.SaveHOI.Text = "Save";
            this.SaveHOI.UseVisualStyleBackColor = false;
            this.SaveHOI.Click += new System.EventHandler(this.SaveHOI_Click);
            // 
            // DeleteHOI
            // 
            this.DeleteHOI.BackColor = System.Drawing.Color.OrangeRed;
            this.DeleteHOI.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteHOI.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeleteHOI.Location = new System.Drawing.Point(86, 3);
            this.DeleteHOI.Name = "DeleteHOI";
            this.DeleteHOI.Size = new System.Drawing.Size(76, 44);
            this.DeleteHOI.TabIndex = 3;
            this.DeleteHOI.Text = "Delete";
            this.DeleteHOI.UseVisualStyleBackColor = false;
            this.DeleteHOI.Click += new System.EventHandler(this.DeleteHOI_Click);
            // 
            // RefreshHOI
            // 
            this.RefreshHOI.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RefreshHOI.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshHOI.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RefreshHOI.Location = new System.Drawing.Point(168, 3);
            this.RefreshHOI.Name = "RefreshHOI";
            this.RefreshHOI.Size = new System.Drawing.Size(77, 44);
            this.RefreshHOI.TabIndex = 5;
            this.RefreshHOI.Text = "Refresh";
            this.RefreshHOI.UseVisualStyleBackColor = false;
            this.RefreshHOI.Click += new System.EventHandler(this.RefreshHOI_Click);
            // 
            // PatientIdText
            // 
            this.PatientIdText.Location = new System.Drawing.Point(464, 3);
            this.PatientIdText.Name = "PatientIdText";
            this.PatientIdText.Size = new System.Drawing.Size(100, 22);
            this.PatientIdText.TabIndex = 7;
            this.PatientIdText.Text = "PatientId";
            this.PatientIdText.Enter += new System.EventHandler(this.HOIText_Enter);
            this.PatientIdText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientIdText_KeyPress);
            this.PatientIdText.Leave += new System.EventHandler(this.PatientIdText_Leave);
            // 
            // Medicines
            // 
            this.Medicines.Controls.Add(this.tableLayoutPanel2);
            this.Medicines.Location = new System.Drawing.Point(4, 25);
            this.Medicines.Name = "Medicines";
            this.Medicines.Padding = new System.Windows.Forms.Padding(3);
            this.Medicines.Size = new System.Drawing.Size(792, 421);
            this.Medicines.TabIndex = 3;
            this.Medicines.Text = "Medicines";
            this.Medicines.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.EditButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CompositionText, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.IngredientText, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.MedicineTable, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.MedicineText, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 415);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.EditButton.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.EditButton.Location = new System.Drawing.Point(3, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(77, 44);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditMedicines_Click);
            // 
            // CompositionText
            // 
            this.CompositionText.Location = new System.Drawing.Point(680, 3);
            this.CompositionText.Name = "CompositionText";
            this.CompositionText.Size = new System.Drawing.Size(100, 22);
            this.CompositionText.TabIndex = 9;
            this.CompositionText.Text = "CompositionId";
            this.CompositionText.Enter += new System.EventHandler(this.CleanTextOnEnter_Enter);
            this.CompositionText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CompositionIdText_KeyPress);
            this.CompositionText.Leave += new System.EventHandler(this.CompositionIdText_Leave);
            // 
            // IngredientText
            // 
            this.IngredientText.Location = new System.Drawing.Point(572, 3);
            this.IngredientText.Name = "IngredientText";
            this.IngredientText.Size = new System.Drawing.Size(100, 22);
            this.IngredientText.TabIndex = 8;
            this.IngredientText.Text = "IngredientId";
            this.IngredientText.Enter += new System.EventHandler(this.CleanTextOnEnter_Enter);
            this.IngredientText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngredientIdText_KeyPress);
            this.IngredientText.Leave += new System.EventHandler(this.IngredientIdText_Leave);
            // 
            // MedicineTable
            // 
            this.MedicineTable.AutoGenerateColumns = false;
            this.MedicineTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedicineTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MedicineTable.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.MedicineTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicineTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicineIdDataGridViewTextBoxColumn,
            this.medicineNameDataGridViewTextBoxColumn,
            this.ingredientIdDataGridViewTextBoxColumn,
            this.ingredientNameDataGridViewTextBoxColumn,
            this.compositionIdDataGridViewTextBoxColumn});
            this.tableLayoutPanel2.SetColumnSpan(this.MedicineTable, 7);
            this.MedicineTable.DataSource = this.medicineViewBindingSource;
            this.MedicineTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedicineTable.Location = new System.Drawing.Point(3, 53);
            this.MedicineTable.Name = "MedicineTable";
            this.MedicineTable.RowHeadersWidth = 51;
            this.MedicineTable.RowTemplate.Height = 24;
            this.MedicineTable.Size = new System.Drawing.Size(780, 359);
            this.MedicineTable.TabIndex = 0;
            // 
            // MedicineText
            // 
            this.MedicineText.Location = new System.Drawing.Point(460, 3);
            this.MedicineText.Name = "MedicineText";
            this.MedicineText.Size = new System.Drawing.Size(100, 22);
            this.MedicineText.TabIndex = 7;
            this.MedicineText.Text = "MedicineId";
            this.MedicineText.Enter += new System.EventHandler(this.CleanTextOnEnter_Enter);
            this.MedicineText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MedicineIdText_KeyPress);
            this.MedicineText.Leave += new System.EventHandler(this.MedicineIdText_Leave);
            // 
            // PatMed
            // 
            this.PatMed.Controls.Add(this.tableLayoutPanel3);
            this.PatMed.Location = new System.Drawing.Point(4, 25);
            this.PatMed.Name = "PatMed";
            this.PatMed.Size = new System.Drawing.Size(792, 421);
            this.PatMed.TabIndex = 4;
            this.PatMed.Text = "Appointed medicines";
            this.PatMed.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.HOIText, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.PatMedEdit, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.MedText, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.PatText, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.PatMedTable, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(792, 421);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // HOIText
            // 
            this.HOIText.Location = new System.Drawing.Point(466, 3);
            this.HOIText.Name = "HOIText";
            this.HOIText.Size = new System.Drawing.Size(100, 22);
            this.HOIText.TabIndex = 9;
            this.HOIText.Text = "HistoryId";
            this.HOIText.Enter += new System.EventHandler(this.CleanTextOnEnterAM_Enter);
            this.HOIText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HOIText_KeyPress);
            this.HOIText.Leave += new System.EventHandler(this.HistoryIdText_Leave);
            // 
            // PatMedEdit
            // 
            this.PatMedEdit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PatMedEdit.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatMedEdit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PatMedEdit.Location = new System.Drawing.Point(3, 3);
            this.PatMedEdit.Name = "PatMedEdit";
            this.PatMedEdit.Size = new System.Drawing.Size(77, 44);
            this.PatMedEdit.TabIndex = 6;
            this.PatMedEdit.Text = "Edit";
            this.PatMedEdit.UseVisualStyleBackColor = false;
            this.PatMedEdit.Click += new System.EventHandler(this.EditAppointments_Click);
            // 
            // MedText
            // 
            this.MedText.Location = new System.Drawing.Point(686, 3);
            this.MedText.Name = "MedText";
            this.MedText.Size = new System.Drawing.Size(100, 22);
            this.MedText.TabIndex = 9;
            this.MedText.Text = "MedicineId";
            this.MedText.Enter += new System.EventHandler(this.CleanTextOnEnterAM_Enter);
            this.MedText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MedText_KeyPress);
            this.MedText.Leave += new System.EventHandler(this.MedicineIdText_Leave);
            // 
            // PatText
            // 
            this.PatText.Location = new System.Drawing.Point(578, 3);
            this.PatText.Name = "PatText";
            this.PatText.Size = new System.Drawing.Size(100, 22);
            this.PatText.TabIndex = 8;
            this.PatText.Text = "PatientId";
            this.PatText.Enter += new System.EventHandler(this.CleanTextOnEnterAM_Enter);
            this.PatText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatText_KeyPress);
            this.PatText.Leave += new System.EventHandler(this.PatientIdText_Leave);
            // 
            // PatMedTable
            // 
            this.PatMedTable.AutoGenerateColumns = false;
            this.PatMedTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatMedTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PatMedTable.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.PatMedTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatMedTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientidDataGridViewTextBoxColumn,
            this.patientNameDataGridViewTextBoxColumn,
            this.patienSurnameDataGridViewTextBoxColumn,
            this.medicineIdDataGridViewTextBoxColumn1,
            this.medicineNameDataGridViewTextBoxColumn1,
            this.hOIIdDataGridViewTextBoxColumn,
            this.diagnoseDataGridViewTextBoxColumn,
            this.appointmentDateDataGridViewTextBoxColumn});
            this.tableLayoutPanel3.SetColumnSpan(this.PatMedTable, 7);
            this.PatMedTable.DataSource = this.appointedMedsViewBindingSource;
            this.PatMedTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatMedTable.Location = new System.Drawing.Point(3, 53);
            this.PatMedTable.Name = "PatMedTable";
            this.PatMedTable.RowHeadersWidth = 51;
            this.PatMedTable.RowTemplate.Height = 24;
            this.PatMedTable.Size = new System.Drawing.Size(786, 365);
            this.PatMedTable.TabIndex = 0;
            // 
            // Performance
            // 
            this.Performance.Controls.Add(this.tableLayoutPanel4);
            this.Performance.Location = new System.Drawing.Point(4, 25);
            this.Performance.Name = "Performance";
            this.Performance.Padding = new System.Windows.Forms.Padding(3);
            this.Performance.Size = new System.Drawing.Size(792, 421);
            this.Performance.TabIndex = 5;
            this.Performance.Text = "Performance report";
            this.Performance.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel4.Controls.Add(this.PerformanceTable, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.YearBox, 4, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel4.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(786, 415);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // PerformanceTable
            // 
            this.PerformanceTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PerformanceTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PerformanceTable.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.PerformanceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel4.SetColumnSpan(this.PerformanceTable, 5);
            this.PerformanceTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PerformanceTable.Location = new System.Drawing.Point(3, 53);
            this.PerformanceTable.Name = "PerformanceTable";
            this.PerformanceTable.RowHeadersWidth = 51;
            this.PerformanceTable.RowTemplate.Height = 24;
            this.PerformanceTable.Size = new System.Drawing.Size(780, 359);
            this.PerformanceTable.TabIndex = 0;
            // 
            // YearBox
            // 
            this.YearBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearBox.FormattingEnabled = true;
            this.YearBox.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023"});
            this.YearBox.Location = new System.Drawing.Point(658, 3);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(121, 24);
            this.YearBox.TabIndex = 1;
            this.YearBox.SelectedValueChanged += new System.EventHandler(this.YearBox_SelectedValueChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // patientViewBindingSource
            // 
            this.patientViewBindingSource.DataSource = typeof(ClinicApp.Models.ViewModels.PatientView);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // surnameDataGridViewTextBoxColumn1
            // 
            this.surnameDataGridViewTextBoxColumn1.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn1.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn1.Name = "surnameDataGridViewTextBoxColumn1";
            // 
            // specializationDataGridViewTextBoxColumn
            // 
            this.specializationDataGridViewTextBoxColumn.DataPropertyName = "Specialization";
            this.specializationDataGridViewTextBoxColumn.HeaderText = "Specialization";
            this.specializationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specializationDataGridViewTextBoxColumn.Name = "specializationDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // houseDataGridViewTextBoxColumn
            // 
            this.houseDataGridViewTextBoxColumn.DataPropertyName = "House";
            this.houseDataGridViewTextBoxColumn.HeaderText = "House";
            this.houseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.houseDataGridViewTextBoxColumn.Name = "houseDataGridViewTextBoxColumn";
            // 
            // apartmentDataGridViewTextBoxColumn
            // 
            this.apartmentDataGridViewTextBoxColumn.DataPropertyName = "Apartment";
            this.apartmentDataGridViewTextBoxColumn.HeaderText = "Apartment";
            this.apartmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apartmentDataGridViewTextBoxColumn.Name = "apartmentDataGridViewTextBoxColumn";
            // 
            // doctorViewBindingSource
            // 
            this.doctorViewBindingSource.DataSource = typeof(ClinicApp.Models.ViewModels.DoctorView);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // historyOfIllnessBindingSource
            // 
            this.historyOfIllnessBindingSource.DataSource = typeof(ClinicApp.Models.HistoryOfIllness);
            // 
            // medicineIdDataGridViewTextBoxColumn
            // 
            this.medicineIdDataGridViewTextBoxColumn.DataPropertyName = "MedicineId";
            this.medicineIdDataGridViewTextBoxColumn.HeaderText = "MedicineId";
            this.medicineIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicineIdDataGridViewTextBoxColumn.Name = "medicineIdDataGridViewTextBoxColumn";
            // 
            // medicineNameDataGridViewTextBoxColumn
            // 
            this.medicineNameDataGridViewTextBoxColumn.DataPropertyName = "MedicineName";
            this.medicineNameDataGridViewTextBoxColumn.HeaderText = "MedicineName";
            this.medicineNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicineNameDataGridViewTextBoxColumn.Name = "medicineNameDataGridViewTextBoxColumn";
            // 
            // ingredientIdDataGridViewTextBoxColumn
            // 
            this.ingredientIdDataGridViewTextBoxColumn.DataPropertyName = "IngredientId";
            this.ingredientIdDataGridViewTextBoxColumn.HeaderText = "IngredientId";
            this.ingredientIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ingredientIdDataGridViewTextBoxColumn.Name = "ingredientIdDataGridViewTextBoxColumn";
            // 
            // ingredientNameDataGridViewTextBoxColumn
            // 
            this.ingredientNameDataGridViewTextBoxColumn.DataPropertyName = "IngredientName";
            this.ingredientNameDataGridViewTextBoxColumn.HeaderText = "IngredientName";
            this.ingredientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ingredientNameDataGridViewTextBoxColumn.Name = "ingredientNameDataGridViewTextBoxColumn";
            // 
            // compositionIdDataGridViewTextBoxColumn
            // 
            this.compositionIdDataGridViewTextBoxColumn.DataPropertyName = "CompositionId";
            this.compositionIdDataGridViewTextBoxColumn.HeaderText = "CompositionId";
            this.compositionIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.compositionIdDataGridViewTextBoxColumn.Name = "compositionIdDataGridViewTextBoxColumn";
            // 
            // medicineViewBindingSource
            // 
            this.medicineViewBindingSource.DataSource = typeof(ClinicApp.Models.ViewModels.MedicineView);
            // 
            // patientidDataGridViewTextBoxColumn
            // 
            this.patientidDataGridViewTextBoxColumn.DataPropertyName = "Patientid";
            this.patientidDataGridViewTextBoxColumn.HeaderText = "PatientId";
            this.patientidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientidDataGridViewTextBoxColumn.Name = "patientidDataGridViewTextBoxColumn";
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "Patient name";
            this.patientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            // 
            // patienSurnameDataGridViewTextBoxColumn
            // 
            this.patienSurnameDataGridViewTextBoxColumn.DataPropertyName = "PatienSurname";
            this.patienSurnameDataGridViewTextBoxColumn.HeaderText = "Patien surname";
            this.patienSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patienSurnameDataGridViewTextBoxColumn.Name = "patienSurnameDataGridViewTextBoxColumn";
            // 
            // medicineIdDataGridViewTextBoxColumn1
            // 
            this.medicineIdDataGridViewTextBoxColumn1.DataPropertyName = "MedicineId";
            this.medicineIdDataGridViewTextBoxColumn1.HeaderText = "MedicineId";
            this.medicineIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.medicineIdDataGridViewTextBoxColumn1.Name = "medicineIdDataGridViewTextBoxColumn1";
            // 
            // medicineNameDataGridViewTextBoxColumn1
            // 
            this.medicineNameDataGridViewTextBoxColumn1.DataPropertyName = "MedicineName";
            this.medicineNameDataGridViewTextBoxColumn1.HeaderText = "Medicine name";
            this.medicineNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.medicineNameDataGridViewTextBoxColumn1.Name = "medicineNameDataGridViewTextBoxColumn1";
            // 
            // hOIIdDataGridViewTextBoxColumn
            // 
            this.hOIIdDataGridViewTextBoxColumn.DataPropertyName = "HOIId";
            this.hOIIdDataGridViewTextBoxColumn.HeaderText = "HistoryId";
            this.hOIIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hOIIdDataGridViewTextBoxColumn.Name = "hOIIdDataGridViewTextBoxColumn";
            // 
            // diagnoseDataGridViewTextBoxColumn
            // 
            this.diagnoseDataGridViewTextBoxColumn.DataPropertyName = "Diagnose";
            this.diagnoseDataGridViewTextBoxColumn.HeaderText = "Diagnose";
            this.diagnoseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diagnoseDataGridViewTextBoxColumn.Name = "diagnoseDataGridViewTextBoxColumn";
            // 
            // appointmentDateDataGridViewTextBoxColumn
            // 
            this.appointmentDateDataGridViewTextBoxColumn.DataPropertyName = "AppointmentDate";
            this.appointmentDateDataGridViewTextBoxColumn.HeaderText = "Appointment date";
            this.appointmentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appointmentDateDataGridViewTextBoxColumn.Name = "appointmentDateDataGridViewTextBoxColumn";
            // 
            // appointedMedsViewBindingSource
            // 
            this.appointedMedsViewBindingSource.DataSource = typeof(ClinicApp.Models.ViewModels.AppointedMedsView);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(ClinicApp.Models.Patient);
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(ClinicApp.Models.Doctor);
            // 
            // ClinicAppMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClinicTabs);
            this.Name = "ClinicAppMain";
            this.Text = "ClinicApp";
            this.ClinicTabs.ResumeLayout(false);
            this.Patients.ResumeLayout(false);
            this.Patients.PerformLayout();
            this.Patientslayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsTable)).EndInit();
            this.Doctors.ResumeLayout(false);
            this.Doctors.PerformLayout();
            this.DoctorLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsTable)).EndInit();
            this.HOI.ResumeLayout(false);
            this.HOI.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HOITable)).EndInit();
            this.Medicines.ResumeLayout(false);
            this.Medicines.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineTable)).EndInit();
            this.PatMed.ResumeLayout(false);
            this.PatMed.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatMedTable)).EndInit();
            this.Performance.ResumeLayout(false);
            this.Performance.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyOfIllnessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointedMedsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ClinicTabs;
        private System.Windows.Forms.TabPage Patients;
        private System.Windows.Forms.TabPage Doctors;
        private System.Windows.Forms.TableLayoutPanel Patientslayout;
        private System.Windows.Forms.DataGridView PatientsTable;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.Button DeletePatients;
        private System.Windows.Forms.Button SavePatients;
        private System.Windows.Forms.Button RefreshPatients;
        private System.Windows.Forms.BindingSource patientViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn House;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apartment;
        private System.Windows.Forms.TableLayoutPanel DoctorLayout;
        private System.Windows.Forms.DataGridView DoctorsTable;
        private System.Windows.Forms.Button SaveDoctors;
        private System.Windows.Forms.Button DeleteDoctors;
        private System.Windows.Forms.Button RefreshDoctors;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.BindingSource doctorViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage HOI;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView HOITable;
        private System.Windows.Forms.Button SaveHOI;
        private System.Windows.Forms.Button DeleteHOI;
        private System.Windows.Forms.Button RefreshHOI;
        private System.Windows.Forms.TextBox PatientIdText;
        private System.Windows.Forms.TextBox DoctorIdText;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn End;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Characteristic;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OnSpecialCount;
        private System.Windows.Forms.BindingSource historyOfIllnessBindingSource;
        private System.Windows.Forms.TabPage Medicines;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox IngredientText;
        private System.Windows.Forms.TextBox MedicineText;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compositionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource medicineViewBindingSource;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox CompositionText;
        public System.Windows.Forms.DataGridView MedicineTable;
        private System.Windows.Forms.TabPage PatMed;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button PatMedEdit;
        private System.Windows.Forms.TextBox MedText;
        private System.Windows.Forms.TextBox PatText;
        public System.Windows.Forms.DataGridView PatMedTable;
        private System.Windows.Forms.TextBox HOIText;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patienSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOIIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnoseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource appointedMedsViewBindingSource;
        private System.Windows.Forms.TextBox DateText;
        private System.Windows.Forms.TabPage Performance;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView PerformanceTable;
        private System.Windows.Forms.ComboBox YearBox;
    }
}

