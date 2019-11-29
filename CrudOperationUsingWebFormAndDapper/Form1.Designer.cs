namespace CrudOperationUsingWebFormAndDapper
{
    partial class myform
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
            this.Found = new System.Windows.Forms.ListBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.NameInsTextBox = new System.Windows.Forms.TextBox();
            this.AgeInsTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.Idlbl = new System.Windows.Forms.Label();
            this.NamelblForSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Found
            // 
            this.Found.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Found.FormattingEnabled = true;
            this.Found.Location = new System.Drawing.Point(12, 101);
            this.Found.Name = "Found";
            this.Found.Size = new System.Drawing.Size(301, 95);
            this.Found.TabIndex = 0;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(105, 46);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(208, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(76, 72);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(76, 289);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertBtn.TabIndex = 4;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // NameInsTextBox
            // 
            this.NameInsTextBox.Location = new System.Drawing.Point(105, 227);
            this.NameInsTextBox.Name = "NameInsTextBox";
            this.NameInsTextBox.Size = new System.Drawing.Size(208, 20);
            this.NameInsTextBox.TabIndex = 5;
            // 
            // AgeInsTextBox
            // 
            this.AgeInsTextBox.Location = new System.Drawing.Point(105, 253);
            this.AgeInsTextBox.Name = "AgeInsTextBox";
            this.AgeInsTextBox.Size = new System.Drawing.Size(207, 20);
            this.AgeInsTextBox.TabIndex = 6;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(55, 234);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(64, 256);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(26, 13);
            this.Age.TabIndex = 8;
            this.Age.Text = "Age";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(193, 288);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(324, 288);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(105, 202);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(207, 20);
            this.IdTextBox.TabIndex = 11;
            // 
            // Idlbl
            // 
            this.Idlbl.AutoSize = true;
            this.Idlbl.Location = new System.Drawing.Point(55, 205);
            this.Idlbl.Name = "Idlbl";
            this.Idlbl.Size = new System.Drawing.Size(18, 13);
            this.Idlbl.TabIndex = 12;
            this.Idlbl.Text = "ID";
            // 
            // NamelblForSearch
            // 
            this.NamelblForSearch.AutoSize = true;
            this.NamelblForSearch.Location = new System.Drawing.Point(55, 49);
            this.NamelblForSearch.Name = "NamelblForSearch";
            this.NamelblForSearch.Size = new System.Drawing.Size(35, 13);
            this.NamelblForSearch.TabIndex = 13;
            this.NamelblForSearch.Text = "Name";
            // 
            // myform
            // 
            this.ClientSize = new System.Drawing.Size(484, 418);
            this.Controls.Add(this.NamelblForSearch);
            this.Controls.Add(this.Idlbl);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AgeInsTextBox);
            this.Controls.Add(this.NameInsTextBox);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.Found);
            this.Name = "myform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox lastNameTextBox;
     
        private System.Windows.Forms.ListBox Found;
      
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.TextBox NameInsTextBox;
        private System.Windows.Forms.TextBox AgeInsTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label Idlbl;
        private System.Windows.Forms.Label NamelblForSearch;
    }
}

