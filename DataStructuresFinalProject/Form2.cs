using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructuresFinalProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SubmitShipperInfoButton_Click(object sender, EventArgs e)
        {
            customer shipperObject = new customer();
            string tempString = shipperObject.Add(ShipperCompanyNametextBox.Text, ShipperAddressLN1textBox.Text, ShipperCitytextBox.Text, ShipperStatecomboBox.Text, ShipperZipCodetextBox.Text).ToString();
            ShipperCustomerNumbertextBox.Text = tempString;            

            //this clears all the fields once submitted but i'm not sure if I need this or not
            //todo
            ShipperCompanyNametextBox.Clear();
            ShipperAddressLN1textBox.Clear();
            ShipperCitytextBox.Clear();
            ShipperStatecomboBox.ResetText();
            ShipperZipCodetextBox.Clear();
            progressBar1.PerformStep();
        }

        private void SubmitConsigneeInfoButton_Click(object sender, EventArgs e)
        {
            customer consigneeObject = new customer();       
            string tempString = consigneeObject.Add(ConsigneeCompanyNametextBox.Text, ConsigneeAddressLN1textBox.Text, ConsigneeCitytextBox.Text, ConsigneeStatecomboBox.Text, ConsigneeZipCodetextBox.Text).ToString();
            ConsigneeCustomerNumbertextBox.Text = tempString;

            //this clears all the fields once submitted but i'm not sure if I need this or not
            //todo
            ConsigneeCompanyNametextBox.Clear();
            ConsigneeAddressLN1textBox.Clear();
            ConsigneeCitytextBox.Clear();
            ConsigneeStatecomboBox.ResetText();
            ConsigneeZipCodetextBox.Clear();
            progressBar1.PerformStep();
        }

        private void ShipperCustomerNumberSearchButton_Click(object sender, EventArgs e)
        {

            customer customer = new customer();
            string tempString = ShipperCustomerNumberSearchtextBox.Text;
            int tempInt = Int32.Parse(tempString);
            customer tempCust = customer.SearchCustomers(tempInt);
            ShipperCompanyNametextBox.Text = tempCust.CompanyName;
            ShipperAddressLN1textBox.Text = tempCust.Addressln1;
            ShipperCitytextBox.Text = tempCust.City;
            ShipperStatecomboBox.Text = tempCust.State;
            ShipperZipCodetextBox.Text = tempCust.Zip;

        }

        private void ConsigneeCustomerNumberSearchButton_Click(object sender, EventArgs e)
        {
            customer customer = new customer();
            string tempString = ConsigneeCustomerNumberSearchtextBox.Text;
            int tempInt = Int32.Parse(tempString);           
            customer tempCust = customer.SearchCustomers(tempInt);
            ConsigneeCompanyNametextBox.Text = tempCust.CompanyName;
            ConsigneeAddressLN1textBox.Text = tempCust.Addressln1;
            ConsigneeCitytextBox.Text = tempCust.City;
            ConsigneeStatecomboBox.Text = tempCust.State;
            ConsigneeZipCodetextBox.Text = tempCust.Zip;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {            
        }

        private void SubmitFreightInfobutton_Click(object sender, EventArgs e)
        {
            //this creates the customer objects from the already populated fields             
            //shipper person sending freight
            customer shipperCust = new customer();
            shipperCust.CompanyName = ShipperCompanyNametextBox.Text;
            shipperCust.Addressln1 = ShipperAddressLN1textBox.Text;
            shipperCust.City = ShipperCitytextBox.Text;
            shipperCust.State = ShipperStatecomboBox.Text;
            shipperCust.Zip = ShipperZipCodetextBox.Text;

            //consignee person recieving freight
            customer consigneeCust = new customer();
            consigneeCust.CompanyName = ConsigneeCompanyNametextBox.Text;
            consigneeCust.Addressln1 = ConsigneeAddressLN1textBox.Text;
            consigneeCust.City = ConsigneeCitytextBox.Text;
            consigneeCust.State = ConsigneeStatecomboBox.Text;
            consigneeCust.Zip = ConsigneeZipCodetextBox.Text;


            PackingList packingListObject = new PackingList();
            string shortDescription = FreightDescriptiontextBox.Text;
            int weightInPounds = (int)WeightInPoundsnumericUpDown.Value;
            //if statement to check hazmat status and set variable
            string hazStatus;
            if (HazStatuscheckBox.Checked)
            {
                hazStatus = "Yes";
            }else
            {
                hazStatus = "No";
            }
            int HUCount = (int)HUnumericUpDown.Value;
            string HUType = HangelingUnitTypecomboBox.Text;
            int freightID = packingListObject.AddPackingList(consigneeCust, shipperCust, shortDescription, weightInPounds, hazStatus, HUCount, HUType);
            FreightIDNumbertextBox.Text = freightID.ToString();           
            DialogResult dr = MessageBox.Show("Your Freight ID Number is :" + FreightIDNumbertextBox.Text + "\n Would you like to add more freight?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //I couldnt find a better way to do this so here it is 
                //shipper clears
                ShipperCompanyNametextBox.Clear();
                ShipperAddressLN1textBox.Clear();
                ShipperCitytextBox.Clear();
                ShipperStatecomboBox.ResetText();
                ShipperZipCodetextBox.Clear();
                //consignee clears
                ConsigneeCompanyNametextBox.Clear();
                ConsigneeAddressLN1textBox.Clear();
                ConsigneeCitytextBox.Clear();
                ConsigneeStatecomboBox.ResetText();
                ConsigneeZipCodetextBox.Clear();
                //freight info clears
                FreightDescriptiontextBox.Clear();
                FreightIDNumbertextBox.Clear();
                HUnumericUpDown.ResetText();
                WeightInPoundsnumericUpDown.ResetText();
                HangelingUnitTypecomboBox.ResetText();

            }
            else if (dr == DialogResult.No)
            {
                this.Hide();
                Form1 homeForm = new Form1();//instanciation
                homeForm.Show();
            }
        }

        private void WeightInPoundsnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void GoBackButtonbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
