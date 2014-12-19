namespace AddressBookApp
{
    partial class AddressBookUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.email_addresstextBox = new System.Windows.Forms.TextBox();
            this.personalcontactnotextBox = new System.Windows.Forms.TextBox();
            this.homecontactnotextBox = new System.Windows.Forms.TextBox();
            this.homeaddresstextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.showallButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.nameradioButton = new System.Windows.Forms.RadioButton();
            this.emailradioButton = new System.Windows.Forms.RadioButton();
            this.noradioButton = new System.Windows.Forms.RadioButton();
            this.showalllistView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personal Contact Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Home Contact Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Home Address";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(171, 32);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(145, 20);
            this.nametextBox.TabIndex = 5;
            // 
            // email_addresstextBox
            // 
            this.email_addresstextBox.Location = new System.Drawing.Point(171, 73);
            this.email_addresstextBox.Name = "email_addresstextBox";
            this.email_addresstextBox.Size = new System.Drawing.Size(145, 20);
            this.email_addresstextBox.TabIndex = 6;
            // 
            // personalcontactnotextBox
            // 
            this.personalcontactnotextBox.Location = new System.Drawing.Point(171, 109);
            this.personalcontactnotextBox.Name = "personalcontactnotextBox";
            this.personalcontactnotextBox.Size = new System.Drawing.Size(145, 20);
            this.personalcontactnotextBox.TabIndex = 7;
            // 
            // homecontactnotextBox
            // 
            this.homecontactnotextBox.Location = new System.Drawing.Point(171, 146);
            this.homecontactnotextBox.Name = "homecontactnotextBox";
            this.homecontactnotextBox.Size = new System.Drawing.Size(145, 20);
            this.homecontactnotextBox.TabIndex = 8;
            // 
            // homeaddresstextBox
            // 
            this.homeaddresstextBox.Location = new System.Drawing.Point(171, 190);
            this.homeaddresstextBox.Name = "homeaddresstextBox";
            this.homeaddresstextBox.Size = new System.Drawing.Size(145, 20);
            this.homeaddresstextBox.TabIndex = 9;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(344, 91);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showallButton
            // 
            this.showallButton.Location = new System.Drawing.Point(344, 261);
            this.showallButton.Name = "showallButton";
            this.showallButton.Size = new System.Drawing.Size(75, 23);
            this.showallButton.TabIndex = 11;
            this.showallButton.Text = "Show All";
            this.showallButton.UseVisualStyleBackColor = true;
            this.showallButton.Click += new System.EventHandler(this.showallButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(343, 458);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(171, 457);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(145, 20);
            this.searchtextBox.TabIndex = 13;
            // 
            // nameradioButton
            // 
            this.nameradioButton.AutoSize = true;
            this.nameradioButton.Location = new System.Drawing.Point(42, 457);
            this.nameradioButton.Name = "nameradioButton";
            this.nameradioButton.Size = new System.Drawing.Size(53, 17);
            this.nameradioButton.TabIndex = 14;
            this.nameradioButton.TabStop = true;
            this.nameradioButton.Text = "Name";
            this.nameradioButton.UseVisualStyleBackColor = true;
            // 
            // emailradioButton
            // 
            this.emailradioButton.AutoSize = true;
            this.emailradioButton.Location = new System.Drawing.Point(42, 488);
            this.emailradioButton.Name = "emailradioButton";
            this.emailradioButton.Size = new System.Drawing.Size(50, 17);
            this.emailradioButton.TabIndex = 15;
            this.emailradioButton.TabStop = true;
            this.emailradioButton.Text = "Email";
            this.emailradioButton.UseVisualStyleBackColor = true;
            // 
            // noradioButton
            // 
            this.noradioButton.AutoSize = true;
            this.noradioButton.Location = new System.Drawing.Point(42, 522);
            this.noradioButton.Name = "noradioButton";
            this.noradioButton.Size = new System.Drawing.Size(102, 17);
            this.noradioButton.TabIndex = 16;
            this.noradioButton.TabStop = true;
            this.noradioButton.Text = "Contact Number";
            this.noradioButton.UseVisualStyleBackColor = true;
            // 
            // showalllistView
            // 
            this.showalllistView.AllowColumnReorder = true;
            this.showalllistView.GridLines = true;
            this.showalllistView.LabelEdit = true;
            this.showalllistView.Location = new System.Drawing.Point(54, 261);
            this.showalllistView.Name = "showalllistView";
            this.showalllistView.Size = new System.Drawing.Size(262, 166);
            this.showalllistView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.showalllistView.TabIndex = 3;
            this.showalllistView.UseCompatibleStateImageBehavior = false;
            this.showalllistView.View = System.Windows.Forms.View.Details;
            // 
            // AddressBookUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 640);
            this.Controls.Add(this.showalllistView);
            this.Controls.Add(this.noradioButton);
            this.Controls.Add(this.emailradioButton);
            this.Controls.Add(this.nameradioButton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.showallButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.homeaddresstextBox);
            this.Controls.Add(this.homecontactnotextBox);
            this.Controls.Add(this.personalcontactnotextBox);
            this.Controls.Add(this.email_addresstextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddressBookUI";
            this.Text = "Address Book UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox email_addresstextBox;
        private System.Windows.Forms.TextBox personalcontactnotextBox;
        private System.Windows.Forms.TextBox homecontactnotextBox;
        private System.Windows.Forms.TextBox homeaddresstextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showallButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.RadioButton nameradioButton;
        private System.Windows.Forms.RadioButton emailradioButton;
        private System.Windows.Forms.RadioButton noradioButton;
        private System.Windows.Forms.ListView showalllistView;
    }
}

