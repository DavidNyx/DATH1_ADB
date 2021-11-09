namespace DBSM_Project
{
    partial class Menu
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
            this.ShowBill = new System.Windows.Forms.Button();
            this.InsertBill = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // ShowBill
            // 
            this.ShowBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ShowBill.Location = new System.Drawing.Point(198, 150);
            this.ShowBill.Name = "ShowBill";
            this.ShowBill.Size = new System.Drawing.Size(124, 42);
            this.ShowBill.TabIndex = 2;
            this.ShowBill.Text = "Xem hóa đơn";
            this.ShowBill.UseVisualStyleBackColor = true;
            this.ShowBill.Click += new System.EventHandler(this.ShowBill_Click);
            // 
            // InsertBill
            // 
            this.InsertBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InsertBill.Location = new System.Drawing.Point(198, 73);
            this.InsertBill.Name = "InsertBill";
            this.InsertBill.Size = new System.Drawing.Size(124, 42);
            this.InsertBill.TabIndex = 1;
            this.InsertBill.Text = "Thêm hóa đơn";
            this.InsertBill.UseVisualStyleBackColor = true;
            this.InsertBill.Click += new System.EventHandler(this.InsertBill_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.Location = new System.Drawing.Point(198, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Thống kê doanh thu";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Exit.Location = new System.Drawing.Point(415, 281);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(124, 42);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 335);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.InsertBill);
            this.Controls.Add(this.ShowBill);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowBill;
        private System.Windows.Forms.Button InsertBill;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Exit;
    }
}