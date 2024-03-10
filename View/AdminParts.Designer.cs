namespace ABC_car_traders.View
{
    partial class AdminParts
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
            tabPage1 = new TabPage();
            btnSave = new Button();
            label12 = new Label();
            txtDescription = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtModel = new TextBox();
            label2 = new Label();
            txtBrand = new TextBox();
            label14 = new Label();
            tabPage2 = new TabPage();
            label15 = new Label();
            textBox11 = new TextBox();
            label16 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            Id = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            panel7.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.Purple;
            panel7.Controls.Add(tabControl1);
            panel7.Controls.Add(label1);
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(806, 653);
            panel7.TabIndex = 20;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(805, 653);
            tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(192, 0, 192);
            tabPage1.Controls.Add(btnSave);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(txtDescription);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(txtPrice);
            tabPage1.Controls.Add(txtQuantity);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtName);
            tabPage1.Controls.Add(txtModel);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtBrand);
            tabPage1.Controls.Add(label14);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(797, 620);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Spare Parts";
            tabPage1.Click += tabPage1_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(536, 537);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(149, 48);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(85, 233);
            label12.Name = "label12";
            label12.Size = new Size(85, 20);
            label12.TabIndex = 22;
            label12.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(85, 256);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(600, 119);
            txtDescription.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(414, 403);
            label10.Name = "label10";
            label10.Size = new Size(41, 20);
            label10.TabIndex = 18;
            label10.Text = "Price";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(82, 400);
            label9.Name = "label9";
            label9.Size = new Size(35, 20);
            label9.TabIndex = 17;
            label9.Text = "QTY";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(411, 423);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(274, 27);
            txtPrice.TabIndex = 16;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(82, 423);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(277, 27);
            txtQuantity.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 147);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 8;
            label5.Text = "Spare Part Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(411, 71);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 7;
            label4.Text = "Model";
            // 
            // txtName
            // 
            txtName.Location = new Point(82, 170);
            txtName.Name = "txtName";
            txtName.Size = new Size(603, 27);
            txtName.TabIndex = 5;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(408, 91);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(277, 27);
            txtModel.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 71);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 2;
            label2.Text = "Brand";
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(82, 91);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(277, 27);
            txtBrand.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(20, 16);
            label14.Name = "label14";
            label14.Size = new Size(149, 25);
            label14.TabIndex = 0;
            label14.Text = "Add Spare Parts";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(192, 0, 192);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(textBox11);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(797, 620);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "View Spare Parts Details";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(707, 41);
            label15.Name = "label15";
            label15.Size = new Size(82, 20);
            label15.TabIndex = 3;
            label15.Text = "Spare Parts";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(534, 64);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(255, 27);
            textBox11.TabIndex = 2;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(18, 23);
            label16.Name = "label16";
            label16.Size = new Size(205, 23);
            label16.TabIndex = 1;
            label16.Text = "View Spare Parts Details";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Column2, Column4, Column5, Description, Column11, Column12 });
            dataGridView1.Location = new Point(1, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(797, 505);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(340, 282);
            label1.Name = "label1";
            label1.Size = new Size(198, 41);
            label1.TabIndex = 21;
            label1.Text = "Manage Parts";
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Brand";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Model";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Spare Part Name";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 125;
            // 
            // Column11
            // 
            Column11.HeaderText = "Quantity";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 125;
            // 
            // Column12
            // 
            Column12.HeaderText = "Price";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.Width = 125;
            // 
            // AdminParts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 653);
            Controls.Add(panel7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminParts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminParts";
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnSave;
        private Label label12;
        private TextBox txtDescription;
        private Label label10;
        private Label label9;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Label label5;
        private Label label4;
        private TextBox txtName;
        private TextBox txtModel;
        private Label label2;
        private TextBox txtBrand;
        private Label label14;
        private TabPage tabPage2;
        private Label label15;
        private TextBox textBox11;
        private Label label16;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
    }
}