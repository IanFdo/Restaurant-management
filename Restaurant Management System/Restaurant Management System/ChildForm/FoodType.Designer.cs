namespace Restaurant_Management_System.ChildForm
{
    partial class FoodType
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
            this.flowFoodType = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowFoodType
            // 
            this.flowFoodType.Location = new System.Drawing.Point(49, 51);
            this.flowFoodType.Name = "flowFoodType";
            this.flowFoodType.Size = new System.Drawing.Size(818, 406);
            this.flowFoodType.TabIndex = 0;
            // 
            // FoodType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 504);
            this.Controls.Add(this.flowFoodType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FoodType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodType";
            this.Load += new System.EventHandler(this.FoodType_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowFoodType;
    }
}