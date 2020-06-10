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
            this.textBoxNumb = new System.Windows.Forms.TextBox();
            this.labelNumb = new System.Windows.Forms.Label();
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelPrise = new System.Windows.Forms.Label();
            this.textBoxPrise = new System.Windows.Forms.TextBox();
            this.dataGridViewAllServises = new System.Windows.Forms.DataGridView();
            this.labelAvaliableServises = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxPrise = new System.Windows.Forms.GroupBox();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.groupBoxGeneralData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllServises)).BeginInit();
            this.groupBoxPrise.SuspendLayout();
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
            // textBoxNumb
            // 
            this.textBoxNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumb.Location = new System.Drawing.Point(154, 29);
            this.textBoxNumb.Name = "textBoxNumb";
            this.textBoxNumb.ReadOnly = true;
            this.textBoxNumb.Size = new System.Drawing.Size(132, 22);
            this.textBoxNumb.TabIndex = 10;
            // 
            // labelNumb
            // 
            this.labelNumb.AutoSize = true;
            this.labelNumb.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumb.Location = new System.Drawing.Point(6, 31);
            this.labelNumb.Name = "labelNumb";
            this.labelNumb.Size = new System.Drawing.Size(145, 20);
            this.labelNumb.TabIndex = 9;
            this.labelNumb.Text = "Номер зустрічі:";
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
            this.dataGridViewPatients.Location = new System.Drawing.Point(16, 235);
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
            this.textBoxDateTime.Location = new System.Drawing.Point(154, 63);
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
            this.listBoxServises.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxServises.FormattingEnabled = true;
            this.listBoxServises.ItemHeight = 18;
            this.listBoxServises.Location = new System.Drawing.Point(430, 313);
            this.listBoxServises.Name = "listBoxServises";
            this.listBoxServises.Size = new System.Drawing.Size(303, 184);
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
            this.labelPatientInfo.Location = new System.Drawing.Point(12, 202);
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
            this.DetailsPatient.Location = new System.Drawing.Point(281, 195);
            this.DetailsPatient.Name = "DetailsPatient";
            this.DetailsPatient.Size = new System.Drawing.Size(123, 34);
            this.DetailsPatient.TabIndex = 29;
            this.DetailsPatient.Text = "Детальніше";
            this.DetailsPatient.UseVisualStyleBackColor = true;
            this.DetailsPatient.Click += new System.EventHandler(this.DetailsPatient_Click);
            // 
            // groupBoxGeneralData
            // 
            this.groupBoxGeneralData.Controls.Add(this.labelNumb);
            this.groupBoxGeneralData.Controls.Add(this.textBoxNumb);
            this.groupBoxGeneralData.Controls.Add(this.labelDateTime);
            this.groupBoxGeneralData.Controls.Add(this.textBoxDateTime);
            this.groupBoxGeneralData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxGeneralData.Location = new System.Drawing.Point(429, 78);
            this.groupBoxGeneralData.Name = "groupBoxGeneralData";
            this.groupBoxGeneralData.Size = new System.Drawing.Size(303, 100);
            this.groupBoxGeneralData.TabIndex = 30;
            this.groupBoxGeneralData.TabStop = false;
            this.groupBoxGeneralData.Text = "Загальні данні";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(12, 517);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(85, 35);
            this.buttonEdit.TabIndex = 18;
            this.buttonEdit.Text = "Змінити";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.Location = new System.Drawing.Point(103, 517);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(107, 35);
            this.buttonSave.TabIndex = 31;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Visible = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Maroon;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(625, 517);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(107, 35);
            this.buttonDelete.TabIndex = 32;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelPrise
            // 
            this.labelPrise.AutoSize = true;
            this.labelPrise.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrise.Location = new System.Drawing.Point(6, 74);
            this.labelPrise.Name = "labelPrise";
            this.labelPrise.Size = new System.Drawing.Size(152, 20);
            this.labelPrise.TabIndex = 33;
            this.labelPrise.Text = "Загальна ціна:";
            // 
            // textBoxPrise
            // 
            this.textBoxPrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrise.Location = new System.Drawing.Point(172, 72);
            this.textBoxPrise.Name = "textBoxPrise";
            this.textBoxPrise.ReadOnly = true;
            this.textBoxPrise.Size = new System.Drawing.Size(114, 22);
            this.textBoxPrise.TabIndex = 34;
            // 
            // dataGridViewAllServises
            // 
            this.dataGridViewAllServises.AllowUserToAddRows = false;
            this.dataGridViewAllServises.AllowUserToDeleteRows = false;
            this.dataGridViewAllServises.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewAllServises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllServises.Location = new System.Drawing.Point(16, 359);
            this.dataGridViewAllServises.Name = "dataGridViewAllServises";
            this.dataGridViewAllServises.ReadOnly = true;
            this.dataGridViewAllServises.RowHeadersVisible = false;
            this.dataGridViewAllServises.RowHeadersWidth = 51;
            this.dataGridViewAllServises.RowTemplate.Height = 24;
            this.dataGridViewAllServises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAllServises.Size = new System.Drawing.Size(388, 134);
            this.dataGridViewAllServises.TabIndex = 35;
            this.dataGridViewAllServises.Visible = false;
            // 
            // labelAvaliableServises
            // 
            this.labelAvaliableServises.AutoSize = true;
            this.labelAvaliableServises.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAvaliableServises.Location = new System.Drawing.Point(12, 325);
            this.labelAvaliableServises.Name = "labelAvaliableServises";
            this.labelAvaliableServises.Size = new System.Drawing.Size(163, 20);
            this.labelAvaliableServises.TabIndex = 36;
            this.labelAvaliableServises.Text = "Можливі сервіси:";
            this.labelAvaliableServises.Visible = false;
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.Location = new System.Drawing.Point(348, 318);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(51, 35);
            this.buttonRemove.TabIndex = 38;
            this.buttonRemove.Text = "-";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Visible = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(273, 318);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(51, 35);
            this.buttonAdd.TabIndex = 37;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Visible = false;
            // 
            // groupBoxPrise
            // 
            this.groupBoxPrise.Controls.Add(this.labelDiscount);
            this.groupBoxPrise.Controls.Add(this.textBoxDiscount);
            this.groupBoxPrise.Controls.Add(this.labelPrise);
            this.groupBoxPrise.Controls.Add(this.textBoxPrise);
            this.groupBoxPrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPrise.Location = new System.Drawing.Point(429, 191);
            this.groupBoxPrise.Name = "groupBoxPrise";
            this.groupBoxPrise.Size = new System.Drawing.Size(303, 113);
            this.groupBoxPrise.TabIndex = 31;
            this.groupBoxPrise.TabStop = false;
            this.groupBoxPrise.Text = "Ціна";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiscount.Location = new System.Drawing.Point(6, 33);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(163, 20);
            this.labelDiscount.TabIndex = 35;
            this.labelDiscount.Text = "Відсоток знижки:";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDiscount.Location = new System.Drawing.Point(172, 34);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.ReadOnly = true;
            this.textBoxDiscount.Size = new System.Drawing.Size(114, 22);
            this.textBoxDiscount.TabIndex = 36;
            // 
            // DetailedAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 564);
            this.Controls.Add(this.groupBoxPrise);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelAvaliableServises);
            this.Controls.Add(this.dataGridViewAllServises);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonEdit);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(763, 611);
            this.MinimumSize = new System.Drawing.Size(763, 611);
            this.Name = "DetailedAppointment";
            this.Text = "DetailedAppointment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.groupBoxGeneralData.ResumeLayout(false);
            this.groupBoxGeneralData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllServises)).EndInit();
            this.groupBoxPrise.ResumeLayout(false);
            this.groupBoxPrise.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxNumb;
        private System.Windows.Forms.Label labelNumb;
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
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelPrise;
        private System.Windows.Forms.TextBox textBoxPrise;
        private System.Windows.Forms.DataGridView dataGridViewAllServises;
        private System.Windows.Forms.Label labelAvaliableServises;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxPrise;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textBoxDiscount;
    }
}