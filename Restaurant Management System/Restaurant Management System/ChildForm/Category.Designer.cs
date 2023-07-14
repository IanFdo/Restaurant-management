namespace Restaurant_Management_System.ChildForm
{
    partial class Category
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
            this.pnlCate = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddCate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowCate = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCate
            // 
            this.pnlCate.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlCate.Controls.Add(this.btnAdd);
            this.pnlCate.Controls.Add(this.txtAddCate);
            this.pnlCate.Controls.Add(this.label1);
            this.pnlCate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCate.Location = new System.Drawing.Point(0, 0);
            this.pnlCate.Name = "pnlCate";
            this.pnlCate.Size = new System.Drawing.Size(1128, 100);
            this.pnlCate.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(160)))), ((int)(((byte)(47)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(448, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 39);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddCate
            // 
            this.txtAddCate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddCate.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCate.Location = new System.Drawing.Point(194, 35);
            this.txtAddCate.Name = "txtAddCate";
            this.txtAddCate.Size = new System.Drawing.Size(234, 31);
            this.txtAddCate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Category";
            // 
            // flowCate
            // 
            this.flowCate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowCate.Location = new System.Drawing.Point(0, 100);
            this.flowCate.Name = "flowCate";
            this.flowCate.Size = new System.Drawing.Size(1128, 420);
            this.flowCate.TabIndex = 3;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 520);
            this.Controls.Add(this.flowCate);
            this.Controls.Add(this.pnlCate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Category";
            this.Text = "Category";
            this.pnlCate.ResumeLayout(false);
            this.pnlCate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAddCate;
        private System.Windows.Forms.FlowLayoutPanel flowCate;
    }
}