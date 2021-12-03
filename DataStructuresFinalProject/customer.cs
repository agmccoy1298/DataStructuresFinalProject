using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresFinalProject
{
    class customer
    {
        //fields
        private string companyName;
        private string addressln1;
        private string addressln2;
        private string state;
        private string zip;
        private static int nextCustomerNum = 1001;
        private int currCustomerNum;

        //constructors
        //default no args
        public customer()
        {

        }
        //non default
        public customer(string _companyName, string _addressln1, string _addressln2, string _state, string _zip)
        {
            this.CompanyName = _companyName;
            this.Addressln1 = _addressln1;
            this.Addressln2 = _addressln2;
            this.State = _state;
            this.Zip = _zip;
            nextCustomerNum++;
            this.CurrCustomerNum = nextCustomerNum;
        }

        //getters and setters
        public string CompanyName { get => companyName; set => companyName = value; }
        public string Addressln1 { get => addressln1; set => addressln1 = value; }
        public string Addressln2 { get => addressln2; set => addressln2 = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }
        public int CurrCustomerNum { get => currCustomerNum; set => currCustomerNum = value; }



        //helper methods



    }
}
