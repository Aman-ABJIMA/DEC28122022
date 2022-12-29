
﻿using Common;
using System;

﻿using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace Business_Layer  
{
        public class Product
        {
            #region Constructors
            public Product()
            {


            }
            public Product(int productID)
            {
                ProductID = productID;
            }
            #endregion

            #region Properties
            public decimal? CurrentPrice { get; set; }
            public int ProductID { get; set; }


            private string _productName;
            public string ProductName
            {
                get
                {
                    return _productName.InserSpaces();
                }
                set
                {
                    _productName = value;
                }
            }
            public string ProductName { get; set; }

            public string ProductDescription { get; set; }
            #endregion

            #region Method:1 Validate Product
            public override bool Verify()
            {

            }


        public bool Verify()

            {
                var isValid = true;
                if (string.IsNullOrWhiteSpace(ProductName))
                {
                    isValid = false;
                }
                if (CurrentPrice == null)
                {
                    isValid = false;
                }
                return isValid;
            }
            #endregion

            //#region
            //public Product Access(int productID)
            //{
            //    return new Product();
            //}

            //public bool Save()
            //{ 
            //    return true; 
            //}

            //#endregion


            public override string ToString() => ProductName;

            public string Log() => $"{ProductID} : {ProductName} Description: {ProductDescription} : {EntityState.ToString()}";

        }
    }
}

