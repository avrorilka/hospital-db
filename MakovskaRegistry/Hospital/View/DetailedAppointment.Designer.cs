﻿namespace Hospital.View
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(181, 23);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(382, 25);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Детальна інформація про запис";
            // 
            // textBoxCardNumb
            // 
            this.textBoxCardNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCardNumb.Location = new System.Drawing.Point(389, 82);
            this.textBoxCardNumb.Name = "textBoxCardNumb";
            this.textBoxCardNumb.ReadOnly = true;
            this.textBoxCardNumb.Size = new System.Drawing.Size(183, 22);
            this.textBoxCardNumb.TabIndex = 10;
            // 
            // labelCardApp
            // 
            this.labelCardApp.AutoSize = true;
            this.labelCardApp.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCardApp.Location = new System.Drawing.Point(202, 84);
            this.labelCardApp.Name = "labelCardApp";
            this.labelCardApp.Size = new System.Drawing.Size(161, 20);
            this.labelCardApp.TabIndex = 9;
            this.labelCardApp.Text = "Номер зустрічі:";
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.AllowUserToAddRows = false;
            this.dataGridViewDoctors.AllowUserToDeleteRows = false;
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors.Location = new System.Drawing.Point(12, 160);
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.ReadOnly = true;
            this.dataGridViewDoctors.RowHeadersVisible = false;
            this.dataGridViewDoctors.RowHeadersWidth = 51;
            this.dataGridViewDoctors.RowTemplate.Height = 24;
            this.dataGridViewDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDoctors.Size = new System.Drawing.Size(384, 71);
            this.dataGridViewDoctors.TabIndex = 12;
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AllowUserToAddRows = false;
            this.dataGridViewPatients.AllowUserToDeleteRows = false;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Location = new System.Drawing.Point(462, 160);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            this.dataGridViewPatients.RowHeadersVisible = false;
            this.dataGridViewPatients.RowHeadersWidth = 51;
            this.dataGridViewPatients.RowTemplate.Height = 24;
            this.dataGridViewPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatients.Size = new System.Drawing.Size(354, 71);
            this.dataGridViewPatients.TabIndex = 13;
            // 
            // DetailedAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 450);
            this.Controls.Add(this.dataGridViewPatients);
            this.Controls.Add(this.dataGridViewDoctors);
            this.Controls.Add(this.textBoxCardNumb);
            this.Controls.Add(this.labelCardApp);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "DetailedAppointment";
            this.Text = "DetailedAppointment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxCardNumb;
        private System.Windows.Forms.Label labelCardApp;
        private System.Windows.Forms.DataGridView dataGridViewDoctors;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
    }
}