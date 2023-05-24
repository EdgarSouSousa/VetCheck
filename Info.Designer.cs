namespace VetCheck
{
    partial class Info
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
            this.tabAppointments = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvAnimals = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvOwners = new System.Windows.Forms.DataGridView();
            this.txtCheckAvailable = new System.Windows.Forms.TextBox();
            this.btnCheckAvailable = new System.Windows.Forms.Button();
            this.btnCancelApp = new System.Windows.Forms.Button();
            this.btnCheckAppDetails = new System.Windows.Forms.Button();
            this.btnFutureOnly = new System.Windows.Forms.Button();
            this.btnUpForAdoption = new System.Windows.Forms.Button();
            this.btnCheckDiagnosis = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabAppointments.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwners)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAppointments
            // 
            this.tabAppointments.Controls.Add(this.tabPage1);
            this.tabAppointments.Controls.Add(this.tabPage2);
            this.tabAppointments.Controls.Add(this.tabPage3);
            this.tabAppointments.Location = new System.Drawing.Point(12, 12);
            this.tabAppointments.Name = "tabAppointments";
            this.tabAppointments.SelectedIndex = 0;
            this.tabAppointments.Size = new System.Drawing.Size(776, 321);
            this.tabAppointments.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvAppointments);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppointments.Location = new System.Drawing.Point(3, 3);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.RowTemplate.Height = 25;
            this.dgvAppointments.Size = new System.Drawing.Size(762, 287);
            this.dgvAppointments.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvAnimals);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvAnimals
            // 
            this.dgvAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAnimals.Location = new System.Drawing.Point(3, 3);
            this.dgvAnimals.Name = "dgvAnimals";
            this.dgvAnimals.RowTemplate.Height = 25;
            this.dgvAnimals.Size = new System.Drawing.Size(762, 287);
            this.dgvAnimals.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvOwners);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 293);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvOwners
            // 
            this.dgvOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOwners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOwners.Location = new System.Drawing.Point(3, 3);
            this.dgvOwners.Name = "dgvOwners";
            this.dgvOwners.RowTemplate.Height = 25;
            this.dgvOwners.Size = new System.Drawing.Size(762, 287);
            this.dgvOwners.TabIndex = 0;
            // 
            // txtCheckAvailable
            // 
            this.txtCheckAvailable.Location = new System.Drawing.Point(39, 339);
            this.txtCheckAvailable.Name = "txtCheckAvailable";
            this.txtCheckAvailable.Size = new System.Drawing.Size(171, 23);
            this.txtCheckAvailable.TabIndex = 1;
            // 
            // btnCheckAvailable
            // 
            this.btnCheckAvailable.Location = new System.Drawing.Point(216, 339);
            this.btnCheckAvailable.Name = "btnCheckAvailable";
            this.btnCheckAvailable.Size = new System.Drawing.Size(75, 23);
            this.btnCheckAvailable.TabIndex = 2;
            this.btnCheckAvailable.Text = "check";
            this.btnCheckAvailable.UseVisualStyleBackColor = true;
            // 
            // btnCancelApp
            // 
            this.btnCancelApp.Location = new System.Drawing.Point(39, 368);
            this.btnCancelApp.Name = "btnCancelApp";
            this.btnCancelApp.Size = new System.Drawing.Size(250, 25);
            this.btnCancelApp.TabIndex = 3;
            this.btnCancelApp.Text = "Cancel Appointment";
            this.btnCancelApp.UseVisualStyleBackColor = true;
            // 
            // btnCheckAppDetails
            // 
            this.btnCheckAppDetails.Location = new System.Drawing.Point(39, 399);
            this.btnCheckAppDetails.Name = "btnCheckAppDetails";
            this.btnCheckAppDetails.Size = new System.Drawing.Size(250, 25);
            this.btnCheckAppDetails.TabIndex = 4;
            this.btnCheckAppDetails.Text = "Check Details";
            this.btnCheckAppDetails.UseVisualStyleBackColor = true;
            // 
            // btnFutureOnly
            // 
            this.btnFutureOnly.Location = new System.Drawing.Point(39, 430);
            this.btnFutureOnly.Name = "btnFutureOnly";
            this.btnFutureOnly.Size = new System.Drawing.Size(250, 25);
            this.btnFutureOnly.TabIndex = 5;
            this.btnFutureOnly.Text = "Future Only";
            this.btnFutureOnly.UseVisualStyleBackColor = true;
            // 
            // btnUpForAdoption
            // 
            this.btnUpForAdoption.Location = new System.Drawing.Point(297, 339);
            this.btnUpForAdoption.Name = "btnUpForAdoption";
            this.btnUpForAdoption.Size = new System.Drawing.Size(250, 25);
            this.btnUpForAdoption.TabIndex = 6;
            this.btnUpForAdoption.Text = "Up for Adoption";
            this.btnUpForAdoption.UseVisualStyleBackColor = true;
            // 
            // btnCheckDiagnosis
            // 
            this.btnCheckDiagnosis.Location = new System.Drawing.Point(472, 370);
            this.btnCheckDiagnosis.Name = "btnCheckDiagnosis";
            this.btnCheckDiagnosis.Size = new System.Drawing.Size(75, 23);
            this.btnCheckDiagnosis.TabIndex = 8;
            this.btnCheckDiagnosis.Text = "check";
            this.btnCheckDiagnosis.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 370);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 23);
            this.textBox1.TabIndex = 7;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 471);
            this.Controls.Add(this.btnCheckDiagnosis);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUpForAdoption);
            this.Controls.Add(this.btnFutureOnly);
            this.Controls.Add(this.btnCheckAppDetails);
            this.Controls.Add(this.btnCancelApp);
            this.Controls.Add(this.btnCheckAvailable);
            this.Controls.Add(this.txtCheckAvailable);
            this.Controls.Add(this.tabAppointments);
            this.Name = "Info";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            this.tabAppointments.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabAppointments;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dgvAppointments;
        private DataGridView dgvAnimals;
        private DataGridView dgvOwners;
        private TextBox txtCheckAvailable;
        private Button btnCheckAvailable;
        private Button btnCancelApp;
        private Button btnCheckAppDetails;
        private Button btnFutureOnly;
        private Button btnUpForAdoption;
        private Button btnCheckDiagnosis;
        private TextBox textBox1;
    }
}