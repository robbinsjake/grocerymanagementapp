namespace GroceryManager
{
    partial class GroceryManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groceryDisplayListBox = new System.Windows.Forms.ListBox();
            this.loadGroceryButton = new System.Windows.Forms.Button();
            this.loadDataGroupBox = new System.Windows.Forms.GroupBox();
            this.qtySoldLabel = new System.Windows.Forms.Label();
            this.qtySoldTextBox = new System.Windows.Forms.TextBox();
            this.updateSoldQtyButton = new System.Windows.Forms.Button();
            this.deleteSelectedItemButton = new System.Windows.Forms.Button();
            this.qtyRestockedLabel = new System.Windows.Forms.Label();
            this.qtyRestockedTextBox = new System.Windows.Forms.TextBox();
            this.updateRestockedQtyButton = new System.Windows.Forms.Button();
            this.sortItemsBySalesButton = new System.Windows.Forms.Button();
            this.updateDataGroupBox = new System.Windows.Forms.GroupBox();
            this.saveGroceryDataButton = new System.Windows.Forms.Button();
            this.saveSalesReportButton = new System.Windows.Forms.Button();
            this.saveRestockReportButton = new System.Windows.Forms.Button();
            this.saveDataGroupBox = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.appTitle = new System.Windows.Forms.Label();
            this.loadDataGroupBox.SuspendLayout();
            this.updateDataGroupBox.SuspendLayout();
            this.saveDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groceryDisplayListBox
            // 
            this.groceryDisplayListBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groceryDisplayListBox.FormattingEnabled = true;
            this.groceryDisplayListBox.Location = new System.Drawing.Point(21, 60);
            this.groceryDisplayListBox.Name = "groceryDisplayListBox";
            this.groceryDisplayListBox.Size = new System.Drawing.Size(948, 199);
            this.groceryDisplayListBox.TabIndex = 0;
            this.groceryDisplayListBox.SelectedIndexChanged += new System.EventHandler(this.groceryDisplayListBox_SelectedIndexChanged);
            // 
            // loadGroceryButton
            // 
            this.loadGroceryButton.Location = new System.Drawing.Point(6, 27);
            this.loadGroceryButton.Name = "loadGroceryButton";
            this.loadGroceryButton.Size = new System.Drawing.Size(118, 29);
            this.loadGroceryButton.TabIndex = 1;
            this.loadGroceryButton.Text = "Load Grocery Data";
            this.loadGroceryButton.UseVisualStyleBackColor = true;
            this.loadGroceryButton.Click += new System.EventHandler(this.loadGroceryButton_Click);
            // 
            // loadDataGroupBox
            // 
            this.loadDataGroupBox.Controls.Add(this.loadGroceryButton);
            this.loadDataGroupBox.Location = new System.Drawing.Point(21, 275);
            this.loadDataGroupBox.Name = "loadDataGroupBox";
            this.loadDataGroupBox.Size = new System.Drawing.Size(158, 81);
            this.loadDataGroupBox.TabIndex = 2;
            this.loadDataGroupBox.TabStop = false;
            this.loadDataGroupBox.Text = "Load Data";
            // 
            // qtySoldLabel
            // 
            this.qtySoldLabel.AutoSize = true;
            this.qtySoldLabel.Location = new System.Drawing.Point(14, 27);
            this.qtySoldLabel.Name = "qtySoldLabel";
            this.qtySoldLabel.Size = new System.Drawing.Size(73, 13);
            this.qtySoldLabel.TabIndex = 3;
            this.qtySoldLabel.Text = "Quantity Sold:";
            // 
            // qtySoldTextBox
            // 
            this.qtySoldTextBox.Location = new System.Drawing.Point(93, 24);
            this.qtySoldTextBox.Name = "qtySoldTextBox";
            this.qtySoldTextBox.Size = new System.Drawing.Size(78, 20);
            this.qtySoldTextBox.TabIndex = 4;
            // 
            // updateSoldQtyButton
            // 
            this.updateSoldQtyButton.Location = new System.Drawing.Point(17, 61);
            this.updateSoldQtyButton.Name = "updateSoldQtyButton";
            this.updateSoldQtyButton.Size = new System.Drawing.Size(121, 39);
            this.updateSoldQtyButton.TabIndex = 5;
            this.updateSoldQtyButton.Text = "Update Sold Qty For Selected Item";
            this.updateSoldQtyButton.UseVisualStyleBackColor = true;
            this.updateSoldQtyButton.Click += new System.EventHandler(this.updateSoldQtyButton_Click);
            // 
            // deleteSelectedItemButton
            // 
            this.deleteSelectedItemButton.Location = new System.Drawing.Point(17, 103);
            this.deleteSelectedItemButton.Name = "deleteSelectedItemButton";
            this.deleteSelectedItemButton.Size = new System.Drawing.Size(121, 42);
            this.deleteSelectedItemButton.TabIndex = 6;
            this.deleteSelectedItemButton.Text = "Delete Selected Grocery Item";
            this.deleteSelectedItemButton.UseVisualStyleBackColor = true;
            this.deleteSelectedItemButton.Click += new System.EventHandler(this.deleteSelectedItemButton_Click);
            // 
            // qtyRestockedLabel
            // 
            this.qtyRestockedLabel.AutoSize = true;
            this.qtyRestockedLabel.Location = new System.Drawing.Point(380, 27);
            this.qtyRestockedLabel.Name = "qtyRestockedLabel";
            this.qtyRestockedLabel.Size = new System.Drawing.Size(104, 13);
            this.qtyRestockedLabel.TabIndex = 7;
            this.qtyRestockedLabel.Text = "Quantity Restocked:";
            // 
            // qtyRestockedTextBox
            // 
            this.qtyRestockedTextBox.Location = new System.Drawing.Point(490, 24);
            this.qtyRestockedTextBox.Name = "qtyRestockedTextBox";
            this.qtyRestockedTextBox.Size = new System.Drawing.Size(78, 20);
            this.qtyRestockedTextBox.TabIndex = 8;
            // 
            // updateRestockedQtyButton
            // 
            this.updateRestockedQtyButton.Location = new System.Drawing.Point(447, 61);
            this.updateRestockedQtyButton.Name = "updateRestockedQtyButton";
            this.updateRestockedQtyButton.Size = new System.Drawing.Size(121, 39);
            this.updateRestockedQtyButton.TabIndex = 9;
            this.updateRestockedQtyButton.Text = "Update Restocked Qty For Selected Item";
            this.updateRestockedQtyButton.UseVisualStyleBackColor = true;
            this.updateRestockedQtyButton.Click += new System.EventHandler(this.updateRestockedQtyButton_Click);
            // 
            // sortItemsBySalesButton
            // 
            this.sortItemsBySalesButton.Location = new System.Drawing.Point(447, 103);
            this.sortItemsBySalesButton.Name = "sortItemsBySalesButton";
            this.sortItemsBySalesButton.Size = new System.Drawing.Size(121, 42);
            this.sortItemsBySalesButton.TabIndex = 10;
            this.sortItemsBySalesButton.Text = "Sort Items Based On Sales";
            this.sortItemsBySalesButton.UseVisualStyleBackColor = true;
            this.sortItemsBySalesButton.Click += new System.EventHandler(this.sortItemsBySalesButton_Click);
            // 
            // updateDataGroupBox
            // 
            this.updateDataGroupBox.Controls.Add(this.sortItemsBySalesButton);
            this.updateDataGroupBox.Controls.Add(this.updateRestockedQtyButton);
            this.updateDataGroupBox.Controls.Add(this.qtyRestockedTextBox);
            this.updateDataGroupBox.Controls.Add(this.qtyRestockedLabel);
            this.updateDataGroupBox.Controls.Add(this.deleteSelectedItemButton);
            this.updateDataGroupBox.Controls.Add(this.updateSoldQtyButton);
            this.updateDataGroupBox.Controls.Add(this.qtySoldTextBox);
            this.updateDataGroupBox.Controls.Add(this.qtySoldLabel);
            this.updateDataGroupBox.Location = new System.Drawing.Point(197, 275);
            this.updateDataGroupBox.Name = "updateDataGroupBox";
            this.updateDataGroupBox.Size = new System.Drawing.Size(586, 164);
            this.updateDataGroupBox.TabIndex = 11;
            this.updateDataGroupBox.TabStop = false;
            this.updateDataGroupBox.Text = "Update Data";
            // 
            // saveGroceryDataButton
            // 
            this.saveGroceryDataButton.Location = new System.Drawing.Point(16, 33);
            this.saveGroceryDataButton.Name = "saveGroceryDataButton";
            this.saveGroceryDataButton.Size = new System.Drawing.Size(121, 23);
            this.saveGroceryDataButton.TabIndex = 12;
            this.saveGroceryDataButton.Text = "Save Grocery Data";
            this.saveGroceryDataButton.UseVisualStyleBackColor = true;
            this.saveGroceryDataButton.Click += new System.EventHandler(this.saveGroceryDataButton_Click);
            // 
            // saveSalesReportButton
            // 
            this.saveSalesReportButton.Location = new System.Drawing.Point(16, 68);
            this.saveSalesReportButton.Name = "saveSalesReportButton";
            this.saveSalesReportButton.Size = new System.Drawing.Size(121, 23);
            this.saveSalesReportButton.TabIndex = 13;
            this.saveSalesReportButton.Text = "Save Sales Report";
            this.saveSalesReportButton.UseVisualStyleBackColor = true;
            this.saveSalesReportButton.Click += new System.EventHandler(this.saveSalesReportButton_Click);
            // 
            // saveRestockReportButton
            // 
            this.saveRestockReportButton.Location = new System.Drawing.Point(16, 104);
            this.saveRestockReportButton.Name = "saveRestockReportButton";
            this.saveRestockReportButton.Size = new System.Drawing.Size(121, 41);
            this.saveRestockReportButton.TabIndex = 14;
            this.saveRestockReportButton.Text = "Save Restock Needs Report";
            this.saveRestockReportButton.UseVisualStyleBackColor = true;
            this.saveRestockReportButton.Click += new System.EventHandler(this.saveRestockReportButton_Click);
            // 
            // saveDataGroupBox
            // 
            this.saveDataGroupBox.Controls.Add(this.saveRestockReportButton);
            this.saveDataGroupBox.Controls.Add(this.saveSalesReportButton);
            this.saveDataGroupBox.Controls.Add(this.saveGroceryDataButton);
            this.saveDataGroupBox.Location = new System.Drawing.Point(816, 275);
            this.saveDataGroupBox.Name = "saveDataGroupBox";
            this.saveDataGroupBox.Size = new System.Drawing.Size(153, 164);
            this.saveDataGroupBox.TabIndex = 15;
            this.saveDataGroupBox.TabStop = false;
            this.saveDataGroupBox.Text = "Save Data";
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.SystemColors.Info;
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(197, 457);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(586, 47);
            this.statusLabel.TabIndex = 16;
            this.statusLabel.Text = "Operation Status Update Displayed Here";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // appTitle
            // 
            this.appTitle.AutoSize = true;
            this.appTitle.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitle.Location = new System.Drawing.Point(271, 9);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(433, 31);
            this.appTitle.TabIndex = 17;
            this.appTitle.Text = "Grocery Management System";
            this.appTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GroceryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 530);
            this.Controls.Add(this.appTitle);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.saveDataGroupBox);
            this.Controls.Add(this.updateDataGroupBox);
            this.Controls.Add(this.loadDataGroupBox);
            this.Controls.Add(this.groceryDisplayListBox);
            this.Name = "GroceryManager";
            this.Text = "GroceryManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loadDataGroupBox.ResumeLayout(false);
            this.updateDataGroupBox.ResumeLayout(false);
            this.updateDataGroupBox.PerformLayout();
            this.saveDataGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox groceryDisplayListBox;
        private System.Windows.Forms.Button loadGroceryButton;
        private System.Windows.Forms.GroupBox loadDataGroupBox;
        private System.Windows.Forms.Label qtySoldLabel;
        private System.Windows.Forms.TextBox qtySoldTextBox;
        private System.Windows.Forms.Button updateSoldQtyButton;
        private System.Windows.Forms.Button deleteSelectedItemButton;
        private System.Windows.Forms.Label qtyRestockedLabel;
        private System.Windows.Forms.TextBox qtyRestockedTextBox;
        private System.Windows.Forms.Button updateRestockedQtyButton;
        private System.Windows.Forms.Button sortItemsBySalesButton;
        private System.Windows.Forms.GroupBox updateDataGroupBox;
        private System.Windows.Forms.Button saveGroceryDataButton;
        private System.Windows.Forms.Button saveSalesReportButton;
        private System.Windows.Forms.Button saveRestockReportButton;
        private System.Windows.Forms.GroupBox saveDataGroupBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label appTitle;
    }
}

