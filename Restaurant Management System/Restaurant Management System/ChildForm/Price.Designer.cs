namespace Restaurant_Management_System.ChildForm
{
    partial class Price
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
            this.pnlPriceCenter = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPriceTop = new System.Windows.Forms.Panel();
            this.cboCate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboFood = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFoodType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPriceTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPriceCenter
            // 
            this.pnlPriceCenter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPriceCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPriceCenter.Location = new System.Drawing.Point(0, 100);
            this.pnlPriceCenter.Name = "pnlPriceCenter";
            this.pnlPriceCenter.Size = new System.Drawing.Size(1633, 449);
            this.pnlPriceCenter.TabIndex = 7;
            // 
            // pnlPriceTop
            // 
            this.pnlPriceTop.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlPriceTop.Controls.Add(this.cboCate);
            this.pnlPriceTop.Controls.Add(this.label4);
            this.pnlPriceTop.Controls.Add(this.txtPrice);
            this.pnlPriceTop.Controls.Add(this.label3);
            this.pnlPriceTop.Controls.Add(this.cboFood);
            this.pnlPriceTop.Controls.Add(this.btnAdd);
            this.pnlPriceTop.Controls.Add(this.txtFoodType);
            this.pnlPriceTop.Controls.Add(this.label2);
            this.pnlPriceTop.Controls.Add(this.label1);
            this.pnlPriceTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPriceTop.Location = new System.Drawing.Point(0, 0);
            this.pnlPriceTop.Name = "pnlPriceTop";
            this.pnlPriceTop.Size = new System.Drawing.Size(1633, 100);
            this.pnlPriceTop.TabIndex = 6;
            // 
            // cboCate
            // 
            this.cboCate.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCate.FormattingEnabled = true;
            this.cboCate.Location = new System.Drawing.Point(210, 31);
            this.cboCate.Name = "cboCate";
            this.cboCate.Size = new System.Drawing.Size(181, 39);
            this.cboCate.TabIndex = 7;
            this.cboCate.SelectedIndexChanged += new System.EventHandler(this.cboCate_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select Category";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(1213, 34);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(181, 31);
            this.txtPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1118, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // cboFood
            // 
            this.cboFood.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFood.FormattingEnabled = true;
            this.cboFood.Location = new System.Drawing.Point(571, 31);
            this.cboFood.Name = "cboFood";
            this.cboFood.Size = new System.Drawing.Size(181, 39);
            this.cboFood.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(160)))), ((int)(((byte)(47)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1428, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 48);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFoodType
            // 
            this.txtFoodType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFoodType.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodType.Location = new System.Drawing.Point(915, 34);
            this.txtFoodType.Name = "txtFoodType";
            this.txtFoodType.Size = new System.Drawing.Size(181, 31);
            this.txtFoodType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Food";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(770, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Type";
            // 
            // Price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 549);
            this.Controls.Add(this.pnlPriceCenter);
            this.Controls.Add(this.pnlPriceTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Price";
            this.Text = "Price";
            this.pnlPriceTop.ResumeLayout(false);
            this.pnlPriceTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlPriceCenter;
        private System.Windows.Forms.Panel pnlPriceTop;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboFood;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFoodType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCate;
        private System.Windows.Forms.Label label4;
    }
}