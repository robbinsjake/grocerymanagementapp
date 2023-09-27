using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;

namespace GroceryManager
{
    public partial class GroceryManagerForm : Form
    {
        //create list to load grocery items into
        List<GroceryItem> ItemList = new List<GroceryItem>();

        //header created manually to match assignment example output.
        string itemHeader = string.Format("{0,-14}{1,-22}{2,-16}{3,-18}{4,-16}{5,-16}{6,-16}{7,-16}{8}", 
            "ItemId", "ItemName", "UnitPrice", "QtyMinForRestock", "InitialQty", "QtySold", "QtyRestocked", "AvailableQty", "Sales");

        public GroceryManagerForm()
        {
            InitializeComponent();
        }



       //clears quantity restocked and quantity sold text fields when called
        private void ClearTextFields()
        {
            qtyRestockedTextBox.Clear();
            qtySoldTextBox.Clear();
        }




        //updates listbox with current Itemlist of grocery items  
        private void LoadAllItemsToListBox()
        {
            groceryDisplayListBox.Items.Clear();
            groceryDisplayListBox.Items.Add(itemHeader);
            foreach (GroceryItem item in ItemList)
            {
                groceryDisplayListBox.Items.Add(item);
            }
        }

        //when load button clicked, tries to read file and parses data into grocery item list
        private void loadGroceryButton_Click(object sender, EventArgs e)
        {
            ItemList.Clear();
            try
            {
                using (StreamReader myInputStream = new StreamReader("superstore.csv"))
                {
                    string eachline;

                    // The following assumes the file's first line is always the header, reads it and does nothing with it,
                    if (!myInputStream.EndOfStream)
                    {
                        eachline = myInputStream.ReadLine();
                        
                    }
                    // reads the data line by line until end of file
                    while (!myInputStream.EndOfStream)
                    {
                        eachline = myInputStream.ReadLine();
                        string[] eachItemFields = eachline.Split(',');
                        string itemId = eachItemFields[0];
                        string itemName = eachItemFields[1];
                        string unitPriceStr = eachItemFields[2];
                        string qtyMinForRestockstr = eachItemFields[3];
                        string initialQtystr = eachItemFields[4];
                        string qtySoldstr = eachItemFields[5];
                        string qtyRestockedstr = eachItemFields[6];
                        double.TryParse(unitPriceStr, out double unitPrice);
                        int.TryParse(qtyMinForRestockstr, out int qtyMinForRestock);
                        int.TryParse(initialQtystr, out int initialQty);
                        int.TryParse(qtySoldstr, out int qtySold);
                        int.TryParse(qtyRestockedstr, out int qtyRestocked);
                        GroceryItem eachItem = new GroceryItem(itemId, itemName, unitPrice, qtyMinForRestock, initialQty, qtySold, qtyRestocked);
                        ItemList.Add(eachItem);


                    }

                }
                //update listbox and status label
                LoadAllItemsToListBox();
                statusLabel.Text = string.Format("Loaded {0} items from the input file", ItemList.Count);
                statusLabel.ForeColor = Color.Black;




            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void groceryDisplayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            ClearTextFields(); // must select item before entering qty sold or restocked.
  
        }

        // Increments Sold Qty by given valid input & displays output message in statusLabel or displays error if invalid input.
        private void updateSoldQtyButton_Click(object sender, EventArgs e)
        {
            int lbIndex = groceryDisplayListBox.SelectedIndex;
            if (lbIndex < 1)
            {
                statusLabel.Text = "Please select a grocery item to increment sold qty!";
                statusLabel.ForeColor = Color.Red;

            }
            else if (qtySoldTextBox.Text == "")
            {
                statusLabel.Text = "Qty Sold field cannot be empty";
                statusLabel.ForeColor = Color.Red;
            }
            else if (!int.TryParse(qtySoldTextBox.Text, out int qtySold) || qtySold < 0)
            {
                statusLabel.Text = "Qty Sold must be a positive integer";
                statusLabel.ForeColor = Color.Red;
            }
            else if (qtySold > ItemList[lbIndex - 1].AvailableQty)
            {
                statusLabel.Text = "Qty Sold cannot be greater than Availably Qty";
                statusLabel.ForeColor = Color.Red;
            }
            else
            {
               
                ItemList[lbIndex - 1].QtySold += qtySold;
                LoadAllItemsToListBox();
                groceryDisplayListBox.SelectedIndex = lbIndex;
                statusLabel.Text = string.Format("Qty Sold incremented for item with item code {0}", ItemList[lbIndex-1].ItemCode);
                statusLabel.ForeColor = Color.Black;
                ClearTextFields();
            }


        }

        //deletes item if selected or displays error if none selected
        private void deleteSelectedItemButton_Click(object sender, EventArgs e)
        {
            int lbIndex = groceryDisplayListBox.SelectedIndex;
            if (lbIndex < 1)
            {
                statusLabel.Text = "Please select a grocery item to delete!";
                statusLabel.ForeColor = Color.Red;

            }
            else 
            {
                // retrieve itemcode for display message before deleting item or there will be no item to access!
                statusLabel.Text = string.Format("Deleted record for item with item code {0}", ItemList[lbIndex-1].ItemCode);
                statusLabel.ForeColor = Color.Black;
                ItemList.RemoveAt(lbIndex - 1);
                groceryDisplayListBox.Items.RemoveAt(lbIndex);



            }
            ClearTextFields();

        }

        //updates restocked qty by user provided input
        private void updateRestockedQtyButton_Click(object sender, EventArgs e)
        {
            int lbIndex = groceryDisplayListBox.SelectedIndex;
            if (lbIndex < 1) // if lbIndex<=0 we have either no selection or selected header
            {
                statusLabel.Text = "Please select a grocery item to increment Restocked Qty!";
                statusLabel.ForeColor = Color.Red;

            }
            else if (qtyRestockedTextBox.Text == "")
            {
                statusLabel.Text = "Qty Restocked field cannot be empty";
                statusLabel.ForeColor = Color.Red;
            }
            else if (!int.TryParse(qtyRestockedTextBox.Text, out int qtyRestock) || qtyRestock < 0)
            {
                statusLabel.Text = "Qty Restocked must be a positive integer";
                statusLabel.ForeColor = Color.Red;
            }

            else
            {

                ItemList[lbIndex - 1].QtyRestocked += qtyRestock;
                LoadAllItemsToListBox();
                groceryDisplayListBox.SelectedIndex = lbIndex;
                statusLabel.Text = string.Format("Qty Restocked incremented for item {0}", ItemList[lbIndex - 1].ItemCode);
                statusLabel.ForeColor = Color.Black;
                ClearTextFields();

            }
           

        }

        private void sortItemsBySalesButton_Click(object sender, EventArgs e)
        {
            List<GroceryItem> SortedList = ItemList.OrderByDescending(Item => Item.TotalSales).ToList();
            ItemList = SortedList;
            LoadAllItemsToListBox();

            //status output message
            statusLabel.Text = "Sorted all items in descending order of Sales";
            statusLabel.ForeColor = Color.Black;

        }

        // writes grocery list and header to updatedgrocery.csv
        private void saveGroceryDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter myOutputStream = new StreamWriter("updatedgrocery.csv"))
                {
                  
                    string headerLine = "ItemCode,ItemName,UntiPrice,QtyMinForRestock,InitialQty,QtySold,QtyRestocked";
                    myOutputStream.WriteLine(headerLine);
                    foreach (GroceryItem Item in ItemList)
                    {
                        //myOutputStream.Write(eachUser);
                        myOutputStream.WriteLine(Item.ItemCode + "," + Item.ItemName + ","
                            + Item.UnitPrice + "," + Item.QtyMinForRestock + ","
                            + Item.InitialQty + "," + Item.QtySold + "," + Item.QtyRestocked);


                    }
                } 
                statusLabel.Text = string.Format("Saved {0} records into the output inventory file", ItemList.Count);
                statusLabel.ForeColor = Color.Black;
        

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //writes grocery list items that have had sales to grocerysales.csv
        private void saveSalesReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter myOutputStream = new StreamWriter("grocerysales.csv"))
                {
               
                    string headerLine = "ItemCode,ItemName,UntiPrice,QtySold,Sales"; //different from Save Grocery Data output
                    myOutputStream.WriteLine(headerLine);

                    List<GroceryItem> FilteredList = ItemList;
                    FilteredList = (from Item in ItemList where Item.QtySold > 0 select Item).ToList(); 

                    foreach (GroceryItem Item in FilteredList)
                    {
                        //myOutputStream.Write(eachUser);
                        myOutputStream.WriteLine(Item.ItemCode + "," + Item.ItemName + ","
                            + Item.UnitPrice + "," + Item.QtySold + "," + Item.TotalSales);


                    }
                    statusLabel.Text = string.Format("Saved {0} records into the output Sales file", FilteredList.Count);
                    statusLabel.ForeColor = Color.Black;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        // writes grocery items that are low in stock below minimum to groceryrestocks.csv
        private void saveRestockReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter myOutputStream = new StreamWriter("groceryrestocks.csv"))
                {

                    string headerLine = "ItemCode,ItemName,QtyMinForRestock,AvailableQty";
                    myOutputStream.WriteLine(headerLine);

                    List<GroceryItem> FilteredList = ItemList;
                    FilteredList = (from Item in ItemList where Item.AvailableQty < Item.QtyMinForRestock select Item).ToList();

                    foreach (GroceryItem Item in FilteredList)
                    {
                        //myOutputStream.Write(eachUser);
                        myOutputStream.WriteLine(Item.ItemCode + "," + Item.ItemName + ","
                            + Item.QtyMinForRestock + "," + Item.AvailableQty);



                    }
                    statusLabel.Text = string.Format("Saved {0} records into the restocks needed output file", FilteredList.Count);
                    statusLabel.ForeColor = Color.Black;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void qtyRestockedLabel_Click(object sender, EventArgs e)
        {
            //oops do not delete
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
