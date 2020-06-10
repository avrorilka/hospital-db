namespace Hospital.View
{
    partial class AddDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDoctor));
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxFullName = new System.Windows.Forms.GroupBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.textBoxEndTime = new System.Windows.Forms.TextBox();
            this.textBoxStartTime = new System.Windows.Forms.TextBox();
            this.textBoxCabinet = new System.Windows.Forms.TextBox();
            this.labelCabinet = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxFullName.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(235, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(360, 25);
            this.labelTitle.TabIndex = 23;
            this.labelTitle.Text = "Додати нового лікаря до бази";
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
            this.groupBoxFullName.Location = new System.Drawing.Point(12, 102);
            this.groupBoxFullName.Name = "groupBoxFullName";
            this.groupBoxFullName.Size = new System.Drawing.Size(391, 159);
            this.groupBoxFullName.TabIndex = 24;
            this.groupBoxFullName.TabStop = false;
            this.groupBoxFullName.Text = "Повне ім\'я";
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
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(195, 32);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(183, 22);
            this.textBoxFirstName.TabIndex = 9;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(195, 119);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(183, 22);
            this.textBoxMiddleName.TabIndex = 11;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(195, 73);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(183, 22);
            this.textBoxSurname.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxType);
            this.groupBox1.Controls.Add(this.labelType);
            this.groupBox1.Controls.Add(this.labelStartTime);
            this.groupBox1.Controls.Add(this.labelEndTime);
            this.groupBox1.Controls.Add(this.textBoxEndTime);
            this.groupBox1.Controls.Add(this.textBoxStartTime);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(423, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 159);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальна інформація";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(155, 29);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(223, 26);
            this.comboBoxType.TabIndex = 19;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.Location = new System.Drawing.Point(8, 34);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(141, 20);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Спеціальність:";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartTime.Location = new System.Drawing.Point(8, 75);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(189, 20);
            this.labelStartTime.TabIndex = 3;
            this.labelStartTime.Text = "Час початку роботи:";
            // 
            // labelEndTime
            // 
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEndTime.Location = new System.Drawing.Point(8, 121);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(216, 20);
            this.labelEndTime.TabIndex = 4;
            this.labelEndTime.Text = "Час закінчення роботи:";
            // 
            // textBoxEndTime
            // 
            this.textBoxEndTime.Location = new System.Drawing.Point(247, 122);
            this.textBoxEndTime.Name = "textBoxEndTime";
            this.textBoxEndTime.Size = new System.Drawing.Size(131, 22);
            this.textBoxEndTime.TabIndex = 11;
            // 
            // textBoxStartTime
            // 
            this.textBoxStartTime.Location = new System.Drawing.Point(247, 76);
            this.textBoxStartTime.Name = "textBoxStartTime";
            this.textBoxStartTime.Size = new System.Drawing.Size(131, 22);
            this.textBoxStartTime.TabIndex = 12;
            // 
            // textBoxCabinet
            // 
            this.textBoxCabinet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCabinet.Location = new System.Drawing.Point(375, 62);
            this.textBoxCabinet.Name = "textBoxCabinet";
            this.textBoxCabinet.Size = new System.Drawing.Size(183, 22);
            this.textBoxCabinet.TabIndex = 26;
            // 
            // labelCabinet
            // 
            this.labelCabinet.AutoSize = true;
            this.labelCabinet.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCabinet.Location = new System.Drawing.Point(265, 64);
            this.labelCabinet.Name = "labelCabinet";
            this.labelCabinet.Size = new System.Drawing.Size(90, 20);
            this.labelCabinet.TabIndex = 25;
            this.labelCabinet.Text = "Кабінет:";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Maroon;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClose.Location = new System.Drawing.Point(705, 267);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(107, 35);
            this.buttonClose.TabIndex = 29;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.Location = new System.Drawing.Point(12, 267);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(107, 35);
            this.buttonSave.TabIndex = 28;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // AddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 316);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxCabinet);
            this.Controls.Add(this.labelCabinet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxFullName);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(842, 363);
            this.MinimumSize = new System.Drawing.Size(842, 363);
            this.Name = "AddDoctor";
            this.Text = "Додати лікаря";
            this.groupBoxFullName.ResumeLayout(false);
            this.groupBoxFullName.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxFullName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.TextBox textBoxEndTime;
        private System.Windows.Forms.TextBox textBoxStartTime;
        private System.Windows.Forms.TextBox textBoxCabinet;
        private System.Windows.Forms.Label labelCabinet;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
    }
}