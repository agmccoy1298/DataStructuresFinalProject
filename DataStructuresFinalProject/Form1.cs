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
    public partial class Form1 : Form
    {
        public PackingList HomePageClass { get; set; }
        public PriorityQueue HomePagePriorityQueue { get; set; }        
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 addForm = new Form2();//instanciation
            //addForm.packingListObjectsForms = HomePageClass;
            addForm.Show();            
        }
       

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            if (PackingList.Size == 0)
            {
                MessageBox.Show("You do not have any freight added to the system. Please add freight first.");
            }
            else
            {                
                this.Hide();
                Form3 searchForm = new Form3();
                searchForm.MySearchClass = HomePageClass;
                searchForm.Show(); 
            }
        }

        private void buttonTerminate_Click(object sender, EventArgs e)
        {
           DialogResult dr = MessageBox.Show("Are you sure you want to close this program? (all freight info will be lost)", "Confirm" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                this.Close();
            }               
        }

        private void IDNumberMultilineTextBox_TextChanged(object sender, EventArgs e)
        {
            PackingList mypackingList = new PackingList();
            mypackingList.IDNumbers();               
        }

        private void ShowPriorityQueueButton_Click(object sender, EventArgs e)
        {
            string tempString;
            if (PackingList.Size == 0)
            {
                tempString = "There is no freight added";
                PriorityFreightQueuetextBox.Text = tempString;
            }
            else
            {
                PriorityFreightQueuetextBox.Text = HomePagePriorityQueue.DisplayQueue();
            }
        }
    }
}
