using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Bank.Commons.Concretes.Helpers;
using Bank.Commons.Concretes.Logger;
using Newtonsoft.Json;
using Customers = Bank.Models.Concretes.Customers;

namespace BankAppForm.RestApi
{
    public partial class Form1 : Form
    {
        Customers senderCustomer;
        Customers receiverCustomer;
        
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_Csave_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = false;
                // Create a HttpClient
                using (var client = new HttpClient())
                {
                    // Setup basics
                    client.BaseAddress = new Uri("http://localhost:33487/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));

                    // Create post body object
                    Customers customer = new Customers()
                    {
                        CustomerName = txt_Cname.Text,
                        CustomerSurname = txt_Csurname.Text,
                        CustomerPasskey = txt_Cpass.Text,
                        Balance = decimal.Parse(txt_Cbalance.Text),
                        BalanceType = byte.Parse(txt_Cbalancetype.Text),
                        isActive = bool.Parse(txt_Cactive.Text)
                    };

                    // Serialize C# object to Json Object
                    var serializedProduct = JsonConvert.SerializeObject(customer);
                    // Json object to System.Net.Http content type
                    var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                    // Post Request to the URI
                    var result = await client.PostAsync("api/Customer", content);
                    // Check for result
                    if (result.IsSuccessStatusCode)
                    {
                        success = true;
                    }
                }
                // Set message depend on success info
                var message = success ? "done" : "failed";
                // Inform user
                MessageBox.Show("Operation " + message);
            }
            catch (Exception ex)
            {
                // Inform user
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        private async void btn_Clist_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a HttpClient
                using (var client = new HttpClient())
                {
                    // Setup basics
                    client.BaseAddress = new Uri("http://localhost:33487/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    
                    // Get Request from the URI
                    using (var result = await client.GetAsync("api/Customer"))
                    {
                        // Check the Result
                        if (result.IsSuccessStatusCode)
                        {
                            // Take the Result as a json string
                            var value = result.Content.ReadAsStringAsync().Result;
                            
                            // Deserialize the string with a Json Converter to ResponseContent object and fill the datagrid
                            dataGrid_Customer.DataSource =
                                JsonConvert.DeserializeObject<ResponseContent<Customers>>(value).Data.ToList();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Inform user if an error occurs
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        private async void btn_makeTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = false;
                // Check for textboxes are okay?
                if (txt_TransactionAmount.Text != "" || txt_TransactionAmount.Text != null ||
                    !txt_TransactionAmount.Text.ToCharArray().Any(x => Char.IsLetter(x)))
                {
                    // Create HttpClient object
                    using (var client = new HttpClient())
                    {
                        // Setup basics
                        client.BaseAddress = new Uri("http://localhost:33487/");
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(
                            new MediaTypeWithQualityHeaderValue("application/json"));

                        // Create an object (normal/basic/plain/non typed/json object)
                        var requestObject = new
                        {
                            SenderId = senderCustomer.CustomerID,
                            ReceiverId = receiverCustomer.CustomerID,
                            Amount = decimal.Parse(txt_TransactionAmount.Text)
                        };

                        // Serialize object to Json Object
                        var serializedProduct = JsonConvert.SerializeObject(requestObject);
                        // Convert the json object to System.Net content
                        var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                        // POST request to the URI with the content
                        var result = await client.PostAsync("api/Transaction/Transfer", content);
                        // Check the result
                        if (result.IsSuccessStatusCode)
                        {
                            // Update the success info
                            success = true;
                        }
                    }
                }
                // Setup the message info depend on success
                var message = success ? "successfully done" : "failed";
                // Inform the User
                MessageBox.Show("Transaction is " + message);
                // Update the Transaction list
                btn_transactionList_Click(sender, e);
            }
            catch (Exception ex)
            {
                // Inform the user if an error occurs
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        private async void txt_Sender_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Get sender info from the SelectCustomerById method
                senderCustomer = await SelectCustomerByID(int.Parse(txt_Sender_ID.Text));
                // Set the property values to the textboxes
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

        private async void txt_Reciever_ID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Get receiver info from the SelectCustomerById method
                receiverCustomer = await SelectCustomerByID(int.Parse(txt_Reciever_ID.Text));
                // Set the property values to the textboxes
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

        private Customers XmlDeserializer(string xml)
        {
            // Deserialize the XML serialization.
            XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(ResponseContent<Customers>));
            // Setup a string reader
            using (StringReader sr = new StringReader(xml))
            {
                // Deserialize the content with the serializer
                var t = (ResponseContent<Customers>)ser.Deserialize(sr);
                // Get the Customer from the data and return it
                return t.Data.FirstOrDefault();
            }
        }
        
        // This method is an async thread this is why it has to sign this way
        private async Task<Customers> SelectCustomerByID(int ID)
        {
            try
            {
                // Create HttpClient
                using (var client = new HttpClient())
                {
                    // Setup basics
                    client.BaseAddress = new Uri("http://localhost:33487/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));

                    // GET Request from the URI
                    using (var result = await client.GetAsync("api/Customer/" + ID))
                    {
                        // Check the result
                        if (result.IsSuccessStatusCode)
                        {
                            // Get the result string as XML
                            var value = result.Content.ReadAsStringAsync().Result;
                            // Deserialize it and return the Customer object we need
                            return XmlDeserializer(value);
                        }
                       
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the request
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                // Inform the user
                MessageBox.Show("Customer doesn't exists.");
            }

            // Return null if somethings went wrong without an exception
            return null;
        }

        private async void btn_deposit_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = false;
                if (txt_TransactionAmount.Text != "" || txt_TransactionAmount.Text != null ||
                    !txt_TransactionAmount.Text.ToCharArray().Any(x => Char.IsLetter(x)))
                {
                    // Create HttpClient object
                    using (var client = new HttpClient())
                    {
                        // Setup basics
                        client.BaseAddress = new Uri("http://localhost:33487/");
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(
                            new MediaTypeWithQualityHeaderValue("application/json"));

                        // Create an object (normal/basic/plain/non typed/json object)
                        var requestObject = new
                        {
                            SenderId = senderCustomer.CustomerID,
                            ReceiverId = senderCustomer.CustomerID,
                            Amount = decimal.Parse(txt_TransactionAmount.Text)
                        };

                        // Serialize object to Json Object
                        var serializedProduct = JsonConvert.SerializeObject(requestObject);
                        // Convert the json object to System.Net content
                        var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                        // POST request to the URI with the content
                        var result = await client.PostAsync("api/Transaction/Deposit", content);
                        // Check the result
                        if (result.IsSuccessStatusCode)
                        {
                            // Update the success info
                            success = true;
                        }
                    }
                }
                // Set the message depend on success 
                var message = success ? "successfully done" : "failed";
                // Inform user
                MessageBox.Show("Transaction is " + message);
                // Update transaction list
                btn_transactionList_Click(sender, e);
            }
            catch (Exception ex)
            {
                // Inform user
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        private async void btn_withdraw_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = false;
                if (txt_TransactionAmount.Text != "" || txt_TransactionAmount.Text != null ||
                    !txt_TransactionAmount.Text.ToCharArray().Any(x => Char.IsLetter(x)))
                {
                    // Create HttpClient object
                    using (var client = new HttpClient())
                    {
                        // Setup basics
                        client.BaseAddress = new Uri("http://localhost:33487/");
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(
                            new MediaTypeWithQualityHeaderValue("application/json"));

                        // Create an object (normal/basic/plain/non typed/json object)
                        var requestObject = new
                        {
                            SenderId = senderCustomer.CustomerID,
                            ReceiverId = senderCustomer.CustomerID,
                            Amount = decimal.Parse(txt_TransactionAmount.Text)
                        };

                        // Serialize object to Json Object
                        var serializedProduct = JsonConvert.SerializeObject(requestObject);
                        // Convert the json object to System.Net content
                        var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                        // POST request to the URI with the content
                        var result = await client.PostAsync("api/Transaction/Withdraw", content);
                        // Check the result
                        if (result.IsSuccessStatusCode)
                        {
                            // Update the success info
                            success = true;
                        }
                    }
                }
                // Setup the message depend on success
                var message = success ? "successfully done" : "failed";
                // Inform the user
                MessageBox.Show("Transaction is " + message);
                // Update the transactions
                btn_transactionList_Click(sender, e);
            }
            catch (Exception ex)
            {
                // Inform the user
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }
    }
}
