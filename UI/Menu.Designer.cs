namespace UI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gwProduct = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeletePro = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancle = new Guna.UI2.WinForms.Guna2Button();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.btnDown = new Guna.UI2.WinForms.Guna2Button();
            this.btnUp = new Guna.UI2.WinForms.Guna2Button();
            this.lbMoneyPay = new System.Windows.Forms.Label();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.tbNumberCus = new System.Windows.Forms.TextBox();
            this.tbNameCus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gwSellProduct = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwProduct)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwSellProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gwProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 664);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(130, 21);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(227, 30);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // gwProduct
            // 
            this.gwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwProduct.BackgroundColor = System.Drawing.Color.White;
            this.gwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwProduct.Location = new System.Drawing.Point(3, 115);
            this.gwProduct.Name = "gwProduct";
            this.gwProduct.RowHeadersWidth = 51;
            this.gwProduct.RowTemplate.Height = 24;
            this.gwProduct.Size = new System.Drawing.Size(802, 546);
            this.gwProduct.TabIndex = 0;
            this.gwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gwProduct_CellClick);
            this.gwProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gwProduct_CellContentClick);
            this.gwProduct.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gwProduct_CellValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(807, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 664);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnDeletePro);
            this.panel3.Controls.Add(this.btnCancle);
            this.panel3.Controls.Add(this.btnPay);
            this.panel3.Controls.Add(this.btnDown);
            this.panel3.Controls.Add(this.btnUp);
            this.panel3.Controls.Add(this.lbMoneyPay);
            this.panel3.Controls.Add(this.tbQty);
            this.panel3.Controls.Add(this.tbNumberCus);
            this.panel3.Controls.Add(this.tbNameCus);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.gwSellProduct);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(808, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(470, 664);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnDeletePro
            // 
            this.btnDeletePro.BorderRadius = 15;
            this.btnDeletePro.CheckedState.Parent = this.btnDeletePro;
            this.btnDeletePro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePro.CustomImages.Parent = this.btnDeletePro;
            this.btnDeletePro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeletePro.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePro.ForeColor = System.Drawing.Color.White;
            this.btnDeletePro.HoverState.Parent = this.btnDeletePro;
            this.btnDeletePro.Image = global::UI.Properties.Resources.remove;
            this.btnDeletePro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeletePro.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDeletePro.Location = new System.Drawing.Point(299, 457);
            this.btnDeletePro.Name = "btnDeletePro";
            this.btnDeletePro.ShadowDecoration.Parent = this.btnDeletePro;
            this.btnDeletePro.Size = new System.Drawing.Size(145, 43);
            this.btnDeletePro.TabIndex = 15;
            this.btnDeletePro.Text = "   Xóa";
            this.btnDeletePro.Click += new System.EventHandler(this.btnDeletePro_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.BorderRadius = 15;
            this.btnCancle.CheckedState.Parent = this.btnCancle;
            this.btnCancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancle.CustomImages.Parent = this.btnCancle;
            this.btnCancle.FillColor = System.Drawing.Color.Red;
            this.btnCancle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.ForeColor = System.Drawing.Color.White;
            this.btnCancle.HoverState.Parent = this.btnCancle;
            this.btnCancle.Image = global::UI.Properties.Resources.remove;
            this.btnCancle.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancle.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCancle.Location = new System.Drawing.Point(258, 596);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.ShadowDecoration.Parent = this.btnCancle;
            this.btnCancle.Size = new System.Drawing.Size(145, 43);
            this.btnCancle.TabIndex = 14;
            this.btnCancle.Text = "   Hủy";
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnPay
            // 
            this.btnPay.BorderRadius = 15;
            this.btnPay.CheckedState.Parent = this.btnPay;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.CustomImages.Parent = this.btnPay;
            this.btnPay.FillColor = System.Drawing.Color.Lime;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.HoverState.Parent = this.btnPay;
            this.btnPay.Image = global::UI.Properties.Resources.dollar;
            this.btnPay.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPay.Location = new System.Drawing.Point(35, 596);
            this.btnPay.Name = "btnPay";
            this.btnPay.ShadowDecoration.Parent = this.btnPay;
            this.btnPay.Size = new System.Drawing.Size(167, 43);
            this.btnPay.TabIndex = 13;
            this.btnPay.Text = "Thanh Toán";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnDown
            // 
            this.btnDown.CheckedState.Parent = this.btnDown;
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.CustomImages.Parent = this.btnDown;
            this.btnDown.FillColor = System.Drawing.Color.Transparent;
            this.btnDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDown.ForeColor = System.Drawing.Color.White;
            this.btnDown.HoverState.Parent = this.btnDown;
            this.btnDown.Image = global::UI.Properties.Resources.down;
            this.btnDown.ImageSize = new System.Drawing.Size(22, 22);
            this.btnDown.Location = new System.Drawing.Point(237, 476);
            this.btnDown.Name = "btnDown";
            this.btnDown.ShadowDecoration.Parent = this.btnDown;
            this.btnDown.Size = new System.Drawing.Size(57, 24);
            this.btnDown.TabIndex = 12;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.CheckedState.Parent = this.btnUp;
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.CustomImages.Parent = this.btnUp;
            this.btnUp.FillColor = System.Drawing.Color.Transparent;
            this.btnUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.HoverState.Parent = this.btnUp;
            this.btnUp.Image = global::UI.Properties.Resources.caret_arrow_up;
            this.btnUp.Location = new System.Drawing.Point(236, 446);
            this.btnUp.Name = "btnUp";
            this.btnUp.ShadowDecoration.Parent = this.btnUp;
            this.btnUp.Size = new System.Drawing.Size(57, 24);
            this.btnUp.TabIndex = 11;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lbMoneyPay
            // 
            this.lbMoneyPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneyPay.Location = new System.Drawing.Point(220, 525);
            this.lbMoneyPay.Name = "lbMoneyPay";
            this.lbMoneyPay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbMoneyPay.Size = new System.Drawing.Size(192, 32);
            this.lbMoneyPay.TabIndex = 10;
            this.lbMoneyPay.Text = "0";
            this.lbMoneyPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbMoneyPay.Click += new System.EventHandler(this.lbMoneyPay_Click);
            // 
            // tbQty
            // 
            this.tbQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQty.Location = new System.Drawing.Point(150, 458);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(80, 30);
            this.tbQty.TabIndex = 9;
            this.tbQty.Text = "0";
            this.tbQty.TextChanged += new System.EventHandler(this.tbQty_TextChanged);
            // 
            // tbNumberCus
            // 
            this.tbNumberCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumberCus.Location = new System.Drawing.Point(131, 71);
            this.tbNumberCus.Name = "tbNumberCus";
            this.tbNumberCus.Size = new System.Drawing.Size(201, 30);
            this.tbNumberCus.TabIndex = 8;
            // 
            // tbNameCus
            // 
            this.tbNameCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameCus.Location = new System.Drawing.Point(131, 21);
            this.tbNameCus.Name = "tbNameCus";
            this.tbNameCus.Size = new System.Drawing.Size(220, 30);
            this.tbNameCus.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 532);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thành tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng:";
            // 
            // gwSellProduct
            // 
            this.gwSellProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwSellProduct.BackgroundColor = System.Drawing.Color.White;
            this.gwSellProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwSellProduct.Location = new System.Drawing.Point(19, 133);
            this.gwSellProduct.Name = "gwSellProduct";
            this.gwSellProduct.RowHeadersWidth = 51;
            this.gwSellProduct.RowTemplate.Height = 24;
            this.gwSellProduct.Size = new System.Drawing.Size(428, 293);
            this.gwSellProduct.TabIndex = 3;
            this.gwSellProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gwSellProduct_CellClick);
            this.gwSellProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gwSellProduct_CellContentClick);
            this.gwSellProduct.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gwSellProduct_CellValueChanged);
            this.gwSellProduct.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gwSellProduct_RowsAdded);
            this.gwSellProduct.SelectionChanged += new System.EventHandler(this.gwSellProduct_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "SĐT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên KH:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 525);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(26, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "đ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1278, 664);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwProduct)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwSellProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gwProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gwSellProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNumberCus;
        private System.Windows.Forms.TextBox tbNameCus;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Label lbMoneyPay;
        private Guna.UI2.WinForms.Guna2Button btnUp;
        private Guna.UI2.WinForms.Guna2Button btnDown;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2Button btnCancle;
        private Guna.UI2.WinForms.Guna2Button btnDeletePro;
        private System.Windows.Forms.Label label2;
    }
}