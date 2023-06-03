namespace VetCheck
{
    partial class Adoption
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
            this.txtAnimalID = new System.Windows.Forms.TextBox();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.txtVetID = new System.Windows.Forms.TextBox();
            this.txtAdoptionFee = new System.Windows.Forms.TextBox();
            this.submitAdoptionButton = new System.Windows.Forms.Button();
            this.isReturnCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.newOwner = new System.Windows.Forms.LinkLabel();
            this.dtpAdoptionDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtAnimalID
            // 
            this.txtAnimalID.Location = new System.Drawing.Point(249, 63);
            this.txtAnimalID.Name = "txtAnimalID";
            this.txtAnimalID.Size = new System.Drawing.Size(196, 23);
            this.txtAnimalID.TabIndex = 0;
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Location = new System.Drawing.Point(249, 92);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.Size = new System.Drawing.Size(196, 23);
            this.txtOwnerID.TabIndex = 1;
            // 
            // txtVetID
            // 
            this.txtVetID.Location = new System.Drawing.Point(249, 121);
            this.txtVetID.Name = "txtVetID";
            this.txtVetID.Size = new System.Drawing.Size(196, 23);
            this.txtVetID.TabIndex = 2;
            // 
            // txtAdoptionFee
            // 
            this.txtAdoptionFee.Location = new System.Drawing.Point(249, 179);
            this.txtAdoptionFee.Name = "txtAdoptionFee";
            this.txtAdoptionFee.Size = new System.Drawing.Size(196, 23);
            this.txtAdoptionFee.TabIndex = 4;
            // 
            // submitAdoptionButton
            // 
            this.submitAdoptionButton.Location = new System.Drawing.Point(249, 245);
            this.submitAdoptionButton.Name = "submitAdoptionButton";
            this.submitAdoptionButton.Size = new System.Drawing.Size(175, 66);
            this.submitAdoptionButton.TabIndex = 5;
            this.submitAdoptionButton.Text = "Submit";
            this.submitAdoptionButton.UseVisualStyleBackColor = true;
            this.submitAdoptionButton.Click += new System.EventHandler(this.submitAdoptionButton_Click);
            // 
            // isReturnCheck
            // 
            this.isReturnCheck.AutoSize = true;
            this.isReturnCheck.Location = new System.Drawing.Point(249, 220);
            this.isReturnCheck.Name = "isReturnCheck";
            this.isReturnCheck.Size = new System.Drawing.Size(82, 19);
            this.isReturnCheck.TabIndex = 6;
            this.isReturnCheck.Text = "Devolução";
            this.isReturnCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID Animal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID Dono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID Vet Responsável";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Taxa";
            // 
            // newOwner
            // 
            this.newOwner.AutoSize = true;
            this.newOwner.Location = new System.Drawing.Point(451, 95);
            this.newOwner.Name = "newOwner";
            this.newOwner.Size = new System.Drawing.Size(68, 15);
            this.newOwner.TabIndex = 12;
            this.newOwner.TabStop = true;
            this.newOwner.Text = "Novo Dono";
            this.newOwner.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newOwner_LinkClicked);
            // 
            // dtpAdoptionDate
            // 
            this.dtpAdoptionDate.Location = new System.Drawing.Point(249, 150);
            this.dtpAdoptionDate.Name = "dtpAdoptionDate";
            this.dtpAdoptionDate.Size = new System.Drawing.Size(200, 23);
            this.dtpAdoptionDate.TabIndex = 13;
            // 
            // Adoption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpAdoptionDate);
            this.Controls.Add(this.newOwner);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isReturnCheck);
            this.Controls.Add(this.submitAdoptionButton);
            this.Controls.Add(this.txtAdoptionFee);
            this.Controls.Add(this.txtVetID);
            this.Controls.Add(this.txtOwnerID);
            this.Controls.Add(this.txtAnimalID);
            this.Name = "Adoption";
            this.Text = "Adoption";
            this.Load += new System.EventHandler(this.Adoption_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAnimalID;
        private TextBox txtOwnerID;
        private TextBox txtVetID;
        private TextBox txtAdoptionFee;
        private Button submitAdoptionButton;
        private CheckBox isReturnCheck;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private LinkLabel newOwner;
        private DateTimePicker dtpAdoptionDate;
    }
}