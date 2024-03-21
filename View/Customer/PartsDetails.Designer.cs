namespace ABC_car_traders.View.Customer
{
    partial class PartsDetails
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
            txtSearchPartsKey = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            customPartsGridView1 = new DataGridView();
            brand = new DataGridViewTextBoxColumn();
            model = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)customPartsGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtSearchPartsKey
            // 
            txtSearchPartsKey.Location = new Point(43, 70);
            txtSearchPartsKey.Name = "txtSearchPartsKey";
            txtSearchPartsKey.Size = new Size(510, 27);
            txtSearchPartsKey.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(559, 68);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(147, 29);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 37);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 10;
            label1.Text = "Enter Model";
            // 
            // customPartsGridView1
            // 
            customPartsGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customPartsGridView1.Columns.AddRange(new DataGridViewColumn[] { brand, model, name, description, quantity, price });
            customPartsGridView1.Location = new Point(12, 126);
            customPartsGridView1.Name = "customPartsGridView1";
            customPartsGridView1.RowHeadersWidth = 51;
            customPartsGridView1.Size = new Size(707, 427);
            customPartsGridView1.TabIndex = 11;
            // 
            // brand
            // 
            brand.HeaderText = "Brand";
            brand.MinimumWidth = 6;
            brand.Name = "brand";
            brand.Width = 125;
            // 
            // model
            // 
            model.HeaderText = "Model";
            model.MinimumWidth = 6;
            model.Name = "model";
            model.Width = 125;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 125;
            // 
            // description
            // 
            description.HeaderText = "Description";
            description.MinimumWidth = 6;
            description.Name = "description";
            description.Width = 125;
            // 
            // quantity
            // 
            quantity.HeaderText = "Quantity";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            quantity.Width = 125;
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.Width = 125;
            // 
            // PartsDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(731, 565);
            Controls.Add(customPartsGridView1);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchPartsKey);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PartsDetails";
            Text = "PartsDetails";
            ((System.ComponentModel.ISupportInitialize)customPartsGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearchPartsKey;
        private Button btnSearch;
        private Label label1;
        private DataGridView customPartsGridView1;
        private DataGridViewTextBoxColumn brand;
        private DataGridViewTextBoxColumn model;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn price;
    }
}