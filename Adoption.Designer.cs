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
            this.txtAdoptionDate = new System.Windows.Forms.TextBox();
            this.txtAdoptionFee = new System.Windows.Forms.TextBox();
            this.submitAdoptionButton = new System.Windows.Forms.Button();
            this.isReturnCheck = new System.Windows.Forms.CheckBox();
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
            // txtAdoptionDate
            // 
            this.txtAdoptionDate.Location = new System.Drawing.Point(249, 150);
            this.txtAdoptionDate.Name = "txtAdoptionDate";
            this.txtAdoptionDate.Size = new System.Drawing.Size(196, 23);
            this.txtAdoptionDate.TabIndex = 3;
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
            this.submitAdoptionButton.Text = "button1";
            this.submitAdoptionButton.UseVisualStyleBackColor = true;
            this.submitAdoptionButton.Click += new System.EventHandler(this.submitAdoptionButton_Click);
            // 
            // isReturnCheck
            // 
            this.isReturnCheck.AutoSize = true;
            this.isReturnCheck.Location = new System.Drawing.Point(249, 220);
            this.isReturnCheck.Name = "isReturnCheck";
            this.isReturnCheck.Size = new System.Drawing.Size(83, 19);
            this.isReturnCheck.TabIndex = 6;
            this.isReturnCheck.Text = "checkBox1";
            this.isReturnCheck.UseVisualStyleBackColor = true;
            // 
            // Adoption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.isReturnCheck);
            this.Controls.Add(this.submitAdoptionButton);
            this.Controls.Add(this.txtAdoptionFee);
            this.Controls.Add(this.txtAdoptionDate);
            this.Controls.Add(this.txtVetID);
            this.Controls.Add(this.txtOwnerID);
            this.Controls.Add(this.txtAnimalID);
            this.Name = "Adoption";
            this.Text = "Adoption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAnimalID;
        private TextBox txtOwnerID;
        private TextBox txtVetID;
        private TextBox txtAdoptionDate;
        private TextBox txtAdoptionFee;
        private Button submitAdoptionButton;
        private CheckBox isReturnCheck;
    }
}