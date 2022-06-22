namespace ClinicApp.Pages
{
    partial class AppointmentsTech
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
            this.MedTabs = new System.Windows.Forms.TabControl();
            this.Appointments = new System.Windows.Forms.TabPage();
            this.Patientslayout = new System.Windows.Forms.TableLayoutPanel();
            this.AppTable = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyOfIllnessIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaveApp = new System.Windows.Forms.Button();
            this.DeleteApp = new System.Windows.Forms.Button();
            this.RefreshApp = new System.Windows.Forms.Button();
            this.AppointmentDetails = new System.Windows.Forms.TabPage();
            this.DoctorLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AppDetTable = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaveAppDet = new System.Windows.Forms.Button();
            this.DeleteAppDet = new System.Windows.Forms.Button();
            this.RefreshAppDet = new System.Windows.Forms.Button();
            this.Contraindication = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ContrTable = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraindicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaveContr = new System.Windows.Forms.Button();
            this.DeleteContr = new System.Windows.Forms.Button();
            this.RefreshContr = new System.Windows.Forms.Button();
            this.MedTabs.SuspendLayout();
            this.Appointments.SuspendLayout();
            this.Patientslayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.AppointmentDetails.SuspendLayout();
            this.DoctorLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppDetTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDetailsBindingSource)).BeginInit();
            this.Contraindication.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContrTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contraindicationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MedTabs
            // 
            this.MedTabs.Controls.Add(this.Appointments);
            this.MedTabs.Controls.Add(this.AppointmentDetails);
            this.MedTabs.Controls.Add(this.Contraindication);
            this.MedTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedTabs.Location = new System.Drawing.Point(0, 0);
            this.MedTabs.Name = "MedTabs";
            this.MedTabs.SelectedIndex = 0;
            this.MedTabs.Size = new System.Drawing.Size(800, 450);
            this.MedTabs.TabIndex = 2;
            // 
            // Appointments
            // 
            this.Appointments.Controls.Add(this.Patientslayout);
            this.Appointments.Location = new System.Drawing.Point(4, 25);
            this.Appointments.Name = "Appointments";
            this.Appointments.Padding = new System.Windows.Forms.Padding(3);
            this.Appointments.Size = new System.Drawing.Size(792, 421);
            this.Appointments.TabIndex = 0;
            this.Appointments.Text = "Appointments";
            this.Appointments.UseVisualStyleBackColor = true;
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
            this.Patientslayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Patientslayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Patientslayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Patientslayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Patientslayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Patientslayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Patientslayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Patientslayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Patientslayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Patientslayout.Controls.Add(this.AppTable, 0, 1);
            this.Patientslayout.Controls.Add(this.SaveApp, 0, 0);
            this.Patientslayout.Controls.Add(this.DeleteApp, 1, 0);
            this.Patientslayout.Controls.Add(this.RefreshApp, 2, 0);
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
            // AppTable
            // 
            this.AppTable.AutoGenerateColumns = false;
            this.AppTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AppTable.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.AppTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.appointmentDateDataGridViewTextBoxColumn,
            this.historyOfIllnessIdDataGridViewTextBoxColumn});
            this.Patientslayout.SetColumnSpan(this.AppTable, 5);
            this.AppTable.DataSource = this.appointmentBindingSource;
            this.AppTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppTable.Location = new System.Drawing.Point(3, 53);
            this.AppTable.Name = "AppTable";
            this.AppTable.RowHeadersWidth = 51;
            this.AppTable.RowTemplate.Height = 24;
            this.AppTable.Size = new System.Drawing.Size(780, 359);
            this.AppTable.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // appointmentDateDataGridViewTextBoxColumn
            // 
            this.appointmentDateDataGridViewTextBoxColumn.DataPropertyName = "AppointmentDate";
            this.appointmentDateDataGridViewTextBoxColumn.HeaderText = "AppointmentDate";
            this.appointmentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appointmentDateDataGridViewTextBoxColumn.Name = "appointmentDateDataGridViewTextBoxColumn";
            // 
            // historyOfIllnessIdDataGridViewTextBoxColumn
            // 
            this.historyOfIllnessIdDataGridViewTextBoxColumn.DataPropertyName = "HistoryOfIllnessId";
            this.historyOfIllnessIdDataGridViewTextBoxColumn.HeaderText = "HistoryOfIllnessId";
            this.historyOfIllnessIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.historyOfIllnessIdDataGridViewTextBoxColumn.Name = "historyOfIllnessIdDataGridViewTextBoxColumn";
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(ClinicApp.Models.Appointment);
            // 
            // SaveApp
            // 
            this.SaveApp.BackColor = System.Drawing.Color.Teal;
            this.SaveApp.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveApp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveApp.Location = new System.Drawing.Point(3, 3);
            this.SaveApp.Name = "SaveApp";
            this.SaveApp.Size = new System.Drawing.Size(77, 44);
            this.SaveApp.TabIndex = 4;
            this.SaveApp.Text = "Save";
            this.SaveApp.UseVisualStyleBackColor = false;
            this.SaveApp.Click += new System.EventHandler(this.SaveAppo_Click);
            // 
            // DeleteApp
            // 
            this.DeleteApp.BackColor = System.Drawing.Color.OrangeRed;
            this.DeleteApp.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteApp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeleteApp.Location = new System.Drawing.Point(86, 3);
            this.DeleteApp.Name = "DeleteApp";
            this.DeleteApp.Size = new System.Drawing.Size(76, 44);
            this.DeleteApp.TabIndex = 3;
            this.DeleteApp.Text = "Delete";
            this.DeleteApp.UseVisualStyleBackColor = false;
            this.DeleteApp.Click += new System.EventHandler(this.DeleteAppo_Click);
            // 
            // RefreshApp
            // 
            this.RefreshApp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RefreshApp.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshApp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RefreshApp.Location = new System.Drawing.Point(168, 3);
            this.RefreshApp.Name = "RefreshApp";
            this.RefreshApp.Size = new System.Drawing.Size(77, 44);
            this.RefreshApp.TabIndex = 5;
            this.RefreshApp.Text = "Refresh";
            this.RefreshApp.UseVisualStyleBackColor = false;
            this.RefreshApp.Click += new System.EventHandler(this.RefreshAppo_Click);
            // 
            // AppointmentDetails
            // 
            this.AppointmentDetails.Controls.Add(this.DoctorLayout);
            this.AppointmentDetails.Location = new System.Drawing.Point(4, 25);
            this.AppointmentDetails.Name = "AppointmentDetails";
            this.AppointmentDetails.Padding = new System.Windows.Forms.Padding(3);
            this.AppointmentDetails.Size = new System.Drawing.Size(792, 421);
            this.AppointmentDetails.TabIndex = 1;
            this.AppointmentDetails.Text = "Appointment details";
            this.AppointmentDetails.UseVisualStyleBackColor = true;
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
            this.DoctorLayout.Controls.Add(this.AppDetTable, 0, 1);
            this.DoctorLayout.Controls.Add(this.SaveAppDet, 0, 0);
            this.DoctorLayout.Controls.Add(this.DeleteAppDet, 1, 0);
            this.DoctorLayout.Controls.Add(this.RefreshAppDet, 2, 0);
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
            // AppDetTable
            // 
            this.AppDetTable.AutoGenerateColumns = false;
            this.AppDetTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppDetTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AppDetTable.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.AppDetTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppDetTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.medicineIdDataGridViewTextBoxColumn,
            this.appointmentIdDataGridViewTextBoxColumn});
            this.DoctorLayout.SetColumnSpan(this.AppDetTable, 5);
            this.AppDetTable.DataSource = this.appointmentDetailsBindingSource;
            this.AppDetTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppDetTable.Location = new System.Drawing.Point(3, 53);
            this.AppDetTable.Name = "AppDetTable";
            this.AppDetTable.RowHeadersWidth = 51;
            this.AppDetTable.RowTemplate.Height = 24;
            this.AppDetTable.Size = new System.Drawing.Size(780, 359);
            this.AppDetTable.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // medicineIdDataGridViewTextBoxColumn
            // 
            this.medicineIdDataGridViewTextBoxColumn.DataPropertyName = "MedicineId";
            this.medicineIdDataGridViewTextBoxColumn.HeaderText = "MedicineId";
            this.medicineIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicineIdDataGridViewTextBoxColumn.Name = "medicineIdDataGridViewTextBoxColumn";
            // 
            // appointmentIdDataGridViewTextBoxColumn
            // 
            this.appointmentIdDataGridViewTextBoxColumn.DataPropertyName = "AppointmentId";
            this.appointmentIdDataGridViewTextBoxColumn.HeaderText = "AppointmentId";
            this.appointmentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appointmentIdDataGridViewTextBoxColumn.Name = "appointmentIdDataGridViewTextBoxColumn";
            // 
            // appointmentDetailsBindingSource
            // 
            this.appointmentDetailsBindingSource.DataSource = typeof(ClinicApp.Models.AppointmentDetails);
            // 
            // SaveAppDet
            // 
            this.SaveAppDet.BackColor = System.Drawing.Color.Teal;
            this.SaveAppDet.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveAppDet.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveAppDet.Location = new System.Drawing.Point(3, 3);
            this.SaveAppDet.Name = "SaveAppDet";
            this.SaveAppDet.Size = new System.Drawing.Size(77, 44);
            this.SaveAppDet.TabIndex = 4;
            this.SaveAppDet.Text = "Save";
            this.SaveAppDet.UseVisualStyleBackColor = false;
            this.SaveAppDet.Click += new System.EventHandler(this.SaveAppoDet_Click);
            // 
            // DeleteAppDet
            // 
            this.DeleteAppDet.BackColor = System.Drawing.Color.OrangeRed;
            this.DeleteAppDet.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteAppDet.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeleteAppDet.Location = new System.Drawing.Point(86, 3);
            this.DeleteAppDet.Name = "DeleteAppDet";
            this.DeleteAppDet.Size = new System.Drawing.Size(76, 44);
            this.DeleteAppDet.TabIndex = 3;
            this.DeleteAppDet.Text = "Delete";
            this.DeleteAppDet.UseVisualStyleBackColor = false;
            this.DeleteAppDet.Click += new System.EventHandler(this.DeleteAppoDet_Click);
            // 
            // RefreshAppDet
            // 
            this.RefreshAppDet.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RefreshAppDet.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshAppDet.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RefreshAppDet.Location = new System.Drawing.Point(168, 3);
            this.RefreshAppDet.Name = "RefreshAppDet";
            this.RefreshAppDet.Size = new System.Drawing.Size(77, 44);
            this.RefreshAppDet.TabIndex = 5;
            this.RefreshAppDet.Text = "Refresh";
            this.RefreshAppDet.UseVisualStyleBackColor = false;
            this.RefreshAppDet.Click += new System.EventHandler(this.RefreshAppoDet_Click);
            // 
            // Contraindication
            // 
            this.Contraindication.Controls.Add(this.tableLayoutPanel1);
            this.Contraindication.Location = new System.Drawing.Point(4, 25);
            this.Contraindication.Name = "Contraindication";
            this.Contraindication.Size = new System.Drawing.Size(792, 421);
            this.Contraindication.TabIndex = 2;
            this.Contraindication.Text = "Contraindication";
            this.Contraindication.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.Controls.Add(this.ContrTable, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SaveContr, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DeleteContr, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RefreshContr, 2, 0);
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
            // ContrTable
            // 
            this.ContrTable.AutoGenerateColumns = false;
            this.ContrTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ContrTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ContrTable.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.ContrTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContrTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.patientIdDataGridViewTextBoxColumn,
            this.medicineIdDataGridViewTextBoxColumn1});
            this.tableLayoutPanel1.SetColumnSpan(this.ContrTable, 6);
            this.ContrTable.DataSource = this.contraindicationBindingSource;
            this.ContrTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContrTable.Location = new System.Drawing.Point(3, 53);
            this.ContrTable.Name = "ContrTable";
            this.ContrTable.RowHeadersWidth = 51;
            this.ContrTable.RowTemplate.Height = 24;
            this.ContrTable.Size = new System.Drawing.Size(786, 365);
            this.ContrTable.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            // 
            // patientIdDataGridViewTextBoxColumn
            // 
            this.patientIdDataGridViewTextBoxColumn.DataPropertyName = "PatientId";
            this.patientIdDataGridViewTextBoxColumn.HeaderText = "PatientId";
            this.patientIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientIdDataGridViewTextBoxColumn.Name = "patientIdDataGridViewTextBoxColumn";
            // 
            // medicineIdDataGridViewTextBoxColumn1
            // 
            this.medicineIdDataGridViewTextBoxColumn1.DataPropertyName = "MedicineId";
            this.medicineIdDataGridViewTextBoxColumn1.HeaderText = "MedicineId";
            this.medicineIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.medicineIdDataGridViewTextBoxColumn1.Name = "medicineIdDataGridViewTextBoxColumn1";
            // 
            // contraindicationBindingSource
            // 
            this.contraindicationBindingSource.DataSource = typeof(ClinicApp.Models.Contraindication);
            // 
            // SaveContr
            // 
            this.SaveContr.BackColor = System.Drawing.Color.Teal;
            this.SaveContr.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveContr.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveContr.Location = new System.Drawing.Point(3, 3);
            this.SaveContr.Name = "SaveContr";
            this.SaveContr.Size = new System.Drawing.Size(77, 44);
            this.SaveContr.TabIndex = 4;
            this.SaveContr.Text = "Save";
            this.SaveContr.UseVisualStyleBackColor = false;
            this.SaveContr.Click += new System.EventHandler(this.SaveContr_Click);
            // 
            // DeleteContr
            // 
            this.DeleteContr.BackColor = System.Drawing.Color.OrangeRed;
            this.DeleteContr.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteContr.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeleteContr.Location = new System.Drawing.Point(86, 3);
            this.DeleteContr.Name = "DeleteContr";
            this.DeleteContr.Size = new System.Drawing.Size(76, 44);
            this.DeleteContr.TabIndex = 3;
            this.DeleteContr.Text = "Delete";
            this.DeleteContr.UseVisualStyleBackColor = false;
            this.DeleteContr.Click += new System.EventHandler(this.DeleteContr_Click);
            // 
            // RefreshContr
            // 
            this.RefreshContr.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RefreshContr.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshContr.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RefreshContr.Location = new System.Drawing.Point(168, 3);
            this.RefreshContr.Name = "RefreshContr";
            this.RefreshContr.Size = new System.Drawing.Size(77, 44);
            this.RefreshContr.TabIndex = 5;
            this.RefreshContr.Text = "Refresh";
            this.RefreshContr.UseVisualStyleBackColor = false;
            this.RefreshContr.Click += new System.EventHandler(this.RefreshContr_Click);
            // 
            // AppointmentsTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MedTabs);
            this.Name = "AppointmentsTech";
            this.Text = "AppointmentsTech";
            this.MedTabs.ResumeLayout(false);
            this.Appointments.ResumeLayout(false);
            this.Appointments.PerformLayout();
            this.Patientslayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.AppointmentDetails.ResumeLayout(false);
            this.AppointmentDetails.PerformLayout();
            this.DoctorLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppDetTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDetailsBindingSource)).EndInit();
            this.Contraindication.ResumeLayout(false);
            this.Contraindication.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContrTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contraindicationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MedTabs;
        private System.Windows.Forms.TabPage Appointments;
        private System.Windows.Forms.TableLayoutPanel Patientslayout;
        private System.Windows.Forms.DataGridView AppTable;
        private System.Windows.Forms.Button SaveApp;
        private System.Windows.Forms.Button DeleteApp;
        private System.Windows.Forms.Button RefreshApp;
        private System.Windows.Forms.TabPage AppointmentDetails;
        private System.Windows.Forms.TableLayoutPanel DoctorLayout;
        private System.Windows.Forms.DataGridView AppDetTable;
        private System.Windows.Forms.Button SaveAppDet;
        private System.Windows.Forms.Button DeleteAppDet;
        private System.Windows.Forms.Button RefreshAppDet;
        private System.Windows.Forms.TabPage Contraindication;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView ContrTable;
        private System.Windows.Forms.Button SaveContr;
        private System.Windows.Forms.Button DeleteContr;
        private System.Windows.Forms.Button RefreshContr;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historyOfIllnessIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource appointmentDetailsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource contraindicationBindingSource;
    }
}