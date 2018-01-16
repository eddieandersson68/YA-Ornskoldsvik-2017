namespace WarGames
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
            this.pnl = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.PictureBox();
            this.front = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.front)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl.Location = new System.Drawing.Point(29, 564);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(103, 93);
            this.pnl.TabIndex = 1;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(1329, 514);
            this.back.TabIndex = 0;
            this.back.TabStop = false;
            // 
            // front
            // 
            this.front.BackColor = System.Drawing.SystemColors.Control;
            this.front.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.front.Location = new System.Drawing.Point(415, 205);
            this.front.Name = "front";
            this.front.Size = new System.Drawing.Size(461, 103);
            this.front.TabIndex = 0;
            this.front.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1370, 669);
            this.Controls.Add(this.front);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.back);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.front)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox front;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.PictureBox back;
    }
}

