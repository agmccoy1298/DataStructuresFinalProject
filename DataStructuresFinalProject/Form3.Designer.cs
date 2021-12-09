
namespace DataStructuresFinalProject
{
    partial class Form3
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
            this.ProSearchlabel = new System.Windows.Forms.Label();
            this.ProSearchtextBox = new System.Windows.Forms.TextBox();
            this.ProSearchbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProSearchlabel
            // 
            this.ProSearchlabel.AutoSize = true;
            this.ProSearchlabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProSearchlabel.Location = new System.Drawing.Point(40, 28);
            this.ProSearchlabel.Name = "ProSearchlabel";
            this.ProSearchlabel.Size = new System.Drawing.Size(191, 25);
            this.ProSearchlabel.TabIndex = 0;
            this.ProSearchlabel.Text = "Search by ID Number";
            // 
            // ProSearchtextBox
            // 
            this.ProSearchtextBox.Location = new System.Drawing.Point(40, 56);
            this.ProSearchtextBox.Name = "ProSearchtextBox";
            this.ProSearchtextBox.Size = new System.Drawing.Size(191, 23);
            this.ProSearchtextBox.TabIndex = 1;
            // 
            // ProSearchbutton
            // 
            this.ProSearchbutton.Location = new System.Drawing.Point(40, 85);
            this.ProSearchbutton.Name = "ProSearchbutton";
            this.ProSearchbutton.Size = new System.Drawing.Size(188, 48);
            this.ProSearchbutton.TabIndex = 2;
            this.ProSearchbutton.Text = "Search";
            this.ProSearchbutton.UseVisualStyleBackColor = true;
            this.ProSearchbutton.Click += new System.EventHandler(this.ProSearchbutton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 690);
            this.Controls.Add(this.ProSearchbutton);
            this.Controls.Add(this.ProSearchtextBox);
            this.Controls.Add(this.ProSearchlabel);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Freight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProSearchlabel;
        private System.Windows.Forms.TextBox ProSearchtextBox;
        private System.Windows.Forms.Button ProSearchbutton;
    }
}