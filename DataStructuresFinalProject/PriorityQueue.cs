using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresFinalProject
{
    //this is my priority queue class that uses linked lists. it displays on form 1 all the ID number added and the ones closest to the top are the ones
    // that are the highest priority. There is a program that is very similar to this at my job
    public class PriorityQueue
    {
       
        //fields 
        private PackingList pQPackingList;
        public LinkedList<PackingList> lLPriorityQueue= new LinkedList<PackingList>();

        //constructors
        public PriorityQueue()
        {
            
        }
        public PriorityQueue(PackingList _packingList)
        {
            PackingList12 = _packingList;                      
        }



        //getters and setters
        internal PackingList PackingList12 { get => pQPackingList; set => pQPackingList = value; }


        //helper methods
        public void Pop()
        {
            lLPriorityQueue.RemoveFirst();
        }
        public void Push(PackingList packingList)
        {
            PriorityQueue newPQ = new PriorityQueue(packingList);
            if (newPQ.PackingList12.Priority.Equals("Yes"))
            {
                lLPriorityQueue.AddFirst(packingList);
            }
            else
            {
                lLPriorityQueue.AddLast(packingList);
            }            
        }
        public string DisplayQueue()
        {
            string tempString = "";
            if (IsEmpty())
            {
                tempString = "No ID numbers Added yet";
                return tempString;
            }
            else
            {
                foreach (PackingList item in lLPriorityQueue)
                {
                    tempString =  item.CurrentIDNumber1 -1 + ", " + tempString ;
                }
                return tempString;
            }
        }
        public bool IsEmpty()
        {
            if(lLPriorityQueue.Count == 0)
            {
                return true;
            }            
            return false;
        }
        
    }
}
