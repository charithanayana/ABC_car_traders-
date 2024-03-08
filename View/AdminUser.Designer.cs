namespace ABC_car_traders.View
{
    partial class AdminUser
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
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            label5 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label14 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(805, 653);
            tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(192, 0, 192);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label14);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(797, 620);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "User Manage";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 151);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 29;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(415, 75);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 28;
            label4.Text = "User Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(412, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 27);
            textBox2.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 75);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 25;
            label2.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 27);
            textBox1.TabIndex = 24;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(24, 20);
            label14.Name = "label14";
            label14.Size = new Size(98, 25);
            label14.TabIndex = 23;
            label14.Text = "Add Users";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(86, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(277, 27);
            textBox3.TabIndex = 36;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(412, 174);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(277, 27);
            textBox4.TabIndex = 37;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(540, 540);
            button1.Name = "button1";
            button1.Size = new Size(149, 48);
            button1.TabIndex = 38;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(415, 151);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 39;
            label1.Text = "Confirm Password";
            // 
            // AdminUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(806, 653);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminUser";
            Text = "AdminUser";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private Label label5;
        private Label label4;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label14;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button button1;
        private Label label1;
    }
}