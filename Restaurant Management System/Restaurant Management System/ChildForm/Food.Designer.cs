namespace Restaurant_Management_System.ChildForm
{
    partial class Food
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
            this.pnlFoodTop = new System.Windows.Forms.Panel();
            this.cboCate = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddFood = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowFood = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFoodTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFoodTop
            // 
            this.pnlFoodTop.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlFoodTop.Controls.Add(this.cboCate);
            this.pnlFoodTop.Controls.Add(this.btnAdd);
            this.pnlFoodTop.Controls.Add(this.txtAddFood);
            this.pnlFoodTop.Controls.Add(this.label2);
            this.pnlFoodTop.Controls.Add(this.label1);
            this.pnlFoodTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFoodTop.Location = new System.Drawing.Point(0, 0);
            this.pnlFoodTop.Name = "pnlFoodTop";
            this.pnlFoodTop.Size = new System.Drawing.Size(1128, 100);
            this.pnlFoodTop.TabIndex = 4;
            // 
            // cboCate
            // 
            this.cboCate.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCate.FormattingEnabled = true;
            this.cboCate.Location = new System.Drawing.Point(214, 32);
            this.cboCate.Name = "cboCate";
            this.cboCate.Size = new System.Drawing.Size(234, 39);
            this.cboCate.TabIndex = 3;
            this.cboCate.SelectedIndexChanged += new System.EventHandler(this.cboCate_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(160)))), ((int)(((byte)(47)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(905, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 48);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddFood
            // 
            this.txtAddFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddFood.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddFood.Location = new System.Drawing.Point(642, 35);
            this.txtAddFood.Name = "txtAddFood";
            this.txtAddFood.Size = new System.Drawing.Size(234, 31);
            this.txtAddFood.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(519, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Food";
            // 
            // flowFood
            // 
            this.flowFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowFood.Location = new System.Drawing.Point(0, 100);
            this.flowFood.Name = "flowFood";
            this.flowFood.Size = new System.Drawing.Size(1128, 420);
            this.flowFood.TabIndex = 5;
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 520);
            this.Controls.Add(this.flowFood);
            this.Controls.Add(this.pnlFoodTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Food";
            this.Text = "Food";
            this.pnlFoodTop.ResumeLayout(false);
            this.pnlFoodTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFoodTop;
        private System.Windows.Forms.ComboBox cboCate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAddFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowFood;
    }
}