using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresFinalProject
{
    class PackingList
    {
        //fields 
        private customer consigneeName;//todo
        private customer shipperName;//todo
        //freight info
        private string shortDescription;
        private int weightInPounds;
        private string hazardousMaterialStatus;
        //HU = Handeling units ie pallets, or skids 
        private int HUCount;
        private string HUType;
        //this is the generator for the ID numbers
        private int currentIDNumber;
        private static int IDNumber = 1001;
        //size component for the amount of freight in the system
        private static int size = 0;

        //list to contain the packinglist objects
        List<PackingList> packingListObjects = new List<PackingList>();






        //constructor for the Packing List
        //the packing list is the main freight identification table it will hold all the information about the freight.
        //default no args?
        public PackingList()
        {

        }
        //non default 
        public PackingList(customer _consigneeName, customer _shipperName, string _shortDescription, int _weightInPounds, string _hazardousMaterialStatus, int _HUCount, string _HUType )
        {
            this.consigneeName = _consigneeName;
            this.shipperName = _shipperName;
            this.shortDescription = _shortDescription;
            this.weightInPounds = _weightInPounds;
            this.hazardousMaterialStatus = _hazardousMaterialStatus;
            this.HUCount = _HUCount;
            this.HUType = _HUType;
            IDNumber++;
            CurrentIDNumber1 = IDNumber;             
        }




        //getters and setters
        public string ShortDescription { get => shortDescription; set => shortDescription = value; }
        public int WeightInPounds { get => weightInPounds; set => weightInPounds = value; }
        public string HazardousMaterialStatus { get => hazardousMaterialStatus; set => hazardousMaterialStatus = value; }
        public int HUCount1 { get => HUCount; set => HUCount = value; }
        public int CurrentIDNumber1 { get => currentIDNumber; set => currentIDNumber = value; }
        public static int Size { get => size; set => size = value; }
        public string HUType1 { get => HUType; set => HUType = value; }


        //helper methods
        public int AddPackingList(customer _consigneeName, customer _shipperName, string _shortDescription, int _weightInPounds, string _hazardousMaterialStatus, int _HUCount, string _HUType)
        {
            PackingList newPackingList = new PackingList(_consigneeName,_shipperName,_shortDescription,_weightInPounds,_hazardousMaterialStatus,_HUCount, HUType);//todo;
            Size++;
            packingListObjects.Add(newPackingList);
            return newPackingList.CurrentIDNumber1;
        }

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
    }
}
