namespace ABC_car_traders.View
{
    partial class OrderDetails
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
            btnSearch = new Button();
            txtSearchKey = new TextBox();
            dataGridSearch = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Model = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Action = new DataGridViewButtonColumn();
            dataGridOrder = new DataGridView();
            ItemId = new DataGridViewTextBoxColumn();
            ItemModel = new DataGridViewTextBoxColumn();
            ItemDescription = new DataGridViewTextBoxColumn();
            ItemUnitPrice = new DataGridViewTextBoxColumn();
            ItemType = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lblTotalCaption = new Label();
            lblTotalPrice = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOrder).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(559, 68);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(147, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchKey
            // 
            txtSearchKey.Location = new Point(43, 70);
            txtSearchKey.Name = "txtSearchKey";
            txtSearchKey.Size = new Size(510, 27);
            txtSearchKey.TabIndex = 3;
            // 
            // dataGridSearch
            // 
            dataGridSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSearch.Columns.AddRange(new DataGridViewColumn[] { Id, Model, Description, UnitPrice, Type, Action });
            dataGridSearch.Location = new Point(43, 117);
            dataGridSearch.Name = "dataGridSearch";
            dataGridSearch.RowHeadersWidth = 51;
            dataGridSearch.Size = new Size(663, 132);
            dataGridSearch.TabIndex = 4;
            dataGridSearch.CellClick += clickAddToCart;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Model
            // 
            Model.HeaderText = "Model";
            Model.MinimumWidth = 6;
            Model.Name = "Model";
            Model.Width = 125;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 125;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "UnitPrice";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.Width = 125;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.Width = 125;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.MinimumWidth = 6;
            Action.Name = "Action";
            Action.Resizable = DataGridViewTriState.True;
            Action.SortMode = DataGridViewColumnSortMode.Automatic;
            Action.Text = "Add To Cart";
            Action.UseColumnTextForButtonValue = true;
            Action.Width = 125;
            // 
            // dataGridOrder
            // 
            dataGridOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOrder.Columns.AddRange(new DataGridViewColumn[] { ItemId, ItemModel, ItemDescription, ItemUnitPrice, ItemType, Quantity, Price });
            dataGridOrder.Location = new Point(43, 315);
            dataGridOrder.Name = "dataGridOrder";
            dataGridOrder.RowHeadersWidth = 51;
            dataGridOrder.Size = new Size(663, 188);
            dataGridOrder.TabIndex = 5;
            // 
            // ItemId
            // 
            ItemId.HeaderText = "ItemId";
            ItemId.MinimumWidth = 6;
            ItemId.Name = "ItemId";
            ItemId.Width = 125;
            // 
            // ItemModel
            // 
            ItemModel.HeaderText = "ItemModel";
            ItemModel.MinimumWidth = 6;
            ItemModel.Name = "ItemModel";
            ItemModel.Width = 125;
            // 
            // ItemDescription
            // 
            ItemDescription.HeaderText = "ItemDescription";
            ItemDescription.MinimumWidth = 6;
            ItemDescription.Name = "ItemDescription";
            ItemDescription.Width = 125;
            // 
            // ItemUnitPrice
            // 
            ItemUnitPrice.HeaderText = "ItemUnitPrice";
            ItemUnitPrice.MinimumWidth = 6;
            ItemUnitPrice.Name = "ItemUnitPrice";
            ItemUnitPrice.Width = 125;
            // 
            // ItemType
            // 
            ItemType.HeaderText = "ItemType";
            ItemType.MinimumWidth = 6;
            ItemType.Name = "ItemType";
            ItemType.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 38);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 6;
            label1.Text = "Enter Model";
            // 
            // lblTotalCaption
            // 
            lblTotalCaption.Font = new Font("Segoe UI", 16F);
            lblTotalCaption.Location = new Point(428, 520);
            lblTotalCaption.Name = "lblTotalCaption";
            lblTotalCaption.Size = new Size(125, 40);
            lblTotalCaption.TabIndex = 7;
            lblTotalCaption.Text = "Total";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Font = new Font("Segoe UI", 16F);
            lblTotalPrice.Location = new Point(581, 520);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(125, 40);
            lblTotalPrice.TabIndex = 8;
            lblTotalPrice.Text = "0.00";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(43, 520);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // OrderDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(749, 612);
            Controls.Add(btnSave);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblTotalCaption);
            Controls.Add(label1);
            Controls.Add(dataGridOrder);
            Controls.Add(dataGridSearch);
            Controls.Add(txtSearchKey);
            Controls.Add(btnSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderDetails";
            Text = "OrderDetails";
            ((System.ComponentModel.ISupportInitialize)dataGridSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSearch;
        private TextBox txtSearchKey;
        private DataGridView dataGridSearch;
        private DataGridView dataGridOrder;
        private Label label1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewButtonColumn Action;
        private DataGridViewTextBoxColumn ItemId;
        private DataGridViewTextBoxColumn ItemModel;
        private DataGridViewTextBoxColumn ItemDescription;
        private DataGridViewTextBoxColumn ItemUnitPrice;
        private DataGridViewTextBoxColumn ItemType;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private Label lblTotalCaption;
        private Label lblTotalPrice;
        private Button btnSave;
    }
}