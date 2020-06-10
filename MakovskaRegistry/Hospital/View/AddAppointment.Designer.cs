namespace Hospital.View
{
    partial class AddAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAppointment));
            this.labelAvaliableServises = new System.Windows.Forms.Label();
            this.dataGridViewAllServises = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.DetailsPatient = new System.Windows.Forms.Button();
            this.DetailsDoctor = new System.Windows.Forms.Button();
            this.labelPatientInfo = new System.Windows.Forms.Label();
            this.labelDoctorInfo = new System.Windows.Forms.Label();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.textBoxDateTime = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSearchDoctor = new System.Windows.Forms.Button();
            this.textBoxSearchDoctor = new System.Windows.Forms.TextBox();
            this.labelSearchDocror = new System.Windows.Forms.Label();
            this.comboBoxSearchDoctor = new System.Windows.Forms.ComboBox();
            this.buttonSearchPatient = new System.Windows.Forms.Button();
            this.textBoxSearchPatient = new System.Windows.Forms.TextBox();
            this.labelSearchPatient = new System.Windows.Forms.Label();
            this.comboBoxsearchPatient = new System.Windows.Forms.ComboBox();
            this.groupBoxDoctor = new System.Windows.Forms.GroupBox();
            this.buttonRefreshDoctors = new System.Windows.Forms.Button();
            this.buttonAddDoctor = new System.Windows.Forms.Button();
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.buttonRefreshPatients = new System.Windows.Forms.Button();
            this.buttonAddPAtient = new System.Windows.Forms.Button();
            this.labelExampleBDay = new System.Windows.Forms.Label();
            this.buttonSearchApp = new System.Windows.Forms.Button();
            this.textBoxSearchApp = new System.Windows.Forms.TextBox();
            this.labelSearchApp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllServises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            this.groupBoxDoctor.SuspendLayout();
            this.groupBoxPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAvaliableServises
            // 
            this.labelAvaliableServises.AutoSize = true;
            this.labelAvaliableServises.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAvaliableServises.Location = new System.Drawing.Point(591, 416);
            this.labelAvaliableServises.Name = "labelAvaliableServises";
            this.labelAvaliableServises.Size = new System.Drawing.Size(163, 20);
            this.labelAvaliableServises.TabIndex = 53;
            this.labelAvaliableServises.Text = "Можливі сервіси:";
            // 
            // dataGridViewAllServises
            // 
            this.dataGridViewAllServises.AllowUserToAddRows = false;
            this.dataGridViewAllServises.AllowUserToDeleteRows = false;
            this.dataGridViewAllServises.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewAllServises.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewAllServises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllServises.Location = new System.Drawing.Point(366, 439);
            this.dataGridViewAllServises.Name = "dataGridViewAllServises";
            this.dataGridViewAllServises.ReadOnly = true;
            this.dataGridViewAllServises.RowHeadersVisible = false;
            this.dataGridViewAllServises.RowHeadersWidth = 51;
            this.dataGridViewAllServises.RowTemplate.Height = 24;
            this.dataGridViewAllServises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAllServises.Size = new System.Drawing.Size(388, 151);
            this.dataGridViewAllServises.TabIndex = 52;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.Location = new System.Drawing.Point(12, 565);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(107, 35);
            this.buttonSave.TabIndex = 49;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // DetailsPatient
            // 
            this.DetailsPatient.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DetailsPatient.Location = new System.Drawing.Point(207, 25);
            this.DetailsPatient.Name = "DetailsPatient";
            this.DetailsPatient.Size = new System.Drawing.Size(113, 34);
            this.DetailsPatient.TabIndex = 47;
            this.DetailsPatient.Text = "Деталі";
            this.DetailsPatient.UseVisualStyleBackColor = true;
            this.DetailsPatient.Click += new System.EventHandler(this.DetailsPatient_Click);
            // 
            // DetailsDoctor
            // 
            this.DetailsDoctor.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DetailsDoctor.Location = new System.Drawing.Point(199, 26);
            this.DetailsDoctor.Name = "DetailsDoctor";
            this.DetailsDoctor.Size = new System.Drawing.Size(114, 34);
            this.DetailsDoctor.TabIndex = 46;
            this.DetailsDoctor.Text = "Деталі";
            this.DetailsDoctor.UseVisualStyleBackColor = true;
            this.DetailsDoctor.Click += new System.EventHandler(this.DetailsDoctor_Click);
            // 
            // labelPatientInfo
            // 
            this.labelPatientInfo.AutoSize = true;
            this.labelPatientInfo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatientInfo.Location = new System.Drawing.Point(19, 33);
            this.labelPatientInfo.Name = "labelPatientInfo";
            this.labelPatientInfo.Size = new System.Drawing.Size(166, 20);
            this.labelPatientInfo.TabIndex = 45;
            this.labelPatientInfo.Text = "Оберіть пацієнта:";
            // 
            // labelDoctorInfo
            // 
            this.labelDoctorInfo.AutoSize = true;
            this.labelDoctorInfo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDoctorInfo.Location = new System.Drawing.Point(16, 33);
            this.labelDoctorInfo.Name = "labelDoctorInfo";
            this.labelDoctorInfo.Size = new System.Drawing.Size(147, 20);
            this.labelDoctorInfo.TabIndex = 44;
            this.labelDoctorInfo.Text = "Оберіть лікаря:";
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AllowUserToAddRows = false;
            this.dataGridViewPatients.AllowUserToDeleteRows = false;
            this.dataGridViewPatients.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewPatients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Location = new System.Drawing.Point(23, 66);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            this.dataGridViewPatients.RowHeadersVisible = false;
            this.dataGridViewPatients.RowHeadersWidth = 51;
            this.dataGridViewPatients.RowTemplate.Height = 24;
            this.dataGridViewPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatients.Size = new System.Drawing.Size(388, 151);
            this.dataGridViewPatients.TabIndex = 41;
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.AllowUserToAddRows = false;
            this.dataGridViewDoctors.AllowUserToDeleteRows = false;
            this.dataGridViewDoctors.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewDoctors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors.Location = new System.Drawing.Point(20, 66);
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.ReadOnly = true;
            this.dataGridViewDoctors.RowHeadersVisible = false;
            this.dataGridViewDoctors.RowHeadersWidth = 51;
            this.dataGridViewDoctors.RowTemplate.Height = 24;
            this.dataGridViewDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDoctors.Size = new System.Drawing.Size(384, 151);
            this.dataGridViewDoctors.TabIndex = 40;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(326, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(244, 25);
            this.labelTitle.TabIndex = 39;
            this.labelTitle.Text = "Додати новий запис";
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateTime.Location = new System.Drawing.Point(312, 59);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(58, 20);
            this.labelDateTime.TabIndex = 16;
            this.labelDateTime.Text = "Дата:";
            // 
            // textBoxDateTime
            // 
            this.textBoxDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDateTime.Location = new System.Drawing.Point(376, 57);
            this.textBoxDateTime.Name = "textBoxDateTime";
            this.textBoxDateTime.Size = new System.Drawing.Size(216, 22);
            this.textBoxDateTime.TabIndex = 17;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Maroon;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClose.Location = new System.Drawing.Point(786, 565);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(107, 35);
            this.buttonClose.TabIndex = 54;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSearchDoctor
            // 
            this.buttonSearchDoctor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSearchDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearchDoctor.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchDoctor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearchDoctor.Location = new System.Drawing.Point(341, 232);
            this.buttonSearchDoctor.Name = "buttonSearchDoctor";
            this.buttonSearchDoctor.Size = new System.Drawing.Size(63, 28);
            this.buttonSearchDoctor.TabIndex = 58;
            this.buttonSearchDoctor.Text = "->";
            this.buttonSearchDoctor.UseVisualStyleBackColor = false;
            this.buttonSearchDoctor.Click += new System.EventHandler(this.buttonSearchDoctor_Click);
            // 
            // textBoxSearchDoctor
            // 
            this.textBoxSearchDoctor.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchDoctor.Location = new System.Drawing.Point(22, 266);
            this.textBoxSearchDoctor.Name = "textBoxSearchDoctor";
            this.textBoxSearchDoctor.Size = new System.Drawing.Size(382, 28);
            this.textBoxSearchDoctor.TabIndex = 57;
            // 
            // labelSearchDocror
            // 
            this.labelSearchDocror.AutoSize = true;
            this.labelSearchDocror.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearchDocror.Location = new System.Drawing.Point(18, 232);
            this.labelSearchDocror.Name = "labelSearchDocror";
            this.labelSearchDocror.Size = new System.Drawing.Size(75, 20);
            this.labelSearchDocror.TabIndex = 56;
            this.labelSearchDocror.Text = "Пошук:";
            // 
            // comboBoxSearchDoctor
            // 
            this.comboBoxSearchDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSearchDoctor.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSearchDoctor.FormattingEnabled = true;
            this.comboBoxSearchDoctor.Items.AddRange(new object[] {
            "за ім\'ям",
            "за прізвищем",
            "за номером кабінету",
            "за спеціальністю"});
            this.comboBoxSearchDoctor.Location = new System.Drawing.Point(93, 230);
            this.comboBoxSearchDoctor.Name = "comboBoxSearchDoctor";
            this.comboBoxSearchDoctor.Size = new System.Drawing.Size(232, 28);
            this.comboBoxSearchDoctor.TabIndex = 55;
            // 
            // buttonSearchPatient
            // 
            this.buttonSearchPatient.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSearchPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearchPatient.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchPatient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSearchPatient.Location = new System.Drawing.Point(348, 232);
            this.buttonSearchPatient.Name = "buttonSearchPatient";
            this.buttonSearchPatient.Size = new System.Drawing.Size(63, 28);
            this.buttonSearchPatient.TabIndex = 62;
            this.buttonSearchPatient.Text = "->";
            this.buttonSearchPatient.UseVisualStyleBackColor = false;
            this.buttonSearchPatient.Click += new System.EventHandler(this.buttonSearchPatient_Click);
            // 
            // textBoxSearchPatient
            // 
            this.textBoxSearchPatient.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchPatient.Location = new System.Drawing.Point(23, 266);
            this.textBoxSearchPatient.Name = "textBoxSearchPatient";
            this.textBoxSearchPatient.Size = new System.Drawing.Size(388, 28);
            this.textBoxSearchPatient.TabIndex = 61;
            // 
            // labelSearchPatient
            // 
            this.labelSearchPatient.AutoSize = true;
            this.labelSearchPatient.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearchPatient.Location = new System.Drawing.Point(18, 236);
            this.labelSearchPatient.Name = "labelSearchPatient";
            this.labelSearchPatient.Size = new System.Drawing.Size(75, 20);
            this.labelSearchPatient.TabIndex = 60;
            this.labelSearchPatient.Text = "Пошук:";
            // 
            // comboBoxsearchPatient
            // 
            this.comboBoxsearchPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxsearchPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxsearchPatient.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxsearchPatient.FormattingEnabled = true;
            this.comboBoxsearchPatient.Items.AddRange(new object[] {
            "за номером медкарти",
            "за ім\'ям",
            "за прізвищем",
            "за датою народження"});
            this.comboBoxsearchPatient.Location = new System.Drawing.Point(99, 232);
            this.comboBoxsearchPatient.Name = "comboBoxsearchPatient";
            this.comboBoxsearchPatient.Size = new System.Drawing.Size(227, 28);
            this.comboBoxsearchPatient.TabIndex = 59;
            // 
            // groupBoxDoctor
            // 
            this.groupBoxDoctor.Controls.Add(this.buttonRefreshDoctors);
            this.groupBoxDoctor.Controls.Add(this.buttonAddDoctor);
            this.groupBoxDoctor.Controls.Add(this.dataGridViewDoctors);
            this.groupBoxDoctor.Controls.Add(this.labelDoctorInfo);
            this.groupBoxDoctor.Controls.Add(this.DetailsDoctor);
            this.groupBoxDoctor.Controls.Add(this.comboBoxSearchDoctor);
            this.groupBoxDoctor.Controls.Add(this.labelSearchDocror);
            this.groupBoxDoctor.Controls.Add(this.textBoxSearchDoctor);
            this.groupBoxDoctor.Controls.Add(this.buttonSearchDoctor);
            this.groupBoxDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDoctor.Location = new System.Drawing.Point(12, 94);
            this.groupBoxDoctor.Name = "groupBoxDoctor";
            this.groupBoxDoctor.Size = new System.Drawing.Size(432, 313);
            this.groupBoxDoctor.TabIndex = 63;
            this.groupBoxDoctor.TabStop = false;
            this.groupBoxDoctor.Text = "Лікар";
            // 
            // buttonRefreshDoctors
            // 
            this.buttonRefreshDoctors.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRefreshDoctors.BackgroundImage = global::Hospital.Properties.Resources.refresh;
            this.buttonRefreshDoctors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRefreshDoctors.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefreshDoctors.Location = new System.Drawing.Point(364, 26);
            this.buttonRefreshDoctors.Name = "buttonRefreshDoctors";
            this.buttonRefreshDoctors.Size = new System.Drawing.Size(40, 34);
            this.buttonRefreshDoctors.TabIndex = 66;
            this.buttonRefreshDoctors.UseVisualStyleBackColor = false;
            this.buttonRefreshDoctors.Click += new System.EventHandler(this.buttonRefreshDoctors_Click);
            // 
            // buttonAddDoctor
            // 
            this.buttonAddDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonAddDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddDoctor.ForeColor = System.Drawing.Color.White;
            this.buttonAddDoctor.Location = new System.Drawing.Point(319, 25);
            this.buttonAddDoctor.Name = "buttonAddDoctor";
            this.buttonAddDoctor.Size = new System.Drawing.Size(39, 35);
            this.buttonAddDoctor.TabIndex = 63;
            this.buttonAddDoctor.Text = "+";
            this.buttonAddDoctor.UseVisualStyleBackColor = false;
            this.buttonAddDoctor.Click += new System.EventHandler(this.buttonAddDoctor_Click);
            // 
            // groupBoxPatient
            // 
            this.groupBoxPatient.Controls.Add(this.buttonRefreshPatients);
            this.groupBoxPatient.Controls.Add(this.buttonAddPAtient);
            this.groupBoxPatient.Controls.Add(this.labelPatientInfo);
            this.groupBoxPatient.Controls.Add(this.dataGridViewPatients);
            this.groupBoxPatient.Controls.Add(this.buttonSearchPatient);
            this.groupBoxPatient.Controls.Add(this.DetailsPatient);
            this.groupBoxPatient.Controls.Add(this.textBoxSearchPatient);
            this.groupBoxPatient.Controls.Add(this.comboBoxsearchPatient);
            this.groupBoxPatient.Controls.Add(this.labelSearchPatient);
            this.groupBoxPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPatient.Location = new System.Drawing.Point(460, 94);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Size = new System.Drawing.Size(433, 313);
            this.groupBoxPatient.TabIndex = 64;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Пацієнт";
            // 
            // buttonRefreshPatients
            // 
            this.buttonRefreshPatients.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRefreshPatients.BackgroundImage = global::Hospital.Properties.Resources.refresh;
            this.buttonRefreshPatients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRefreshPatients.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefreshPatients.Location = new System.Drawing.Point(371, 26);
            this.buttonRefreshPatients.Name = "buttonRefreshPatients";
            this.buttonRefreshPatients.Size = new System.Drawing.Size(40, 34);
            this.buttonRefreshPatients.TabIndex = 65;
            this.buttonRefreshPatients.UseVisualStyleBackColor = false;
            this.buttonRefreshPatients.Click += new System.EventHandler(this.buttonRefreshPatients_Click);
            // 
            // buttonAddPAtient
            // 
            this.buttonAddPAtient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonAddPAtient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPAtient.ForeColor = System.Drawing.Color.White;
            this.buttonAddPAtient.Location = new System.Drawing.Point(326, 26);
            this.buttonAddPAtient.Name = "buttonAddPAtient";
            this.buttonAddPAtient.Size = new System.Drawing.Size(39, 35);
            this.buttonAddPAtient.TabIndex = 64;
            this.buttonAddPAtient.Text = "+";
            this.buttonAddPAtient.UseVisualStyleBackColor = false;
            this.buttonAddPAtient.Click += new System.EventHandler(this.buttonAddPAtient_Click);
            // 
            // labelExampleBDay
            // 
            this.labelExampleBDay.AutoSize = true;
            this.labelExampleBDay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelExampleBDay.Location = new System.Drawing.Point(415, 37);
            this.labelExampleBDay.Name = "labelExampleBDay";
            this.labelExampleBDay.Size = new System.Drawing.Size(137, 17);
            this.labelExampleBDay.TabIndex = 65;
            this.labelExampleBDay.Text = "03.05.2020 12:00";
            // 
            // buttonSearchApp
            // 
            this.buttonSearchApp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSearchApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearchApp.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchApp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearchApp.Location = new System.Drawing.Point(288, 479);
            this.buttonSearchApp.Name = "buttonSearchApp";
            this.buttonSearchApp.Size = new System.Drawing.Size(63, 28);
            this.buttonSearchApp.TabIndex = 69;
            this.buttonSearchApp.Text = "->";
            this.buttonSearchApp.UseVisualStyleBackColor = false;
            this.buttonSearchApp.Click += new System.EventHandler(this.buttonSearchApp_Click);
            // 
            // textBoxSearchApp
            // 
            this.textBoxSearchApp.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchApp.Location = new System.Drawing.Point(157, 513);
            this.textBoxSearchApp.Name = "textBoxSearchApp";
            this.textBoxSearchApp.Size = new System.Drawing.Size(194, 28);
            this.textBoxSearchApp.TabIndex = 68;
            // 
            // labelSearchApp
            // 
            this.labelSearchApp.AutoSize = true;
            this.labelSearchApp.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearchApp.Location = new System.Drawing.Point(153, 479);
            this.labelSearchApp.Name = "labelSearchApp";
            this.labelSearchApp.Size = new System.Drawing.Size(75, 20);
            this.labelSearchApp.TabIndex = 67;
            this.labelSearchApp.Text = "Пошук:";
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 612);
            this.Controls.Add(this.buttonSearchApp);
            this.Controls.Add(this.textBoxSearchApp);
            this.Controls.Add(this.labelSearchApp);
            this.Controls.Add(this.labelExampleBDay);
            this.Controls.Add(this.groupBoxPatient);
            this.Controls.Add(this.groupBoxDoctor);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.textBoxDateTime);
            this.Controls.Add(this.labelAvaliableServises);
            this.Controls.Add(this.dataGridViewAllServises);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(930, 659);
            this.MinimumSize = new System.Drawing.Size(930, 659);
            this.Name = "AddAppointment";
            this.Text = "Додати запис";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllServises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            this.groupBoxDoctor.ResumeLayout(false);
            this.groupBoxDoctor.PerformLayout();
            this.groupBoxPatient.ResumeLayout(false);
            this.groupBoxPatient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAvaliableServises;
        private System.Windows.Forms.DataGridView dataGridViewAllServises;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button DetailsPatient;
        private System.Windows.Forms.Button DetailsDoctor;
        private System.Windows.Forms.Label labelPatientInfo;
        private System.Windows.Forms.Label labelDoctorInfo;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.DataGridView dataGridViewDoctors;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.TextBox textBoxDateTime;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSearchDoctor;
        private System.Windows.Forms.TextBox textBoxSearchDoctor;
        private System.Windows.Forms.Label labelSearchDocror;
        private System.Windows.Forms.ComboBox comboBoxSearchDoctor;
        private System.Windows.Forms.Button buttonSearchPatient;
        private System.Windows.Forms.TextBox textBoxSearchPatient;
        private System.Windows.Forms.Label labelSearchPatient;
        private System.Windows.Forms.ComboBox comboBoxsearchPatient;
        private System.Windows.Forms.GroupBox groupBoxDoctor;
        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.Button buttonAddDoctor;
        private System.Windows.Forms.Button buttonAddPAtient;
        private System.Windows.Forms.Button buttonRefreshPatients;
        private System.Windows.Forms.Button buttonRefreshDoctors;
        private System.Windows.Forms.Label labelExampleBDay;
        private System.Windows.Forms.Button buttonSearchApp;
        private System.Windows.Forms.TextBox textBoxSearchApp;
        private System.Windows.Forms.Label labelSearchApp;
    }
}