namespace ABC_car_traders.View.Customer
{
    partial class ViewOrders
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
            label1 = new Label();
            custOrderViewGridView1 = new DataGridView();
            order_id = new DataGridViewTextBoxColumn();
            total_price = new DataGridViewTextBoxColumn();
            order_date = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)custOrderViewGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 37);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 11;
            label1.Text = "Your Orders";
            // 
            // custOrderViewGridView1
            // 
            custOrderViewGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            custOrderViewGridView1.Columns.AddRange(new DataGridViewColumn[] { order_id, total_price, order_date, status });
            custOrderViewGridView1.Location = new Point(76, 75);
            custOrderViewGridView1.Name = "custOrderViewGridView1";
            custOrderViewGridView1.RowHeadersWidth = 51;
            custOrderViewGridView1.Size = new Size(554, 418);
            custOrderViewGridView1.TabIndex = 12;
            // 
            // order_id
            // 
            order_id.HeaderText = "Order Number";
            order_id.MinimumWidth = 6;
            order_id.Name = "order_id";
            order_id.Width = 125;
            // 
            // total_price
            // 
            total_price.HeaderText = "Total Price";
            total_price.MinimumWidth = 6;
            total_price.Name = "total_price";
            total_price.Width = 125;
            // 
            // order_date
            // 
            order_date.HeaderText = "Order Date";
            order_date.MinimumWidth = 6;
            order_date.Name = "order_date";
            order_date.Width = 125;
            // 
            // status
            // 
            status.HeaderText = "Current Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.Width = 125;
            // 
            // ViewOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(713, 518);
            Controls.Add(custOrderViewGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrders";
            Text = "ViewOrders";
            ((System.ComponentModel.ISupportInitialize)custOrderViewGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView custOrderViewGridView1;
        private DataGridViewTextBoxColumn order_id;
        private DataGridViewTextBoxColumn total_price;
        private DataGridViewTextBoxColumn order_date;
        private DataGridViewTextBoxColumn status;
    }
}