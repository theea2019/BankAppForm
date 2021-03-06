﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Bank.Commons.Concretes.Helpers;
using Bank.Commons.Concretes.Logger;
using Bank.BusinessLogic;
using Customers = Bank.Models.Concretes.Customers;
using Transactions = Bank.Models.Concretes.Transactions;

namespace BankAppForm.Pure
{
    public partial class Form1 : Form
    {
        Customers senderCustomer;
        Customers receiverCustomer;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Csave_Click(object sender, EventArgs e)
        {
            try
            {
                    bool success;
                    using (var customerBusiness = new CustomersBusiness())
                    {
                        success = customerBusiness.InsertCustomer(new Customers()
                        {
                            CustomerName = txt_Cname.Text,
                            CustomerSurname = txt_Csurname.Text,
                            CustomerPasskey = txt_Cpass.Text,
                            Balance = decimal.Parse(txt_Cbalance.Text),
                            BalanceType = byte.Parse(txt_Cbalancetype.Text),
                            isActive = bool.Parse(txt_Cactive.Text)
                        });
                    }
                    var message = success ? "done" : "failed";

                    MessageBox.Show("Operation " + message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        private void btn_Clist_Click(object sender, EventArgs e)
        {
            try
            {
                using (var customerBusiness = new CustomersBusiness())
                {
                    List<Customers> customers = customerBusiness.SelectAllCustomers().OrderBy(x => x.CustomerID).ToList();
                    dataGrid_Customer.DataSource = customers.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        private void btn_makeTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = false;
                if (txt_TransactionAmount.Text != "" || txt_TransactionAmount.Text != null ||
                    !txt_TransactionAmount.Text.ToCharArray().Any(x => Char.IsLetter(x)))
                {
                    using (var transactionBusiness = new TransactionBusiness())
                    {
                        using (var customerBusiness = new CustomersBusiness())
                        {
                            Transactions transaction = new Transactions()
                            {
                                Customer = senderCustomer,
                                TransactionDate = DateTime.Now,
                                ReceiverAccountNumber = receiverCustomer.CustomerID,
                                TransactorAccountNumber = senderCustomer.CustomerID,
                                TransactionAmount = decimal.Parse(txt_TransactionAmount.Text),
                            };
                            success = transactionBusiness.MakeTransaction(transaction, transaction.Customer, receiverCustomer);
                        }
                    }
                }

                var message = success ? "successfully done" : "failed";

                MessageBox.Show("Transaction is " + message);

                btn_transactionList_Click(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        private void txt_Sender_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                senderCustomer = SelectCustomerByID(int.Parse(txt_Sender_ID.Text));
                lbl_sendername.Text = senderCustomer.CustomerName;
                lbl_sendersurname.Text = senderCustomer.CustomerSurname;
                lbl_senderbalance.Text = senderCustomer.Balance.ToString();
                dataGrid_Transactions.DataSource = senderCustomer.Transactions.ToList();
            }
            catch (Exception)
            {
                lbl_sendername.Text = "";
                lbl_sendersurname.Text = "";
                lbl_senderbalance.Text = "";
            }
        }

        private void txt_Reciever_ID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                receiverCustomer = SelectCustomerByID(int.Parse(txt_Reciever_ID.Text));
                lbl_recievername.Text = receiverCustomer.CustomerName;
                lbl_recieversurname.Text = receiverCustomer.CustomerSurname;
                lbl_recieverbalance.Text = receiverCustomer.Balance.ToString();
            }
            catch (Exception)
            {
                lbl_recievername.Text = "";
                lbl_recieversurname.Text = "";
                lbl_recieverbalance.Text = "";
            }
        }

        private void btn_transactionList_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Sender_ID.Text != "" || txt_Sender_ID.Text != null)
                {
                    txt_Sender_name_TextChanged(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Sender ID");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private Customers SelectCustomerByID(int ID)
        {
            try
            {
                using (var customerBusiness = new CustomersBusiness())
                {
                    Customers castedCustomer = customerBusiness.SelectCustomerById(ID);
                    return castedCustomer;
                }
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("Customer doesn't exists.");
            }
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = false;
                if (txt_TransactionAmount.Text != "" || txt_TransactionAmount.Text != null ||
                    !txt_TransactionAmount.Text.ToCharArray().Any(x => Char.IsLetter(x)))
                {
                    using (var transactionBusiness = new TransactionBusiness())
                    {
                        using (var customerBusiness = new CustomersBusiness())
                        {
                            Transactions transaction = new Transactions()
                            {
                                Customer = senderCustomer,
                                TransactionDate = DateTime.Now,
                                ReceiverAccountNumber = senderCustomer.CustomerID,
                                TransactorAccountNumber = senderCustomer.CustomerID,
                                TransactionAmount = decimal.Parse(txt_TransactionAmount.Text),
                            };
                            success = transactionBusiness.DepositMoney(transaction, senderCustomer);
                        }
                    }
                }

                var message = success ? "successfully done" : "failed";

                MessageBox.Show("Transaction is " + message);

                btn_transactionList_Click(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = false;
                if (txt_TransactionAmount.Text != "" || txt_TransactionAmount.Text != null ||
                    !txt_TransactionAmount.Text.ToCharArray().Any(x => Char.IsLetter(x)))
                {
                    using (var transactionBusiness = new TransactionBusiness())
                    {
                        using (var customerBusiness = new CustomersBusiness())
                        {
                            Transactions transaction = new Transactions()
                            {
                                Customer = senderCustomer,
                                TransactionDate = DateTime.Now,
                                ReceiverAccountNumber = null,
                                TransactorAccountNumber = senderCustomer.CustomerID,
                                TransactionAmount = decimal.Parse(txt_TransactionAmount.Text),
                            };
                            success = transactionBusiness.WithdrawMoney(transaction,
                                senderCustomer);
                        }
                    }
                }

                var message = success ? "successfully done" : "failed";

                MessageBox.Show("Transaction is " + message);

                btn_transactionList_Click(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error happened: " + ex.Message);
            }
        }
    }
}
