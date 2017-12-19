namespace EntityFramework01
{
    partial class Form1
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
            this.lstBxStaff = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmBxFirstName = new System.Windows.Forms.ComboBox();
            this.cmBxLastName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateDBStaff = new System.Windows.Forms.Button();
            this.txBxFirstName = new System.Windows.Forms.TextBox();
            this.txBxLastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstBxStaff
            // 
            this.lstBxStaff.FormattingEnabled = true;
            this.lstBxStaff.Location = new System.Drawing.Point(16, 54);
            this.lstBxStaff.Name = "lstBxStaff";
            this.lstBxStaff.Size = new System.Drawing.Size(352, 212);
            this.lstBxStaff.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employees";
            // 
            // cmBxFirstName
            // 
            this.cmBxFirstName.FormattingEnabled = true;
            this.cmBxFirstName.Location = new System.Drawing.Point(374, 155);
            this.cmBxFirstName.Name = "cmBxFirstName";
            this.cmBxFirstName.Size = new System.Drawing.Size(121, 21);
            this.cmBxFirstName.TabIndex = 2;
            // 
            // cmBxLastName
            // 
            this.cmBxLastName.FormattingEnabled = true;
            this.cmBxLastName.Location = new System.Drawing.Point(378, 80);
            this.cmBxLastName.Name = "cmBxLastName";
            this.cmBxLastName.Size = new System.Drawing.Size(121, 21);
            this.cmBxLastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "FirstName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "LastName";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(15, 336);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(402, 336);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateDBStaff
            // 
            this.btnUpdateDBStaff.Location = new System.Drawing.Point(203, 336);
            this.btnUpdateDBStaff.Name = "btnUpdateDBStaff";
            this.btnUpdateDBStaff.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateDBStaff.TabIndex = 8;
            this.btnUpdateDBStaff.Text = "Update";
            this.btnUpdateDBStaff.UseVisualStyleBackColor = true;
            this.btnUpdateDBStaff.Click += new System.EventHandler(this.btnUpdateDBStaff_Click);
            // 
            // txBxFirstName
            // 
            this.txBxFirstName.Location = new System.Drawing.Point(16, 292);
            this.txBxFirstName.Name = "txBxFirstName";
            this.txBxFirstName.Size = new System.Drawing.Size(100, 20);
            this.txBxFirstName.TabIndex = 9;
            // 
            // txBxLastName
            // 
            this.txBxLastName.Location = new System.Drawing.Point(246, 292);
            this.txBxLastName.Name = "txBxLastName";
            this.txBxLastName.Size = new System.Drawing.Size(100, 20);
            this.txBxLastName.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 490);
            this.Controls.Add(this.txBxLastName);
            this.Controls.Add(this.txBxFirstName);
            this.Controls.Add(this.btnUpdateDBStaff);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmBxLastName);
            this.Controls.Add(this.cmBxFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBxStaff);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmBxFirstName;
        private System.Windows.Forms.ComboBox cmBxLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateDBStaff;
        private System.Windows.Forms.TextBox txBxFirstName;
        private System.Windows.Forms.TextBox txBxLastName;
    }
}

