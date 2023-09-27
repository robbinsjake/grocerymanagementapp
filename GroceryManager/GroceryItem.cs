using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryManager
{
    internal class GroceryItem
    {
        //read/write properties
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public double UnitPrice { get; set; }
        public int QtyMinForRestock { get; set; }
        public int InitialQty { get; set; }
        public int QtySold { get; set; }
        public int QtyRestocked { get; set; }

        //constructor
        public GroceryItem(string itemCode, string itemName, double unitPrice, int qtyMinForRestock, int initialQty, int qtySold, int qtyRestocked ) 
        { 
            ItemCode= itemCode;
            ItemName= itemName;
            UnitPrice= unitPrice;
            QtyMinForRestock= qtyMinForRestock;
            InitialQty= initialQty;
            QtySold= qtySold;
            QtyRestocked= qtyRestocked;
            
    
        }

        // Read only properties
        public int AvailableQty
        {
            get { return (InitialQty - QtySold + QtyRestocked); }
        }

        public double TotalSales
        {
            get { return (UnitPrice*QtySold ); }
        }


        //output of grocery items formatted for alignment. Note: header line formatted 
        //separately in Form1.cs as string 'itemHeader'
        public override string ToString()
        {
            return string.Format("{0,-14}{1,-22}{2,-16:C2}{3,-18}{4,-16}{5,-16}{6,-16}{7,-16}{8,5:C2}", ItemCode,ItemName, UnitPrice, QtyMinForRestock , InitialQty,QtySold, QtyRestocked,AvailableQty, TotalSales);
        }


    }
}
