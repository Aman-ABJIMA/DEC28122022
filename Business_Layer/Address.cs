using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class Address
    {
        #region Constructors
        public Address() { }
        public Address(int addressID)
        {
            AddressID=addressID;
        }
        #endregion

        #region Properties
        public int AddressID     { get;private set; }
        public int AddressType   { get; set; }
        public string City       { get; set; }
        public string PostalCode { get; set; }
        public string Country    { get; set; }
        public string State      { get; set; }
        public string StreetLine1{ get; set; }
        public string StreetLine2{ get; set; }

        #endregion

        #region Method:1 Validate Address
        public bool Verify()
        {
            var isValid = true;
            if (PostalCode == null)
            {
                isValid = false;
            }

            return isValid;
        }
        #endregion

        //#region Method:2 Save Data
        //public bool Save()
        //{
        //    return true;
        //}
        //#endregion

        //#region Method:3 Access Data
        //public Order Access()
        //{
        //    return new Order();
        //}
        //#endregion


    }
}
