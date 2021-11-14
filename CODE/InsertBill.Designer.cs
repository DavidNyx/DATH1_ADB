namespace DBSM_Project
{
    partial class InsertBill
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
            this.BillEnter = new System.Windows.Forms.GroupBox();
            this.InsertDataButton = new System.Windows.Forms.Button();
            this.txtTONGTIEN = new System.Windows.Forms.TextBox();
            this.txtNGAYLAP = new System.Windows.Forms.TextBox();
            this.txtMAKH = new System.Windows.Forms.TextBox();
            this.txtMAHD = new System.Windows.Forms.TextBox();
            this.TONGTIEN = new System.Windows.Forms.Label();
            this.NGAYLAP = new System.Windows.Forms.Label();
            this.MAKH = new System.Windows.Forms.Label();
            this.MAHD = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.BillEnter.SuspendLayout();
            this.SuspendLayout();
            // 
            // BillEnter
            // 
            this.BillEnter.Controls.Add(this.InsertDataButton);
            this.BillEnter.Controls.Add(this.txtTONGTIEN);
            this.BillEnter.Controls.Add(this.txtNGAYLAP);
            this.BillEnter.Controls.Add(this.txtMAKH);
            this.BillEnter.Controls.Add(this.txtMAHD);
            this.BillEnter.Controls.Add(this.TONGTIEN);
            this.BillEnter.Controls.Add(this.NGAYLAP);
            this.BillEnter.Controls.Add(this.MAKH);
            this.BillEnter.Controls.Add(this.MAHD);
            this.BillEnter.Location = new System.Drawing.Point(80, 12);
            this.BillEnter.Name = "BillEnter";
            this.BillEnter.Size = new System.Drawing.Size(346, 374);
            this.BillEnter.TabIndex = 3;
            this.BillEnter.TabStop = false;
            this.BillEnter.Text = "Nhập hóa đơn";
            // 
            // InsertDataButton
            // 
            this.InsertDataButton.Location = new System.Drawing.Point(90, 282);
            this.InsertDataButton.Name = "InsertDataButton";
            this.InsertDataButton.Size = new System.Drawing.Size(157, 36);
            this.InsertDataButton.TabIndex = 8;
            this.InsertDataButton.Text = "Thêm dữ liệu";
            this.InsertDataButton.UseVisualStyleBackColor = true;
            this.InsertDataButton.Click += new System.EventHandler(this.InsertData_Click);
            // 
            // txtTONGTIEN
            // 
            this.txtTONGTIEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTONGTIEN.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTONGTIEN.Location = new System.Drawing.Point(90, 197);
            this.txtTONGTIEN.Name = "txtTONGTIEN";
            this.txtTONGTIEN.Size = new System.Drawing.Size(183, 24);
            this.txtTONGTIEN.TabIndex = 7;
            this.txtTONGTIEN.Text = "Tổng tiền (số)";
            this.txtTONGTIEN.Enter += new System.EventHandler(this.txtTONGTIEN_Enter);
            this.txtTONGTIEN.Leave += new System.EventHandler(this.txtTONGTIEN_Leave);
            // 
            // txtNGAYLAP
            // 
            this.txtNGAYLAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtNGAYLAP.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNGAYLAP.Location = new System.Drawing.Point(90, 139);
            this.txtNGAYLAP.Name = "txtNGAYLAP";
            this.txtNGAYLAP.Size = new System.Drawing.Size(183, 24);
            this.txtNGAYLAP.TabIndex = 6;
            this.txtNGAYLAP.Text = "dd-mm-yy (vd: 20-5-21)";
            this.txtNGAYLAP.Enter += new System.EventHandler(this.txtNGAYLAP_Enter);
            this.txtNGAYLAP.Leave += new System.EventHandler(this.txtNGAYLAP_Leave);
            // 
            // txtMAKH
            // 
            this.txtMAKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtMAKH.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMAKH.Location = new System.Drawing.Point(90, 77);
            this.txtMAKH.Name = "txtMAKH";
            this.txtMAKH.Size = new System.Drawing.Size(183, 24);
            this.txtMAKH.TabIndex = 5;
            this.txtMAKH.Text = "Mã khách hàng";
            this.txtMAKH.Enter += new System.EventHandler(this.txtMAKH_Enter);
            this.txtMAKH.Leave += new System.EventHandler(this.txtMAKH_Leave);
            // 
            // txtMAHD
            // 
            this.txtMAHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtMAHD.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMAHD.Location = new System.Drawing.Point(90, 19);
            this.txtMAHD.Name = "txtMAHD";
            this.txtMAHD.Size = new System.Drawing.Size(183, 24);
            this.txtMAHD.TabIndex = 4;
            this.txtMAHD.Text = "Mã hóa đơn";
            this.txtMAHD.Enter += new System.EventHandler(this.txtMAHD_Enter);
            this.txtMAHD.Leave += new System.EventHandler(this.txtMAHD_Leave);
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.AutoSize = true;
            this.TONGTIEN.Location = new System.Drawing.Point(7, 204);
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.Size = new System.Drawing.Size(63, 13);
            this.TONGTIEN.TabIndex = 3;
            this.TONGTIEN.Text = "TONGTIEN";
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.AutoSize = true;
            this.NGAYLAP.Location = new System.Drawing.Point(7, 142);
            this.NGAYLAP.Name = "NGAYLAP";
            this.NGAYLAP.Size = new System.Drawing.Size(57, 13);
            this.NGAYLAP.TabIndex = 2;
            this.NGAYLAP.Text = "NGAYLAP";
            // 
            // MAKH
            // 
            this.MAKH.AutoSize = true;
            this.MAKH.Location = new System.Drawing.Point(7, 77);
            this.MAKH.Name = "MAKH";
            this.MAKH.Size = new System.Drawing.Size(38, 13);
            this.MAKH.TabIndex = 1;
            this.MAKH.Text = "MAKH";
            // 
            // MAHD
            // 
            this.MAHD.AutoSize = true;
            this.MAHD.Location = new System.Drawing.Point(7, 20);
            this.MAHD.Name = "MAHD";
            this.MAHD.Size = new System.Drawing.Size(39, 13);
            this.MAHD.TabIndex = 0;
            this.MAHD.Text = "MAHD";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(170, 392);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(157, 46);
            this.Back.TabIndex = 4;
            this.Back.Text = "Quay về";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // InsertBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.BillEnter);
            this.Name = "InsertBill";
            this.Text = "InsertBill";
            this.BillEnter.ResumeLayout(false);
            this.BillEnter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox BillEnter;
        private System.Windows.Forms.Label MAHD;
        private System.Windows.Forms.Label TONGTIEN;
        private System.Windows.Forms.Label NGAYLAP;
        private System.Windows.Forms.Label MAKH;
        private System.Windows.Forms.Button InsertDataButton;
        private System.Windows.Forms.TextBox txtTONGTIEN;
        private System.Windows.Forms.TextBox txtNGAYLAP;
        private System.Windows.Forms.TextBox txtMAKH;
        private System.Windows.Forms.TextBox txtMAHD;
        private System.Windows.Forms.Button Back;
    }
}

