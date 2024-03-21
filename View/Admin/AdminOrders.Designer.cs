namespace ABC_car_traders.View
{
    partial class AdminOrders
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
            panel7 = new Panel();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label15 = new Label();
            textBox11 = new TextBox();
            label14 = new Label();
            orderDetailGrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            OrderId = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            deleiverd = new DataGridViewButtonColumn();
            onProgress = new DataGridViewButtonColumn();
            panel7.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderDetailGrid).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.Purple;
            panel7.Controls.Add(tabControl1);
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(806, 653);
            panel7.TabIndex = 20;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(805, 653);
            tabControl1.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(192, 0, 192);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(textBox11);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(orderDetailGrid);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(797, 620);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "View All Orders";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(684, 41);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 5;
            label1.Text = "Order Status";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(555, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(220, 28);
            comboBox1.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(458, 41);
            label15.Name = "label15";
            label15.Size = new Size(66, 20);
            label15.TabIndex = 3;
            label15.Text = "Order ID";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(269, 64);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(255, 27);
            textBox11.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(28, 30);
            label14.Name = "label14";
            label14.Size = new Size(161, 23);
            label14.TabIndex = 1;
            label14.Text = "View Order Details";
            // 
            // orderDetailGrid
            // 
            orderDetailGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDetailGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, OrderId, Column5, Column4, Column10, deleiverd, onProgress });
            orderDetailGrid.Location = new Point(1, 115);
            orderDetailGrid.Name = "orderDetailGrid";
            orderDetailGrid.RowHeadersWidth = 51;
            orderDetailGrid.Size = new Size(797, 505);
            orderDetailGrid.TabIndex = 0;
            orderDetailGrid.CellClick += updateOrderDetails;
            // 
            // Column1
            // 
            Column1.HeaderText = "CustomerID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "CustomerName";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // OrderId
            // 
            OrderId.HeaderText = "OrderId";
            OrderId.MinimumWidth = 6;
            OrderId.Name = "OrderId";
            OrderId.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "TotalPrice";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Date";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "Status";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 125;
            // 
            // deleiverd
            // 
            deleiverd.HeaderText = "Action";
            deleiverd.MinimumWidth = 6;
            deleiverd.Name = "deleiverd";
            deleiverd.Text = "Delivered";
            deleiverd.UseColumnTextForButtonValue = true;
            deleiverd.Width = 125;
            // 
            // onProgress
            // 
            onProgress.HeaderText = "Action";
            onProgress.MinimumWidth = 6;
            onProgress.Name = "onProgress";
            onProgress.Text = "OnProgress";
            onProgress.UseColumnTextForButtonValue = true;
            onProgress.Width = 125;
            // 
            // AdminOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 653);
            Controls.Add(panel7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminOrders";
            panel7.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderDetailGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private Label label15;
        private TextBox textBox11;
        private Label label14;
        private DataGridView orderDetailGrid;
        private Label label1;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn OrderId;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewButtonColumn deleiverd;
        private DataGridViewButtonColumn onProgress;
    }
}