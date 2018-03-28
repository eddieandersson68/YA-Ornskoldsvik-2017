namespace FormsBank
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblA2 = new System.Windows.Forms.Label();
            this.lblA1 = new System.Windows.Forms.Label();
            this.tBxAccount1Balance = new System.Windows.Forms.TextBox();
            this.tBxAccount2Balance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txBxTrans2 = new System.Windows.Forms.TextBox();
            this.txBxTrans1 = new System.Windows.Forms.TextBox();
            this.dep = new System.Windows.Forms.Label();
            this.txBxDeposit1 = new System.Windows.Forms.TextBox();
            this.txBxDeposit2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstTransaction1 = new System.Windows.Forms.ListBox();
            this.lstTransaction2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account 2";
            // 
            // lblA2
            // 
            this.lblA2.AutoSize = true;
            this.lblA2.Location = new System.Drawing.Point(318, 186);
            this.lblA2.Name = "lblA2";
            this.lblA2.Size = new System.Drawing.Size(46, 13);
            this.lblA2.TabIndex = 2;
            this.lblA2.Text = "Balance";
            // 
            // lblA1
            // 
            this.lblA1.AutoSize = true;
            this.lblA1.Location = new System.Drawing.Point(318, 25);
            this.lblA1.Name = "lblA1";
            this.lblA1.Size = new System.Drawing.Size(46, 13);
            this.lblA1.TabIndex = 3;
            this.lblA1.Text = "Balance";
            // 
            // tBxAccount1Balance
            // 
            this.tBxAccount1Balance.Location = new System.Drawing.Point(321, 41);
            this.tBxAccount1Balance.Name = "tBxAccount1Balance";
            this.tBxAccount1Balance.Size = new System.Drawing.Size(100, 20);
            this.tBxAccount1Balance.TabIndex = 6;
            // 
            // tBxAccount2Balance
            // 
            this.tBxAccount2Balance.Location = new System.Drawing.Point(321, 202);
            this.tBxAccount2Balance.Name = "tBxAccount2Balance";
            this.tBxAccount2Balance.Size = new System.Drawing.Size(100, 20);
            this.tBxAccount2Balance.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Transfer Kr:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Transfer Kr:";
            // 
            // txBxTrans2
            // 
            this.txBxTrans2.Location = new System.Drawing.Point(176, 202);
            this.txBxTrans2.Name = "txBxTrans2";
            this.txBxTrans2.Size = new System.Drawing.Size(100, 20);
            this.txBxTrans2.TabIndex = 10;
            this.txBxTrans2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txBxTrans2_KeyDown);
            // 
            // txBxTrans1
            // 
            this.txBxTrans1.Location = new System.Drawing.Point(176, 41);
            this.txBxTrans1.Name = "txBxTrans1";
            this.txBxTrans1.Size = new System.Drawing.Size(100, 20);
            this.txBxTrans1.TabIndex = 11;
            this.txBxTrans1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txBxTrans1_KeyUp);
            // 
            // dep
            // 
            this.dep.AutoSize = true;
            this.dep.Location = new System.Drawing.Point(28, 25);
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(59, 13);
            this.dep.TabIndex = 12;
            this.dep.Text = "Deposit Kr:";
            // 
            // txBxDeposit1
            // 
            this.txBxDeposit1.Location = new System.Drawing.Point(31, 41);
            this.txBxDeposit1.Name = "txBxDeposit1";
            this.txBxDeposit1.Size = new System.Drawing.Size(112, 20);
            this.txBxDeposit1.TabIndex = 13;
            this.txBxDeposit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txBxDeposit1_KeyDown);
            // 
            // txBxDeposit2
            // 
            this.txBxDeposit2.Location = new System.Drawing.Point(31, 202);
            this.txBxDeposit2.Name = "txBxDeposit2";
            this.txBxDeposit2.Size = new System.Drawing.Size(112, 20);
            this.txBxDeposit2.TabIndex = 14;
            this.txBxDeposit2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txBxDeposit2_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Deposit Kr:";
            // 
            // lstTransaction1
            // 
            this.lstTransaction1.FormattingEnabled = true;
            this.lstTransaction1.Location = new System.Drawing.Point(176, 78);
            this.lstTransaction1.Name = "lstTransaction1";
            this.lstTransaction1.Size = new System.Drawing.Size(100, 95);
            this.lstTransaction1.TabIndex = 16;
            // 
            // lstTransaction2
            // 
            this.lstTransaction2.FormattingEnabled = true;
            this.lstTransaction2.Location = new System.Drawing.Point(176, 256);
            this.lstTransaction2.Name = "lstTransaction2";
            this.lstTransaction2.Size = new System.Drawing.Size(100, 95);
            this.lstTransaction2.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 401);
            this.Controls.Add(this.lstTransaction2);
            this.Controls.Add(this.lstTransaction1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txBxDeposit2);
            this.Controls.Add(this.txBxDeposit1);
            this.Controls.Add(this.dep);
            this.Controls.Add(this.txBxTrans1);
            this.Controls.Add(this.txBxTrans2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBxAccount2Balance);
            this.Controls.Add(this.tBxAccount1Balance);
            this.Controls.Add(this.lblA1);
            this.Controls.Add(this.lblA2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblA2;
        private System.Windows.Forms.Label lblA1;
        private System.Windows.Forms.TextBox tBxAccount1Balance;
        private System.Windows.Forms.TextBox tBxAccount2Balance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txBxTrans2;
        private System.Windows.Forms.TextBox txBxTrans1;
        private System.Windows.Forms.Label dep;
        private System.Windows.Forms.TextBox txBxDeposit1;
        private System.Windows.Forms.TextBox txBxDeposit2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstTransaction1;
        private System.Windows.Forms.ListBox lstTransaction2;
    }
}

