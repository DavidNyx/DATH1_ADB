namespace DBSM_Project
{
    partial class Connect
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
            this.ServerName = new System.Windows.Forms.Label();
            this.DBName = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.ServerConnectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServerName
            // 
            this.ServerName.AutoSize = true;
            this.ServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ServerName.Location = new System.Drawing.Point(16, 55);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(80, 18);
            this.ServerName.TabIndex = 0;
            this.ServerName.Text = "Tên Server";
            // 
            // DBName
            // 
            this.DBName.AutoSize = true;
            this.DBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DBName.Location = new System.Drawing.Point(16, 107);
            this.DBName.Name = "DBName";
            this.DBName.Size = new System.Drawing.Size(100, 18);
            this.DBName.TabIndex = 1;
            this.DBName.Text = "Tên Database";
            // 
            // txtServerName
            // 
            this.txtServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtServerName.Location = new System.Drawing.Point(139, 52);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(162, 21);
            this.txtServerName.TabIndex = 2;
            // 
            // txtDBName
            // 
            this.txtDBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtDBName.Location = new System.Drawing.Point(139, 106);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(162, 21);
            this.txtDBName.TabIndex = 3;
            this.txtDBName.Text = "STORE";
            
            // 
            // ServerConnectBtn
            // 
            this.ServerConnectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ServerConnectBtn.Location = new System.Drawing.Point(73, 148);
            this.ServerConnectBtn.Name = "ServerConnectBtn";
            this.ServerConnectBtn.Size = new System.Drawing.Size(228, 38);
            this.ServerConnectBtn.TabIndex = 4;
            this.ServerConnectBtn.Text = "Kết nối Server";
            this.ServerConnectBtn.UseVisualStyleBackColor = true;
            this.ServerConnectBtn.Click += new System.EventHandler(this.ServerConnectBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 198);
            this.Controls.Add(this.ServerConnectBtn);
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.DBName);
            this.Controls.Add(this.ServerName);
            this.Name = "Connect";
            this.Text = "Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServerName;
        private System.Windows.Forms.Label DBName;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.Button ServerConnectBtn;
    }
}