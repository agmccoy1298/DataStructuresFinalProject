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
    //the primary function of this form is to display the contents of the packinglist linked list. 
    //you can search an iDnumber on this page and if it exists it will show you all information 
    public partial class Form3 : Form
    {
        //this class is for the datat that is being passed between forms 
        public PackingList MySearchClass { get; set; }
        public Form3()
        {
            InitializeComponent();
        }
        //PackingList 
        //this is the submit button for the ID search this is very very similar to a 
        //program at my job. Very useful
        private void ProSearchbutton_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (ProSearchtextBox.Text.Length == 0 || !int.TryParse(ProSearchtextBox.Text, out parsedValue))
            {
                MessageBox.Show("You have not entered a ID number. Please enter an ID number. (must only contain numbers with no added characters or spaces)");
                ProSearchtextBox.Clear();
            }
            else
            {
                if (MySearchClass.DoesExist(parsedValue) == false)
                {
                    MessageBox.Show("The number you have entered does not match anything that we have in our database (it must already be added in the system)");
                    ProSearchtextBox.Clear();
                }
                else
                {
                    parsedValue = int.Parse(ProSearchtextBox.Text);
                    LinkedListNode<PackingList> tempPackingListNode = MySearchClass.FindObjectInformation(parsedValue);

                    //shipper info
                    ShipperNametextBox.Text = tempPackingListNode.Value.ShipperName.CompanyName;
                    ShipperAddresstextBox.Text = tempPackingListNode.Value.ShipperName.Addressln1;
                    ShipperCitytextBox.Text = tempPackingListNode.Value.ShipperName.City;
                    ShipperStatetextBox.Text = tempPackingListNode.Value.ShipperName.State;
                    ShipperZiptextBox.Text = tempPackingListNode.Value.ShipperName.Zip;

                    //consignee info 
                    ConsigneeNametextBox.Text = tempPackingListNode.Value.ConsigneeName.CompanyName;
                    ConsigneeAddresstextBox.Text = tempPackingListNode.Value.ConsigneeName.Addressln1;
                    ConsigneeCitytextBox.Text = tempPackingListNode.Value.ConsigneeName.City;
                    ConsigneeStatetextBox.Text = tempPackingListNode.Value.ConsigneeName.State;
                    ConsigneeZiptextBox.Text = tempPackingListNode.Value.ConsigneeName.Zip;

                    //freight info
                    FreightDescriptiontextBox.Text = tempPackingListNode.Value.ShortDescription;
                    HazerdousMaterialtextBox.Text = tempPackingListNode.Value.HazardousMaterialStatus;
                    string tempString = tempPackingListNode.Value.WeightInPounds.ToString();
                    WeighttextBox.Text = tempString;
                    string tempString2 = tempPackingListNode.Value.HUCount.ToString();
                    HandelingUnitstextBox.Text = tempString2;
                    HandlingUnitTypetextBox.Text = tempPackingListNode.Value.HUType;
                    PriorityStatustextBox.Text = tempPackingListNode.Value.Priority;
                }                               
            }
        }
        //go back to main form
        private void GoBackbutton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to leave?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                this.Hide();
                Form1 form1 = new Form1();//instanciation
                form1.HomePageClass = MySearchClass;
                form1.Show();

            }

        }
        //these next two are for the print packing list option
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0); 
        }
        Bitmap bmp; 
        private void PrintPackingListbutton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
    }
}
