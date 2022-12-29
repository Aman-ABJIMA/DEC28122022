using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
   
    public class Order
    {
        #region Constructors

        public Order():this (0)
        {

        }

        public Order()
        {
            
        }

        public Order(int orderID)
        {
            OrderID=orderID;
            OrderItems = new List<OrderItem>();
        }
        #endregion

        #region Properties
        public int OrderID { get;private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int CustomerID { get; set; }
        public int ShippingAddressID { get; set; }
        public List<OrderItem> OrderItems { get; set; }



        #endregion

        #region Method:1 Validate Order
        public bool Verify()
        {
            var isValid = true;
            if (OrderDate == null)
            {
                isValid = false;
            }
           
            return isValid;
        }
        #endregion

        #region Method:2 Save Data
        public bool Save()
        {
            return true;
        }
        #endregion

        #region Method:3 Access Data
        public Order Access()
        {
            return new Order();
        }
        #endregion

    }
}
