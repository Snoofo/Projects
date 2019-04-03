using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme_Insurance.Business_Logic_Layer
{
    class Product
    {
        private int productID, productTypeID;
        private double yearlyPremium;
        private string productName;

        public Product() { }

        public Product(int productID, int productTypeID, string productName, double yearlyPremium)
        {
            ProductID = productID;
            ProductTypeID = productTypeID;
            ProductName = productName;
            YearlyPremium = yearlyPremium;
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

        public int ProductTypeID
        {
            get
            {
                return productTypeID;
            }
            set
            {
                productTypeID = value;
            }
        }

        public double YearlyPremium
        {
            get
            {
                return yearlyPremium;
            }
            set
            {
                yearlyPremium = value;
            }
        }

        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }
    }
}
