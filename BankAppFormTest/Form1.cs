using System;
using System.Linq;
using System.Windows.Forms;
using Bank.BusinessLogic;
using Bank.Models.Concretes;

namespace BankAppForm
{
    public partial class Form1 : Form
    {
        Customers senderCustomer;
        Customers recieverCustomer;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Csave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var customerbussiness = new CustomersBusiness())
                {
                    var c = new Customers();
                    c.CustomerName = txt_Cname.Text;
                    c.CustomerSurname = txt_Csurname.Text;
                    c.CustomerPasskey = txt_Cpass.Text;
                    c.Balance = decimal.Parse(txt_Cbalance.Text);
                    c.BalanceType = byte.Parse(txt_Cbalancetype.Text);
                    c.isActive = bool.Parse(txt_Cactive.Text);

                    var success = customerbussiness.InsertCustomer(c);

                    var message = success ? "done" : "failed";

                    MessageBox.Show("Operation " + message);
                }
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
                using (var customerbussiness = new CustomersBusiness())
                {
                    dataGrid_Customer.DataSource = customerbussiness.SelectAllCustomers().ToList();
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
                bool success;

                Transactions transaction = new Transactions();
                transaction.TransactorAccountNumber = senderCustomer.CustomerID;
                transaction.RecieverAccountNumber = recieverCustomer.CustomerID;
                transaction.TransactionAmount = int.Parse(txt_TransactionAmount.Text);
                transaction.TransactionDate = DateTime.Now;
                transaction.isSuccess = true;

                using (var transactionbussines = new TransactionBusiness())
                {
                    success = transactionbussines.MakeTransaction(transaction, senderCustomer, recieverCustomer);
                }

                var message = success ? "successfully done" : "failed";

                MessageBox.Show("Transaction is " + message);
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
                using (var customerbussiness = new CustomersBusiness())
                {
                    senderCustomer = customerbussiness.SelectCustomerById(int.Parse(txt_Sender_ID.Text));
                    lbl_sendername.Text = senderCustomer.CustomerName;
                    lbl_sendersurname.Text = senderCustomer.CustomerSurname;
                    lbl_senderbalance.Text = senderCustomer.Balance.ToString();
                }
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
                using (var customerbussiness = new CustomersBusiness())
                {
                    recieverCustomer = customerbussiness.SelectCustomerById(int.Parse(txt_Reciever_ID.Text));
                    lbl_recievername.Text = recieverCustomer.CustomerName;
                    lbl_recieversurname.Text = recieverCustomer.CustomerSurname;
                    lbl_recieverbalance.Text = recieverCustomer.Balance.ToString();
                }
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
                using (var transactionBussiness = new TransactionBusiness())
                {                 dataGrid_Transactions.DataSource = transactionBussiness.SelectAllTransactions().ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
