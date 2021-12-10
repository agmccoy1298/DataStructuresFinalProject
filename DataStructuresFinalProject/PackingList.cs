using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresFinalProject
{
    public class PackingList
    {
        //fields 
        private customer consigneeName;
        private customer shipperName;
        //freight info
        private string shortDescription;
        private int weightInPounds;
        private string hazardousMaterialStatus;
        //HU = Handeling units ie pallets, or skids 
        private int hUCount;
        private string hUType;
        private string priority;
        //this is the generator for the ID numbers
        private int currentIDNumber;
        public static int staticIDNumber = 1000;
        //size component for the amount of freight in the system
        private static int size = 0;

        //list to contain the packinglist objects
        public LinkedList<PackingList> packingListObjects = new LinkedList<PackingList>();



        //this is a test for the priority queue 
        //public static customer testCustomer = new customer("test", "test", "test", "test", "test");
        //public static PackingList firstPackingList = new PackingList(testCustomer, testCustomer, "test", 0000, "test", 0000, "test", "N");

        //constructor for the Packing List
        //the packing list is the main freight identification table it will hold all the information about the freight.
        //default no args
        public PackingList()
        {

        }
        //non default 
        public PackingList(customer _consigneeName, customer _shipperName, string _shortDescription, int _weightInPounds, string _hazardousMaterialStatus, int _HUCount, string _HUType, string priority )
        {
          
            this.ConsigneeName = _consigneeName;
            this.ShipperName = _shipperName;
            this.ShortDescription = _shortDescription;
            this.WeightInPounds = _weightInPounds;
            this.HazardousMaterialStatus = _hazardousMaterialStatus;
            this.HUCount = _HUCount;
            this.HUType = _HUType;
            this.Priority = priority;
            CurrentIDNumber1 = staticIDNumber;
            staticIDNumber++;            
        }        




        //getters and setters
        public string ShortDescription { get => shortDescription; set => shortDescription = value; }
        public int WeightInPounds { get => weightInPounds; set => weightInPounds = value; }
        public string HazardousMaterialStatus { get => hazardousMaterialStatus; set => hazardousMaterialStatus = value; }
        public int HUCount { get => hUCount; set => hUCount = value; }
        public int CurrentIDNumber1 { get => currentIDNumber; set => currentIDNumber = value; }
        public static int Size { get => size; set => size = value; }
        public string HUType { get => hUType; set => hUType = value; }
        internal customer ConsigneeName { get => consigneeName; set => consigneeName = value; }
        internal customer ShipperName { get => shipperName; set => shipperName = value; }
        public string Priority { get => priority; set => priority = value; }



        //helper methods
        //this method adds the packing list to the system 
        public int AddPackingList(customer _consigneeName, customer _shipperName, string _shortDescription, int _weightInPounds, string _hazardousMaterialStatus, int _HUCount, string _HUType, string _priority)
        {
            if (Size == 0)
            {
                FirstAdd();
            }
            PackingList newPackingList = new PackingList(_consigneeName,_shipperName,_shortDescription,_weightInPounds,_hazardousMaterialStatus,_HUCount, _HUType, _priority);//todo;            
            Size++;
            packingListObjects.AddFirst(newPackingList);
            return newPackingList.CurrentIDNumber1;
        }
        //this is for the first add 
        public void FirstAdd()
        {
            customer testCustomer = new customer("test", "test", "test", "test", "test");
            PackingList firstPackingList = new PackingList(testCustomer, testCustomer, "test", 0000, "test", 0000, "test", "N");
            packingListObjects.AddLast(firstPackingList);
        }
        //spent a while making this and didn't end up needing it so I kept it lol
        public string IDNumbers()
        {
            string tempString;
            if (Size == 0)
            {
                tempString = "No ID numbers at this time";
                return tempString;
            }
            else
            {
                foreach (PackingList i in packingListObjects)
                {
                    tempString = i.CurrentIDNumber1 + "\n";
                    return tempString;
                }
            }

            return null;            
        }
        //this method is for the search page it returns all info that corresponds with the id number
        public LinkedListNode<PackingList> FindObjectInformation(int IDNumber)
        {
            LinkedListNode<PackingList> element = packingListObjects.First;
            while(element != packingListObjects.Last)
            {
                if (element.Value.currentIDNumber == IDNumber)
                {
                    return element;
                }                                                 
                
                element = element.Next;                
                
            }                           
            return null;            
        }
        //bool does freight exist method
        public bool DoesExist(int IDNumber)
        {
            LinkedListNode<PackingList> element = packingListObjects.First;
            while(element != packingListObjects.Last)
            {
                if(element.Value.CurrentIDNumber1 == IDNumber)
                {
                    return true;
                }
                element = element.Next;
            }
            return false;

        }
    }
}
