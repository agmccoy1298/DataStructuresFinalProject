
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.ProSearchlabel = new System.Windows.Forms.Label();
            this.ProSearchtextBox = new System.Windows.Forms.TextBox();
            this.ProSearchbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ShipperInfogroupBox = new System.Windows.Forms.GroupBox();
            this.ShipperStatetextBox = new System.Windows.Forms.TextBox();
            this.ShipperStatelabel = new System.Windows.Forms.Label();
            this.ShipperZiptextBox = new System.Windows.Forms.TextBox();
            this.ShipperCitytextBox = new System.Windows.Forms.TextBox();
            this.ShipperAddresstextBox = new System.Windows.Forms.TextBox();
            this.ShipperNametextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ShipperCitylabel = new System.Windows.Forms.Label();
            this.ShipperAddresslabel = new System.Windows.Forms.Label();
            this.ShipperNamelabel = new System.Windows.Forms.Label();
            this.ConsigneeInfogroupBox = new System.Windows.Forms.GroupBox();
            this.ConsigneeStatetextBox = new System.Windows.Forms.TextBox();
            this.ConsigneeStatelabel = new System.Windows.Forms.Label();
            this.ConsigneeZiptextBox = new System.Windows.Forms.TextBox();
            this.ConsigneeCitytextBox = new System.Windows.Forms.TextBox();
            this.ConsigneeAddresstextBox = new System.Windows.Forms.TextBox();
            this.ConsigneeNametextBox = new System.Windows.Forms.TextBox();
            this.ConsigneeZiplabel = new System.Windows.Forms.Label();
            this.ConsigneeCitylabel = new System.Windows.Forms.Label();
            this.ConsigneeAddresslabel = new System.Windows.Forms.Label();
            this.ConsigneeNamelabel = new System.Windows.Forms.Label();
            this.FreightInformationgroupBox = new System.Windows.Forms.GroupBox();
            this.WeighttextBox = new System.Windows.Forms.TextBox();
            this.Weightlabel = new System.Windows.Forms.Label();
            this.HandlingUnitCountlabel = new System.Windows.Forms.Label();
            this.HandlingUnitTypetextBox = new System.Windows.Forms.TextBox();
            this.HandlingUnitTypelabel = new System.Windows.Forms.Label();
            this.HandelingUnitstextBox = new System.Windows.Forms.TextBox();
            this.HazerdousMaterialtextBox = new System.Windows.Forms.TextBox();
            this.HazmatStatuslabel = new System.Windows.Forms.Label();
            this.FreightDescriptiontextBox = new System.Windows.Forms.TextBox();
            this.FreightDescriptionlabel = new System.Windows.Forms.Label();
            this.GoBackbutton = new System.Windows.Forms.Button();
            this.PrintPackingListbutton = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.PriorityStatuslabel = new System.Windows.Forms.Label();
            this.PriorityStatustextBox = new System.Windows.Forms.TextBox();
            this.ShipperInfogroupBox.SuspendLayout();
            this.ConsigneeInfogroupBox.SuspendLayout();
            this.FreightInformationgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProSearchlabel
            // 
            this.ProSearchlabel.AutoSize = true;
            this.ProSearchlabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProSearchlabel.Location = new System.Drawing.Point(27, 23);
            this.ProSearchlabel.Name = "ProSearchlabel";
            this.ProSearchlabel.Size = new System.Drawing.Size(191, 25);
            this.ProSearchlabel.TabIndex = 0;
            this.ProSearchlabel.Text = "Search by ID Number";
            // 
            // ProSearchtextBox
            // 
            this.ProSearchtextBox.Location = new System.Drawing.Point(27, 51);
            this.ProSearchtextBox.Name = "ProSearchtextBox";
            this.ProSearchtextBox.Size = new System.Drawing.Size(191, 23);
            this.ProSearchtextBox.TabIndex = 1;
            // 
            // ProSearchbutton
            // 
            this.ProSearchbutton.Location = new System.Drawing.Point(27, 80);
            this.ProSearchbutton.Name = "ProSearchbutton";
            this.ProSearchbutton.Size = new System.Drawing.Size(188, 48);
            this.ProSearchbutton.TabIndex = 2;
            this.ProSearchbutton.Text = "Search";
            this.ProSearchbutton.UseVisualStyleBackColor = true;
            this.ProSearchbutton.Click += new System.EventHandler(this.ProSearchbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(369, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Freight Information";           
            // 
            // ShipperInfogroupBox
            // 
            this.ShipperInfogroupBox.Controls.Add(this.ShipperStatetextBox);
            this.ShipperInfogroupBox.Controls.Add(this.ShipperStatelabel);
            this.ShipperInfogroupBox.Controls.Add(this.ShipperZiptextBox);
            this.ShipperInfogroupBox.Controls.Add(this.ShipperCitytextBox);
            this.ShipperInfogroupBox.Controls.Add(this.ShipperAddresstextBox);
            this.ShipperInfogroupBox.Controls.Add(this.ShipperNametextBox);
            this.ShipperInfogroupBox.Controls.Add(this.label5);
            this.ShipperInfogroupBox.Controls.Add(this.ShipperCitylabel);
            this.ShipperInfogroupBox.Controls.Add(this.ShipperAddresslabel);
            this.ShipperInfogroupBox.Controls.Add(this.ShipperNamelabel);
            this.ShipperInfogroupBox.Location = new System.Drawing.Point(27, 169);
            this.ShipperInfogroupBox.Name = "ShipperInfogroupBox";
            this.ShipperInfogroupBox.Size = new System.Drawing.Size(542, 222);
            this.ShipperInfogroupBox.TabIndex = 4;
            this.ShipperInfogroupBox.TabStop = false;
            this.ShipperInfogroupBox.Text = "Shipper Info --------";
            // 
            // ShipperStatetextBox
            // 
            this.ShipperStatetextBox.Location = new System.Drawing.Point(300, 177);
            this.ShipperStatetextBox.Name = "ShipperStatetextBox";
            this.ShipperStatetextBox.Size = new System.Drawing.Size(107, 23);
            this.ShipperStatetextBox.TabIndex = 9;
            // 
            // ShipperStatelabel
            // 
            this.ShipperStatelabel.AutoSize = true;
            this.ShipperStatelabel.Location = new System.Drawing.Point(300, 159);
            this.ShipperStatelabel.Name = "ShipperStatelabel";
            this.ShipperStatelabel.Size = new System.Drawing.Size(33, 15);
            this.ShipperStatelabel.TabIndex = 8;
            this.ShipperStatelabel.Text = "State";
            // 
            // ShipperZiptextBox
            // 
            this.ShipperZiptextBox.Location = new System.Drawing.Point(430, 177);
            this.ShipperZiptextBox.Name = "ShipperZiptextBox";
            this.ShipperZiptextBox.Size = new System.Drawing.Size(107, 23);
            this.ShipperZiptextBox.TabIndex = 7;
            // 
            // ShipperCitytextBox
            // 
            this.ShipperCitytextBox.Location = new System.Drawing.Point(300, 112);
            this.ShipperCitytextBox.Name = "ShipperCitytextBox";
            this.ShipperCitytextBox.Size = new System.Drawing.Size(191, 23);
            this.ShipperCitytextBox.TabIndex = 6;
            // 
            // ShipperAddresstextBox
            // 
            this.ShipperAddresstextBox.Location = new System.Drawing.Point(65, 112);
            this.ShipperAddresstextBox.Name = "ShipperAddresstextBox";
            this.ShipperAddresstextBox.Size = new System.Drawing.Size(191, 23);
            this.ShipperAddresstextBox.TabIndex = 5;
            // 
            // ShipperNametextBox
            // 
            this.ShipperNametextBox.Location = new System.Drawing.Point(65, 65);
            this.ShipperNametextBox.Name = "ShipperNametextBox";
            this.ShipperNametextBox.Size = new System.Drawing.Size(191, 23);
            this.ShipperNametextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Zip Code";
            // 
            // ShipperCitylabel
            // 
            this.ShipperCitylabel.AutoSize = true;
            this.ShipperCitylabel.Location = new System.Drawing.Point(300, 94);
            this.ShipperCitylabel.Name = "ShipperCitylabel";
            this.ShipperCitylabel.Size = new System.Drawing.Size(28, 15);
            this.ShipperCitylabel.TabIndex = 2;
            this.ShipperCitylabel.Text = "City";
            // 
            // ShipperAddresslabel
            // 
            this.ShipperAddresslabel.AutoSize = true;
            this.ShipperAddresslabel.Location = new System.Drawing.Point(65, 94);
            this.ShipperAddresslabel.Name = "ShipperAddresslabel";
            this.ShipperAddresslabel.Size = new System.Drawing.Size(49, 15);
            this.ShipperAddresslabel.TabIndex = 1;
            this.ShipperAddresslabel.Text = "Address";
            // 
            // ShipperNamelabel
            // 
            this.ShipperNamelabel.AutoSize = true;
            this.ShipperNamelabel.Location = new System.Drawing.Point(65, 46);
            this.ShipperNamelabel.Name = "ShipperNamelabel";
            this.ShipperNamelabel.Size = new System.Drawing.Size(39, 15);
            this.ShipperNamelabel.TabIndex = 0;
            this.ShipperNamelabel.Text = "Name";
            // 
            // ConsigneeInfogroupBox
            // 
            this.ConsigneeInfogroupBox.Controls.Add(this.ConsigneeStatetextBox);
            this.ConsigneeInfogroupBox.Controls.Add(this.ConsigneeStatelabel);
            this.ConsigneeInfogroupBox.Controls.Add(this.ConsigneeZiptextBox);
            this.ConsigneeInfogroupBox.Controls.Add(this.ConsigneeCitytextBox);
            this.ConsigneeInfogroupBox.Controls.Add(this.ConsigneeAddresstextBox);
            this.ConsigneeInfogroupBox.Controls.Add(this.ConsigneeNametextBox);
            this.ConsigneeInfogroupBox.Controls.Add(this.ConsigneeZiplabel);
            this.ConsigneeInfogroupBox.Controls.Add(this.ConsigneeCitylabel);
            this.ConsigneeInfogroupBox.Controls.Add(this.ConsigneeAddresslabel);
            this.ConsigneeInfogroupBox.Controls.Add(this.ConsigneeNamelabel);
            this.ConsigneeInfogroupBox.Location = new System.Drawing.Point(27, 391);
            this.ConsigneeInfogroupBox.Name = "ConsigneeInfogroupBox";
            this.ConsigneeInfogroupBox.Size = new System.Drawing.Size(542, 222);
            this.ConsigneeInfogroupBox.TabIndex = 8;
            this.ConsigneeInfogroupBox.TabStop = false;
            this.ConsigneeInfogroupBox.Text = "Consignee Info --------";            
            // 
            // ConsigneeStatetextBox
            // 
            this.ConsigneeStatetextBox.Location = new System.Drawing.Point(300, 177);
            this.ConsigneeStatetextBox.Name = "ConsigneeStatetextBox";
            this.ConsigneeStatetextBox.Size = new System.Drawing.Size(107, 23);
            this.ConsigneeStatetextBox.TabIndex = 11;
            // 
            // ConsigneeStatelabel
            // 
            this.ConsigneeStatelabel.AutoSize = true;
            this.ConsigneeStatelabel.Location = new System.Drawing.Point(300, 159);
            this.ConsigneeStatelabel.Name = "ConsigneeStatelabel";
            this.ConsigneeStatelabel.Size = new System.Drawing.Size(33, 15);
            this.ConsigneeStatelabel.TabIndex = 10;
            this.ConsigneeStatelabel.Text = "State";
            // 
            // ConsigneeZiptextBox
            // 
            this.ConsigneeZiptextBox.Location = new System.Drawing.Point(430, 177);
            this.ConsigneeZiptextBox.Name = "ConsigneeZiptextBox";
            this.ConsigneeZiptextBox.Size = new System.Drawing.Size(107, 23);
            this.ConsigneeZiptextBox.TabIndex = 7;
            // 
            // ConsigneeCitytextBox
            // 
            this.ConsigneeCitytextBox.Location = new System.Drawing.Point(300, 112);
            this.ConsigneeCitytextBox.Name = "ConsigneeCitytextBox";
            this.ConsigneeCitytextBox.Size = new System.Drawing.Size(191, 23);
            this.ConsigneeCitytextBox.TabIndex = 6;
            // 
            // ConsigneeAddresstextBox
            // 
            this.ConsigneeAddresstextBox.Location = new System.Drawing.Point(65, 112);
            this.ConsigneeAddresstextBox.Name = "ConsigneeAddresstextBox";
            this.ConsigneeAddresstextBox.Size = new System.Drawing.Size(191, 23);
            this.ConsigneeAddresstextBox.TabIndex = 5;
            // 
            // ConsigneeNametextBox
            // 
            this.ConsigneeNametextBox.Location = new System.Drawing.Point(65, 65);
            this.ConsigneeNametextBox.Name = "ConsigneeNametextBox";
            this.ConsigneeNametextBox.Size = new System.Drawing.Size(191, 23);
            this.ConsigneeNametextBox.TabIndex = 4;
            // 
            // ConsigneeZiplabel
            // 
            this.ConsigneeZiplabel.AutoSize = true;
            this.ConsigneeZiplabel.Location = new System.Drawing.Point(430, 159);
            this.ConsigneeZiplabel.Name = "ConsigneeZiplabel";
            this.ConsigneeZiplabel.Size = new System.Drawing.Size(55, 15);
            this.ConsigneeZiplabel.TabIndex = 3;
            this.ConsigneeZiplabel.Text = "Zip Code";
            // 
            // ConsigneeCitylabel
            // 
            this.ConsigneeCitylabel.AutoSize = true;
            this.ConsigneeCitylabel.Location = new System.Drawing.Point(300, 94);
            this.ConsigneeCitylabel.Name = "ConsigneeCitylabel";
            this.ConsigneeCitylabel.Size = new System.Drawing.Size(31, 15);
            this.ConsigneeCitylabel.TabIndex = 2;
            this.ConsigneeCitylabel.Text = "City ";
            // 
            // ConsigneeAddresslabel
            // 
            this.ConsigneeAddresslabel.AutoSize = true;
            this.ConsigneeAddresslabel.Location = new System.Drawing.Point(65, 94);
            this.ConsigneeAddresslabel.Name = "ConsigneeAddresslabel";
            this.ConsigneeAddresslabel.Size = new System.Drawing.Size(49, 15);
            this.ConsigneeAddresslabel.TabIndex = 1;
            this.ConsigneeAddresslabel.Text = "Address";
            // 
            // ConsigneeNamelabel
            // 
            this.ConsigneeNamelabel.AutoSize = true;
            this.ConsigneeNamelabel.Location = new System.Drawing.Point(65, 46);
            this.ConsigneeNamelabel.Name = "ConsigneeNamelabel";
            this.ConsigneeNamelabel.Size = new System.Drawing.Size(39, 15);
            this.ConsigneeNamelabel.TabIndex = 0;
            this.ConsigneeNamelabel.Text = "Name";
            // 
            // FreightInformationgroupBox
            // 
            this.FreightInformationgroupBox.Controls.Add(this.PriorityStatuslabel);
            this.FreightInformationgroupBox.Controls.Add(this.PriorityStatustextBox);
            this.FreightInformationgroupBox.Controls.Add(this.WeighttextBox);
            this.FreightInformationgroupBox.Controls.Add(this.Weightlabel);
            this.FreightInformationgroupBox.Controls.Add(this.HandlingUnitCountlabel);
            this.FreightInformationgroupBox.Controls.Add(this.HandlingUnitTypetextBox);
            this.FreightInformationgroupBox.Controls.Add(this.HandlingUnitTypelabel);
            this.FreightInformationgroupBox.Controls.Add(this.HandelingUnitstextBox);
            this.FreightInformationgroupBox.Controls.Add(this.HazerdousMaterialtextBox);
            this.FreightInformationgroupBox.Controls.Add(this.HazmatStatuslabel);
            this.FreightInformationgroupBox.Controls.Add(this.FreightDescriptiontextBox);
            this.FreightInformationgroupBox.Controls.Add(this.FreightDescriptionlabel);
            this.FreightInformationgroupBox.Location = new System.Drawing.Point(572, 169);
            this.FreightInformationgroupBox.Name = "FreightInformationgroupBox";
            this.FreightInformationgroupBox.Size = new System.Drawing.Size(360, 444);
            this.FreightInformationgroupBox.TabIndex = 9;
            this.FreightInformationgroupBox.TabStop = false;
            this.FreightInformationgroupBox.Text = "Freight Info";           
            // 
            // WeighttextBox
            // 
            this.WeighttextBox.Location = new System.Drawing.Point(199, 281);
            this.WeighttextBox.Name = "WeighttextBox";
            this.WeighttextBox.Size = new System.Drawing.Size(117, 23);
            this.WeighttextBox.TabIndex = 18;
            // 
            // Weightlabel
            // 
            this.Weightlabel.AutoSize = true;
            this.Weightlabel.Location = new System.Drawing.Point(199, 263);
            this.Weightlabel.Name = "Weightlabel";
            this.Weightlabel.Size = new System.Drawing.Size(101, 15);
            this.Weightlabel.TabIndex = 17;
            this.Weightlabel.Text = "Weight in Pounds";
            // 
            // HandlingUnitCountlabel
            // 
            this.HandlingUnitCountlabel.AutoSize = true;
            this.HandlingUnitCountlabel.Location = new System.Drawing.Point(46, 322);
            this.HandlingUnitCountlabel.Name = "HandlingUnitCountlabel";
            this.HandlingUnitCountlabel.Size = new System.Drawing.Size(86, 15);
            this.HandlingUnitCountlabel.TabIndex = 16;
            this.HandlingUnitCountlabel.Text = "Handling Units";
            // 
            // HandlingUnitTypetextBox
            // 
            this.HandlingUnitTypetextBox.Location = new System.Drawing.Point(199, 340);
            this.HandlingUnitTypetextBox.Name = "HandlingUnitTypetextBox";
            this.HandlingUnitTypetextBox.Size = new System.Drawing.Size(117, 23);
            this.HandlingUnitTypetextBox.TabIndex = 13;
            // 
            // HandlingUnitTypelabel
            // 
            this.HandlingUnitTypelabel.AutoSize = true;
            this.HandlingUnitTypelabel.Location = new System.Drawing.Point(199, 322);
            this.HandlingUnitTypelabel.Name = "HandlingUnitTypelabel";
            this.HandlingUnitTypelabel.Size = new System.Drawing.Size(111, 15);
            this.HandlingUnitTypelabel.TabIndex = 15;
            this.HandlingUnitTypelabel.Text = "Handling Unit Type ";            
            // 
            // HandelingUnitstextBox
            // 
            this.HandelingUnitstextBox.Location = new System.Drawing.Point(46, 340);
            this.HandelingUnitstextBox.Name = "HandelingUnitstextBox";
            this.HandelingUnitstextBox.Size = new System.Drawing.Size(117, 23);
            this.HandelingUnitstextBox.TabIndex = 14;
            // 
            // HazerdousMaterialtextBox
            // 
            this.HazerdousMaterialtextBox.Location = new System.Drawing.Point(46, 281);
            this.HazerdousMaterialtextBox.Name = "HazerdousMaterialtextBox";
            this.HazerdousMaterialtextBox.Size = new System.Drawing.Size(117, 23);
            this.HazerdousMaterialtextBox.TabIndex = 12;
            // 
            // HazmatStatuslabel
            // 
            this.HazmatStatuslabel.AutoSize = true;
            this.HazmatStatuslabel.Location = new System.Drawing.Point(46, 263);
            this.HazmatStatuslabel.Name = "HazmatStatuslabel";
            this.HazmatStatuslabel.Size = new System.Drawing.Size(117, 15);
            this.HazmatStatuslabel.TabIndex = 12;
            this.HazmatStatuslabel.Text = "Hazardous Material? ";
            // 
            // FreightDescriptiontextBox
            // 
            this.FreightDescriptiontextBox.Location = new System.Drawing.Point(46, 64);
            this.FreightDescriptiontextBox.Multiline = true;
            this.FreightDescriptiontextBox.Name = "FreightDescriptiontextBox";
            this.FreightDescriptiontextBox.Size = new System.Drawing.Size(270, 172);
            this.FreightDescriptiontextBox.TabIndex = 11;
            // 
            // FreightDescriptionlabel
            // 
            this.FreightDescriptionlabel.AutoSize = true;
            this.FreightDescriptionlabel.Location = new System.Drawing.Point(46, 46);
            this.FreightDescriptionlabel.Name = "FreightDescriptionlabel";
            this.FreightDescriptionlabel.Size = new System.Drawing.Size(107, 15);
            this.FreightDescriptionlabel.TabIndex = 10;
            this.FreightDescriptionlabel.Text = "Freight Description";
            // 
            // GoBackbutton
            // 
            this.GoBackbutton.Location = new System.Drawing.Point(662, 27);
            this.GoBackbutton.Name = "GoBackbutton";
            this.GoBackbutton.Size = new System.Drawing.Size(270, 23);
            this.GoBackbutton.TabIndex = 19;
            this.GoBackbutton.Text = "Go Back";
            this.GoBackbutton.UseVisualStyleBackColor = true;
            this.GoBackbutton.Click += new System.EventHandler(this.GoBackbutton_Click);
            // 
            // PrintPackingListbutton
            // 
            this.PrintPackingListbutton.Location = new System.Drawing.Point(744, 80);
            this.PrintPackingListbutton.Name = "PrintPackingListbutton";
            this.PrintPackingListbutton.Size = new System.Drawing.Size(188, 48);
            this.PrintPackingListbutton.TabIndex = 20;
            this.PrintPackingListbutton.Text = "Print Packing List";
            this.PrintPackingListbutton.UseVisualStyleBackColor = true;
            this.PrintPackingListbutton.Click += new System.EventHandler(this.PrintPackingListbutton_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // PriorityStatuslabel
            // 
            this.PriorityStatuslabel.AutoSize = true;
            this.PriorityStatuslabel.Location = new System.Drawing.Point(46, 381);
            this.PriorityStatuslabel.Name = "PriorityStatuslabel";
            this.PriorityStatuslabel.Size = new System.Drawing.Size(80, 15);
            this.PriorityStatuslabel.TabIndex = 20;
            this.PriorityStatuslabel.Text = "Priority Status";
            // 
            // PriorityStatustextBox
            // 
            this.PriorityStatustextBox.Location = new System.Drawing.Point(46, 399);
            this.PriorityStatustextBox.Name = "PriorityStatustextBox";
            this.PriorityStatustextBox.Size = new System.Drawing.Size(117, 23);
            this.PriorityStatustextBox.TabIndex = 19;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 690);
            this.Controls.Add(this.PrintPackingListbutton);
            this.Controls.Add(this.GoBackbutton);
            this.Controls.Add(this.FreightInformationgroupBox);
            this.Controls.Add(this.ConsigneeInfogroupBox);
            this.Controls.Add(this.ShipperInfogroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProSearchbutton);
            this.Controls.Add(this.ProSearchtextBox);
            this.Controls.Add(this.ProSearchlabel);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Freight";
            this.ShipperInfogroupBox.ResumeLayout(false);
            this.ShipperInfogroupBox.PerformLayout();
            this.ConsigneeInfogroupBox.ResumeLayout(false);
            this.ConsigneeInfogroupBox.PerformLayout();
            this.FreightInformationgroupBox.ResumeLayout(false);
            this.FreightInformationgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProSearchlabel;
        private System.Windows.Forms.TextBox ProSearchtextBox;
        private System.Windows.Forms.Button ProSearchbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ShipperInfogroupBox;
        private System.Windows.Forms.TextBox ShipperStatetextBox;
        private System.Windows.Forms.Label ShipperStatelabel;
        private System.Windows.Forms.TextBox ShipperZiptextBox;
        private System.Windows.Forms.TextBox ShipperCitytextBox;
        private System.Windows.Forms.TextBox ShipperAddresstextBox;
        private System.Windows.Forms.TextBox ShipperNametextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ShipperCitylabel;
        private System.Windows.Forms.Label ShipperAddresslabel;
        private System.Windows.Forms.Label ShipperNamelabel;
        private System.Windows.Forms.GroupBox ConsigneeInfogroupBox;
        private System.Windows.Forms.TextBox ConsigneeStatetextBox;
        private System.Windows.Forms.Label ConsigneeStatelabel;
        private System.Windows.Forms.TextBox ConsigneeZiptextBox;
        private System.Windows.Forms.TextBox ConsigneeCitytextBox;
        private System.Windows.Forms.TextBox ConsigneeAddresstextBox;
        private System.Windows.Forms.TextBox ConsigneeNametextBox;
        private System.Windows.Forms.Label ConsigneeZiplabel;
        private System.Windows.Forms.Label ConsigneeCitylabel;
        private System.Windows.Forms.Label ConsigneeAddresslabel;
        private System.Windows.Forms.Label ConsigneeNamelabel;
        private System.Windows.Forms.GroupBox FreightInformationgroupBox;
        private System.Windows.Forms.TextBox FreightDescriptiontextBox;
        private System.Windows.Forms.Label FreightDescriptionlabel;
        private System.Windows.Forms.Label HandlingUnitCountlabel;
        private System.Windows.Forms.TextBox HandelingUnitstextBox;
        private System.Windows.Forms.TextBox HazerdousMaterialtextBox;
        private System.Windows.Forms.Label HazmatStatuslabel;
        private System.Windows.Forms.TextBox HandlingUnitTypetextBox;
        private System.Windows.Forms.Label HandlingUnitTypelabel;
        private System.Windows.Forms.TextBox WeighttextBox;
        private System.Windows.Forms.Label Weightlabel;
        private System.Windows.Forms.Button GoBackbutton;
        private System.Windows.Forms.Button PrintPackingListbutton;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label PriorityStatuslabel;
        private System.Windows.Forms.TextBox PriorityStatustextBox;
    }
}