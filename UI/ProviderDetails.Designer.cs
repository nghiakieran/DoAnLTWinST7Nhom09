namespace UI
{
    partial class ProviderDetails
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
            this.btnUP = new Guna.UI2.WinForms.Guna2Button();
            this.btnDP = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddPD = new Guna.UI2.WinForms.Guna2Button();
            this.tbMaPhieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gwProviderDetail = new System.Windows.Forms.DataGridView();
            this.btnRD = new Guna.UI2.WinForms.Guna2Button();
            this.tbMaSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbQty = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNameSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gwProviderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUP
            // 
            this.btnUP.BorderRadius = 10;
            this.btnUP.CheckedState.Parent = this.btnUP;
            this.btnUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUP.CustomImages.Parent = this.btnUP;
            this.btnUP.FillColor = System.Drawing.Color.Blue;
            this.btnUP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUP.ForeColor = System.Drawing.Color.White;
            this.btnUP.HoverState.Parent = this.btnUP;
            this.btnUP.Location = new System.Drawing.Point(1118, 519);
            this.btnUP.Name = "btnUP";
            this.btnUP.PressedColor = System.Drawing.Color.Transparent;
            this.btnUP.ShadowDecoration.Parent = this.btnUP;
            this.btnUP.Size = new System.Drawing.Size(80, 37);
            this.btnUP.TabIndex = 56;
            this.btnUP.Text = "Sửa";
            this.btnUP.Click += new System.EventHandler(this.btnUpdateProvider_Click);
            // 
            // btnDP
            // 
            this.btnDP.BorderRadius = 10;
            this.btnDP.CheckedState.Parent = this.btnDP;
            this.btnDP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDP.CustomImages.Parent = this.btnDP;
            this.btnDP.FillColor = System.Drawing.Color.Red;
            this.btnDP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDP.ForeColor = System.Drawing.Color.White;
            this.btnDP.HoverState.Parent = this.btnDP;
            this.btnDP.Location = new System.Drawing.Point(1028, 519);
            this.btnDP.Name = "btnDP";
            this.btnDP.PressedColor = System.Drawing.Color.Transparent;
            this.btnDP.ShadowDecoration.Parent = this.btnDP;
            this.btnDP.Size = new System.Drawing.Size(78, 37);
            this.btnDP.TabIndex = 55;
            this.btnDP.Text = "Xóa";
            // 
            // btnAddPD
            // 
            this.btnAddPD.BorderRadius = 10;
            this.btnAddPD.CheckedState.Parent = this.btnAddPD;
            this.btnAddPD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPD.CustomImages.Parent = this.btnAddPD;
            this.btnAddPD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddPD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPD.ForeColor = System.Drawing.Color.White;
            this.btnAddPD.HoverState.Parent = this.btnAddPD;
            this.btnAddPD.Location = new System.Drawing.Point(931, 519);
            this.btnAddPD.Name = "btnAddPD";
            this.btnAddPD.PressedColor = System.Drawing.Color.Transparent;
            this.btnAddPD.ShadowDecoration.Parent = this.btnAddPD;
            this.btnAddPD.Size = new System.Drawing.Size(83, 37);
            this.btnAddPD.TabIndex = 54;
            this.btnAddPD.Text = "Thêm";
            // 
            // tbMaPhieu
            // 
            this.tbMaPhieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMaPhieu.DefaultText = "";
            this.tbMaPhieu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMaPhieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMaPhieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMaPhieu.DisabledState.Parent = this.tbMaPhieu;
            this.tbMaPhieu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMaPhieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaPhieu.FocusedState.Parent = this.tbMaPhieu;
            this.tbMaPhieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaPhieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaPhieu.HoverState.Parent = this.tbMaPhieu;
            this.tbMaPhieu.Location = new System.Drawing.Point(1067, 90);
            this.tbMaPhieu.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbMaPhieu.Name = "tbMaPhieu";
            this.tbMaPhieu.PasswordChar = '\0';
            this.tbMaPhieu.PlaceholderText = "";
            this.tbMaPhieu.ReadOnly = true;
            this.tbMaPhieu.SelectedText = "";
            this.tbMaPhieu.ShadowDecoration.Parent = this.tbMaPhieu;
            this.tbMaPhieu.Size = new System.Drawing.Size(157, 32);
            this.tbMaPhieu.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(948, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "Mã phiếu:";
            // 
            // gwProviderDetail
            // 
            this.gwProviderDetail.BackgroundColor = System.Drawing.Color.White;
            this.gwProviderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwProviderDetail.Location = new System.Drawing.Point(15, 66);
            this.gwProviderDetail.Name = "gwProviderDetail";
            this.gwProviderDetail.RowHeadersWidth = 51;
            this.gwProviderDetail.RowTemplate.Height = 24;
            this.gwProviderDetail.Size = new System.Drawing.Size(899, 533);
            this.gwProviderDetail.TabIndex = 46;
            // 
            // btnRD
            // 
            this.btnRD.BorderRadius = 10;
            this.btnRD.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnRD.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnRD.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnRD.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.btnRD.CheckedState.Parent = this.btnRD;
            this.btnRD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRD.CustomImages.Parent = this.btnRD;
            this.btnRD.FillColor = System.Drawing.Color.Transparent;
            this.btnRD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRD.ForeColor = System.Drawing.Color.White;
            this.btnRD.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnRD.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnRD.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnRD.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btnRD.HoverState.Parent = this.btnRD;
            this.btnRD.Image = global::UI.Properties.Resources.sync;
            this.btnRD.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRD.Location = new System.Drawing.Point(1205, 514);
            this.btnRD.Name = "btnRD";
            this.btnRD.PressedColor = System.Drawing.Color.Transparent;
            this.btnRD.ShadowDecoration.Parent = this.btnRD;
            this.btnRD.Size = new System.Drawing.Size(58, 46);
            this.btnRD.TabIndex = 57;
            // 
            // tbMaSP
            // 
            this.tbMaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMaSP.DefaultText = "";
            this.tbMaSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMaSP.DisabledState.Parent = this.tbMaSP;
            this.tbMaSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMaSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaSP.FocusedState.Parent = this.tbMaSP;
            this.tbMaSP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaSP.HoverState.Parent = this.tbMaSP;
            this.tbMaSP.Location = new System.Drawing.Point(1067, 170);
            this.tbMaSP.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbMaSP.Name = "tbMaSP";
            this.tbMaSP.PasswordChar = '\0';
            this.tbMaSP.PlaceholderText = "";
            this.tbMaSP.ReadOnly = true;
            this.tbMaSP.SelectedText = "";
            this.tbMaSP.ShadowDecoration.Parent = this.tbMaSP;
            this.tbMaSP.Size = new System.Drawing.Size(157, 32);
            this.tbMaSP.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(948, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Mã SP:";
            // 
            // tbQty
            // 
            this.tbQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbQty.DefaultText = "";
            this.tbQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbQty.DisabledState.Parent = this.tbQty;
            this.tbQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbQty.FocusedState.Parent = this.tbQty;
            this.tbQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbQty.HoverState.Parent = this.tbQty;
            this.tbQty.Location = new System.Drawing.Point(1067, 345);
            this.tbQty.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbQty.Name = "tbQty";
            this.tbQty.PasswordChar = '\0';
            this.tbQty.PlaceholderText = "";
            this.tbQty.ReadOnly = true;
            this.tbQty.SelectedText = "";
            this.tbQty.ShadowDecoration.Parent = this.tbQty;
            this.tbQty.Size = new System.Drawing.Size(157, 32);
            this.tbQty.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(948, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 60;
            this.label3.Text = "Số Lượng:";
            // 
            // tbPrice
            // 
            this.tbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrice.DefaultText = "";
            this.tbPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrice.DisabledState.Parent = this.tbPrice;
            this.tbPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.FocusedState.Parent = this.tbPrice;
            this.tbPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.HoverState.Parent = this.tbPrice;
            this.tbPrice.Location = new System.Drawing.Point(1067, 430);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.PlaceholderText = "";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.SelectedText = "";
            this.tbPrice.ShadowDecoration.Parent = this.tbPrice;
            this.tbPrice.Size = new System.Drawing.Size(157, 32);
            this.tbPrice.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(948, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 62;
            this.label4.Text = "Đơn giá:";
            // 
            // tbNameSP
            // 
            this.tbNameSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNameSP.DefaultText = "";
            this.tbNameSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNameSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNameSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNameSP.DisabledState.Parent = this.tbNameSP;
            this.tbNameSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNameSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameSP.FocusedState.Parent = this.tbNameSP;
            this.tbNameSP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameSP.HoverState.Parent = this.tbNameSP;
            this.tbNameSP.Location = new System.Drawing.Point(1067, 256);
            this.tbNameSP.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbNameSP.Name = "tbNameSP";
            this.tbNameSP.PasswordChar = '\0';
            this.tbNameSP.PlaceholderText = "";
            this.tbNameSP.ReadOnly = true;
            this.tbNameSP.SelectedText = "";
            this.tbNameSP.ShadowDecoration.Parent = this.tbNameSP;
            this.tbNameSP.Size = new System.Drawing.Size(157, 32);
            this.tbNameSP.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(948, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 64;
            this.label5.Text = "Tên SP:";
            // 
            // ProviderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1278, 664);
            this.Controls.Add(this.tbNameSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMaSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRD);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.btnDP);
            this.Controls.Add(this.btnAddPD);
            this.Controls.Add(this.tbMaPhieu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gwProviderDetail);
            this.Name = "ProviderDetails";
            this.Text = "ProviderDetails";
            ((System.ComponentModel.ISupportInitialize)(this.gwProviderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnRD;
        private Guna.UI2.WinForms.Guna2Button btnUP;
        private Guna.UI2.WinForms.Guna2Button btnDP;
        private Guna.UI2.WinForms.Guna2Button btnAddPD;
        private Guna.UI2.WinForms.Guna2TextBox tbMaPhieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gwProviderDetail;
        private Guna.UI2.WinForms.Guna2TextBox tbMaSP;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbQty;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbPrice;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbNameSP;
        private System.Windows.Forms.Label label5;
    }
}