using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme_Insurance.Business_Logic_Layer
{
    class ProductType
    {
        private int productID;
        private string productType;

        public ProductType() { }

        public ProductType(int productID, string productType)
        {
            ProductTypeID = productID;
            ProductTypeName = productType;
        }

        public int ProductTypeID
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

        public string ProductTypeName
        {
            get
            {
                return productType;
            }
            set
            {
                productType = value;
            }
        }
    }
}
