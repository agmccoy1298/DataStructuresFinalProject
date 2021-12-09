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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ProSearchbutton_Click(object sender, EventArgs e)
        {
            if (ProSearchtextBox.Text.Length == 0)
            {
                MessageBox.Show("You have not entered a ID number. Please enter an ID number.");
            }
            else
            {
                
            }
        }
    }
}
