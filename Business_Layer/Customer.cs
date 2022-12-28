namespace Business_Layer
{
    public class Customer
    {
        #nullable disable
        #region Constructors
        public Customer()
        {

        }
        public Customer(int cutomerID)
        {
           CustomerId= cutomerID;
        }
        #endregion

        #region Properties
        public int CustomerId  { get; private set; }
        public string Email    { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + "," + LastName; } }
        public static int ObjectCount { get; set; }

        #endregion


        #region Method:1 Check Valid Inputs!

        public bool Verify()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName))
            { 
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(Email))
            {
                isValid = false;
            }
            return isValid;
        }
        #endregion

        #region Method:2 Saves Current Customer!
        //public bool Save()
        //{
        //    return true;
        //}
        #endregion

        #region Method:3 Access One Customer!

        //public Customer Access(int customerID)
        //{
        //    return new Customer();
        //}
        #endregion

        #region Method:4 Access List of Customers!

        public List<Customer>Access()
        {
            return new List<Customer>();
        }
        #endregion
    }
}