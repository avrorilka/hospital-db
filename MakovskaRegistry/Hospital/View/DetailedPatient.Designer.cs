namespace Hospital.View
{
    partial class DetailedPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailedPatient));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCardNumb = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelBirth = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxCardNumb = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxBirth = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.groupBoxFullName = new System.Windows.Forms.GroupBox();
            this.groupBoxGeneralData = new System.Windows.Forms.GroupBox();
            this.groupBoxMedInfo = new System.Windows.Forms.GroupBox();
            this.listBoxGroup = new System.Windows.Forms.ListBox();
            this.buttonRemoveGroup = new System.Windows.Forms.Button();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.labelGroup = new System.Windows.Forms.Label();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBoxFullName.SuspendLayout();
            this.groupBoxGeneralData.SuspendLayout();
            this.groupBoxMedInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(209, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(416, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Детальна інформація про пацієнта";
            // 
            // labelCardNumb
            // 
            this.labelCardNumb.AutoSize = true;
            this.labelCardNumb.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCardNumb.Location = new System.Drawing.Point(255, 95);
            this.labelCardNumb.Name = "labelCardNumb";
            this.labelCardNumb.Size = new System.Drawing.Size(151, 20);
            this.labelCardNumb.TabIndex = 1;
            this.labelCardNumb.Text = "Номер картки:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.Location = new System.Drawing.Point(8, 34);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(52, 20);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "Ім\'я:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(8, 75);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(100, 20);
            this.labelSurname.TabIndex = 3;
            this.labelSurname.Text = "Прізвище:";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleName.Location = new System.Drawing.Point(8, 121);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(119, 20);
            this.labelMiddleName.TabIndex = 4;
            this.labelMiddleName.Text = "По батькові:";
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirth.Location = new System.Drawing.Point(6, 29);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(173, 20);
            this.labelBirth.TabIndex = 5;
            this.labelBirth.Text = "Дата народження:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(6, 77);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(162, 20);
            this.labelPhone.TabIndex = 6;
            this.labelPhone.Text = "Номер телефону:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress.Location = new System.Drawing.Point(6, 127);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(80, 20);
            this.labelAddress.TabIndex = 7;
            this.labelAddress.Text = "Адреса:";
            // 
            // textBoxCardNumb
            // 
            this.textBoxCardNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCardNumb.Location = new System.Drawing.Point(442, 93);
            this.textBoxCardNumb.Name = "textBoxCardNumb";
            this.textBoxCardNumb.ReadOnly = true;
            this.textBoxCardNumb.Size = new System.Drawing.Size(183, 22);
            this.textBoxCardNumb.TabIndex = 8;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(195, 32);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(183, 22);
            this.textBoxFirstName.TabIndex = 9;
            // 
            // textBoxBirth
            // 
            this.textBoxBirth.Location = new System.Drawing.Point(193, 27);
            this.textBoxBirth.Name = "textBoxBirth";
            this.textBoxBirth.ReadOnly = true;
            this.textBoxBirth.Size = new System.Drawing.Size(183, 22);
            this.textBoxBirth.TabIndex = 10;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(195, 119);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.ReadOnly = true;
            this.textBoxMiddleName.Size = new System.Drawing.Size(183, 22);
            this.textBoxMiddleName.TabIndex = 11;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(195, 73);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.ReadOnly = true;
            this.textBoxSurname.Size = new System.Drawing.Size(183, 22);
            this.textBoxSurname.TabIndex = 12;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(193, 75);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.ReadOnly = true;
            this.textBoxPhone.Size = new System.Drawing.Size(183, 22);
            this.textBoxPhone.TabIndex = 13;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(102, 125);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.Size = new System.Drawing.Size(274, 22);
            this.textBoxAddress.TabIndex = 14;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(16, 500);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(85, 35);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Змінити";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.Location = new System.Drawing.Point(107, 500);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(107, 35);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Maroon;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(706, 500);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(107, 35);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Enabled = false;
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(102, 40);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(276, 26);
            this.comboBoxStatus.TabIndex = 18;
            // 
            // groupBoxFullName
            // 
            this.groupBoxFullName.Controls.Add(this.labelFirstName);
            this.groupBoxFullName.Controls.Add(this.labelSurname);
            this.groupBoxFullName.Controls.Add(this.labelMiddleName);
            this.groupBoxFullName.Controls.Add(this.textBoxFirstName);
            this.groupBoxFullName.Controls.Add(this.textBoxMiddleName);
            this.groupBoxFullName.Controls.Add(this.textBoxSurname);
            this.groupBoxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFullName.Location = new System.Drawing.Point(16, 130);
            this.groupBoxFullName.Name = "groupBoxFullName";
            this.groupBoxFullName.Size = new System.Drawing.Size(391, 159);
            this.groupBoxFullName.TabIndex = 19;
            this.groupBoxFullName.TabStop = false;
            this.groupBoxFullName.Text = "Повне ім\'я";
            // 
            // groupBoxGeneralData
            // 
            this.groupBoxGeneralData.Controls.Add(this.labelBirth);
            this.groupBoxGeneralData.Controls.Add(this.labelPhone);
            this.groupBoxGeneralData.Controls.Add(this.labelAddress);
            this.groupBoxGeneralData.Controls.Add(this.textBoxBirth);
            this.groupBoxGeneralData.Controls.Add(this.textBoxPhone);
            this.groupBoxGeneralData.Controls.Add(this.textBoxAddress);
            this.groupBoxGeneralData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxGeneralData.Location = new System.Drawing.Point(421, 131);
            this.groupBoxGeneralData.Name = "groupBoxGeneralData";
            this.groupBoxGeneralData.Size = new System.Drawing.Size(392, 158);
            this.groupBoxGeneralData.TabIndex = 20;
            this.groupBoxGeneralData.TabStop = false;
            this.groupBoxGeneralData.Text = "Загальні данні";
            // 
            // groupBoxMedInfo
            // 
            this.groupBoxMedInfo.Controls.Add(this.listBoxGroup);
            this.groupBoxMedInfo.Controls.Add(this.buttonRemoveGroup);
            this.groupBoxMedInfo.Controls.Add(this.buttonAddGroup);
            this.groupBoxMedInfo.Controls.Add(this.labelGroup);
            this.groupBoxMedInfo.Controls.Add(this.comboBoxGroup);
            this.groupBoxMedInfo.Controls.Add(this.labelStatus);
            this.groupBoxMedInfo.Controls.Add(this.comboBoxStatus);
            this.groupBoxMedInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMedInfo.Location = new System.Drawing.Point(16, 310);
            this.groupBoxMedInfo.Name = "groupBoxMedInfo";
            this.groupBoxMedInfo.Size = new System.Drawing.Size(797, 175);
            this.groupBoxMedInfo.TabIndex = 21;
            this.groupBoxMedInfo.TabStop = false;
            this.groupBoxMedInfo.Text = "Медична інформація";
            // 
            // listBoxGroup
            // 
            this.listBoxGroup.FormattingEnabled = true;
            this.listBoxGroup.ItemHeight = 16;
            this.listBoxGroup.Location = new System.Drawing.Point(415, 21);
            this.listBoxGroup.Name = "listBoxGroup";
            this.listBoxGroup.Size = new System.Drawing.Size(366, 148);
            this.listBoxGroup.TabIndex = 24;
            // 
            // buttonRemoveGroup
            // 
            this.buttonRemoveGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRemoveGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveGroup.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveGroup.Location = new System.Drawing.Point(327, 89);
            this.buttonRemoveGroup.Name = "buttonRemoveGroup";
            this.buttonRemoveGroup.Size = new System.Drawing.Size(51, 35);
            this.buttonRemoveGroup.TabIndex = 23;
            this.buttonRemoveGroup.Text = "-";
            this.buttonRemoveGroup.UseVisualStyleBackColor = false;
            this.buttonRemoveGroup.Visible = false;
            this.buttonRemoveGroup.Click += new System.EventHandler(this.buttonRemoveGroup_Click);
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonAddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddGroup.ForeColor = System.Drawing.Color.White;
            this.buttonAddGroup.Location = new System.Drawing.Point(252, 89);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(51, 35);
            this.buttonAddGroup.TabIndex = 22;
            this.buttonAddGroup.Text = "+";
            this.buttonAddGroup.UseVisualStyleBackColor = false;
            this.buttonAddGroup.Visible = false;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroup.Location = new System.Drawing.Point(8, 96);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(182, 20);
            this.labelGroup.TabIndex = 21;
            this.labelGroup.Text = "Пільгова категорія:";
            this.labelGroup.Visible = false;
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(12, 130);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(366, 26);
            this.comboBoxGroup.TabIndex = 20;
            this.comboBoxGroup.Visible = false;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(8, 40);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(74, 20);
            this.labelStatus.TabIndex = 19;
            this.labelStatus.Text = "Статус:";
            // 
            // DetailedPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 547);
            this.Controls.Add(this.groupBoxMedInfo);
            this.Controls.Add(this.groupBoxGeneralData);
            this.Controls.Add(this.groupBoxFullName);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxCardNumb);
            this.Controls.Add(this.labelCardNumb);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(845, 594);
            this.MinimumSize = new System.Drawing.Size(845, 594);
            this.Name = "DetailedPatient";
            this.Text = "Детальна інформація про пацієнта";
            this.groupBoxFullName.ResumeLayout(false);
            this.groupBoxFullName.PerformLayout();
            this.groupBoxGeneralData.ResumeLayout(false);
            this.groupBoxGeneralData.PerformLayout();
            this.groupBoxMedInfo.ResumeLayout(false);
            this.groupBoxMedInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCardNumb;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxCardNumb;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxBirth;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.GroupBox groupBoxFullName;
        private System.Windows.Forms.GroupBox groupBoxGeneralData;
        private System.Windows.Forms.GroupBox groupBoxMedInfo;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonRemoveGroup;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.ListBox listBoxGroup;
    }
}