namespace PersonRegistry
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
            this.tbxFirstname = new System.Windows.Forms.TextBox();
            this.tbxLastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.grpNewPerson = new System.Windows.Forms.GroupBox();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.grpPersons = new System.Windows.Forms.GroupBox();
            this.lsBxPersons = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblFirstOrLastname = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpNewPerson.SuspendLayout();
            this.grpPersons.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxFirstname
            // 
            this.tbxFirstname.Location = new System.Drawing.Point(16, 45);
            this.tbxFirstname.Name = "tbxFirstname";
            this.tbxFirstname.Size = new System.Drawing.Size(100, 20);
            this.tbxFirstname.TabIndex = 0;
            this.tbxFirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFirstname_KeyPress);
            // 
            // tbxLastname
            // 
            this.tbxLastname.Location = new System.Drawing.Point(170, 45);
            this.tbxLastname.Name = "tbxLastname";
            this.tbxLastname.Size = new System.Drawing.Size(100, 20);
            this.tbxLastname.TabIndex = 1;
            this.tbxLastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLastname_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lastname";
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(16, 82);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(51, 17);
            this.rdbMale.TabIndex = 4;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male ";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // grpNewPerson
            // 
            this.grpNewPerson.Controls.Add(this.btnAddToList);
            this.grpNewPerson.Controls.Add(this.rdbFemale);
            this.grpNewPerson.Controls.Add(this.tbxFirstname);
            this.grpNewPerson.Controls.Add(this.label2);
            this.grpNewPerson.Controls.Add(this.rdbMale);
            this.grpNewPerson.Controls.Add(this.label1);
            this.grpNewPerson.Controls.Add(this.tbxLastname);
            this.grpNewPerson.Location = new System.Drawing.Point(12, 32);
            this.grpNewPerson.Name = "grpNewPerson";
            this.grpNewPerson.Size = new System.Drawing.Size(347, 156);
            this.grpNewPerson.TabIndex = 5;
            this.grpNewPerson.TabStop = false;
            this.grpNewPerson.Text = "New person";
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(182, 118);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(75, 23);
            this.btnAddToList.TabIndex = 6;
            this.btnAddToList.Text = "Add";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(16, 124);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(59, 17);
            this.rdbFemale.TabIndex = 5;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // grpPersons
            // 
            this.grpPersons.Controls.Add(this.lsBxPersons);
            this.grpPersons.Location = new System.Drawing.Point(365, 32);
            this.grpPersons.Name = "grpPersons";
            this.grpPersons.Size = new System.Drawing.Size(348, 269);
            this.grpPersons.TabIndex = 6;
            this.grpPersons.TabStop = false;
            this.grpPersons.Text = "List of persons";
            // 
            // lsBxPersons
            // 
            this.lsBxPersons.FormattingEnabled = true;
            this.lsBxPersons.Location = new System.Drawing.Point(22, 19);
            this.lsBxPersons.Name = "lsBxPersons";
            this.lsBxPersons.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsBxPersons.Size = new System.Drawing.Size(296, 238);
            this.lsBxPersons.TabIndex = 0;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(41, 392);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 7;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(186, 392);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(75, 23);
            this.btnMerge.TabIndex = 8;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(331, 392);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.lblFirstOrLastname);
            this.grpSearch.Controls.Add(this.tbxSearch);
            this.grpSearch.Location = new System.Drawing.Point(12, 214);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(347, 87);
            this.grpSearch.TabIndex = 10;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // lblFirstOrLastname
            // 
            this.lblFirstOrLastname.AutoSize = true;
            this.lblFirstOrLastname.Location = new System.Drawing.Point(20, 24);
            this.lblFirstOrLastname.Name = "lblFirstOrLastname";
            this.lblFirstOrLastname.Size = new System.Drawing.Size(94, 13);
            this.lblFirstOrLastname.TabIndex = 7;
            this.lblFirstOrLastname.Text = "First OR Lastname";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(23, 48);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(281, 20);
            this.tbxSearch.TabIndex = 0;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            this.tbxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSearch_KeyPress);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(476, 392);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(621, 392);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(694, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select two people in the list that are of the  opposite sex and hit the merge but" +
    "ton to make a child.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(397, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "I think the rest of the buttons are quite self explanatory.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 432);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.grpPersons);
            this.Controls.Add(this.grpNewPerson);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person registry";
            this.grpNewPerson.ResumeLayout(false);
            this.grpNewPerson.PerformLayout();
            this.grpPersons.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFirstname;
        private System.Windows.Forms.TextBox tbxLastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.GroupBox grpNewPerson;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.GroupBox grpPersons;
        private System.Windows.Forms.ListBox lsBxPersons;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblFirstOrLastname;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

