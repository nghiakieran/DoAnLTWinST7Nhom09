namespace UI
{
    partial class Provider
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
            this.btnAddProvider = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gwProProvider = new System.Windows.Forms.DataGridView();
            this.tbSearchProvider = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gwProvider = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.lbMoneyPay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.btnReloadProvider = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gwProProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProvider
            // 
            this.btnAddProvider.BorderRadius = 10;
            this.btnAddProvider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProvider.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddProvider.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProvider.ForeColor = System.Drawing.Color.White;
            this.btnAddProvider.Location = new System.Drawing.Point(630, 607);
            this.btnAddProvider.Name = "btnAddProvider";
            this.btnAddProvider.PressedColor = System.Drawing.Color.Transparent;
            this.btnAddProvider.Size = new System.Drawing.Size(106, 37);
            this.btnAddProvider.TabIndex = 38;
            this.btnAddProvider.Text = "Thêm";
            this.btnAddProvider.Click += new System.EventHandler(this.btnAddProvider_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 614);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Tổng tiền:";
            // 
            // gwProProvider
            // 
            this.gwProProvider.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwProProvider.BackgroundColor = System.Drawing.Color.White;
            this.gwProProvider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwProProvider.Location = new System.Drawing.Point(10, 68);
            this.gwProProvider.Name = "gwProProvider";
            this.gwProProvider.RowHeadersWidth = 51;
            this.gwProProvider.RowTemplate.Height = 24;
            this.gwProProvider.Size = new System.Drawing.Size(635, 445);
            this.gwProProvider.TabIndex = 28;
            this.gwProProvider.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gwProProvider_CellClick);
            // 
            // tbSearchProvider
            // 
            this.tbSearchProvider.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchProvider.DefaultText = "";
            this.tbSearchProvider.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchProvider.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchProvider.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchProvider.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchProvider.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchProvider.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchProvider.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchProvider.Location = new System.Drawing.Point(112, 16);
            this.tbSearchProvider.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbSearchProvider.Name = "tbSearchProvider";
            this.tbSearchProvider.PasswordChar = '\0';
            this.tbSearchProvider.PlaceholderText = "";
            this.tbSearchProvider.SelectedText = "";
            this.tbSearchProvider.Size = new System.Drawing.Size(277, 42);
            this.tbSearchProvider.TabIndex = 27;
            this.tbSearchProvider.TextChanged += new System.EventHandler(this.tbSearchProvider_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tìm kiếm";
            // 
            // gwProvider
            // 
            this.gwProvider.BackgroundColor = System.Drawing.Color.White;
            this.gwProvider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwProvider.Location = new System.Drawing.Point(671, 68);
            this.gwProvider.Name = "gwProvider";
            this.gwProvider.RowHeadersWidth = 51;
            this.gwProvider.RowTemplate.Height = 24;
            this.gwProvider.Size = new System.Drawing.Size(595, 445);
            this.gwProvider.TabIndex = 42;
            this.gwProvider.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gwProvider_CellClick);
            this.gwProvider.SelectionChanged += new System.EventHandler(this.gwProvider_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nhà cung cấp:";
            // 
            // cbNCC
            // 
            this.cbNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(150, 533);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(295, 28);
            this.cbNCC.TabIndex = 44;
            // 
            // lbMoneyPay
            // 
            this.lbMoneyPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneyPay.Location = new System.Drawing.Point(146, 614);
            this.lbMoneyPay.Name = "lbMoneyPay";
            this.lbMoneyPay.Size = new System.Drawing.Size(145, 41);
            this.lbMoneyPay.TabIndex = 45;
            this.lbMoneyPay.Text = "0";
            this.lbMoneyPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 614);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 41);
            this.label3.TabIndex = 46;
            this.label3.Text = "đ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 576);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 47;
            this.label5.Text = "Số lượng:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbQty
            // 
            this.tbQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQty.Location = new System.Drawing.Point(150, 573);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(100, 30);
            this.tbQty.TabIndex = 48;
            this.tbQty.TextChanged += new System.EventHandler(this.tbQty_TextChanged);
            // 
            // btnReloadProvider
            // 
            this.btnReloadProvider.BorderRadius = 10;
            this.btnReloadProvider.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnReloadProvider.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnReloadProvider.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnReloadProvider.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.btnReloadProvider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReloadProvider.FillColor = System.Drawing.Color.Transparent;
            this.btnReloadProvider.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadProvider.ForeColor = System.Drawing.Color.White;
            this.btnReloadProvider.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnReloadProvider.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnReloadProvider.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnReloadProvider.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btnReloadProvider.Image = global::UI.Properties.Resources.sync;
            this.btnReloadProvider.ImageSize = new System.Drawing.Size(40, 40);
            this.btnReloadProvider.Location = new System.Drawing.Point(742, 606);
            this.btnReloadProvider.Name = "btnReloadProvider";
            this.btnReloadProvider.PressedColor = System.Drawing.Color.Transparent;
            this.btnReloadProvider.Size = new System.Drawing.Size(58, 46);
            this.btnReloadProvider.TabIndex = 41;
            this.btnReloadProvider.Click += new System.EventHandler(this.btnReloadProvider_Click);
            // 
            // Provider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1278, 664);
            this.ControlBox = false;
            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMoneyPay);
            this.Controls.Add(this.cbNCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gwProvider);
            this.Controls.Add(this.btnReloadProvider);
            this.Controls.Add(this.btnAddProvider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gwProProvider);
            this.Controls.Add(this.tbSearchProvider);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Provider";
            this.Text = "Provider";
            this.Load += new System.EventHandler(this.Provider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gwProProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnReloadProvider;
        private Guna.UI2.WinForms.Guna2Button btnAddProvider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gwProProvider;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gwProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.Label lbMoneyPay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbQty;
    }
}