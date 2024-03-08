namespace ABC_car_traders.View
{
    partial class AdmiCoustomer
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
            label15 = new Label();
            textBox11 = new TextBox();
            label14 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            panel7.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tabControl1.TabIndex = 5;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(192, 0, 192);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(textBox11);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(797, 620);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "View All Coustomer";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(672, 47);
            label15.Name = "label15";
            label15.Size = new Size(120, 20);
            label15.TabIndex = 3;
            label15.Text = "Customer Search";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(534, 67);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(255, 27);
            textBox11.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(34, 36);
            label14.Name = "label14";
            label14.Size = new Size(201, 23);
            label14.TabIndex = 1;
            label14.Text = "View Coustomer Details";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column4, Column10, Column11 });
            dataGridView1.Location = new Point(1, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(797, 505);
            dataGridView1.TabIndex = 0;
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
            Column2.HeaderText = "CoustomerName";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "CoustomerMobile";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "CoustomerEmail";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "CoustomerAddress";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "CoustomerUserName";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 125;
            // 
            // Column11
            // 
            Column11.HeaderText = "CoustomerPassword";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 125;
            // 
            // AdmiCoustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(806, 653);
            Controls.Add(panel7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdmiCoustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdmiCoustomer";
            panel7.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private Label label15;
        private TextBox textBox11;
        private Label label14;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
    }
}