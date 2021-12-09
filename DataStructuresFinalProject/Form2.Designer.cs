
namespace DataStructuresFinalProject
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.ShipperCompanyNametextBox = new System.Windows.Forms.TextBox();
            this.AddAShipperLabel = new System.Windows.Forms.Label();
            this.ShipperCompanyNameLabel = new System.Windows.Forms.Label();
            this.ShipperAddressLN1Label = new System.Windows.Forms.Label();
            this.ShipperAddressLN1textBox = new System.Windows.Forms.TextBox();
            this.ShipperCitytextBox = new System.Windows.Forms.TextBox();
            this.ShipperCityLabel = new System.Windows.Forms.Label();
            this.ShipperStateLabel = new System.Windows.Forms.Label();
            this.ShipperZipCodetextBox = new System.Windows.Forms.TextBox();
            this.ShipperZipCodeLabel = new System.Windows.Forms.Label();
            this.SearchByShipperCustomerNumberLabel = new System.Windows.Forms.Label();
            this.ShipperCustomerNumberSearchtextBox = new System.Windows.Forms.TextBox();
            this.ShipperCustomerNumberSearchButton = new System.Windows.Forms.Button();
            this.ConsigneeCustomerNumberSearchButton = new System.Windows.Forms.Button();
            this.ConsigneeCustomerNumberSearchtextBox = new System.Windows.Forms.TextBox();
            this.SearchByConsigneeCustomerNumberLabel = new System.Windows.Forms.Label();
            this.ConsigneeZipCodetextBox = new System.Windows.Forms.TextBox();
            this.ConsigneeZipCodeLabel = new System.Windows.Forms.Label();
            this.ConsigneeStateLabel = new System.Windows.Forms.Label();
            this.ConsigneeCitytextBox = new System.Windows.Forms.TextBox();
            this.ConsigneeCityLabel = new System.Windows.Forms.Label();
            this.ConsigneeAddressLN1textBox = new System.Windows.Forms.TextBox();
            this.ConsigneeAddressLN1Label = new System.Windows.Forms.Label();
            this.ConsigneeCompanyNameLabel = new System.Windows.Forms.Label();
            this.AddAConsigneeLabel = new System.Windows.Forms.Label();
            this.ConsigneeCompanyNametextBox = new System.Windows.Forms.TextBox();
            this.SubmitShipperInfoButton = new System.Windows.Forms.Button();
            this.SubmitConsigneeInfoButton = new System.Windows.Forms.Button();
            this.ShipperCustomerNumbertextBox = new System.Windows.Forms.TextBox();
            this.ConsigneeCustomerNumbertextBox = new System.Windows.Forms.TextBox();
            this.ShipperCustomerNumberLabel = new System.Windows.Forms.Label();
            this.ConsigneeCustomerNumberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FreightDescriptionlabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ProgressBarLabel = new System.Windows.Forms.Label();
            this.HUlabel = new System.Windows.Forms.Label();
            this.FreightDescriptiontextBox = new System.Windows.Forms.TextBox();
            this.HUnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HazStatuscheckBox = new System.Windows.Forms.CheckBox();
            this.WeightInPoundsnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WeightInPoundslabel = new System.Windows.Forms.Label();
            this.FreightIDNumberlabel = new System.Windows.Forms.Label();
            this.FreightIDNumbertextBox = new System.Windows.Forms.TextBox();
            this.SubmitFreightInfobutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ShipperStatecomboBox = new System.Windows.Forms.ComboBox();
            this.ConsigneeStatecomboBox = new System.Windows.Forms.ComboBox();
            this.HandelingUnitTypelabel = new System.Windows.Forms.Label();
            this.HangelingUnitTypecomboBox = new System.Windows.Forms.ComboBox();
            this.GoBackButtonbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HUnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightInPoundsnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShipperCompanyNametextBox
            // 
            this.ShipperCompanyNametextBox.Location = new System.Drawing.Point(54, 86);
            this.ShipperCompanyNametextBox.Name = "ShipperCompanyNametextBox";
            this.ShipperCompanyNametextBox.Size = new System.Drawing.Size(279, 23);
            this.ShipperCompanyNametextBox.TabIndex = 0;
            this.ShipperCompanyNametextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddAShipperLabel
            // 
            this.AddAShipperLabel.AutoSize = true;
            this.AddAShipperLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddAShipperLabel.Location = new System.Drawing.Point(54, 23);
            this.AddAShipperLabel.Name = "AddAShipperLabel";
            this.AddAShipperLabel.Size = new System.Drawing.Size(144, 30);
            this.AddAShipperLabel.TabIndex = 1;
            this.AddAShipperLabel.Text = "Add a Shipper";
            // 
            // ShipperCompanyNameLabel
            // 
            this.ShipperCompanyNameLabel.AutoSize = true;
            this.ShipperCompanyNameLabel.Location = new System.Drawing.Point(54, 68);
            this.ShipperCompanyNameLabel.Name = "ShipperCompanyNameLabel";
            this.ShipperCompanyNameLabel.Size = new System.Drawing.Size(131, 15);
            this.ShipperCompanyNameLabel.TabIndex = 2;
            this.ShipperCompanyNameLabel.Text = "Company Name/Name";
            // 
            // ShipperAddressLN1Label
            // 
            this.ShipperAddressLN1Label.AutoSize = true;
            this.ShipperAddressLN1Label.Location = new System.Drawing.Point(54, 112);
            this.ShipperAddressLN1Label.Name = "ShipperAddressLN1Label";
            this.ShipperAddressLN1Label.Size = new System.Drawing.Size(68, 15);
            this.ShipperAddressLN1Label.TabIndex = 3;
            this.ShipperAddressLN1Label.Text = "Address ln1";
            // 
            // ShipperAddressLN1textBox
            // 
            this.ShipperAddressLN1textBox.Location = new System.Drawing.Point(54, 130);
            this.ShipperAddressLN1textBox.Name = "ShipperAddressLN1textBox";
            this.ShipperAddressLN1textBox.Size = new System.Drawing.Size(279, 23);
            this.ShipperAddressLN1textBox.TabIndex = 4;
            // 
            // ShipperCitytextBox
            // 
            this.ShipperCitytextBox.Location = new System.Drawing.Point(54, 177);
            this.ShipperCitytextBox.Name = "ShipperCitytextBox";
            this.ShipperCitytextBox.Size = new System.Drawing.Size(279, 23);
            this.ShipperCitytextBox.TabIndex = 6;
            // 
            // ShipperCityLabel
            // 
            this.ShipperCityLabel.AutoSize = true;
            this.ShipperCityLabel.Location = new System.Drawing.Point(54, 159);
            this.ShipperCityLabel.Name = "ShipperCityLabel";
            this.ShipperCityLabel.Size = new System.Drawing.Size(28, 15);
            this.ShipperCityLabel.TabIndex = 5;
            this.ShipperCityLabel.Text = "City";
            // 
            // ShipperStateLabel
            // 
            this.ShipperStateLabel.AutoSize = true;
            this.ShipperStateLabel.Location = new System.Drawing.Point(54, 206);
            this.ShipperStateLabel.Name = "ShipperStateLabel";
            this.ShipperStateLabel.Size = new System.Drawing.Size(33, 15);
            this.ShipperStateLabel.TabIndex = 7;
            this.ShipperStateLabel.Text = "State";
            // 
            // ShipperZipCodetextBox
            // 
            this.ShipperZipCodetextBox.Location = new System.Drawing.Point(54, 271);
            this.ShipperZipCodetextBox.Name = "ShipperZipCodetextBox";
            this.ShipperZipCodetextBox.Size = new System.Drawing.Size(131, 23);
            this.ShipperZipCodetextBox.TabIndex = 10;
            // 
            // ShipperZipCodeLabel
            // 
            this.ShipperZipCodeLabel.AutoSize = true;
            this.ShipperZipCodeLabel.Location = new System.Drawing.Point(54, 253);
            this.ShipperZipCodeLabel.Name = "ShipperZipCodeLabel";
            this.ShipperZipCodeLabel.Size = new System.Drawing.Size(58, 15);
            this.ShipperZipCodeLabel.TabIndex = 9;
            this.ShipperZipCodeLabel.Text = "Zip Code ";
            // 
            // SearchByShipperCustomerNumberLabel
            // 
            this.SearchByShipperCustomerNumberLabel.AutoSize = true;
            this.SearchByShipperCustomerNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchByShipperCustomerNumberLabel.Location = new System.Drawing.Point(54, 297);
            this.SearchByShipperCustomerNumberLabel.Name = "SearchByShipperCustomerNumberLabel";
            this.SearchByShipperCustomerNumberLabel.Size = new System.Drawing.Size(213, 21);
            this.SearchByShipperCustomerNumberLabel.TabIndex = 11;
            this.SearchByShipperCustomerNumberLabel.Text = "Or Search Customer Number";
            // 
            // ShipperCustomerNumberSearchtextBox
            // 
            this.ShipperCustomerNumberSearchtextBox.Location = new System.Drawing.Point(54, 321);
            this.ShipperCustomerNumberSearchtextBox.Name = "ShipperCustomerNumberSearchtextBox";
            this.ShipperCustomerNumberSearchtextBox.Size = new System.Drawing.Size(101, 23);
            this.ShipperCustomerNumberSearchtextBox.TabIndex = 12;
            // 
            // ShipperCustomerNumberSearchButton
            // 
            this.ShipperCustomerNumberSearchButton.Location = new System.Drawing.Point(175, 321);
            this.ShipperCustomerNumberSearchButton.Name = "ShipperCustomerNumberSearchButton";
            this.ShipperCustomerNumberSearchButton.Size = new System.Drawing.Size(102, 23);
            this.ShipperCustomerNumberSearchButton.TabIndex = 13;
            this.ShipperCustomerNumberSearchButton.Text = "Search Customer Number";
            this.ShipperCustomerNumberSearchButton.UseVisualStyleBackColor = true;
            this.ShipperCustomerNumberSearchButton.Click += new System.EventHandler(this.ShipperCustomerNumberSearchButton_Click);
            // 
            // ConsigneeCustomerNumberSearchButton
            // 
            this.ConsigneeCustomerNumberSearchButton.Location = new System.Drawing.Point(677, 321);
            this.ConsigneeCustomerNumberSearchButton.Name = "ConsigneeCustomerNumberSearchButton";
            this.ConsigneeCustomerNumberSearchButton.Size = new System.Drawing.Size(102, 23);
            this.ConsigneeCustomerNumberSearchButton.TabIndex = 27;
            this.ConsigneeCustomerNumberSearchButton.Text = "Search Customer Number";
            this.ConsigneeCustomerNumberSearchButton.UseVisualStyleBackColor = true;
            this.ConsigneeCustomerNumberSearchButton.Click += new System.EventHandler(this.ConsigneeCustomerNumberSearchButton_Click);
            // 
            // ConsigneeCustomerNumberSearchtextBox
            // 
            this.ConsigneeCustomerNumberSearchtextBox.Location = new System.Drawing.Point(556, 321);
            this.ConsigneeCustomerNumberSearchtextBox.Name = "ConsigneeCustomerNumberSearchtextBox";
            this.ConsigneeCustomerNumberSearchtextBox.Size = new System.Drawing.Size(101, 23);
            this.ConsigneeCustomerNumberSearchtextBox.TabIndex = 26;
            // 
            // SearchByConsigneeCustomerNumberLabel
            // 
            this.SearchByConsigneeCustomerNumberLabel.AutoSize = true;
            this.SearchByConsigneeCustomerNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchByConsigneeCustomerNumberLabel.Location = new System.Drawing.Point(556, 297);
            this.SearchByConsigneeCustomerNumberLabel.Name = "SearchByConsigneeCustomerNumberLabel";
            this.SearchByConsigneeCustomerNumberLabel.Size = new System.Drawing.Size(213, 21);
            this.SearchByConsigneeCustomerNumberLabel.TabIndex = 25;
            this.SearchByConsigneeCustomerNumberLabel.Text = "Or Search Customer Number";
            // 
            // ConsigneeZipCodetextBox
            // 
            this.ConsigneeZipCodetextBox.Location = new System.Drawing.Point(556, 271);
            this.ConsigneeZipCodetextBox.Name = "ConsigneeZipCodetextBox";
            this.ConsigneeZipCodetextBox.Size = new System.Drawing.Size(131, 23);
            this.ConsigneeZipCodetextBox.TabIndex = 24;
            // 
            // ConsigneeZipCodeLabel
            // 
            this.ConsigneeZipCodeLabel.AutoSize = true;
            this.ConsigneeZipCodeLabel.Location = new System.Drawing.Point(556, 253);
            this.ConsigneeZipCodeLabel.Name = "ConsigneeZipCodeLabel";
            this.ConsigneeZipCodeLabel.Size = new System.Drawing.Size(58, 15);
            this.ConsigneeZipCodeLabel.TabIndex = 23;
            this.ConsigneeZipCodeLabel.Text = "Zip Code ";
            // 
            // ConsigneeStateLabel
            // 
            this.ConsigneeStateLabel.AutoSize = true;
            this.ConsigneeStateLabel.Location = new System.Drawing.Point(556, 206);
            this.ConsigneeStateLabel.Name = "ConsigneeStateLabel";
            this.ConsigneeStateLabel.Size = new System.Drawing.Size(33, 15);
            this.ConsigneeStateLabel.TabIndex = 21;
            this.ConsigneeStateLabel.Text = "State";
            // 
            // ConsigneeCitytextBox
            // 
            this.ConsigneeCitytextBox.Location = new System.Drawing.Point(556, 177);
            this.ConsigneeCitytextBox.Name = "ConsigneeCitytextBox";
            this.ConsigneeCitytextBox.Size = new System.Drawing.Size(279, 23);
            this.ConsigneeCitytextBox.TabIndex = 20;
            // 
            // ConsigneeCityLabel
            // 
            this.ConsigneeCityLabel.AutoSize = true;
            this.ConsigneeCityLabel.Location = new System.Drawing.Point(556, 159);
            this.ConsigneeCityLabel.Name = "ConsigneeCityLabel";
            this.ConsigneeCityLabel.Size = new System.Drawing.Size(28, 15);
            this.ConsigneeCityLabel.TabIndex = 19;
            this.ConsigneeCityLabel.Text = "City";
            // 
            // ConsigneeAddressLN1textBox
            // 
            this.ConsigneeAddressLN1textBox.Location = new System.Drawing.Point(556, 130);
            this.ConsigneeAddressLN1textBox.Name = "ConsigneeAddressLN1textBox";
            this.ConsigneeAddressLN1textBox.Size = new System.Drawing.Size(279, 23);
            this.ConsigneeAddressLN1textBox.TabIndex = 18;
            // 
            // ConsigneeAddressLN1Label
            // 
            this.ConsigneeAddressLN1Label.AutoSize = true;
            this.ConsigneeAddressLN1Label.Location = new System.Drawing.Point(556, 112);
            this.ConsigneeAddressLN1Label.Name = "ConsigneeAddressLN1Label";
            this.ConsigneeAddressLN1Label.Size = new System.Drawing.Size(68, 15);
            this.ConsigneeAddressLN1Label.TabIndex = 17;
            this.ConsigneeAddressLN1Label.Text = "Address ln1";
            // 
            // ConsigneeCompanyNameLabel
            // 
            this.ConsigneeCompanyNameLabel.AutoSize = true;
            this.ConsigneeCompanyNameLabel.Location = new System.Drawing.Point(556, 68);
            this.ConsigneeCompanyNameLabel.Name = "ConsigneeCompanyNameLabel";
            this.ConsigneeCompanyNameLabel.Size = new System.Drawing.Size(131, 15);
            this.ConsigneeCompanyNameLabel.TabIndex = 16;
            this.ConsigneeCompanyNameLabel.Text = "Company Name/Name";
            // 
            // AddAConsigneeLabel
            // 
            this.AddAConsigneeLabel.AutoSize = true;
            this.AddAConsigneeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddAConsigneeLabel.Location = new System.Drawing.Point(556, 23);
            this.AddAConsigneeLabel.Name = "AddAConsigneeLabel";
            this.AddAConsigneeLabel.Size = new System.Drawing.Size(171, 30);
            this.AddAConsigneeLabel.TabIndex = 15;
            this.AddAConsigneeLabel.Text = "Add a Consignee";
            // 
            // ConsigneeCompanyNametextBox
            // 
            this.ConsigneeCompanyNametextBox.Location = new System.Drawing.Point(556, 86);
            this.ConsigneeCompanyNametextBox.Name = "ConsigneeCompanyNametextBox";
            this.ConsigneeCompanyNametextBox.Size = new System.Drawing.Size(279, 23);
            this.ConsigneeCompanyNametextBox.TabIndex = 14;
            // 
            // SubmitShipperInfoButton
            // 
            this.SubmitShipperInfoButton.Location = new System.Drawing.Point(54, 363);
            this.SubmitShipperInfoButton.Name = "SubmitShipperInfoButton";
            this.SubmitShipperInfoButton.Size = new System.Drawing.Size(186, 23);
            this.SubmitShipperInfoButton.TabIndex = 28;
            this.SubmitShipperInfoButton.Text = "Submit Shipper Information";
            this.SubmitShipperInfoButton.UseVisualStyleBackColor = true;
            this.SubmitShipperInfoButton.Click += new System.EventHandler(this.SubmitShipperInfoButton_Click);
            // 
            // SubmitConsigneeInfoButton
            // 
            this.SubmitConsigneeInfoButton.Location = new System.Drawing.Point(556, 363);
            this.SubmitConsigneeInfoButton.Name = "SubmitConsigneeInfoButton";
            this.SubmitConsigneeInfoButton.Size = new System.Drawing.Size(186, 23);
            this.SubmitConsigneeInfoButton.TabIndex = 29;
            this.SubmitConsigneeInfoButton.Text = "Submit Consignee Information";
            this.SubmitConsigneeInfoButton.UseVisualStyleBackColor = true;
            this.SubmitConsigneeInfoButton.Click += new System.EventHandler(this.SubmitConsigneeInfoButton_Click);
            // 
            // ShipperCustomerNumbertextBox
            // 
            this.ShipperCustomerNumbertextBox.Location = new System.Drawing.Point(290, 363);
            this.ShipperCustomerNumbertextBox.Name = "ShipperCustomerNumbertextBox";
            this.ShipperCustomerNumbertextBox.ReadOnly = true;
            this.ShipperCustomerNumbertextBox.Size = new System.Drawing.Size(101, 23);
            this.ShipperCustomerNumbertextBox.TabIndex = 30;
            // 
            // ConsigneeCustomerNumbertextBox
            // 
            this.ConsigneeCustomerNumbertextBox.Location = new System.Drawing.Point(805, 363);
            this.ConsigneeCustomerNumbertextBox.Name = "ConsigneeCustomerNumbertextBox";
            this.ConsigneeCustomerNumbertextBox.ReadOnly = true;
            this.ConsigneeCustomerNumbertextBox.Size = new System.Drawing.Size(101, 23);
            this.ConsigneeCustomerNumbertextBox.TabIndex = 31;
            // 
            // ShipperCustomerNumberLabel
            // 
            this.ShipperCustomerNumberLabel.AutoSize = true;
            this.ShipperCustomerNumberLabel.Location = new System.Drawing.Point(290, 345);
            this.ShipperCustomerNumberLabel.Name = "ShipperCustomerNumberLabel";
            this.ShipperCustomerNumberLabel.Size = new System.Drawing.Size(106, 15);
            this.ShipperCustomerNumberLabel.TabIndex = 32;
            this.ShipperCustomerNumberLabel.Text = "Customer Number";
            // 
            // ConsigneeCustomerNumberLabel
            // 
            this.ConsigneeCustomerNumberLabel.AutoSize = true;
            this.ConsigneeCustomerNumberLabel.Location = new System.Drawing.Point(805, 345);
            this.ConsigneeCustomerNumberLabel.Name = "ConsigneeCustomerNumberLabel";
            this.ConsigneeCustomerNumberLabel.Size = new System.Drawing.Size(106, 15);
            this.ConsigneeCustomerNumberLabel.TabIndex = 33;
            this.ConsigneeCustomerNumberLabel.Text = "Customer Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 30);
            this.label1.TabIndex = 34;
            this.label1.Text = "Freight Information";
            // 
            // FreightDescriptionlabel
            // 
            this.FreightDescriptionlabel.AutoSize = true;
            this.FreightDescriptionlabel.Location = new System.Drawing.Point(54, 469);
            this.FreightDescriptionlabel.Name = "FreightDescriptionlabel";
            this.FreightDescriptionlabel.Size = new System.Drawing.Size(107, 15);
            this.FreightDescriptionlabel.TabIndex = 36;
            this.FreightDescriptionlabel.Text = "Freight Description";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(301, 655);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(372, 23);
            this.progressBar1.Step = 33;
            this.progressBar1.TabIndex = 37;
            // 
            // ProgressBarLabel
            // 
            this.ProgressBarLabel.AutoSize = true;
            this.ProgressBarLabel.Location = new System.Drawing.Point(462, 637);
            this.ProgressBarLabel.Name = "ProgressBarLabel";
            this.ProgressBarLabel.Size = new System.Drawing.Size(55, 15);
            this.ProgressBarLabel.TabIndex = 38;
            this.ProgressBarLabel.Text = "Progress ";
            // 
            // HUlabel
            // 
            this.HUlabel.AutoSize = true;
            this.HUlabel.Location = new System.Drawing.Point(416, 474);
            this.HUlabel.Name = "HUlabel";
            this.HUlabel.Size = new System.Drawing.Size(89, 15);
            this.HUlabel.TabIndex = 40;
            this.HUlabel.Text = "Handling Units ";
            // 
            // FreightDescriptiontextBox
            // 
            this.FreightDescriptiontextBox.Location = new System.Drawing.Point(54, 487);
            this.FreightDescriptiontextBox.MaxLength = 3276;
            this.FreightDescriptiontextBox.Multiline = true;
            this.FreightDescriptiontextBox.Name = "FreightDescriptiontextBox";
            this.FreightDescriptiontextBox.Size = new System.Drawing.Size(342, 113);
            this.FreightDescriptiontextBox.TabIndex = 41;
            // 
            // HUnumericUpDown
            // 
            this.HUnumericUpDown.AllowDrop = true;
            this.HUnumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HUnumericUpDown.Location = new System.Drawing.Point(416, 493);
            this.HUnumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.HUnumericUpDown.Name = "HUnumericUpDown";
            this.HUnumericUpDown.Size = new System.Drawing.Size(144, 19);
            this.HUnumericUpDown.TabIndex = 42;
            // 
            // HazStatuscheckBox
            // 
            this.HazStatuscheckBox.AutoSize = true;
            this.HazStatuscheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HazStatuscheckBox.Location = new System.Drawing.Point(416, 446);
            this.HazStatuscheckBox.Name = "HazStatuscheckBox";
            this.HazStatuscheckBox.Size = new System.Drawing.Size(187, 25);
            this.HazStatuscheckBox.TabIndex = 43;
            this.HazStatuscheckBox.Text = "Hazmat? (Check = yes)";
            this.HazStatuscheckBox.UseVisualStyleBackColor = true;
            this.HazStatuscheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // WeightInPoundsnumericUpDown
            // 
            this.WeightInPoundsnumericUpDown.AllowDrop = true;
            this.WeightInPoundsnumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WeightInPoundsnumericUpDown.Location = new System.Drawing.Point(416, 581);
            this.WeightInPoundsnumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.WeightInPoundsnumericUpDown.Name = "WeightInPoundsnumericUpDown";
            this.WeightInPoundsnumericUpDown.Size = new System.Drawing.Size(144, 19);
            this.WeightInPoundsnumericUpDown.TabIndex = 45;
            this.WeightInPoundsnumericUpDown.ValueChanged += new System.EventHandler(this.WeightInPoundsnumericUpDown_ValueChanged);
            // 
            // WeightInPoundslabel
            // 
            this.WeightInPoundslabel.AutoSize = true;
            this.WeightInPoundslabel.Location = new System.Drawing.Point(416, 562);
            this.WeightInPoundslabel.Name = "WeightInPoundslabel";
            this.WeightInPoundslabel.Size = new System.Drawing.Size(101, 30);
            this.WeightInPoundslabel.TabIndex = 44;
            this.WeightInPoundslabel.Text = "Weight In Pounds\r\n\r\n";
            // 
            // FreightIDNumberlabel
            // 
            this.FreightIDNumberlabel.AutoSize = true;
            this.FreightIDNumberlabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FreightIDNumberlabel.Location = new System.Drawing.Point(682, 544);
            this.FreightIDNumberlabel.Name = "FreightIDNumberlabel";
            this.FreightIDNumberlabel.Size = new System.Drawing.Size(248, 25);
            this.FreightIDNumberlabel.TabIndex = 46;
            this.FreightIDNumberlabel.Text = "Auto Generated Freight ID #";
            this.FreightIDNumberlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FreightIDNumbertextBox
            // 
            this.FreightIDNumbertextBox.Location = new System.Drawing.Point(665, 577);
            this.FreightIDNumbertextBox.Name = "FreightIDNumbertextBox";
            this.FreightIDNumbertextBox.Size = new System.Drawing.Size(276, 23);
            this.FreightIDNumbertextBox.TabIndex = 47;
            // 
            // SubmitFreightInfobutton
            // 
            this.SubmitFreightInfobutton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubmitFreightInfobutton.Location = new System.Drawing.Point(682, 469);
            this.SubmitFreightInfobutton.Name = "SubmitFreightInfobutton";
            this.SubmitFreightInfobutton.Size = new System.Drawing.Size(230, 54);
            this.SubmitFreightInfobutton.TabIndex = 48;
            this.SubmitFreightInfobutton.Text = "Submit";
            this.SubmitFreightInfobutton.UseVisualStyleBackColor = true;
            this.SubmitFreightInfobutton.Click += new System.EventHandler(this.SubmitFreightInfobutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ShipperStatecomboBox
            // 
            this.ShipperStatecomboBox.FormattingEnabled = true;
            this.ShipperStatecomboBox.Items.AddRange(new object[] {
            "AL\t",
            "AK\t",
            "AZ\t",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.ShipperStatecomboBox.Location = new System.Drawing.Point(54, 224);
            this.ShipperStatecomboBox.Name = "ShipperStatecomboBox";
            this.ShipperStatecomboBox.Size = new System.Drawing.Size(121, 23);
            this.ShipperStatecomboBox.TabIndex = 51;
            // 
            // ConsigneeStatecomboBox
            // 
            this.ConsigneeStatecomboBox.FormattingEnabled = true;
            this.ConsigneeStatecomboBox.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.ConsigneeStatecomboBox.Location = new System.Drawing.Point(556, 224);
            this.ConsigneeStatecomboBox.Name = "ConsigneeStatecomboBox";
            this.ConsigneeStatecomboBox.Size = new System.Drawing.Size(121, 23);
            this.ConsigneeStatecomboBox.TabIndex = 52;
            // 
            // HandelingUnitTypelabel
            // 
            this.HandelingUnitTypelabel.AutoSize = true;
            this.HandelingUnitTypelabel.Location = new System.Drawing.Point(416, 515);
            this.HandelingUnitTypelabel.Name = "HandelingUnitTypelabel";
            this.HandelingUnitTypelabel.Size = new System.Drawing.Size(108, 15);
            this.HandelingUnitTypelabel.TabIndex = 53;
            this.HandelingUnitTypelabel.Text = "Handling Unit Type";
            // 
            // HangelingUnitTypecomboBox
            // 
            this.HangelingUnitTypecomboBox.FormattingEnabled = true;
            this.HangelingUnitTypecomboBox.Items.AddRange(new object[] {
            "SK",
            "PL",
            "RL",
            "BX",
            "CR",
            "PC",
            "TB"});
            this.HangelingUnitTypecomboBox.Location = new System.Drawing.Point(416, 533);
            this.HangelingUnitTypecomboBox.Name = "HangelingUnitTypecomboBox";
            this.HangelingUnitTypecomboBox.Size = new System.Drawing.Size(121, 23);
            this.HangelingUnitTypecomboBox.TabIndex = 54;
            // 
            // GoBackButtonbutton
            // 
            this.GoBackButtonbutton.Location = new System.Drawing.Point(722, 637);
            this.GoBackButtonbutton.Name = "GoBackButtonbutton";
            this.GoBackButtonbutton.Size = new System.Drawing.Size(208, 32);
            this.GoBackButtonbutton.TabIndex = 55;
            this.GoBackButtonbutton.Text = "Go Back";
            this.GoBackButtonbutton.UseVisualStyleBackColor = true;
            this.GoBackButtonbutton.Click += new System.EventHandler(this.GoBackButtonbutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 690);
            this.Controls.Add(this.GoBackButtonbutton);
            this.Controls.Add(this.HangelingUnitTypecomboBox);
            this.Controls.Add(this.HandelingUnitTypelabel);
            this.Controls.Add(this.ConsigneeStatecomboBox);
            this.Controls.Add(this.ShipperStatecomboBox);
            this.Controls.Add(this.SubmitFreightInfobutton);
            this.Controls.Add(this.FreightIDNumbertextBox);
            this.Controls.Add(this.FreightIDNumberlabel);
            this.Controls.Add(this.WeightInPoundsnumericUpDown);
            this.Controls.Add(this.WeightInPoundslabel);
            this.Controls.Add(this.HazStatuscheckBox);
            this.Controls.Add(this.HUnumericUpDown);
            this.Controls.Add(this.FreightDescriptiontextBox);
            this.Controls.Add(this.HUlabel);
            this.Controls.Add(this.ProgressBarLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.FreightDescriptionlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsigneeCustomerNumberLabel);
            this.Controls.Add(this.ShipperCustomerNumberLabel);
            this.Controls.Add(this.ConsigneeCustomerNumbertextBox);
            this.Controls.Add(this.ShipperCustomerNumbertextBox);
            this.Controls.Add(this.SubmitConsigneeInfoButton);
            this.Controls.Add(this.SubmitShipperInfoButton);
            this.Controls.Add(this.ConsigneeCustomerNumberSearchButton);
            this.Controls.Add(this.ConsigneeCustomerNumberSearchtextBox);
            this.Controls.Add(this.SearchByConsigneeCustomerNumberLabel);
            this.Controls.Add(this.ConsigneeZipCodetextBox);
            this.Controls.Add(this.ConsigneeZipCodeLabel);
            this.Controls.Add(this.ConsigneeStateLabel);
            this.Controls.Add(this.ConsigneeCitytextBox);
            this.Controls.Add(this.ConsigneeCityLabel);
            this.Controls.Add(this.ConsigneeAddressLN1textBox);
            this.Controls.Add(this.ConsigneeAddressLN1Label);
            this.Controls.Add(this.ConsigneeCompanyNameLabel);
            this.Controls.Add(this.AddAConsigneeLabel);
            this.Controls.Add(this.ConsigneeCompanyNametextBox);
            this.Controls.Add(this.ShipperCustomerNumberSearchButton);
            this.Controls.Add(this.ShipperCustomerNumberSearchtextBox);
            this.Controls.Add(this.SearchByShipperCustomerNumberLabel);
            this.Controls.Add(this.ShipperZipCodetextBox);
            this.Controls.Add(this.ShipperZipCodeLabel);
            this.Controls.Add(this.ShipperStateLabel);
            this.Controls.Add(this.ShipperCitytextBox);
            this.Controls.Add(this.ShipperCityLabel);
            this.Controls.Add(this.ShipperAddressLN1textBox);
            this.Controls.Add(this.ShipperAddressLN1Label);
            this.Controls.Add(this.ShipperCompanyNameLabel);
            this.Controls.Add(this.AddAShipperLabel);
            this.Controls.Add(this.ShipperCompanyNametextBox);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Freight To System";
            ((System.ComponentModel.ISupportInitialize)(this.HUnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightInPoundsnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ShipperCompanyNametextBox;
        private System.Windows.Forms.Label AddAShipperLabel;
        private System.Windows.Forms.Label ShipperCompanyNameLabel;
        private System.Windows.Forms.Label ShipperAddressLN1Label;
        private System.Windows.Forms.TextBox ShipperAddressLN1textBox;
        private System.Windows.Forms.TextBox ShipperCitytextBox;
        private System.Windows.Forms.Label ShipperCityLabel;
        private System.Windows.Forms.Label ShipperStateLabel;
        private System.Windows.Forms.TextBox ShipperZipCodetextBox;
        private System.Windows.Forms.Label ShipperZipCodeLabel;
        private System.Windows.Forms.Label SearchByShipperCustomerNumberLabel;
        private System.Windows.Forms.TextBox ShipperCustomerNumberSearchtextBox;
        private System.Windows.Forms.Button ShipperCustomerNumberSearchButton;
        private System.Windows.Forms.Button ConsigneeCustomerNumberSearchButton;
        private System.Windows.Forms.TextBox ConsigneeCustomerNumberSearchtextBox;
        private System.Windows.Forms.Label SearchByConsigneeCustomerNumberLabel;
        private System.Windows.Forms.TextBox ConsigneeZipCodetextBox;
        private System.Windows.Forms.Label ConsigneeZipCodeLabel;
        private System.Windows.Forms.Label ConsigneeStateLabel;
        private System.Windows.Forms.TextBox ConsigneeCitytextBox;
        private System.Windows.Forms.Label ConsigneeCityLabel;
        private System.Windows.Forms.TextBox ConsigneeAddressLN1textBox;
        private System.Windows.Forms.Label ConsigneeAddressLN1Label;
        private System.Windows.Forms.Label ConsigneeCompanyNameLabel;
        private System.Windows.Forms.Label AddAConsigneeLabel;
        private System.Windows.Forms.TextBox ConsigneeCompanyNametextBox;
        private System.Windows.Forms.Button SubmitShipperInfoButton;
        private System.Windows.Forms.Button SubmitConsigneeInfoButton;
        private System.Windows.Forms.TextBox ShipperCustomerNumbertextBox;
        private System.Windows.Forms.TextBox ConsigneeCustomerNumbertextBox;
        private System.Windows.Forms.Label ShipperCustomerNumberLabel;
        private System.Windows.Forms.Label ConsigneeCustomerNumberLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FreightDescriptionlabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label ProgressBarLabel;
        private System.Windows.Forms.Label HUlabel;
        private System.Windows.Forms.TextBox FreightDescriptiontextBox;
        private System.Windows.Forms.NumericUpDown HUnumericUpDown;
        private System.Windows.Forms.CheckBox HazStatuscheckBox;
        private System.Windows.Forms.NumericUpDown WeightInPoundsnumericUpDown;
        private System.Windows.Forms.Label WeightInPoundslabel;
        private System.Windows.Forms.Label FreightIDNumberlabel;
        private System.Windows.Forms.TextBox FreightIDNumbertextBox;
        private System.Windows.Forms.Button SubmitFreightInfobutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox ShipperStatecomboBox;
        private System.Windows.Forms.ComboBox ConsigneeStatecomboBox;
        private System.Windows.Forms.ComboBox HangelingUnitTypecomboBox;
        private System.Windows.Forms.Label HandelingUnitTypelabel;
        private System.Windows.Forms.Button GoBackButtonbutton;
    }
}