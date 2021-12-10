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
        //these classes are for the datat that is being passed between forms 
        public PackingList packingListObjectsForms = new PackingList();
        public PriorityQueue packingListPriorityQueue = new PriorityQueue();
        public Form2()
        {
            InitializeComponent();           
        }        
        //these next two buttons submits the customer infor and makes customer classes
        private void SubmitShipperInfoButton_Click(object sender, EventArgs e)
        {
            customer shipperObject = new customer();
            string tempString = shipperObject.Add(ShipperCompanyNametextBox.Text, ShipperAddressLN1textBox.Text, ShipperCitytextBox.Text, ShipperStatecomboBox.Text, ShipperZipCodetextBox.Text).ToString();
            ShipperCustomerNumbertextBox.Text = tempString;
           
            progressBar1.PerformStep();
        }

        private void SubmitConsigneeInfoButton_Click(object sender, EventArgs e)
        {
            customer consigneeObject = new customer();       
            string tempString = consigneeObject.Add(ConsigneeCompanyNametextBox.Text, ConsigneeAddressLN1textBox.Text, ConsigneeCitytextBox.Text, ConsigneeStatecomboBox.Text, ConsigneeZipCodetextBox.Text).ToString();
            ConsigneeCustomerNumbertextBox.Text = tempString;
           
            progressBar1.PerformStep();
        }
        //these next two buttons check if there is an existing customer to look for and repopulate the fields if there is
        private void ShipperCustomerNumberSearchButton_Click(object sender, EventArgs e)
        {
            string tempString = ShipperCustomerNumberSearchtextBox.Text;
            int tempInt = Int32.Parse(tempString);
            customer customer = new customer();
            if (customer.DoesExist(tempInt).Equals(true))
            {
                //clear boxes 
                ShipperCompanyNametextBox.Clear();
                ShipperAddressLN1textBox.Clear();
                ShipperCitytextBox.Clear();
                ShipperStatecomboBox.ResetText();
                ShipperZipCodetextBox.Clear();

                //refill boxes
                progressBar1.PerformStep();
                customer tempCust = customer.SearchCustomers(tempInt);
                ShipperCompanyNametextBox.Text = tempCust.CompanyName;
                ShipperAddressLN1textBox.Text = tempCust.Addressln1;
                ShipperCitytextBox.Text = tempCust.City;
                ShipperStatecomboBox.Text = tempCust.State;
                ShipperZipCodetextBox.Text = tempCust.Zip;
            }
            else
            {
                MessageBox.Show("This customer does not exist", "Confirm", MessageBoxButtons.OK);
                ShipperCustomerNumberSearchtextBox.Clear();
            }            
        }

        private void ConsigneeCustomerNumberSearchButton_Click(object sender, EventArgs e)
        {
            string tempString = ConsigneeCustomerNumberSearchtextBox.Text;
            int tempInt = Int32.Parse(tempString);
            customer customer = new customer();
            if (customer.DoesExist(tempInt).Equals(true))
            {
                //clears boxes
                ConsigneeCompanyNametextBox.Clear();
                ConsigneeAddressLN1textBox.Clear();
                ConsigneeCitytextBox.Clear();
                ConsigneeStatecomboBox.ResetText();
                ConsigneeZipCodetextBox.Clear();

                //refills boxes
                progressBar1.PerformStep();
                customer tempCust = customer.SearchCustomers(tempInt);
                ConsigneeCompanyNametextBox.Text = tempCust.CompanyName;
                ConsigneeAddressLN1textBox.Text = tempCust.Addressln1;
                ConsigneeCitytextBox.Text = tempCust.City;
                ConsigneeStatecomboBox.Text = tempCust.State;
                ConsigneeZipCodetextBox.Text = tempCust.Zip;
            }
            else
            {
                MessageBox.Show("This customer does not exist", "Confirm", MessageBoxButtons.OK);
                ShipperCustomerNumberSearchtextBox.Clear();
            }
        }
        //this is the most important button about 50% of the app process goes through here it submits all information to classes 
        // and it then stores that information
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

            

            string shortDescription = FreightDescriptiontextBox.Text;
            int weightInPounds = (int)WeightInPoundsnumericUpDown.Value;
            string priority = PrioritycomboBox.Text;
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

            //this is where I add to packinglist objects for packinglist and priority queue
            int freightID = packingListObjectsForms.AddPackingList(consigneeCust, shipperCust, shortDescription, weightInPounds, hazStatus, HUCount, HUType, priority);
            PackingList tempPackingList = new PackingList(consigneeCust, shipperCust, shortDescription, weightInPounds, hazStatus, HUCount, HUType, priority);
            packingListPriorityQueue.Push(tempPackingList);            
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
                PrioritycomboBox.ResetText();
                //reset progress bar
                progressBar1.Value = 0;
            }
            else if (dr == DialogResult.No)
            {
                this.Hide();
                Form1 form1 = new Form1();//instanciation
                form1.HomePageClass = packingListObjectsForms;
                form1.HomePagePriorityQueue = packingListPriorityQueue;
                form1.Show();
            }
        }

        private void WeightInPoundsnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }      
        //travel to form 1
        private void GoBackButtonbutton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to leave?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();                
                Form1 form1 = new Form1();//instanciation
                form1.HomePageClass = packingListObjectsForms;
                form1.HomePagePriorityQueue = packingListPriorityQueue; 
                form1.Show();

            }            
        }                   
    }
}
