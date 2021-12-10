
namespace DataStructuresFinalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonTerminate = new System.Windows.Forms.Button();
            this.PriorityFreightQueuetextBox = new System.Windows.Forms.TextBox();
            this.PriorityFreightQueuelabel = new System.Windows.Forms.Label();
            this.ShowPriorityQueueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.AccessibleName = "buttonAdd";
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAdd.Location = new System.Drawing.Point(218, 311);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(156, 82);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Would you like to add an item or search an item? ";            
            // 
            // buttonSearch
            // 
            this.buttonSearch.AccessibleName = "buttonSearch";
            this.buttonSearch.Location = new System.Drawing.Point(468, 311);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(156, 82);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click_1);
            // 
            // buttonTerminate
            // 
            this.buttonTerminate.AccessibleName = "buttonTerminate";
            this.buttonTerminate.Location = new System.Drawing.Point(44, 562);
            this.buttonTerminate.Name = "buttonTerminate";
            this.buttonTerminate.Size = new System.Drawing.Size(176, 59);
            this.buttonTerminate.TabIndex = 3;
            this.buttonTerminate.Text = "Terminate Program";
            this.buttonTerminate.UseVisualStyleBackColor = true;
            this.buttonTerminate.Click += new System.EventHandler(this.buttonTerminate_Click);
            // 
            // PriorityFreightQueuetextBox
            // 
            this.PriorityFreightQueuetextBox.Location = new System.Drawing.Point(732, 174);
            this.PriorityFreightQueuetextBox.Multiline = true;
            this.PriorityFreightQueuetextBox.Name = "PriorityFreightQueuetextBox";
            this.PriorityFreightQueuetextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PriorityFreightQueuetextBox.Size = new System.Drawing.Size(102, 323);
            this.PriorityFreightQueuetextBox.TabIndex = 4;            
            // 
            // PriorityFreightQueuelabel
            // 
            this.PriorityFreightQueuelabel.AutoSize = true;
            this.PriorityFreightQueuelabel.Location = new System.Drawing.Point(732, 103);
            this.PriorityFreightQueuelabel.Name = "PriorityFreightQueuelabel";
            this.PriorityFreightQueuelabel.Size = new System.Drawing.Size(185, 25);
            this.PriorityFreightQueuelabel.TabIndex = 5;
            this.PriorityFreightQueuelabel.Text = "Priority Freight Queue";
            // 
            // ShowPriorityQueueButton
            // 
            this.ShowPriorityQueueButton.Location = new System.Drawing.Point(732, 133);
            this.ShowPriorityQueueButton.Name = "ShowPriorityQueueButton";
            this.ShowPriorityQueueButton.Size = new System.Drawing.Size(85, 35);
            this.ShowPriorityQueueButton.TabIndex = 6;
            this.ShowPriorityQueueButton.Text = "Show";
            this.ShowPriorityQueueButton.UseVisualStyleBackColor = true;
            this.ShowPriorityQueueButton.Click += new System.EventHandler(this.ShowPriorityQueueButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1029, 690);
            this.Controls.Add(this.ShowPriorityQueueButton);
            this.Controls.Add(this.PriorityFreightQueuelabel);
            this.Controls.Add(this.PriorityFreightQueuetextBox);
            this.Controls.Add(this.buttonTerminate);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "McCoy Freight Solutions ";            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonTerminate;
        private System.Windows.Forms.TextBox PriorityFreightQueuetextBox;
        private System.Windows.Forms.Label PriorityFreightQueuelabel;
        private System.Windows.Forms.Button ShowPriorityQueueButton;
    }
}

