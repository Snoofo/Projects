using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme_Insurance.Business_Logic_Layer
{
    class Sale
    {
        private int saleID, customerID, productID;
        string payable;
        private DateTime startDate;

        public Sale() { }

        public Sale(int saleID, int customerID, int productID, string payable, DateTime startDate)
        {
            SaleID = saleID;
            CustomerID = customerID;
            ProductID = productID;
            Payable = payable;
            StartDate = startDate;
        }

        public int SaleID
        {
            get
            {
                return saleID;
            }
            set
            {
                saleID = value;
            }
        }

        public int CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                customerID = value;
            }
        }

        public int ProductID
        {
            get
            {
                return productID;
            }
            set
            {
                productID = value;
            }
        }

        public string Payable
        {
            get
            {
                return payable;
            }
            set
            {
                payable = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                startDate = value;
            }
        }
    }
}
