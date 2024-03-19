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
            txtSearchKey = new TextBox();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // txtSearchKey
            // 
            txtSearchKey.Location = new Point(43, 70);
            txtSearchKey.Name = "txtSearchKey";
            txtSearchKey.Size = new Size(510, 27);
            txtSearchKey.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(559, 68);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(147, 29);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // PartsDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(713, 518);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchKey);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PartsDetails";
            Text = "PartsDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearchKey;
        private Button btnSearch;
    }
}