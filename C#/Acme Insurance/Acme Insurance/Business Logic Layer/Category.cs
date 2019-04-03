using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme_Insurance.Business_Logic_Layer
{
    class Category
    {
        private int categoryID;
        private string category;

        public Category() { }

        public Category(int categoryID, string category)
        {
            this.categoryID = categoryID;
            this.category = category;
        }

        public int CategoryID
        {
            get
            {
                return categoryID;
            }
            set
            {
                categoryID = value;
            }
        }

        public string CategoryName
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
    }
}
