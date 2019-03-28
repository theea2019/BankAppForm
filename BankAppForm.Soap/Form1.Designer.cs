namespace BankAppForm.Soap
{
    partial class Form1
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
            this.btn_Csave = new System.Windows.Forms.Button();
            this.txt_Cname = new System.Windows.Forms.TextBox();
            this.txt_Csurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Cpass = new System.Windows.Forms.TextBox();
            this.txt_Cbalance = new System.Windows.Forms.TextBox();
            this.txt_Cbalancetype = new System.Windows.Forms.TextBox();
            this.txt_Cactive = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_listCustomers = new System.Windows.Forms.Button();
            this.dataGrid_Customer = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Sender_ID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_senderbalance = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_sendersurname = new System.Windows.Forms.Label();
            this.lbl_sendername = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Reciever_ID = new System.Windows.Forms.TextBox();
            this.lbl_recieverbalance = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_recieversurname = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_recievername = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_makeTransaction = new System.Windows.Forms.Button();
            this.txt_TransactionAmount = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dataGrid_Transactions = new System.Windows.Forms.DataGridView();
            this.btn_transactionList = new System.Windows.Forms.Button();
            this.btn_withdraw = new System.Windows.Forms.Button();
            this.btn_deposit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Customer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Transactions)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Csave
            // 
            this.btn_Csave.Location = new System.Drawing.Point(15, 168);
            this.btn_Csave.Name = "btn_Csave";
            this.btn_Csave.Size = new System.Drawing.Size(199, 23);
            this.btn_Csave.TabIndex = 0;
            this.btn_Csave.Text = "Save Customer";
            this.btn_Csave.UseVisualStyleBackColor = true;
            this.btn_Csave.Click += new System.EventHandler(this.btn_Csave_Click);
            // 
            // txt_Cname
            // 
            this.txt_Cname.Location = new System.Drawing.Point(114, 12);
            this.txt_Cname.Name = "txt_Cname";
            this.txt_Cname.Size = new System.Drawing.Size(100, 20);
            this.txt_Cname.TabIndex = 1;
            // 
            // txt_Csurname
            // 
            this.txt_Csurname.Location = new System.Drawing.Point(114, 38);
            this.txt_Csurname.Name = "txt_Csurname";
            this.txt_Csurname.Size = new System.Drawing.Size(100, 20);
            this.txt_Csurname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Name";
            // 
            // txt_Cpass
            // 
            this.txt_Cpass.Location = new System.Drawing.Point(114, 64);
            this.txt_Cpass.Name = "txt_Cpass";
            this.txt_Cpass.Size = new System.Drawing.Size(100, 20);
            this.txt_Cpass.TabIndex = 1;
            // 
            // txt_Cbalance
            // 
            this.txt_Cbalance.Location = new System.Drawing.Point(114, 90);
            this.txt_Cbalance.Name = "txt_Cbalance";
            this.txt_Cbalance.Size = new System.Drawing.Size(100, 20);
            this.txt_Cbalance.TabIndex = 2;
            // 
            // txt_Cbalancetype
            // 
            this.txt_Cbalancetype.Location = new System.Drawing.Point(114, 116);
            this.txt_Cbalancetype.Name = "txt_Cbalancetype";
            this.txt_Cbalancetype.Size = new System.Drawing.Size(100, 20);
            this.txt_Cbalancetype.TabIndex = 1;
            // 
            // txt_Cactive
            // 
            this.txt_Cactive.Location = new System.Drawing.Point(114, 142);
            this.txt_Cactive.Name = "txt_Cactive";
            this.txt_Cactive.Size = new System.Drawing.Size(100, 20);
            this.txt_Cactive.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Passkey";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Balance Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Active";
            // 
            // btn_listCustomers
            // 
            this.btn_listCustomers.Location = new System.Drawing.Point(255, 168);
            this.btn_listCustomers.Name = "btn_listCustomers";
            this.btn_listCustomers.Size = new System.Drawing.Size(636, 23);
            this.btn_listCustomers.TabIndex = 4;
            this.btn_listCustomers.Text = "List Customers";
            this.btn_listCustomers.UseVisualStyleBackColor = true;
            this.btn_listCustomers.Click += new System.EventHandler(this.btn_Clist_Click);
            // 
            // dataGrid_Customer
            // 
            this.dataGrid_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Customer.Location = new System.Drawing.Point(255, 15);
            this.dataGrid_Customer.Name = "dataGrid_Customer";
            this.dataGrid_Customer.Size = new System.Drawing.Size(636, 150);
            this.dataGrid_Customer.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Sender_ID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbl_senderbalance);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl_sendersurname);
            this.groupBox1.Controls.Add(this.lbl_sendername);
            this.groupBox1.Location = new System.Drawing.Point(15, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 146);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sender";
            // 
            // txt_Sender_ID
            // 
            this.txt_Sender_ID.Location = new System.Drawing.Point(108, 23);
            this.txt_Sender_ID.Name = "txt_Sender_ID";
            this.txt_Sender_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_Sender_ID.TabIndex = 4;
            this.txt_Sender_ID.TextChanged += new System.EventHandler(this.txt_Sender_name_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Balance";
            // 
            // lbl_senderbalance
            // 
            this.lbl_senderbalance.AutoSize = true;
            this.lbl_senderbalance.Location = new System.Drawing.Point(108, 104);
            this.lbl_senderbalance.Name = "lbl_senderbalance";
            this.lbl_senderbalance.Size = new System.Drawing.Size(0, 13);
            this.lbl_senderbalance.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Customer Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Customer ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Customer Surname";
            // 
            // lbl_sendersurname
            // 
            this.lbl_sendersurname.AutoSize = true;
            this.lbl_sendersurname.Location = new System.Drawing.Point(108, 77);
            this.lbl_sendersurname.Name = "lbl_sendersurname";
            this.lbl_sendersurname.Size = new System.Drawing.Size(0, 13);
            this.lbl_sendersurname.TabIndex = 14;
            // 
            // lbl_sendername
            // 
            this.lbl_sendername.AutoSize = true;
            this.lbl_sendername.Location = new System.Drawing.Point(108, 52);
            this.lbl_sendername.Name = "lbl_sendername";
            this.lbl_sendername.Size = new System.Drawing.Size(0, 13);
            this.lbl_sendername.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Reciever_ID);
            this.groupBox2.Controls.Add(this.lbl_recieverbalance);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lbl_recieversurname);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lbl_recievername);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(255, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 146);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reciever";
            // 
            // txt_Reciever_ID
            // 
            this.txt_Reciever_ID.Location = new System.Drawing.Point(108, 23);
            this.txt_Reciever_ID.Name = "txt_Reciever_ID";
            this.txt_Reciever_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_Reciever_ID.TabIndex = 4;
            this.txt_Reciever_ID.TextChanged += new System.EventHandler(this.txt_Reciever_ID_TextChanged);
            // 
            // lbl_recieverbalance
            // 
            this.lbl_recieverbalance.AutoSize = true;
            this.lbl_recieverbalance.Location = new System.Drawing.Point(105, 104);
            this.lbl_recieverbalance.Name = "lbl_recieverbalance";
            this.lbl_recieverbalance.Size = new System.Drawing.Size(0, 13);
            this.lbl_recieverbalance.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Balance";
            // 
            // lbl_recieversurname
            // 
            this.lbl_recieversurname.AutoSize = true;
            this.lbl_recieversurname.Location = new System.Drawing.Point(105, 77);
            this.lbl_recieversurname.Name = "lbl_recieversurname";
            this.lbl_recieversurname.Size = new System.Drawing.Size(0, 13);
            this.lbl_recieversurname.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Customer ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Customer Name";
            // 
            // lbl_recievername
            // 
            this.lbl_recievername.AutoSize = true;
            this.lbl_recievername.Location = new System.Drawing.Point(105, 52);
            this.lbl_recievername.Name = "lbl_recievername";
            this.lbl_recievername.Size = new System.Drawing.Size(0, 13);
            this.lbl_recievername.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Customer Surname";
            // 
            // btn_makeTransaction
            // 
            this.btn_makeTransaction.Location = new System.Drawing.Point(255, 366);
            this.btn_makeTransaction.Name = "btn_makeTransaction";
            this.btn_makeTransaction.Size = new System.Drawing.Size(234, 27);
            this.btn_makeTransaction.TabIndex = 7;
            this.btn_makeTransaction.Text = "Make Transaction";
            this.btn_makeTransaction.UseVisualStyleBackColor = true;
            this.btn_makeTransaction.Click += new System.EventHandler(this.btn_makeTransaction_Click);
            // 
            // txt_TransactionAmount
            // 
            this.txt_TransactionAmount.Location = new System.Drawing.Point(149, 370);
            this.txt_TransactionAmount.Name = "txt_TransactionAmount";
            this.txt_TransactionAmount.Size = new System.Drawing.Size(100, 20);
            this.txt_TransactionAmount.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(41, 373);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "Transaction Amount";
            // 
            // dataGrid_Transactions
            // 
            this.dataGrid_Transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Transactions.Location = new System.Drawing.Point(9, 425);
            this.dataGrid_Transactions.Name = "dataGrid_Transactions";
            this.dataGrid_Transactions.Size = new System.Drawing.Size(882, 178);
            this.dataGrid_Transactions.TabIndex = 11;
            // 
            // btn_transactionList
            // 
            this.btn_transactionList.Location = new System.Drawing.Point(9, 609);
            this.btn_transactionList.Name = "btn_transactionList";
            this.btn_transactionList.Size = new System.Drawing.Size(882, 23);
            this.btn_transactionList.TabIndex = 12;
            this.btn_transactionList.Text = "List Transactions";
            this.btn_transactionList.UseVisualStyleBackColor = true;
            this.btn_transactionList.Click += new System.EventHandler(this.btn_transactionList_Click);
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.Location = new System.Drawing.Point(495, 366);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(131, 27);
            this.btn_withdraw.TabIndex = 13;
            this.btn_withdraw.Text = "Withdraw";
            this.btn_withdraw.UseVisualStyleBackColor = true;
            this.btn_withdraw.Click += new System.EventHandler(this.btn_withdraw_Click);
            // 
            // btn_deposit
            // 
            this.btn_deposit.Location = new System.Drawing.Point(495, 333);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(131, 27);
            this.btn_deposit.TabIndex = 14;
            this.btn_deposit.Text = "Deposit";
            this.btn_deposit.UseVisualStyleBackColor = true;
            this.btn_deposit.Click += new System.EventHandler(this.btn_deposit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 671);
            this.Controls.Add(this.btn_deposit);
            this.Controls.Add(this.btn_withdraw);
            this.Controls.Add(this.btn_transactionList);
            this.Controls.Add(this.dataGrid_Transactions);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt_TransactionAmount);
            this.Controls.Add(this.btn_makeTransaction);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGrid_Customer);
            this.Controls.Add(this.btn_listCustomers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Cactive);
            this.Controls.Add(this.txt_Cbalancetype);
            this.Controls.Add(this.txt_Cbalance);
            this.Controls.Add(this.txt_Cpass);
            this.Controls.Add(this.txt_Csurname);
            this.Controls.Add(this.txt_Cname);
            this.Controls.Add(this.btn_Csave);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Customer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Transactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Csave;
        private System.Windows.Forms.TextBox txt_Cname;
        private System.Windows.Forms.TextBox txt_Csurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Cpass;
        private System.Windows.Forms.TextBox txt_Cbalance;
        private System.Windows.Forms.TextBox txt_Cbalancetype;
        private System.Windows.Forms.TextBox txt_Cactive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_listCustomers;
        private System.Windows.Forms.DataGridView dataGrid_Customer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Sender_ID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Reciever_ID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_makeTransaction;
        private System.Windows.Forms.TextBox txt_TransactionAmount;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbl_senderbalance;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_sendersurname;
        private System.Windows.Forms.Label lbl_sendername;
        private System.Windows.Forms.Label lbl_recieverbalance;
        private System.Windows.Forms.Label lbl_recieversurname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_recievername;
        private System.Windows.Forms.DataGridView dataGrid_Transactions;
        private System.Windows.Forms.Button btn_transactionList;
        private System.Windows.Forms.Button btn_withdraw;
        private System.Windows.Forms.Button btn_deposit;
    }
}

