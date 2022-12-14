namespace Hospital
{
    partial class HospitalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalForm));
            this.buttonPatients = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAllDoctors = new System.Windows.Forms.Button();
            this.buttonAppointments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPatients
            // 
            this.buttonPatients.BackColor = System.Drawing.Color.Silver;
            this.buttonPatients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPatients.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPatients.Location = new System.Drawing.Point(108, 118);
            this.buttonPatients.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPatients.Name = "buttonPatients";
            this.buttonPatients.Size = new System.Drawing.Size(198, 58);
            this.buttonPatients.TabIndex = 0;
            this.buttonPatients.Text = "Всі пацієнти";
            this.buttonPatients.UseVisualStyleBackColor = false;
            this.buttonPatients.Click += new System.EventHandler(this.buttonPatients_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(63, 49);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(405, 29);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Реєстратура поліклініки №1";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(108, 371);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(198, 58);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Вихід";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAllDoctors
            // 
            this.buttonAllDoctors.BackColor = System.Drawing.Color.Silver;
            this.buttonAllDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAllDoctors.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAllDoctors.Location = new System.Drawing.Point(108, 203);
            this.buttonAllDoctors.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAllDoctors.Name = "buttonAllDoctors";
            this.buttonAllDoctors.Size = new System.Drawing.Size(198, 58);
            this.buttonAllDoctors.TabIndex = 3;
            this.buttonAllDoctors.Text = "Всі лікарі";
            this.buttonAllDoctors.UseVisualStyleBackColor = false;
            this.buttonAllDoctors.Click += new System.EventHandler(this.buttonAllDoctors_Click);
            // 
            // buttonAppointments
            // 
            this.buttonAppointments.BackColor = System.Drawing.Color.Silver;
            this.buttonAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAppointments.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAppointments.Location = new System.Drawing.Point(108, 288);
            this.buttonAppointments.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAppointments.Name = "buttonAppointments";
            this.buttonAppointments.Size = new System.Drawing.Size(198, 58);
            this.buttonAppointments.TabIndex = 4;
            this.buttonAppointments.Text = "Всі записи";
            this.buttonAppointments.UseVisualStyleBackColor = false;
            this.buttonAppointments.Click += new System.EventHandler(this.buttonAppointments_Click);
            // 
            // HospitalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 464);
            this.Controls.Add(this.buttonAppointments);
            this.Controls.Add(this.buttonAllDoctors);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonPatients);
            this.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(451, 511);
            this.MinimumSize = new System.Drawing.Size(451, 511);
            this.Name = "HospitalForm";
            this.Text = "Hospital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPatients;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAllDoctors;
        private System.Windows.Forms.Button buttonAppointments;
    }
}

