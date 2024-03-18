namespace ABC_car_traders.View
{
    partial class AdminCars
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
            cmbTransmission = new ComboBox();
            label13 = new Label();
            btnSave = new Button();
            label12 = new Label();
            txtDescription = new TextBox();
            label11 = new Label();
            cmbFuelType = new ComboBox();
            label10 = new Label();
            txtPrice = new TextBox();
            label8 = new Label();
            txtColour = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtEngineCapacity = new TextBox();
            txtRegisteredYear = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtBodyType = new TextBox();
            txtModel = new TextBox();
            label3 = new Label();
            txtManufactureYear = new TextBox();
            label2 = new Label();
            txtBrand = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            button1 = new Button();
            label15 = new Label();
            textBox11 = new TextBox();
            label14 = new Label();
            gridCarDetails = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            delete = new DataGridViewTextBoxColumn();
            panel7.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCarDetails).BeginInit();
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
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(805, 653);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(192, 0, 192);
            tabPage1.Controls.Add(cmbTransmission);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(btnSave);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(txtDescription);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(cmbFuelType);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(txtPrice);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(txtColour);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtEngineCapacity);
            tabPage1.Controls.Add(txtRegisteredYear);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtBodyType);
            tabPage1.Controls.Add(txtModel);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtManufactureYear);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtBrand);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(797, 620);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Car";
            // 
            // cmbTransmission
            // 
            cmbTransmission.FormattingEnabled = true;
            cmbTransmission.Items.AddRange(new object[] { "Auto", "Manual" });
            cmbTransmission.Location = new Point(82, 313);
            cmbTransmission.Name = "cmbTransmission";
            cmbTransmission.Size = new Size(277, 28);
            cmbTransmission.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(82, 290);
            label13.Name = "label13";
            label13.Size = new Size(93, 20);
            label13.TabIndex = 25;
            label13.Text = "Transmission";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(82, 511);
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
            label12.Location = new Point(82, 354);
            label12.Name = "label12";
            label12.Size = new Size(85, 20);
            label12.TabIndex = 22;
            label12.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(82, 377);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(603, 119);
            txtDescription.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(408, 290);
            label11.Name = "label11";
            label11.Size = new Size(71, 20);
            label11.TabIndex = 20;
            label11.Text = "Fuel Type";
            // 
            // cmbFuelType
            // 
            cmbFuelType.AutoCompleteCustomSource.AddRange(new string[] { "Petrol", "Diesel" });
            cmbFuelType.FormattingEnabled = true;
            cmbFuelType.Items.AddRange(new object[] { "Diesel", "Petrol" });
            cmbFuelType.Location = new Point(408, 313);
            cmbFuelType.Name = "cmbFuelType";
            cmbFuelType.Size = new Size(277, 28);
            cmbFuelType.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(408, 234);
            label10.Name = "label10";
            label10.Size = new Size(41, 20);
            label10.TabIndex = 18;
            label10.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(408, 257);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(277, 27);
            txtPrice.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(82, 234);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 14;
            label8.Text = "Colour";
            // 
            // txtColour
            // 
            txtColour.Location = new Point(82, 257);
            txtColour.Name = "txtColour";
            txtColour.Size = new Size(277, 27);
            txtColour.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(408, 181);
            label7.Name = "label7";
            label7.Size = new Size(115, 20);
            label7.TabIndex = 12;
            label7.Text = "Engine Capacity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 124);
            label6.Name = "label6";
            label6.Size = new Size(124, 20);
            label6.TabIndex = 11;
            label6.Text = "Manufacture Year";
            // 
            // txtEngineCapacity
            // 
            txtEngineCapacity.Location = new Point(408, 204);
            txtEngineCapacity.Name = "txtEngineCapacity";
            txtEngineCapacity.Size = new Size(277, 27);
            txtEngineCapacity.TabIndex = 10;
            // 
            // txtRegisteredYear
            // 
            txtRegisteredYear.Location = new Point(408, 147);
            txtRegisteredYear.Name = "txtRegisteredYear";
            txtRegisteredYear.Size = new Size(277, 27);
            txtRegisteredYear.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 181);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 8;
            label5.Text = "Body Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(408, 68);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 7;
            label4.Text = "Model";
            label4.Click += label4_Click;
            // 
            // txtBodyType
            // 
            txtBodyType.Location = new Point(82, 204);
            txtBodyType.Name = "txtBodyType";
            txtBodyType.Size = new Size(277, 27);
            txtBodyType.TabIndex = 6;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(408, 91);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(277, 27);
            txtModel.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(408, 124);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 4;
            label3.Text = "Registered Year";
            // 
            // txtManufactureYear
            // 
            txtManufactureYear.Location = new Point(82, 147);
            txtManufactureYear.Name = "txtManufactureYear";
            txtManufactureYear.Size = new Size(277, 27);
            txtManufactureYear.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 68);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(87, 28);
            label1.TabIndex = 0;
            label1.Text = "Add Car";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(192, 0, 192);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(textBox11);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(gridCarDetails);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(797, 620);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "View Car Details";
            tabPage2.Click += tabPage2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(410, 63);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(731, 41);
            label15.Name = "label15";
            label15.Size = new Size(31, 20);
            label15.TabIndex = 3;
            label15.Text = "Car";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(534, 64);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(255, 27);
            textBox11.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(25, 27);
            label14.Name = "label14";
            label14.Size = new Size(141, 23);
            label14.TabIndex = 1;
            label14.Text = "View Car Details";
            // 
            // gridCarDetails
            // 
            gridCarDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCarDetails.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column12, Column13, delete });
            gridCarDetails.Location = new Point(1, 115);
            gridCarDetails.Name = "gridCarDetails";
            gridCarDetails.RowHeadersWidth = 51;
            gridCarDetails.Size = new Size(797, 505);
            gridCarDetails.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "CarID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
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
            Column5.HeaderText = "Body Type";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Manufacture Year";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Engine Capacity";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Transmission";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "Fuel Type";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "Colour";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 125;
            // 
            // Column12
            // 
            Column12.HeaderText = "Price";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.Width = 125;
            // 
            // Column13
            // 
            Column13.HeaderText = "Description";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.Width = 125;
            // 
            // delete
            // 
            delete.HeaderText = "Action";
            delete.MinimumWidth = 6;
            delete.Name = "delete";
            delete.Width = 125;
            // 
            // AdminCars
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 653);
            Controls.Add(panel7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminCars";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminCars";
            panel7.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridCarDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label5;
        private Label label4;
        private TextBox txtBodyType;
        private TextBox txtModel;
        private Label label3;
        private TextBox txtManufactureYear;
        private Label label2;
        private TextBox txtBrand;
        private Label label1;
        private Label label8;
        private TextBox txtColour;
        private Label label7;
        private Label label6;
        private TextBox txtEngineCapacity;
        private TextBox txtRegisteredYear;
        private TextBox txtDescription;
        private Label label11;
        private ComboBox comboBox1;
        private ComboBox cmbFuelType;
        private TextBox txtPrice;
        private Label label10;
        private Label label9;
        private TextBox textBox9;
        private TextBox textBox8;
        private Label label12;
        private Button btnSave;
        private Label label13;
        private DataGridView gridCarDetails;
        private ComboBox cmbTransmission;
        private Label label14;
        private Label label15;
        private TextBox textBox11;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn delete;
    }
}