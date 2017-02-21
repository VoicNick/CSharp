using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Common;

namespace COMP2614Assign06
{
    /// <summary>
    /// Class to represent the list of clients and the current selected client
    /// It can generate events.
    /// </summary>
    class ClientViewModel : INotifyPropertyChanged
    {
        private string clientCode;
        private string companyName;
        private string address1;
        private string address2;
        private string city;
        private string province;
        private string postalCode;
        private decimal yTDSales;
        private bool creditHold;
        private string notes;
        
        //collection of all the clients
        public ClientCollection Clients { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged ([CallerMemberName] string propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public ClientViewModel()
        {
        }

        public ClientViewModel (ClientCollection clients)
        { 
            this.Clients = clients;
        }

        /// <summary>
        /// Property to determine if the Client object in the clientVM
        /// is a new or existing client
        /// </summary>
        public bool NewClient { get; set; }

        public string ClientCode 
        {
            get { return clientCode; }
            set
            {
                clientCode = value;
                OnPropertyChanged();
            }
        }

        public string CompanyName
        {
            get { return companyName; }
            set
            {
                companyName = value;
                OnPropertyChanged();
            }
        }
        public string Address1 
        {
            get { return address1; }
            set
            {
                address1 = value;
                OnPropertyChanged();
            }
        }
        public string Address2 
        {
            get { return address2; }
            set
            {
                address2 = value;
                OnPropertyChanged();
            }
        }
        public string City 
        {
            get { return city; }
            set
            {
                city = value;
                OnPropertyChanged();
            }
        }

        public string Province 
        {
            get { return province; }
            set
            {
                province = value;
                OnPropertyChanged();
            }
        }
        public string PostalCode 
        {
            get { return postalCode; }
            set
            {
                postalCode = value;
                OnPropertyChanged();
            }
        }
        public decimal YTDSales 
        {
            get { return yTDSales; }
            set
            {
                yTDSales = value;
                OnPropertyChanged();
            }
        }
        public bool CreditHold 
        {
            get { return creditHold; }
            set
            {
                creditHold = value;
                OnPropertyChanged();
            }
        }
        public string Notes 
        {
            get { return notes; }
            set
            {
                notes = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Sets the current displayed client
        /// </summary>
        /// <param name="client">the client to display</param>
        public void SetDisplayClient(Client client)
        {
            this.ClientCode = client.ClientCode;
            this.CompanyName = client.CompanyName;
            this.Address1 = client.Address1;
            this.Address2 = client.Address2;
            this.City = client.City;
            this.Province = client.Province;
            this.PostalCode = client.PostalCode;
            this.YTDSales = client.YTDSales;
            this.CreditHold = client.CreditHold;
            this.Notes = client.Notes;
        }

        /// <summary>
        /// returns a copy of the currentlly displayed client
        /// </summary>
        /// <returns>a copy of the currentlly displayed client</returns>
        public Client GetDisplayClient()
        {
            return new Client { ClientCode = this.ClientCode
                              , CompanyName = this.CompanyName
                              , Address1 = this.Address1
                              , Address2 = this.Address2
                              , City = this.City
                              , Province = this.Province
                              , PostalCode = this.PostalCode
                              , YTDSales = this.YTDSales
                              , CreditHold = this.CreditHold
                              , Notes = this.Notes};
        }
    }
}
