namespace VetCheck
{
    partial class Appointment
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
            this.txtAnimalId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVetId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAppointmentReason = new System.Windows.Forms.TextBox();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.lstDiagnostics = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lstTreatments = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtAnimalId
            // 
            this.txtAnimalId.Location = new System.Drawing.Point(112, 32);
            this.txtAnimalId.Name = "txtAnimalId";
            this.txtAnimalId.Size = new System.Drawing.Size(206, 23);
            this.txtAnimalId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "AnimalID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vet ID";
            // 
            // txtVetId
            // 
            this.txtVetId.Location = new System.Drawing.Point(112, 61);
            this.txtVetId.Name = "txtVetId";
            this.txtVetId.Size = new System.Drawing.Size(206, 23);
            this.txtVetId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reason";
            // 
            // txtAppointmentReason
            // 
            this.txtAppointmentReason.Location = new System.Drawing.Point(112, 90);
            this.txtAppointmentReason.Name = "txtAppointmentReason";
            this.txtAppointmentReason.Size = new System.Drawing.Size(206, 23);
            this.txtAppointmentReason.TabIndex = 4;
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.CustomFormat = "";
            this.dtpAppointmentDate.Location = new System.Drawing.Point(112, 137);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(200, 23);
            this.dtpAppointmentDate.TabIndex = 6;
            // 
            // lstDiagnostics
            // 
            this.lstDiagnostics.FormattingEnabled = true;
            this.lstDiagnostics.ItemHeight = 15;
            this.lstDiagnostics.Location = new System.Drawing.Point(559, 27);
            this.lstDiagnostics.Name = "lstDiagnostics";
            this.lstDiagnostics.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDiagnostics.Size = new System.Drawing.Size(185, 259);
            this.lstDiagnostics.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(131, 274);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(113, 62);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lstTreatments
            // 
            this.lstTreatments.FormattingEnabled = true;
            this.lstTreatments.ItemHeight = 15;
            this.lstTreatments.Location = new System.Drawing.Point(363, 27);
            this.lstTreatments.Name = "lstTreatments";
            this.lstTreatments.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstTreatments.Size = new System.Drawing.Size(167, 259);
            this.lstTreatments.TabIndex = 10;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstTreatments);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lstDiagnostics);
            this.Controls.Add(this.dtpAppointmentDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAppointmentReason);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVetId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnimalId);
            this.Name = "Appointment";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAnimalId;
        private Label label1;
        private Label label2;
        private TextBox txtVetId;
        private Label label3;
        private TextBox txtAppointmentReason;
        private DateTimePicker dtpAppointmentDate;
        private ListBox lstDiagnostics;
        private Button btnSubmit;
        private ListBox lstTreatments;
    }
}