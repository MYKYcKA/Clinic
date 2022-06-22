namespace ClinicApp.Pages
{
    partial class MedicineTech
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
            this.Composition = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CompTable = new System.Windows.Forms.DataGridView();
            this.SaveComp = new System.Windows.Forms.Button();
            this.DeleteComp = new System.Windows.Forms.Button();
            this.RefreshComp = new System.Windows.Forms.Button();
            this.Ingredient = new System.Windows.Forms.TabPage();
            this.DoctorLayout = new System.Windows.Forms.TableLayoutPanel();
            this.IngTable = new System.Windows.Forms.DataGridView();
            this.SaveIngredient = new System.Windows.Forms.Button();
            this.DeleteIngredient = new System.Windows.Forms.Button();
            this.RefreshIngredient = new System.Windows.Forms.Button();
            this.Medicine = new System.Windows.Forms.TabPage();
            this.Patientslayout = new System.Windows.Forms.TableLayoutPanel();
            this.MedTable = new System.Windows.Forms.DataGridView();
            this.SaveMedicine = new System.Windows.Forms.Button();
            this.DeleteMedicine = new System.Windows.Forms.Button();
            this.RefreshMedicine = new System.Windows.Forms.Button();
            this.MedTabs = new System.Windows.Forms.TabControl();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Composition.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompTable)).BeginInit();
            this.Ingredient.SuspendLayout();
            this.DoctorLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IngTable)).BeginInit();
            this.Medicine.SuspendLayout();
            this.Patientslayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedTable)).BeginInit();
            this.MedTabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Composition
            // 
            this.Composition.Controls.Add(this.tableLayoutPanel1);
            this.Composition.Location = new System.Drawing.Point(4, 25);
            this.Composition.Name = "Composition";
            this.Composition.Size = new System.Drawing.Size(792, 421);
            this.Composition.TabIndex = 2;
            this.Composition.Text = "Composition";
            this.Composition.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.Controls.Add(this.CompTable, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SaveComp, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DeleteComp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RefreshComp, 2, 0);
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
            // CompTable
            // 
            this.CompTable.AutoGenerateColumns = false;
            this.CompTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CompTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CompTable.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.CompTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ingredientIdDataGridViewTextBoxColumn,
            this.medicineIdDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.CompTable, 6);
            this.CompTable.DataSource = this.compositionBindingSource;
            this.CompTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompTable.Location = new System.Drawing.Point(3, 53);
            this.CompTable.Name = "CompTable";
            this.CompTable.RowHeadersWidth = 51;
            this.CompTable.RowTemplate.Height = 24;
            this.CompTable.Size = new System.Drawing.Size(786, 365);
            this.CompTable.TabIndex = 0;
            // 
            // SaveComp
            // 
            this.SaveComp.BackColor = System.Drawing.Color.Teal;
            this.SaveComp.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveComp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveComp.Location = new System.Drawing.Point(3, 3);
            this.SaveComp.Name = "SaveComp";
            this.SaveComp.Size = new System.Drawing.Size(77, 44);
            this.SaveComp.TabIndex = 4;
            this.SaveComp.Text = "Save";
            this.SaveComp.UseVisualStyleBackColor = false;
            this.SaveComp.Click += new System.EventHandler(this.SaveComp_Click);
            // 
            // DeleteComp
            // 
            this.DeleteComp.BackColor = System.Drawing.Color.OrangeRed;
            this.DeleteComp.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteComp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeleteComp.Location = new System.Drawing.Point(86, 3);
            this.DeleteComp.Name = "DeleteComp";
            this.DeleteComp.Size = new System.Drawing.Size(76, 44);
            this.DeleteComp.TabIndex = 3;
            this.DeleteComp.Text = "Delete";
            this.DeleteComp.UseVisualStyleBackColor = false;
            this.DeleteComp.Click += new System.EventHandler(this.DeleteComp_Click);
            // 
            // RefreshComp
            // 
            this.RefreshComp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RefreshComp.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshComp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RefreshComp.Location = new System.Drawing.Point(168, 3);
            this.RefreshComp.Name = "RefreshComp";
            this.RefreshComp.Size = new System.Drawing.Size(77, 44);
            this.RefreshComp.TabIndex = 5;
            this.RefreshComp.Text = "Refresh";
            this.RefreshComp.UseVisualStyleBackColor = false;
            this.RefreshComp.Click += new System.EventHandler(this.RefreshComp_Click);
            // 
            // Ingredient
            // 
            this.Ingredient.Controls.Add(this.DoctorLayout);
            this.Ingredient.Location = new System.Drawing.Point(4, 25);
            this.Ingredient.Name = "Ingredient";
            this.Ingredient.Padding = new System.Windows.Forms.Padding(3);
            this.Ingredient.Size = new System.Drawing.Size(792, 421);
            this.Ingredient.TabIndex = 1;
            this.Ingredient.Text = "Ingredient";
            this.Ingredient.UseVisualStyleBackColor = true;
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
            this.DoctorLayout.Controls.Add(this.IngTable, 0, 1);
            this.DoctorLayout.Controls.Add(this.SaveIngredient, 0, 0);
            this.DoctorLayout.Controls.Add(this.DeleteIngredient, 1, 0);
            this.DoctorLayout.Controls.Add(this.RefreshIngredient, 2, 0);
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
            // IngTable
            // 
            this.IngTable.AutoGenerateColumns = false;
            this.IngTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.IngTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.IngTable.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.IngTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn});
            this.DoctorLayout.SetColumnSpan(this.IngTable, 5);
            this.IngTable.DataSource = this.ingredientsBindingSource;
            this.IngTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IngTable.Location = new System.Drawing.Point(3, 53);
            this.IngTable.Name = "IngTable";
            this.IngTable.RowHeadersWidth = 51;
            this.IngTable.RowTemplate.Height = 24;
            this.IngTable.Size = new System.Drawing.Size(780, 359);
            this.IngTable.TabIndex = 0;
            // 
            // SaveIngredient
            // 
            this.SaveIngredient.BackColor = System.Drawing.Color.Teal;
            this.SaveIngredient.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveIngredient.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveIngredient.Location = new System.Drawing.Point(3, 3);
            this.SaveIngredient.Name = "SaveIngredient";
            this.SaveIngredient.Size = new System.Drawing.Size(77, 44);
            this.SaveIngredient.TabIndex = 4;
            this.SaveIngredient.Text = "Save";
            this.SaveIngredient.UseVisualStyleBackColor = false;
            this.SaveIngredient.Click += new System.EventHandler(this.SaveIng_Click);
            // 
            // DeleteIngredient
            // 
            this.DeleteIngredient.BackColor = System.Drawing.Color.OrangeRed;
            this.DeleteIngredient.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteIngredient.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeleteIngredient.Location = new System.Drawing.Point(86, 3);
            this.DeleteIngredient.Name = "DeleteIngredient";
            this.DeleteIngredient.Size = new System.Drawing.Size(76, 44);
            this.DeleteIngredient.TabIndex = 3;
            this.DeleteIngredient.Text = "Delete";
            this.DeleteIngredient.UseVisualStyleBackColor = false;
            this.DeleteIngredient.Click += new System.EventHandler(this.DeleteIng_Click);
            // 
            // RefreshIngredient
            // 
            this.RefreshIngredient.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RefreshIngredient.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshIngredient.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RefreshIngredient.Location = new System.Drawing.Point(168, 3);
            this.RefreshIngredient.Name = "RefreshIngredient";
            this.RefreshIngredient.Size = new System.Drawing.Size(77, 44);
            this.RefreshIngredient.TabIndex = 5;
            this.RefreshIngredient.Text = "Refresh";
            this.RefreshIngredient.UseVisualStyleBackColor = false;
            this.RefreshIngredient.Click += new System.EventHandler(this.RefreshIng_Click);
            // 
            // Medicine
            // 
            this.Medicine.Controls.Add(this.Patientslayout);
            this.Medicine.Location = new System.Drawing.Point(4, 25);
            this.Medicine.Name = "Medicine";
            this.Medicine.Padding = new System.Windows.Forms.Padding(3);
            this.Medicine.Size = new System.Drawing.Size(792, 421);
            this.Medicine.TabIndex = 0;
            this.Medicine.Text = "Medicine";
            this.Medicine.UseVisualStyleBackColor = true;
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
            this.Patientslayout.Controls.Add(this.MedTable, 0, 1);
            this.Patientslayout.Controls.Add(this.SaveMedicine, 0, 0);
            this.Patientslayout.Controls.Add(this.DeleteMedicine, 1, 0);
            this.Patientslayout.Controls.Add(this.RefreshMedicine, 2, 0);
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
            // MedTable
            // 
            this.MedTable.AutoGenerateColumns = false;
            this.MedTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MedTable.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.MedTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn1});
            this.Patientslayout.SetColumnSpan(this.MedTable, 5);
            this.MedTable.DataSource = this.medicinesBindingSource;
            this.MedTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedTable.Location = new System.Drawing.Point(3, 53);
            this.MedTable.Name = "MedTable";
            this.MedTable.RowHeadersWidth = 51;
            this.MedTable.RowTemplate.Height = 24;
            this.MedTable.Size = new System.Drawing.Size(780, 359);
            this.MedTable.TabIndex = 0;
            // 
            // SaveMedicine
            // 
            this.SaveMedicine.BackColor = System.Drawing.Color.Teal;
            this.SaveMedicine.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveMedicine.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveMedicine.Location = new System.Drawing.Point(3, 3);
            this.SaveMedicine.Name = "SaveMedicine";
            this.SaveMedicine.Size = new System.Drawing.Size(77, 44);
            this.SaveMedicine.TabIndex = 4;
            this.SaveMedicine.Text = "Save";
            this.SaveMedicine.UseVisualStyleBackColor = false;
            this.SaveMedicine.Click += new System.EventHandler(this.SaveMed_Click);
            // 
            // DeleteMedicine
            // 
            this.DeleteMedicine.BackColor = System.Drawing.Color.OrangeRed;
            this.DeleteMedicine.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteMedicine.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeleteMedicine.Location = new System.Drawing.Point(86, 3);
            this.DeleteMedicine.Name = "DeleteMedicine";
            this.DeleteMedicine.Size = new System.Drawing.Size(76, 44);
            this.DeleteMedicine.TabIndex = 3;
            this.DeleteMedicine.Text = "Delete";
            this.DeleteMedicine.UseVisualStyleBackColor = false;
            this.DeleteMedicine.Click += new System.EventHandler(this.DeleteMed_Click);
            // 
            // RefreshMedicine
            // 
            this.RefreshMedicine.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RefreshMedicine.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshMedicine.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RefreshMedicine.Location = new System.Drawing.Point(168, 3);
            this.RefreshMedicine.Name = "RefreshMedicine";
            this.RefreshMedicine.Size = new System.Drawing.Size(77, 44);
            this.RefreshMedicine.TabIndex = 5;
            this.RefreshMedicine.Text = "Refresh";
            this.RefreshMedicine.UseVisualStyleBackColor = false;
            this.RefreshMedicine.Click += new System.EventHandler(this.RefreshMed_Click);
            // 
            // MedTabs
            // 
            this.MedTabs.Controls.Add(this.Medicine);
            this.MedTabs.Controls.Add(this.Ingredient);
            this.MedTabs.Controls.Add(this.Composition);
            this.MedTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedTabs.Location = new System.Drawing.Point(0, 0);
            this.MedTabs.Name = "MedTabs";
            this.MedTabs.SelectedIndex = 0;
            this.MedTabs.Size = new System.Drawing.Size(800, 450);
            this.MedTabs.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // medicinesBindingSource
            // 
            this.medicinesBindingSource.DataSource = typeof(ClinicApp.Models.Medicines);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ingredientsBindingSource
            // 
            this.ingredientsBindingSource.DataSource = typeof(ClinicApp.Models.Ingredients);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // ingredientIdDataGridViewTextBoxColumn
            // 
            this.ingredientIdDataGridViewTextBoxColumn.DataPropertyName = "IngredientId";
            this.ingredientIdDataGridViewTextBoxColumn.HeaderText = "IngredientId";
            this.ingredientIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ingredientIdDataGridViewTextBoxColumn.Name = "ingredientIdDataGridViewTextBoxColumn";
            // 
            // medicineIdDataGridViewTextBoxColumn
            // 
            this.medicineIdDataGridViewTextBoxColumn.DataPropertyName = "MedicineId";
            this.medicineIdDataGridViewTextBoxColumn.HeaderText = "MedicineId";
            this.medicineIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicineIdDataGridViewTextBoxColumn.Name = "medicineIdDataGridViewTextBoxColumn";
            // 
            // compositionBindingSource
            // 
            this.compositionBindingSource.DataSource = typeof(ClinicApp.Models.Composition);
            // 
            // MedicineTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MedTabs);
            this.Name = "MedicineTech";
            this.Text = "MedicineTech";
            this.Composition.ResumeLayout(false);
            this.Composition.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompTable)).EndInit();
            this.Ingredient.ResumeLayout(false);
            this.Ingredient.PerformLayout();
            this.DoctorLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IngTable)).EndInit();
            this.Medicine.ResumeLayout(false);
            this.Medicine.PerformLayout();
            this.Patientslayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MedTable)).EndInit();
            this.MedTabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Composition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView CompTable;
        private System.Windows.Forms.Button SaveComp;
        private System.Windows.Forms.Button DeleteComp;
        private System.Windows.Forms.Button RefreshComp;
        private System.Windows.Forms.TabPage Ingredient;
        private System.Windows.Forms.TableLayoutPanel DoctorLayout;
        private System.Windows.Forms.DataGridView IngTable;
        private System.Windows.Forms.Button SaveIngredient;
        private System.Windows.Forms.Button DeleteIngredient;
        private System.Windows.Forms.Button RefreshIngredient;
        private System.Windows.Forms.TabPage Medicine;
        private System.Windows.Forms.TableLayoutPanel Patientslayout;
        private System.Windows.Forms.DataGridView MedTable;
        private System.Windows.Forms.Button SaveMedicine;
        private System.Windows.Forms.Button DeleteMedicine;
        private System.Windows.Forms.Button RefreshMedicine;
        private System.Windows.Forms.TabControl MedTabs;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource compositionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ingredientsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource medicinesBindingSource;
    }
}