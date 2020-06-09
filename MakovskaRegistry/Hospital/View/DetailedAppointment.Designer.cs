namespace Hospital.View
{
    partial class DetailedAppointment
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxCardNumb = new System.Windows.Forms.TextBox();
            this.labelCardApp = new System.Windows.Forms.Label();
            this.dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.textBoxDateTime = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.listBoxServises = new System.Windows.Forms.ListBox();
            this.labelDoctorInfo = new System.Windows.Forms.Label();
            this.labelPatientInfo = new System.Windows.Forms.Label();
            this.DetailsDoctor = new System.Windows.Forms.Button();
            this.DetailsPatient = new System.Windows.Forms.Button();
            this.groupBoxGeneralData = new System.Windows.Forms.GroupBox();
            this.labelPrise = new System.Windows.Forms.Label();
            this.textBoxPrise = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.groupBoxGeneralData.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(223, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(382, 25);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Детальна інформація про запис";
            // 
            // textBoxCardNumb
            // 
            this.textBoxCardNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCardNumb.Location = new System.Drawing.Point(193, 29);
            this.textBoxCardNumb.Name = "textBoxCardNumb";
            this.textBoxCardNumb.ReadOnly = true;
            this.textBoxCardNumb.Size = new System.Drawing.Size(132, 22);
            this.textBoxCardNumb.TabIndex = 10;
            // 
            // labelCardApp
            // 
            this.labelCardApp.AutoSize = true;
            this.labelCardApp.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCardApp.Location = new System.Drawing.Point(6, 31);
            this.labelCardApp.Name = "labelCardApp";
            this.labelCardApp.Size = new System.Drawing.Size(145, 20);
            this.labelCardApp.TabIndex = 9;
            this.labelCardApp.Text = "Номер зустрічі:";
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.AllowUserToAddRows = false;
            this.dataGridViewDoctors.AllowUserToDeleteRows = false;
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors.Location = new System.Drawing.Point(12, 118);
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.ReadOnly = true;
            this.dataGridViewDoctors.RowHeadersVisible = false;
            this.dataGridViewDoctors.RowHeadersWidth = 51;
            this.dataGridViewDoctors.RowTemplate.Height = 24;
            this.dataGridViewDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDoctors.Size = new System.Drawing.Size(384, 60);
            this.dataGridViewDoctors.TabIndex = 12;
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AllowUserToAddRows = false;
            this.dataGridViewPatients.AllowUserToDeleteRows = false;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Location = new System.Drawing.Point(426, 118);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            this.dataGridViewPatients.RowHeadersVisible = false;
            this.dataGridViewPatients.RowHeadersWidth = 51;
            this.dataGridViewPatients.RowTemplate.Height = 24;
            this.dataGridViewPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatients.Size = new System.Drawing.Size(388, 60);
            this.dataGridViewPatients.TabIndex = 13;
            // 
            // textBoxDateTime
            // 
            this.textBoxDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDateTime.Location = new System.Drawing.Point(193, 63);
            this.textBoxDateTime.Name = "textBoxDateTime";
            this.textBoxDateTime.ReadOnly = true;
            this.textBoxDateTime.Size = new System.Drawing.Size(132, 22);
            this.textBoxDateTime.TabIndex = 15;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateTime.Location = new System.Drawing.Point(6, 65);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(58, 20);
            this.labelDateTime.TabIndex = 14;
            this.labelDateTime.Text = "Дата:";
            // 
            // listBoxServises
            // 
            this.listBoxServises.FormattingEnabled = true;
            this.listBoxServises.ItemHeight = 16;
            this.listBoxServises.Location = new System.Drawing.Point(537, 210);
            this.listBoxServises.Name = "listBoxServises";
            this.listBoxServises.Size = new System.Drawing.Size(255, 148);
            this.listBoxServises.TabIndex = 25;
            // 
            // labelDoctorInfo
            // 
            this.labelDoctorInfo.AutoSize = true;
            this.labelDoctorInfo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDoctorInfo.Location = new System.Drawing.Point(8, 85);
            this.labelDoctorInfo.Name = "labelDoctorInfo";
            this.labelDoctorInfo.Size = new System.Drawing.Size(220, 20);
            this.labelDoctorInfo.TabIndex = 26;
            this.labelDoctorInfo.Text = "Інформація про лікаря:";
            // 
            // labelPatientInfo
            // 
            this.labelPatientInfo.AutoSize = true;
            this.labelPatientInfo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatientInfo.Location = new System.Drawing.Point(422, 85);
            this.labelPatientInfo.Name = "labelPatientInfo";
            this.labelPatientInfo.Size = new System.Drawing.Size(239, 20);
            this.labelPatientInfo.TabIndex = 27;
            this.labelPatientInfo.Text = "Інформація про пацієнта:";
            // 
            // DetailsDoctor
            // 
            this.DetailsDoctor.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DetailsDoctor.Location = new System.Drawing.Point(273, 78);
            this.DetailsDoctor.Name = "DetailsDoctor";
            this.DetailsDoctor.Size = new System.Drawing.Size(123, 34);
            this.DetailsDoctor.TabIndex = 28;
            this.DetailsDoctor.Text = "Детальніше";
            this.DetailsDoctor.UseVisualStyleBackColor = true;
            this.DetailsDoctor.Click += new System.EventHandler(this.DetailsDoctor_Click);
            // 
            // DetailsPatient
            // 
            this.DetailsPatient.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DetailsPatient.Location = new System.Drawing.Point(691, 78);
            this.DetailsPatient.Name = "DetailsPatient";
            this.DetailsPatient.Size = new System.Drawing.Size(123, 34);
            this.DetailsPatient.TabIndex = 29;
            this.DetailsPatient.Text = "Детальніше";
            this.DetailsPatient.UseVisualStyleBackColor = true;
            this.DetailsPatient.Click += new System.EventHandler(this.DetailsPatient_Click);
            // 
            // groupBoxGeneralData
            // 
            this.groupBoxGeneralData.Controls.Add(this.labelPrise);
            this.groupBoxGeneralData.Controls.Add(this.textBoxPrise);
            this.groupBoxGeneralData.Controls.Add(this.labelCardApp);
            this.groupBoxGeneralData.Controls.Add(this.textBoxCardNumb);
            this.groupBoxGeneralData.Controls.Add(this.labelDateTime);
            this.groupBoxGeneralData.Controls.Add(this.textBoxDateTime);
            this.groupBoxGeneralData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxGeneralData.Location = new System.Drawing.Point(12, 210);
            this.groupBoxGeneralData.Name = "groupBoxGeneralData";
            this.groupBoxGeneralData.Size = new System.Drawing.Size(342, 135);
            this.groupBoxGeneralData.TabIndex = 30;
            this.groupBoxGeneralData.TabStop = false;
            this.groupBoxGeneralData.Text = "Загальні данні";
            // 
            // labelPrise
            // 
            this.labelPrise.AutoSize = true;
            this.labelPrise.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrise.Location = new System.Drawing.Point(6, 101);
            this.labelPrise.Name = "labelPrise";
            this.labelPrise.Size = new System.Drawing.Size(141, 20);
            this.labelPrise.TabIndex = 16;
            this.labelPrise.Text = "Загальна ціна:";
            // 
            // textBoxPrise
            // 
            this.textBoxPrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrise.Location = new System.Drawing.Point(193, 99);
            this.textBoxPrise.Name = "textBoxPrise";
            this.textBoxPrise.ReadOnly = true;
            this.textBoxPrise.Size = new System.Drawing.Size(132, 22);
            this.textBoxPrise.TabIndex = 17;
            // 
            // DetailedAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.groupBoxGeneralData);
            this.Controls.Add(this.DetailsPatient);
            this.Controls.Add(this.DetailsDoctor);
            this.Controls.Add(this.labelPatientInfo);
            this.Controls.Add(this.labelDoctorInfo);
            this.Controls.Add(this.listBoxServises);
            this.Controls.Add(this.dataGridViewPatients);
            this.Controls.Add(this.dataGridViewDoctors);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "DetailedAppointment";
            this.Text = "DetailedAppointment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.groupBoxGeneralData.ResumeLayout(false);
            this.groupBoxGeneralData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxCardNumb;
        private System.Windows.Forms.Label labelCardApp;
        private System.Windows.Forms.DataGridView dataGridViewDoctors;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.TextBox textBoxDateTime;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.ListBox listBoxServises;
        private System.Windows.Forms.Label labelDoctorInfo;
        private System.Windows.Forms.Label labelPatientInfo;
        private System.Windows.Forms.Button DetailsDoctor;
        private System.Windows.Forms.Button DetailsPatient;
        private System.Windows.Forms.GroupBox groupBoxGeneralData;
        private System.Windows.Forms.Label labelPrise;
        private System.Windows.Forms.TextBox textBoxPrise;
    }
}