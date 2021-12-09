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
        private string city;
        private string state;
        private string zip;
        private static int nextCustomerNum = 0;
        private int currCustomerNum;

        //array to hold the customers
        private static customer[] custArray = new customer[100000];
        public static int indexForArray = 0;

        //constructors
        //default no args
        public customer()
        {

        }
        //non default
        public customer(string _companyName, string _addressln1, string city, string _state, string _zip)
        {
            this.CompanyName = _companyName;
            this.Addressln1 = _addressln1;
            this.City = city;
            this.State = _state;
            this.Zip = _zip;
            nextCustomerNum++;
            this.CurrCustomerNum = nextCustomerNum;
        }


        //getters and setters
        public string CompanyName { get => companyName; set => companyName = value; }
        public string Addressln1 { get => addressln1; set => addressln1 = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }
        public int CurrCustomerNum { get => currCustomerNum; set => currCustomerNum = value; }



        //helper methods
        public int Add(string _companyName, string _addressln1, string _city, string _state, string _zip)
        {
            customer customer = new customer(_companyName, _addressln1, _city, _state, _zip);
            custArray[indexForArray] = customer;
            //customer = custArray[indexForArray];
            indexForArray++;
            return customer.CurrCustomerNum;
        }
        public customer SearchCustomers(int custNum)
        {

            customer tempCustomer = new customer();
            for (int i = 0; i <= custArray.Length; i++)
            {
                if (custNum == custArray[i].currCustomerNum)
                {
                    tempCustomer = custArray[i];
                    break;
                }

            }
            return tempCustomer;


        }
        public int GetCustomerNumber(customer myCustomer)
        {
            int tempInt;
            tempInt = myCustomer.currCustomerNum;

            return tempInt;
        }

    }
}
