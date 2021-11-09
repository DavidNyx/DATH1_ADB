namespace DBSM_Project
{
    partial class ShowBill
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
            this.Bill = new System.Windows.Forms.GroupBox();
            this.BillList = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.Bill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillList)).BeginInit();
            this.SuspendLayout();
            // 
            // Bill
            // 
            this.Bill.Controls.Add(this.BillList);
            this.Bill.Location = new System.Drawing.Point(12, 12);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(634, 374);
            this.Bill.TabIndex = 3;
            this.Bill.TabStop = false;
            this.Bill.Text = "Danh sách hóa đơn";
            // 
            // BillList
            // 
            this.BillList.AllowUserToAddRows = false;
            this.BillList.AllowUserToDeleteRows = false;
            this.BillList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillList.Location = new System.Drawing.Point(0, 20);
            this.BillList.Name = "BillList";
            this.BillList.ReadOnly = true;
            this.BillList.Size = new System.Drawing.Size(634, 354);
            this.BillList.TabIndex = 0;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Back.Location = new System.Drawing.Point(268, 393);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(118, 45);
            this.Back.TabIndex = 4;
            this.Back.Text = "Quay về";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ShowBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Bill);
            this.Name = "ShowBill";
            this.Text = "ShowBill";
            this.Load += new System.EventHandler(this.ShowBill_Load);
            this.Bill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BillList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Bill;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView BillList;
    }
}