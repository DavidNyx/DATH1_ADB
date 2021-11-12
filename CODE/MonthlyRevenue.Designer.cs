namespace DBSM_Project
{
    partial class MonthlyRevenue
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RevenueList = new System.Windows.Forms.DataGridView();
            this.YearList = new System.Windows.Forms.ComboBox();
            this.Year = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RevenueList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RevenueList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(68, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê doanh thu theo tháng";
            // 
            // RevenueList
            // 
            this.RevenueList.AllowUserToAddRows = false;
            this.RevenueList.AllowUserToDeleteRows = false;
            this.RevenueList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RevenueList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RevenueList.Location = new System.Drawing.Point(0, 20);
            this.RevenueList.Name = "RevenueList";
            this.RevenueList.ReadOnly = true;
            this.RevenueList.Size = new System.Drawing.Size(370, 363);
            this.RevenueList.TabIndex = 0;
            // 
            // YearList
            // 
            this.YearList.FormattingEnabled = true;
            this.YearList.Items.AddRange(new object[] {
            "2020",
            "2021"});
            this.YearList.Location = new System.Drawing.Point(362, 13);
            this.YearList.Name = "YearList";
            this.YearList.Size = new System.Drawing.Size(121, 21);
            this.YearList.TabIndex = 1;
            this.YearList.Text = "2021";
            this.YearList.SelectedIndexChanged += new System.EventHandler(this.YearList_SelectedIndexChanged);
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Year.Location = new System.Drawing.Point(322, 14);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(34, 15);
            this.Year.TabIndex = 2;
            this.Year.Text = "Năm";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(83, 37);
            this.Back.TabIndex = 3;
            this.Back.Text = "Quay về";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // MonthlyRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.YearList);
            this.Controls.Add(this.groupBox1);
            this.Name = "MonthlyRevenue";
            this.Text = "MonthlyRevenue";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RevenueList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView RevenueList;
        private System.Windows.Forms.ComboBox YearList;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Button Back;
    }
}