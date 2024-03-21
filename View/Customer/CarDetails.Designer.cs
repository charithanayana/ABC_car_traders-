namespace ABC_car_traders.View.Customer
{
    partial class CarDetails
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
            txtSearchKey = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            customerCarGridView1 = new DataGridView();
            Brand = new DataGridViewTextBoxColumn();
            model = new DataGridViewTextBoxColumn();
            manu_year = new DataGridViewTextBoxColumn();
            regi_year = new DataGridViewTextBoxColumn();
            body_type = new DataGridViewTextBoxColumn();
            capacity = new DataGridViewTextBoxColumn();
            color = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            transmission = new DataGridViewTextBoxColumn();
            fuel_type = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)customerCarGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtSearchKey
            // 
            txtSearchKey.Location = new Point(43, 70);
            txtSearchKey.Name = "txtSearchKey";
            txtSearchKey.Size = new Size(510, 27);
            txtSearchKey.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 38);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 7;
            label1.Text = "Enter Model";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(559, 68);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(147, 29);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // customerCarGridView1
            // 
            customerCarGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerCarGridView1.Columns.AddRange(new DataGridViewColumn[] { Brand, model, manu_year, regi_year, body_type, capacity, color, price, transmission, fuel_type });
            customerCarGridView1.Location = new Point(12, 125);
            customerCarGridView1.Name = "customerCarGridView1";
            customerCarGridView1.RowHeadersWidth = 51;
            customerCarGridView1.Size = new Size(707, 428);
            customerCarGridView1.TabIndex = 9;
            // 
            // Brand
            // 
            Brand.HeaderText = "Brand";
            Brand.MinimumWidth = 6;
            Brand.Name = "Brand";
            Brand.Width = 125;
            // 
            // model
            // 
            model.HeaderText = "Model";
            model.MinimumWidth = 6;
            model.Name = "model";
            model.Width = 125;
            // 
            // manu_year
            // 
            manu_year.HeaderText = "Manufactured Year";
            manu_year.MinimumWidth = 6;
            manu_year.Name = "manu_year";
            manu_year.Width = 125;
            // 
            // regi_year
            // 
            regi_year.HeaderText = "Registered Year";
            regi_year.MinimumWidth = 6;
            regi_year.Name = "regi_year";
            regi_year.Width = 125;
            // 
            // body_type
            // 
            body_type.HeaderText = "Body Type";
            body_type.MinimumWidth = 6;
            body_type.Name = "body_type";
            body_type.Width = 125;
            // 
            // capacity
            // 
            capacity.HeaderText = "Capacity";
            capacity.MinimumWidth = 6;
            capacity.Name = "capacity";
            capacity.Width = 125;
            // 
            // color
            // 
            color.HeaderText = "Color";
            color.MinimumWidth = 6;
            color.Name = "color";
            color.Width = 125;
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.Width = 125;
            // 
            // transmission
            // 
            transmission.HeaderText = "Transmission";
            transmission.MinimumWidth = 6;
            transmission.Name = "transmission";
            transmission.Width = 125;
            // 
            // fuel_type
            // 
            fuel_type.HeaderText = "Fuel Type";
            fuel_type.MinimumWidth = 6;
            fuel_type.Name = "fuel_type";
            fuel_type.Width = 125;
            // 
            // CarDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(731, 565);
            Controls.Add(customerCarGridView1);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(txtSearchKey);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarDetails";
            Text = "CarDetails";
            //Load += CarDetails_Load;
            ((System.ComponentModel.ISupportInitialize)customerCarGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearchKey;
        private Label label1;
        private Button btnSearch;
        private DataGridView customerCarGridView1;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn model;
        private DataGridViewTextBoxColumn manu_year;
        private DataGridViewTextBoxColumn regi_year;
        private DataGridViewTextBoxColumn body_type;
        private DataGridViewTextBoxColumn capacity;
        private DataGridViewTextBoxColumn color;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn transmission;
        private DataGridViewTextBoxColumn fuel_type;
    }
}