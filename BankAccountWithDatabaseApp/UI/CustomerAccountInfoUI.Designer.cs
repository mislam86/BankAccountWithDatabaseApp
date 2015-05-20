namespace BankAccountWithDatabaseApp.UI
{
    partial class CustomerAccountInfoUI
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
            this.label11 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.accountNumberForTransactionTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.depositButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showInfoListView = new System.Windows.Forms.ListView();
            this.accountNumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openingDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.accountBalanceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.accountNumberToSearchTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.openingDateEntryTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberEntryTextBox = new System.Windows.Forms.TextBox();
            this.customerEmailEntryTextBox = new System.Windows.Forms.TextBox();
            this.customerNameEntryTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Font = new System.Drawing.Font("Papyrus", 19.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(343, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(282, 41);
            this.label11.TabIndex = 7;
            this.label11.Text = "Fast Banking Solution";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(117, 45);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(145, 20);
            this.amountTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Amount";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(117, 75);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(64, 23);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.accountNumberForTransactionTextBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.amountTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.withdrawButton);
            this.groupBox3.Controls.Add(this.depositButton);
            this.groupBox3.Location = new System.Drawing.Point(338, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 120);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaction";
            // 
            // accountNumberForTransactionTextBox
            // 
            this.accountNumberForTransactionTextBox.Location = new System.Drawing.Point(117, 19);
            this.accountNumberForTransactionTextBox.Name = "accountNumberForTransactionTextBox";
            this.accountNumberForTransactionTextBox.Size = new System.Drawing.Size(145, 20);
            this.accountNumberForTransactionTextBox.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Account Number";
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(200, 75);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(62, 23);
            this.depositButton.TabIndex = 3;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showInfoListView);
            this.groupBox2.Controls.Add(this.accountNumberToSearchTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Location = new System.Drawing.Point(37, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 216);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer and Account Info";
            // 
            // showInfoListView
            // 
            this.showInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.accountNumberColumnHeader,
            this.customerNameColumnHeader,
            this.openingDateColumnHeader,
            this.accountBalanceColumnHeader});
            this.showInfoListView.FullRowSelect = true;
            this.showInfoListView.GridLines = true;
            this.showInfoListView.Location = new System.Drawing.Point(6, 48);
            this.showInfoListView.Name = "showInfoListView";
            this.showInfoListView.Size = new System.Drawing.Size(582, 162);
            this.showInfoListView.TabIndex = 10;
            this.showInfoListView.UseCompatibleStateImageBehavior = false;
            this.showInfoListView.View = System.Windows.Forms.View.Details;
            // 
            // accountNumberColumnHeader
            // 
            this.accountNumberColumnHeader.Text = "Account Number";
            this.accountNumberColumnHeader.Width = 135;
            // 
            // customerNameColumnHeader
            // 
            this.customerNameColumnHeader.Text = "Customer Name";
            this.customerNameColumnHeader.Width = 154;
            // 
            // openingDateColumnHeader
            // 
            this.openingDateColumnHeader.Text = "Opening Date";
            this.openingDateColumnHeader.Width = 182;
            // 
            // accountBalanceColumnHeader
            // 
            this.accountBalanceColumnHeader.Text = "Balance";
            this.accountBalanceColumnHeader.Width = 101;
            // 
            // accountNumberToSearchTextBox
            // 
            this.accountNumberToSearchTextBox.Location = new System.Drawing.Point(347, 21);
            this.accountNumberToSearchTextBox.Name = "accountNumberToSearchTextBox";
            this.accountNumberToSearchTextBox.Size = new System.Drawing.Size(145, 20);
            this.accountNumberToSearchTextBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Account Number";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(498, 19);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(90, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.openingDateEntryTextBox);
            this.groupBox1.Controls.Add(this.accountNumberEntryTextBox);
            this.groupBox1.Controls.Add(this.customerEmailEntryTextBox);
            this.groupBox1.Controls.Add(this.customerNameEntryTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 167);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer and Account Info Entry";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(187, 125);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openingDateEntryTextBox
            // 
            this.openingDateEntryTextBox.Location = new System.Drawing.Point(117, 99);
            this.openingDateEntryTextBox.Name = "openingDateEntryTextBox";
            this.openingDateEntryTextBox.Size = new System.Drawing.Size(145, 20);
            this.openingDateEntryTextBox.TabIndex = 3;
            // 
            // accountNumberEntryTextBox
            // 
            this.accountNumberEntryTextBox.Location = new System.Drawing.Point(117, 73);
            this.accountNumberEntryTextBox.Name = "accountNumberEntryTextBox";
            this.accountNumberEntryTextBox.Size = new System.Drawing.Size(145, 20);
            this.accountNumberEntryTextBox.TabIndex = 2;
            // 
            // customerEmailEntryTextBox
            // 
            this.customerEmailEntryTextBox.Location = new System.Drawing.Point(117, 48);
            this.customerEmailEntryTextBox.Name = "customerEmailEntryTextBox";
            this.customerEmailEntryTextBox.Size = new System.Drawing.Size(145, 20);
            this.customerEmailEntryTextBox.TabIndex = 1;
            // 
            // customerNameEntryTextBox
            // 
            this.customerNameEntryTextBox.Location = new System.Drawing.Point(117, 23);
            this.customerNameEntryTextBox.Name = "customerNameEntryTextBox";
            this.customerNameEntryTextBox.Size = new System.Drawing.Size(145, 20);
            this.customerNameEntryTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Opening Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer Name";
            // 
            // CustomerAccountInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 435);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerAccountInfoUI";
            this.ShowIcon = false;
            this.Text = "Customer and Account Information";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView showInfoListView;
        private System.Windows.Forms.ColumnHeader accountNumberColumnHeader;
        private System.Windows.Forms.ColumnHeader customerNameColumnHeader;
        private System.Windows.Forms.ColumnHeader openingDateColumnHeader;
        private System.Windows.Forms.ColumnHeader accountBalanceColumnHeader;
        private System.Windows.Forms.TextBox accountNumberToSearchTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox openingDateEntryTextBox;
        private System.Windows.Forms.TextBox accountNumberEntryTextBox;
        private System.Windows.Forms.TextBox customerEmailEntryTextBox;
        private System.Windows.Forms.TextBox customerNameEntryTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accountNumberForTransactionTextBox;

    }
}

