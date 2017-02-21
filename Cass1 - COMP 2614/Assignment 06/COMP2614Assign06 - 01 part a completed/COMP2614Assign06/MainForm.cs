using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614Assign06
{
    public partial class MainForm : Form
    {
        private ClientViewModel clientVM;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                clientVM = new ClientViewModel(ClientRepository.GetAllClients());
                setBindings();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Data Access Error\n\n{0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Processing Error\n\n{0}", ex.Message);
            }
        }

        private void setBindings()
        {
            listBoxClients.DataSource = clientVM.Clients;
            listBoxClients.DisplayMember = "ClientCode"; 

            textBoxClientCode.DataBindings.Add("Text", clientVM, "ClientCode", false, DataSourceUpdateMode.OnValidation,"");
            textBoxCompanyName.DataBindings.Add("Text", clientVM, "CompanyName");
            textBoxAddress1.DataBindings.Add("Text", clientVM, "Address1");
            textBoxAddress2.DataBindings.Add("Text", clientVM, "Address2");
            textBoxCity.DataBindings.Add("Text", clientVM, "City");
            textBoxProvince.DataBindings.Add("Text", clientVM, "Province");
            textBoxPostalCode.DataBindings.Add("Text", clientVM, "PostalCode");
            textBoxYTDSales.DataBindings.Add("Text", clientVM, "YTDSales", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00));0.00");
            checkBoxCreditHold.DataBindings.Add("Checked", clientVM, "CreditHold");
            textBoxNotes.DataBindings.Add("Text", clientVM, "Notes");         
        }

        private void listBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = Math.Max(0, listBoxClients.SelectedIndex);
            Client client = clientVM.Clients[selectedIndex];
            clientVM.SetDisplayClient(client);
        }


    }
}
