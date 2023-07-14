namespace Restaurant_Management_System.ChildForm
{
    partial class AddItem
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
            this.pnlWorkspace = new System.Windows.Forms.Panel();
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.btnFoodItem = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.pnlSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWorkspace
            // 
            this.pnlWorkspace.BackColor = System.Drawing.Color.LightGray;
            this.pnlWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWorkspace.Location = new System.Drawing.Point(0, 150);
            this.pnlWorkspace.Name = "pnlWorkspace";
            this.pnlWorkspace.Size = new System.Drawing.Size(1128, 517);
            this.pnlWorkspace.TabIndex = 4;
            // 
            // pnlSelect
            // 
            this.pnlSelect.BackColor = System.Drawing.Color.LightGray;
            this.pnlSelect.Controls.Add(this.btnFoodItem);
            this.pnlSelect.Controls.Add(this.btnPrice);
            this.pnlSelect.Controls.Add(this.btnCategory);
            this.pnlSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSelect.Location = new System.Drawing.Point(0, 0);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(1128, 150);
            this.pnlSelect.TabIndex = 3;
            // 
            // btnFoodItem
            // 
            this.btnFoodItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(160)))), ((int)(((byte)(47)))));
            this.btnFoodItem.FlatAppearance.BorderSize = 0;
            this.btnFoodItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodItem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodItem.Location = new System.Drawing.Point(294, 34);
            this.btnFoodItem.Name = "btnFoodItem";
            this.btnFoodItem.Size = new System.Drawing.Size(181, 81);
            this.btnFoodItem.TabIndex = 2;
            this.btnFoodItem.Text = "Food Item";
            this.btnFoodItem.UseVisualStyleBackColor = false;
            this.btnFoodItem.Click += new System.EventHandler(this.btnFoodItem_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(160)))), ((int)(((byte)(47)))));
            this.btnPrice.FlatAppearance.BorderSize = 0;
            this.btnPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrice.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrice.Location = new System.Drawing.Point(542, 34);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(181, 81);
            this.btnPrice.TabIndex = 1;
            this.btnPrice.Text = "Price";
            this.btnPrice.UseVisualStyleBackColor = false;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(160)))), ((int)(((byte)(47)))));
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Location = new System.Drawing.Point(49, 34);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(181, 81);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 667);
            this.Controls.Add(this.pnlWorkspace);
            this.Controls.Add(this.pnlSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddItem";
            this.Text = "AddItem";
            this.pnlSelect.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWorkspace;
        private System.Windows.Forms.Panel pnlSelect;
        private System.Windows.Forms.Button btnFoodItem;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Button btnCategory;
    }
}